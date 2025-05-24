#nullable enable
using System;

namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Количественный вывод элементов
    /// </summary>
    /// <typeparam name="TItem">Тип элементов</typeparam>
    [Serializable]
    public class ItemCountDto<TItem>
    {
        /// <summary>
        /// Количество элементов
        /// </summary>
        public int Count { get; set; } = 0;

        /// <summary>
        /// Массив элементов
        /// </summary>
        public TItem[] Items { get; set; } = default!;
    }
}
