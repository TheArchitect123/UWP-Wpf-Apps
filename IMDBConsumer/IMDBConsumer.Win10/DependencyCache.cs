using Caliburn.Micro;
using IMDBConsumer.Uwp.Services.HttpClients;
using System.Net.Http;

namespace IMDBConsumer.Uwp
{
    public static class DependencyCache
    {
        public static CommonHttpClientConsumer ClientHttpConsumer => IoC.Get<CommonHttpClientConsumer>();
    }
}
