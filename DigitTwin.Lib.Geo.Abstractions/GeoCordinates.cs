using System;

namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Гео точка
    /// </summary>
    [Serializable]
    public class GeoCordinates
    {
        /// <summary>
        /// Долгота
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        public double Latitude { get; set; }
    }
}
