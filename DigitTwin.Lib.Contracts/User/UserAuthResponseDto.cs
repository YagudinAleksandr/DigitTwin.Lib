namespace DigitTwin.Lib.Contracts
{
    /// <summary>
    /// Ответ авторизации пользователя
    /// </summary>
    public class UserAuthResponseDto
    {
        /// <summary>
        /// Токен авторизации
        /// </summary>
        public string AuthToken {  get; set; }

        /// <summary>
        /// Токен обновления авторизации
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        UserDto User { get; set; }
    }
}
