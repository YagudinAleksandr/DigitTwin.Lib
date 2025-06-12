using System;

namespace DigitTwin.Lib.Geo.Abstractions
{
    /// <summary>
    /// Утилиты для конвертирования геоданных
    /// </summary>
    public static class GeoHelper
    {
        /// <summary>
        /// Радиус Земли
        /// </summary>
        private const float EARTH_RADIUS = 6378137f;

        /// <summary>
        /// Перевод данных
        /// </summary>
        private const float ORIGIN_SHIFT = (float)(2f * Math.PI * EARTH_RADIUS / 2f);

        /// <summary>
        /// Широта и долгота в мировые координаты
        /// </summary>
        /// <param name="geoCordinates">Гео-координаты</param>
        /// <returns>
        /// <list type="bullet">
        /// <item>Координата X</item>
        /// <item>Координата Y</item>
        /// </list>
        /// </returns>
        public static (float coordX, float coordY) LatLonToWorld(GeoCordinates geoCordinates)
        {
            float x = (float)(geoCordinates.Longitude * ORIGIN_SHIFT / 180.0);
            float y = (float)(Math.Log(Math.Tan((90 + geoCordinates.Latitude) * Math.PI / 360.0f)) / Math.PI / 180.0f);

            y = (float)(y * ORIGIN_SHIFT / 180.0);

            return (x, y);
        }

        /// <summary>
        /// Мировые координаты в широту и долготу
        /// </summary>
        /// <param name="worldPos">Вектор</param>
        /// <returns>Гео-координаты</returns>
        public static GeoCordinates WorldToLatLon(float coordX, float coordY)
        {
            double lon = (coordX / ORIGIN_SHIFT) * 180.0;
            double lat = (coordY / ORIGIN_SHIFT) * 180.0;

            lat = 180.0 / Math.PI * (2f * Math.Atan(Math.Exp((float)lat * Math.PI / 180.0f)) - Math.PI / 2f);

            return new GeoCordinates { Latitude = lat, Longitude = lon };
        }
    }
}
