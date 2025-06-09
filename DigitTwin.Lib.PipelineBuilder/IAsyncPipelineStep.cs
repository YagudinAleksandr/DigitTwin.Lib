using System.Threading.Tasks;
using System.Threading;

namespace DigitTwin.Lib.PipelineBuilder
{
    /// <summary>
    /// Шаг асинхронного пайплайна
    /// </summary>
    /// <typeparam name="TContext">Тип контекста обработки</typeparam>
    public interface IAsyncPipelineStep<TContext>
    {
        /// <summary>
        /// Порядок выполнения шага (от меньшего к большему)
        /// </summary>
        int Order { get; }

        /// <summary>
        /// Выполняет асинхронную обработку контекста
        /// </summary>
        /// <param name="context">Контекст обработки</param>
        /// <param name="ct">Токен отмены</param>
        Task ExecuteAsync(TContext context, CancellationToken ct);
    }
}
