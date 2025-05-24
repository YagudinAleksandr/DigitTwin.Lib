namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Базовые типы объектов гео-объектов
    /// </summary>
    public enum GeoTypeEnum
    {
        /// <summary>
        /// Точка старта
        /// </summary>
        INITIAL_POINT,

        /// <summary>
        /// Точка
        /// </summary>
        POINT,

        /// <summary>
        /// Линия
        /// </summary>
        LINE,

        /// <summary>
        /// Полигон
        /// </summary>
        POLYGON,

        /// <summary>
        /// Мультиполигон
        /// </summary>
        MULTYPOLYGON
    }
}
