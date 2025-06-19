namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Типы сообщений
    /// </summary>
    public enum EmailTypeEnum
    {
        /// <summary>
        /// Базовое сообщение
        /// </summary>
        Default = 0,

        /// <summary>
        /// Сообщение о создании
        /// </summary>
        Created = 1,

        /// <summary>
        /// Сообщение об обновлении
        /// </summary>
        Updated = 2,

        /// <summary>
        /// Сообщение об удалении
        /// </summary>
        Deleted = 3,

        /// <summary>
        /// Сообщение о событии
        /// </summary>
        Event = 4,

        /// <summary>
        /// Оповещение
        /// </summary>
        Notofication = 5
    }
}
