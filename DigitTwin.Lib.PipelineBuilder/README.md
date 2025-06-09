# Pipeline Service
Реализация паттерна Pipeline с поддержкой:

Синхронного и асинхронного выполнения

Автоматической сортировки шагов

Интеграции через Dependency Injection

Гибкой настройки контекста обработки

## Установка
1. Добавьте проект/пакет в решение
2. Зарегистрируйте в DI-контейнере:
```csharp
builder.Services.AddPipelines<UserContext>(Assembly.GetExecutingAssembly());
```

## Настрйка
1. Создайте контекст
```csharp
public class MyContext
{
    public string Data { get; set; }
    public bool IsValid { get; set; }
}
```
2. Реализуйте шаги
```csharp
// Синхронный шаг
public class ValidationStep : IPipelineStep<MyContext>
{
    public int Order => 10; // Порядок выполнения

    public void Execute(MyContext context)
    {
        context.IsValid = !string.IsNullOrEmpty(context.Data);
    }
}

// Асинхронный шаг
public class ProcessingStep : IAsyncPipelineStep<MyContext>
{
    public int Order => 20;

    public async Task ExecuteAsync(MyContext context, CancellationToken ct)
    {
        await Task.Delay(100, ct);
        context.Data = context.Data.ToUpper();
    }
}
```
3. Использование
```csharp
public class MyService
{
    private readonly IPipeline<MyContext> _pipeline;
    private readonly IAsyncPipeline<MyContext> _asyncPipeline;

    public MyService(
        IPipeline<MyContext> pipeline,
        IAsyncPipeline<MyContext> asyncPipeline)
    {
        _pipeline = pipeline;
        _asyncPipeline = asyncPipeline;
    }

    public void ProcessSync()
    {
        var context = new MyContext { Data = "test" };
        _pipeline.Execute(context);
        Console.WriteLine(context.IsValid); // true
    }

    public async Task ProcessAsync()
    {
        var context = new MyContext { Data = "test" };
        await _asyncPipeline.ExecuteAsync(context);
        Console.WriteLine(context.Data); // "TEST"
    }
}
```

## Особенности работы с DI
### Почему Transient?
Pipeline зарегистрирован как Transient, потому что:

Не содержит собственного состояния

Зависит от коллекции шагов, которые могут быть разных Lifetime

Гарантирует актуальность списка шагов при каждом запросе

Избегает проблем с кэшированием зависимостей
### Использование в Singleton
#### Можно, но с ограничениями:
```csharp
services.AddSingleton<IPipeline<MyContext>>(provider => 
    new Pipeline<MyContext>(
        provider.GetServices<IPipelineStep<MyContext>>()
    ));
```
#### Требования:
Все шаги должны поддерживать Singleton:

    Или быть Stateless

    Или явно зарегистрированы как Singleton

Не должны зависеть от Scoped-сервисов

#### Рекомендации:
Для веб-приложений используйте Scoped/Transient

Для фоновых служб - Singleton с осторожностью

Тестируйте жизненный цикл зависимостей шагов

### Преимущества реализации
Гибкость:

    Комбинируйте синхронные и асинхронные шаги

    Контроль порядка через свойство Order

Тестируемость:

    Шаги тестируются изолированно

    Легко мокировать отдельные шаги

Расширяемость:

    Добавление новых шагов без изменения ядра

    Поддержка различных контекстов

Безопасность:

    Автоматическая проверка CancellationToken

    Изоляция исключений в шагах

## Ограничения
Нет встроенной обработки ошибок (добавляйте try-catch в шаги)

Нет поддержки параллельного выполнения (v. 0.0.1)

Порядок выполнения определяется только свойством Order