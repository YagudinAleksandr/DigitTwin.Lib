using System.Collections.Generic;

namespace DigitTwin.Lib.Validator
{
    /// <summary>
    /// Правила валидации
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public abstract class ValidationRule<TModel>
    {
        /// <summary>
        /// Получение списка валидации
        /// </summary>
        /// <param name="obj">Модель</param>
        /// <returns>Список ошибок</returns>
        public abstract IEnumerable<string> Validate(TModel obj);
    }
}
