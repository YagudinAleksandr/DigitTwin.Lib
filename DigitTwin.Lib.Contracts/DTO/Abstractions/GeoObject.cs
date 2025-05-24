namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Геообъект
    /// </summary>
    public abstract class GeoObject
    {
        /// <summary>
        /// ИД объекта
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Тип объекта
        /// </summary>
        public abstract GeoTypeEnum GeoType { get;}
    }
}
