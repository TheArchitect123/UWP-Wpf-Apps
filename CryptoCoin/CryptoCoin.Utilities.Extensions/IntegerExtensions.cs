using System;

namespace CryptoCoin.Utilities.Extensions
{
    public static class IntegerExtensions
    {
        public static int GenerateRandomNumber() => (new Random()).Next(1, 10000);
    }
}
