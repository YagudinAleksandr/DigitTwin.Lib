using System.Collections.Generic;

namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Линия
    /// </summary>
    public class GeoObjectLine : GeoObject
    {
        public override GeoTypeEnum Type => GeoTypeEnum.LINE;

        /// <summary>
        /// Координаты
        /// </summary>
        public List<GeoCordinates> Cordinates { get; set; } = new List<GeoCordinates>();
    }
}
