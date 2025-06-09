namespace DigitTwin.Lib.PipelineBuilder
{
    /// <summary>
    /// Шаг синхронного пайплайна
    /// </summary>
    /// <typeparam name="TContext">Тип контекста обработки</typeparam>
    public interface IPipelineStep<TContext>
    {
        /// <summary>
        /// Порядок выполнения шага (от меньшего к большему)
        /// </summary>
        int Order { get; }

        /// <summary>
        /// Выполняет синхронную обработку контекста
        /// </summary>
        /// <param name="context">Контекст обработки</param>
        void Execute(TContext context);
    }
}
