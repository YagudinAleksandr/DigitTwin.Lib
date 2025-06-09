using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace DigitTwin.Lib.PipelineBuilder
{
    /// <summary>
    /// Базовая реализация асинхронного пайплайна
    /// </summary>
    /// <typeparam name="TContext">Тип контекста обработки</typeparam>
    public sealed class AsyncPipeline<TContext> : IAsyncPipeline<TContext>
    {
        private readonly IEnumerable<IAsyncPipelineStep<TContext>> _steps;

        /// <summary>
        /// Инициализирует асинхронный пайплайн с набором шагов
        /// </summary>
        /// <param name="steps">Коллекция асинхронных шагов обработки</param>
        public AsyncPipeline(IEnumerable<IAsyncPipelineStep<TContext>> steps)
        {
            _steps = steps.OrderBy(step => step.Order).ToList();
        }

        /// <summary>
        /// Асинхронно выполняет все шаги пайплайна в порядке возрастания Order
        /// </summary>
        /// <param name="context">Контекст обработки</param>
        /// <param name="ct">Токен отмены</param>
        public async Task ExecuteAsync(TContext context, CancellationToken ct = default)
        {
            foreach (var step in _steps)
            {
                ct.ThrowIfCancellationRequested();
                await step.ExecuteAsync(context, ct);
            }
        }
    }
}
