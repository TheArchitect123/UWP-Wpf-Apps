namespace IMDBConsumer.Utilities.Extensions
{
    using Plugin.Security.Core;

    public static class SecurityExtensions
    {
        public static string HashPassword(this string clearText) => new PasswordEncoder().Encode(clearText, EncryptType.SHA_512);
    }
}