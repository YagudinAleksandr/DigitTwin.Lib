namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Стартовая позиция камеры
    /// <see cref="GeoObject"/>
    /// </summary>
    public class StartPositionResponseDto : GeoObject
    {
        public override GeoTypeEnum GeoType => GeoTypeEnum.START_POSITION;

        /// <summary>
        /// Координаты
        /// </summary>
        public GeoCoordinate Coordinate { get; set; } = new GeoCoordinate();
    }
}
