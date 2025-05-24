using System;
using System.Collections.Generic;
using System.Net.Http;

#nullable enable
namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Базовый тип запроса к API
    /// </summary>
    /// <typeparam name="TBody">Тип тела ответа</typeparam>
    [Serializable]
    public class BaseApiRequest<TBody> where TBody : class
    {
        /// <summary>
        /// Метод запроса
        /// </summary>
        HttpMethod Method { get; set; } = HttpMethod.Get;

        /// <summary>
        /// URI
        /// </summary>
        public string Uri { get; set; } = null!;

        /// <summary>
        /// Тело запроса
        /// </summary>
        public TBody? Body { get; set; }

        /// <summary>
        /// Ссылка перенаправления
        /// </summary>
        public string RedirectionUrl { get; set; } = string.Empty;

        /// <summary>
        /// Заголовки
        /// </summary>
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Параметры запроса
        /// </summary>
        public Dictionary<string, string> RequestParams { get; set; } = new Dictionary<string, string>();
    }
}
