using Newtonsoft.Json;

namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Базовый геообъект
    /// </summary>
    public abstract class GeoObject
    {
        /// <summary>
        /// Тип геообъекта
        /// </summary>
        [JsonProperty("type")]
        public abstract GeoTypeEnum Type { get; }
    }
}
