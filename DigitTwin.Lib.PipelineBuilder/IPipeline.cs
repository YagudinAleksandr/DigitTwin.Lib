namespace DigitTwin.Lib.PipelineBuilder
{
    /// <summary>
    /// Синхронный пайплайн обработки
    /// </summary>
    /// <typeparam name="TContext">Тип контекста обработки</typeparam>
    public interface IPipeline<TContext>
    {
        /// <summary>
        /// Запускает синхронное выполнение пайплайна
        /// </summary>
        /// <param name="context">Контекст обработки</param>
        void Execute(TContext context);
    }
}
