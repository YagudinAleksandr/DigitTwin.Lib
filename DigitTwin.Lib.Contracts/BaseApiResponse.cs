using System;
using System.Collections.Generic;

#nullable enable
namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Базовый ответ от API
    /// </summary>
    /// <typeparam name="TBody">Тип тела ответа</typeparam>
    [Serializable]
    public class BaseApiResponse<TBody> : IBaseApiResponse
    {
        public int StatusCode { get; set; }

        public string RedirectionUrl { get; set; } = string.Empty;

        public int MaxRedirects { get; set; } = 3;

        public List<string> Errors { get; set; } = new List<string>();

        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Тело
        /// </summary>
        public TBody Body { get; set; } = default!;
    }
}
