namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Запрос на создание организации
    /// </summary>
    public class OrganizationCreateRequestDto
    {
        /// <summary>
        /// Короткое название организации
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Полное название организации
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// ОГРН
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// Фактический адрес
        /// </summary>
        public string FactAddress { get; set; }

        /// <summary>
        /// Юридический адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Рассчетный счет
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Кореспондентский счет
        /// </summary>
        public string CorrespondentialAccount { get; set; }
    }
}
