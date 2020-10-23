namespace CryptoCoin.Utilities.Extensions
{
    using System;

    public static class TokenExtensions
    {
        public static bool IsExpired(this DateTime expirationDate) => (DateTime.UtcNow) > expirationDate;
    }
}
