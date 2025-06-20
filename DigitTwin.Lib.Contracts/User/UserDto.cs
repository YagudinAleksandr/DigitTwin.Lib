using System;

namespace DigitTwin.Lib.Contracts.User
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// ИД
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Тип пользователя
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Статус активности
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// ИД организации
        /// </summary>
        public Guid? OrganizationId { get; set; }
    }
}
