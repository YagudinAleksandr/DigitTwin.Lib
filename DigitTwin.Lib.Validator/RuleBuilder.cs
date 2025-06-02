using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitTwin.Lib.Validator
{
    /// <summary>
    /// Построитель правил
    /// </summary>
    /// <typeparam name="T">Параметр</typeparam>
    /// <typeparam name="TProperty">Свойство</typeparam>
    public class RuleBuilder<T, TProperty>
    {
        /// <summary>
        /// Выборка правил
        /// </summary>
        private readonly Func<T, TProperty> _propertySelector;

        /// <summary>
        /// Список валидаторов
        /// </summary>
        private readonly List<Func<TProperty, string?>> _validators = new List<Func<TProperty, string?>>();

        public RuleBuilder(Func<T, TProperty> propertySelector)
        {
            _propertySelector = propertySelector;
        }

        /// <summary>
        /// Должен
        /// </summary>
        /// <param name="predicate">Условие</param>
        /// <param name="errorMessage">Ошибка</param>
        /// <returns>Правила</returns>
        public RuleBuilder<T, TProperty> Must(Func<TProperty, bool> predicate, string errorMessage)
        {
            _validators.Add(value => predicate(value) ? null : errorMessage);
            return this;
        }

        /// <summary>
        /// Применить правила
        /// </summary>
        /// <param name="obj">Объект</param>
        /// <returns>Правила</returns>
        public IEnumerable<string> Apply(T obj)
        {
            var value = _propertySelector(obj);
            return _validators
                .Select(validator => validator(value))
                .Where(error => error != null)!;
        }
    }
}
