using System.Collections.Generic;

namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Базовый ответ сервера
    /// </summary>
    public interface IBaseApiResponse
    {
        /// <summary>
        /// Код обработки сервера
        /// </summary>
        int StatusCode { get; set; }

        /// <summary>
        /// Перенаправление
        /// </summary>
        string RedirectionUrl { get; set; }

        /// <summary>
        /// Максимальное количество перенапрвлений
        /// </summary>
        int MaxRedirects { get; set; }

        /// <summary>
        /// Ошибки
        /// </summary>
        Dictionary<string, string> Errors { get; set; }

        /// <summary>
        /// Заголовки
        /// </summary>
        Dictionary<string, string> Headers { get; set; }
    }
}
