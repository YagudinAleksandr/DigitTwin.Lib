using System.Collections.Generic;

#nullable enable
namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Базовый контракт для E-mail
    /// </summary>
    public class BaseMailContract
    {
        /// <summary>
        /// E-mail адресата
        /// </summary>
        public string Address { get; set; } = null!;

        /// <summary>
        /// Тема письма
        /// </summary>
        public string Subject { get; set; } = null!;

        /// <summary>
        /// Тело
        /// </summary>
        public string Body { get; set; } = string.Empty;

        /// <summary>
        /// Вложения
        /// </summary>
        public List<string> Attachments { get; set; } = new List<string>();

        /// <summary>
        /// Тип сообщения
        /// </summary>
        public EmailTypeEnum Type { get; set; } = EmailTypeEnum.Default;
    }
}
