using System;

namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Информация о токене
    /// </summary>
    public class TokenInfoDto
    {
        /// <summary>
        /// ИД пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Email пользователя
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Тип пользователя
        /// </summary>
        public int UserType { get; set; }

        /// <summary>
        /// Время создания токена
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Время истечения токена
        /// </summary>
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// JWT токен
        /// </summary>
        public string Token { get; set; } = string.Empty;
    }
}
