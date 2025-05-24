namespace DigitTwin.Lib.Geo.Abstractions
{
    public abstract class GeoObject
    {
        /// <summary>
        /// ИД объекта
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Тип объекта
        /// </summary>
        public abstract GeoTypeEnum GeoType { get; }
    }
}
