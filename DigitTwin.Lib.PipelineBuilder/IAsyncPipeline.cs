using System.Threading.Tasks;
using System.Threading;

namespace DigitTwin.Lib.PipelineBuilder
{
    /// <summary>
    /// Асинхронный пайплайн обработки
    /// </summary>
    /// <typeparam name="TContext">Тип контекста обработки</typeparam>
    public interface IAsyncPipeline<TContext>
    {
        /// <summary>
        /// Запускает асинхронное выполнение пайплайна
        /// </summary>
        /// <param name="context">Контекст обработки</param>
        /// <param name="ct">Токен отмены</param>
        Task ExecuteAsync(TContext context, CancellationToken ct = default);
    }
}
