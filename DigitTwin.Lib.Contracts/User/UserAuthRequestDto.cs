namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Запрос авторизации пользователя
    /// </summary>
    public class UserAuthRequestDto
    {
        /// <summary>
        /// E-mail пользователя
        /// </summary>
        public string Email {  get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
    }
}
