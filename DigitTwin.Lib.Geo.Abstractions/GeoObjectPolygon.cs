using System;
using System.Collections.Generic;

namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Полигон
    /// </summary>
    [Serializable]
    public class GeoObjectPolygon : GeoObject
    {
        public override GeoTypeEnum Type => GeoTypeEnum.POLYGON;

        /// <summary>
        /// Координаты
        /// </summary>
        public List<List<GeoCordinates>> Cordinates { get; set; } = new List<List<GeoCordinates>>();
    }
}
