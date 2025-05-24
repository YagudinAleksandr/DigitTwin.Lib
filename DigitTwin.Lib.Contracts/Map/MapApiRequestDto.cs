using System;

namespace DigitTwin.Lib.Contracts.Map
{
    /// <summary>
    /// Запрос получения данных для карты организации
    /// </summary>
    [Serializable]
    public class MapApiRequestDto
    {
        /// <summary>
        /// ИД организации
        /// </summary>
        public Guid OrganizationId { get; set; }
    }
}
