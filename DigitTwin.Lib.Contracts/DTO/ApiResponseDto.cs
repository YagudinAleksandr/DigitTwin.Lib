namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Базовый ответ от API
    /// </summary>
    /// <typeparam name="TBody">Тип тела ответа</typeparam>
    public class ApiResponseDto<TBody>
    {
        /// <summary>
        /// Код ответа
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Адрес перенаправления
        /// </summary>
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Тело ответа
        /// </summary>
        public TBody? Body { get; set; }

        /// <summary>
        /// Список ошибок
        /// </summary>
        public Dictionary<string, string> Errors { get; set; } = new Dictionary<string, string>();
    }
}
