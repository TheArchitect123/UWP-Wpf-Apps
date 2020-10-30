using System;

namespace IMDBConsumer.Utilities.Extensions
{
    public static class IntegerExtensions
    {
        public static int GenerateRandomNumber() => (new Random()).Next(1, 10000);
    }
}
