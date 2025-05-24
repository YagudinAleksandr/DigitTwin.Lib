namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Стартовая точка
    /// </summary>
    public class GeoObjectInitialPoint : GeoObject
    {
        public override GeoTypeEnum Type => GeoTypeEnum.INITIAL_POINT;

        /// <summary>
        /// Начальные координаты
        /// </summary>
        public GeoCordinates Position { get; set; } = new GeoCordinates();
    }
}
