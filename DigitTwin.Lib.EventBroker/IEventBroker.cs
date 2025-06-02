using System;
using System.Threading.Tasks;

namespace DigitTwin.Lib.EventBroker
{
    /// <summary>
    /// Внутреннйи брокер сообщений
    /// </summary>
    public interface IEventBroker
    {
        /// <summary>
        /// Подписка на событие тип <typeparamref name="TEvent"/>
        /// </summary>
        /// <typeparam name="TEvent">Тип события</typeparam>
        /// <param name="action">Обработчик</param>
        IDisposable On<TEvent>(Action<TEvent> action);

        /// <summary>
        /// Подписка на событие типа <typeparamref name="TEvent"/> с маршрутизацией <paramref name="route"/>
        /// </summary>
        /// <typeparam name="TEvent">Тип события</typeparam>
        /// <param name="route">Маршрут</param>
        /// <param name="action">Обработчик</param>
        IDisposable On<TEvent>(string route, Action<TEvent> action);

        /// <summary>
        /// Отправка в очередь события
        /// </summary>
        /// <typeparam name="TEvent">Тип события</typeparam>
        /// <param name="value">Событие</param>
        void Push<TEvent>(TEvent value);

        /// <summary>
        /// Отправка события в очередь с маршрутом
        /// </summary>
        /// <typeparam name="TEvent">Тип события</typeparam>
        /// <param name="route">Маршрут</param>
        /// <param name="value">Событие</param>
        void Push<TEvent>(string route, TEvent value);

        /// <summary>
        /// Асинхронная отправка события
        /// </summary>
        /// <typeparam name="TEvent">Тип события</typeparam>
        /// <param name="value">Событие</param>
        Task PushAsync<TEvent>(TEvent value);
    }
}
