using System.Collections.Generic;
using System.Linq;

namespace DigitTwin.Lib.PipelineBuilder
{
    /// <summary>
    /// Базовая реализация синхронного пайплайна
    /// </summary>
    /// <typeparam name="TContext">Тип контекста обработки</typeparam>
    public sealed class Pipeline<TContext> : IPipeline<TContext>
    {
        private readonly IEnumerable<IPipelineStep<TContext>> _steps;

        public Pipeline(IEnumerable<IPipelineStep<TContext>> steps)
        {
            _steps = steps.OrderBy(step => step.Order).ToList();
        }
        public void Execute(TContext context)
        {
            foreach (var step in _steps)
            {
                step.Execute(context);
            }
        }
    }
}
