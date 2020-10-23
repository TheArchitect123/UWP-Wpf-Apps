using Caliburn.Micro;
using CryptoCoin.Uwp.Services.HttpClients;
using System.Net.Http;

namespace CryptoCoin.Uwp
{
    public static class DependencyCache
    {
        public static CommonHttpClientConsumer ClientHttpConsumer => IoC.Get<CommonHttpClientConsumer>();
    }
}
