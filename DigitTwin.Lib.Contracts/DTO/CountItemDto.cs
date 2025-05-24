namespace DigitTwin.Lib.Contracts.DTO
{
    /// <summary>
    /// Количественный вывод элементов
    /// </summary>
    /// <typeparam name="TItem">Тип данных</typeparam>
    public class CountItemDto<TItem>
    {
        /// <summary>
        /// Количество элементов
        /// </summary>
        public int Count { get; set; } = 0;

        /// <summary>
        /// Элементы
        /// </summary>
        public TItem[]? Items { get; set; }
    }
}
