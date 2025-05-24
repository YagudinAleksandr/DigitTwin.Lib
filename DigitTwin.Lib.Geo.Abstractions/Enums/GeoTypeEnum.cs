namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Типы геообъектов
    /// </summary>
    public enum GeoTypeEnum
    {
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
        MULTYPOLYGON,

        /// <summary>
        /// Стартовая позиция
        /// </summary>
        START_POSITION
    }
}
