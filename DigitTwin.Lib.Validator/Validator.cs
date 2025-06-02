using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace DigitTwin.Lib.Validator
{
    /// <summary>
    /// Валидатор
    /// </summary>
    /// <typeparam name="T">Модель</typeparam>
    public class Validator<T>
    {
        /// <summary>
        /// Построитель правил
        /// </summary>
        private readonly List<RuleBuilder<T, object>> _rules = new List<RuleBuilder<T, object>>();

        /// <summary>
        /// Правила для
        /// </summary>
        /// <typeparam name="TProperty">Свойство</typeparam>
        /// <param name="expression">Выражение</param>
        /// <returns>Построеное правило</returns>
        public RuleBuilder<T, TProperty> RuleFor<TProperty>(
            Expression<Func<T, TProperty>> expression)
        {
            var compiledSelector = expression.Compile();
            var rule = new RuleBuilder<T, TProperty>(compiledSelector);
            _rules.Add(rule as RuleBuilder<T, object>);
            return rule;
        }

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="dto">DTO</param>
        /// <returns>Ответ валидации</returns>
        public ValidationResult Validate(T dto)
        {
            var errors = _rules
                .SelectMany(rule => rule.Apply(dto))
                .ToList();

            return new ValidationResult(!errors.Any(), errors);
        }
    }
}
