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
        public TokenInfoDto AuthToken {  get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public UserDto User { get; set; }
    }
}
