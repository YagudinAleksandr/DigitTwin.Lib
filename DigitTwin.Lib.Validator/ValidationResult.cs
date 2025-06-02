using System.Collections.Generic;

namespace DigitTwin.Lib.Validator
{
    /// <summary>
    /// Результат валидации
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Валидна ли модель
        /// </summary>
        public bool IsValid { get; }

        /// <summary>
        /// Список ошибок
        /// </summary>
        public List<string> Errors { get; }

        public ValidationResult(bool isValid, List<string> errors) { IsValid = isValid; Errors = errors; }
    }
}
