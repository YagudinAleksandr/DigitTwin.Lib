﻿using System;

namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Организация
    /// </summary>
    public class OrganizationDto
    {
        /// <summary>
        /// ИД
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Короткое название организации
        /// </summary>
        public string ShortName { get; set; } = null!;

        /// <summary>
        /// Полное название организации
        /// </summary>
        public string FullName { get; set; } = null!;

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; } = null!;

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;

        /// <summary>
        /// ОГРН
        /// </summary>
        public string Ogrn { get; set; } = null!;

        /// <summary>
        /// Фактический адрес
        /// </summary>
        public string FactAddress { get; set; } = null!;

        /// <summary>
        /// Юридический адрес
        /// </summary>
        public string Address { get; set; } = null!;

        /// <summary>
        /// Рассчетный счет
        /// </summary>
        public string Account { get; set; } = null!;

        /// <summary>
        /// Кореспондентский счет
        /// </summary>
        public string CorrespondentialAccount { get; set; } = null!;
    }
}
