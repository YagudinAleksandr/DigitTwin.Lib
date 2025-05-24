using System.Collections.Generic;

namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Точка
    /// </summary>
    public class GeoObjectPoint : GeoObject
    {
        public override GeoTypeEnum Type => GeoTypeEnum.POINT;

        /// <summary>
        /// ИД объекта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Координаты
        /// </summary>
        public GeoCordinates Cordinates { get; set; } = new GeoCordinates();
    }
}
