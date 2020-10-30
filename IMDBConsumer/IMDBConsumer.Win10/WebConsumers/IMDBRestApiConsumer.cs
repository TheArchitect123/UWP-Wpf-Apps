using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace IMDBConsumer.Win10.WebConsumers
{
    public class IMDBRestApiConsumer
    {
        public readonly HttpClient _proxyClient;
        public IMDBRestApiConsumer()
        {
            _proxyClient = new HttpClient();
        }
    }
}
