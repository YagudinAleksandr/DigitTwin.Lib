using System.Collections.Generic;

#nullable enable
namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Базовый ответ от API
    /// </summary>
    /// <typeparam name="TBody">Тип тела ответа</typeparam>
    public class BaseApiResponse<TBody>
    {
        /// <summary>
        /// Код обработки сервера
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Тело
        /// </summary>
        public TBody Body { get; set; } = default!;

        /// <summary>
        /// Перенаправление
        /// </summary>
        public string RedirectionUrl { get; set; } = string.Empty;

        /// <summary>
        /// Максимальное количество перенапрвлений
        /// </summary>
        public int MaxRedirects { get; set; } = 3;

        /// <summary>
        /// Ошибки
        /// </summary>
        public Dictionary<string, string> Errors { get; set; } = new Dictionary<string, string>();
    }
}
