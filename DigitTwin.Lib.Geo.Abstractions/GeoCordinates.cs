using System;
using Newtonsoft.Json;

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
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
    }
}
