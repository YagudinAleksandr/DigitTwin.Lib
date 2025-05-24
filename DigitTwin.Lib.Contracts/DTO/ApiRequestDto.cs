namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Базовый запрос к API
    /// </summary>
    /// <typeparam name="TBody">Тип данных тела запроса</typeparam>
    public class ApiRequestDto<TBody>
    {
        /// <summary>
        /// Uri запроса
        /// </summary>
        public string Uri { get; set; } = null!;

        /// <summary>
        /// Заголовки запроса
        /// </summary>
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Парметры запроса
        /// </summary>
        public Dictionary<string, string> Params { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Метод запроса
        /// </summary>
        /// <remarks>По умолчанию GET запрос</remarks>
        public HttpMethod Method { get; set; } = HttpMethod.Get;

        /// <summary>
        /// Тело запроса
        /// </summary>
        public TBody? Body { get; set; }

        /// <summary>
        /// Максимальное количество перенаправлений
        /// </summary>
        public int MaxRedirects { get; set; } = 3;
    }
}
