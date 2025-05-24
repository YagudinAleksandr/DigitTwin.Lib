using System;
using DigitTwin.Lib.Geo.Abstractions;

namespace DigitTwin.Lib.Contracts.Map
{
    /// <summary>
    /// Ответ API о инициализации карты
    /// </summary>
    [Serializable]
    public class MapApiResponseDto
    {
        /// <summary>
        /// ИД
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Координаты
        /// </summary>
        public GeoObjectInitialPoint Coordinates { get; set; }
    }
}
