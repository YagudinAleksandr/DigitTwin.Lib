using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace DigitTwin.Lib.EventBroker
{
    public class EventBroker : IEventBroker
    {
        private readonly ConcurrentDictionary<EventIdentity, List<Delegate>> _subscribers =
        new ConcurrentDictionary<EventIdentity, List<Delegate>>(new EventIdentityEqualityComparer());

        private readonly object _cleanupLock = new object();
        public static EventBroker? Self { get; private set; }

        public EventBroker()
        {
            Self ??= this;
        }

        public IDisposable On<TEvent>(Action<TEvent> action)
        {
            return On(typeof(TEvent).FullName!, action);
        }

        public IDisposable On<TEvent>(string route, Action<TEvent> action)
        {
            if (string.IsNullOrEmpty(route))
                throw new ArgumentNullException(nameof(route));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var identity = new EventIdentity(route, typeof(TEvent));
            var subscription = new EventSubscription(() => RemoveSubscription(identity, action));

            _subscribers.AddOrUpdate(
                identity,
                new List<Delegate> { action },
                (_, existing) =>
                {
                    lock (_cleanupLock)
                    {
                        existing.Add(action);
                        return existing;
                    }
                }
            );

            return subscription;
        }

        public void Push<TEvent>(TEvent value)
        {
            Push(typeof(TEvent).FullName!, value);
        }

        public void Push<TEvent>(string route, TEvent value)
        {
            var identity = new EventIdentity(route, typeof(TEvent));

            if (_subscribers.TryGetValue(identity, out var actions))
            {
                // Создаем копию для безопасной итерации
                Delegate[] actionsCopy;
                lock (_cleanupLock)
                {
                    actionsCopy = actions.Where(a => a != null).ToArray();
                }

                foreach (var action in actionsCopy.OfType<Action<TEvent>>())
                {
                    try
                    {
                        action?.Invoke(value);
                    }
                    catch
                    {
                        // Обработка ошибок по желанию
                    }
                }

                CleanEmptyHandlers(identity, actions);
            }
        }

        public Task PushAsync<TEvent>(TEvent value)
        {
            return Task.Run(() => Push(value));
        }

        private void RemoveSubscription(EventIdentity identity, Delegate handler)
        {
            if (!_subscribers.TryGetValue(identity, out var actions))
                return;

            lock (_cleanupLock)
            {
                actions.RemoveAll(a => a == handler);
            }

            CleanEmptyHandlers(identity, actions);
        }

        private void CleanEmptyHandlers(EventIdentity identity, List<Delegate> handlers)
        {
            lock (_cleanupLock)
            {
                if (handlers.Count == 0)
                {
                    _subscribers.TryRemove(identity, out _);
                }
            }
        }

        private class EventSubscription : IDisposable
        {
            private Action _unsubscribe;
            private bool _disposed = false;

            public EventSubscription(Action unsubscribe)
            {
                _unsubscribe = unsubscribe;
            }

            public void Dispose()
            {
                if (_disposed) return;

                _unsubscribe?.Invoke();
                _unsubscribe = null;
                _disposed = true;
            }
        }

        private readonly struct EventIdentity
        {
            public string Route { get; }
            public Type EventType { get; }

            public EventIdentity(string route, Type eventType)
            {
                Route = route;
                EventType = eventType;
            }
        }

        private class EventIdentityEqualityComparer : IEqualityComparer<EventIdentity>
        {
            public bool Equals(EventIdentity x, EventIdentity y)
            {
                return string.Equals(x.Route, y.Route, StringComparison.OrdinalIgnoreCase);
            }

            public int GetHashCode(EventIdentity obj)
            {
                return obj.Route.GetHashCode();
            }
        }
    }
}
