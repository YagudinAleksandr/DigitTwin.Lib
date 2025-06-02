# Внутренний обработчик событий
## 1. Регистрация в DI
```csharp
services.AddSingleton<IEventBus, EventBus>();
```
## 2. Подписка на события
```csharp
public class OrderService
{
    private readonly IEventBus _eventBus;
    private IDisposable _subscription;

    public OrderService(IEventBus eventBus)
    {
        _eventBus = eventBus;
        Subscribe();
    }

    private void Subscribe()
    {
        // Подписка без маршрута
        _subscription = _eventBus.On<OrderCreated>(order => 
            Console.WriteLine($"Order received: {order.Id}"));
        
        // Подписка с маршрутом
        _eventBus.On<OrderCancelled>("orders/cancelled", order => 
            Console.WriteLine($"Cancelled: {order.Reason}"));
    }
}
```
## 3. Публикация событий
```csharp
public class OrderProcessor
{
    private readonly IEventBus _eventBus;

    public OrderProcessor(IEventBus eventBus) => _eventBus = eventBus;

    public void CreateOrder(Order order)
    {
        // Синхронная отправка
        _eventBus.Push(new OrderCreated(order.Id));
        
        // Отправка с маршрутом
        _eventBus.Push("orders/cancelled", new OrderCancelled(order.Id, "Timeout"));
        
        // Асинхронная отправка
        _eventBus.PushAsync(new OrderCreated(order.Id));
    }
}
```
## 4. Отписка от событий
```csharp
// Через Dispose
_subscription.Dispose();

// Или через using
using (_eventBus.On<OrderCompleted>(order => {...}))
{
    // Временная подписка
}
```

## 5. Глобальный доступ (опционально)
```csharp
// Через статическое свойство
EventBus.Self?.Push(new SystemEvent("AppStarted"));
```