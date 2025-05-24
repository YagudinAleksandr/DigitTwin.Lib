using System.Collections.Generic;

namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Мультиполигон
    /// </summary>
    internal class GeoObjectMultypolygon : GeoObject
    {
        public override GeoTypeEnum Type => GeoTypeEnum.MULTYPOLYGON;

        /// <summary>
        /// Координаты
        /// </summary>
        public List<List<List<GeoCordinates>>> Cordinates { get; set; } = new List<List<List<GeoCordinates>>>();
    }
}
