
using CryptoCoin.Utilities.Constants;
using CryptoCoin.Utilities.Extensions;
using CryptoCoin.Uwp.Services.Security;
using CryptoCoin.Domain.Services;
using ModernHttpClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace CryptoCoin.Uwp.Services.HttpClients
{
    public class SecurityDto
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class CommonHttpClientConsumer
    {
        private readonly HttpClient _httpClient = RegisterWebServices.GetService<IHttpClientFactory>().CreateClient(nameof(CommonHttpClientConsumer));

        public async Task<Token> GenerateAccessTokenForSignIn()
        {
            Token responseToken = null;
            using (var request = new HttpRequestMessage(HttpMethod.Post, ApiResourceConstants.authenticate_login))
            {
                request.Content = new StringContent(JsonConvert.SerializeObject(new SecurityDto()
                {
                    username = SecurityConstants.xRemoteUsernameAccess,
                    password = SecurityConstants.xRemotePasswordsAccess
                }), Encoding.UTF8, "application/json");

                var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);
                if (response != null)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(result))
                        responseToken = JsonConvert.DeserializeObject<Token>(result);

                }
            }

            //Save the Token to Local Storage For the Next Session
            WindowsClientStorage.SaveSettingsToLocalContainer(new KeyValuePair<string, string>(SecurityConstants.GlobalTokenAccessIdentifier, JsonConvert.SerializeObject(responseToken)));

            return responseToken;
        }

        //public async Task<IEnumerable<ProjectsDto>> GetProjectsForSpecifiedToken(Token accessToken)
        //{
        //    if (accessToken.expiresOnUtc.IsExpired()) //Token has expired, and thus a new token has to be generated
        //        accessToken = GenerateAccessTokenForSignIn().Result;


        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Get,
        //        RequestUri = new Uri(ApiResourceConstants.get_projects_forAuthUser),
        //    };

        //    request.Headers.Add("Authorization", accessToken.authorizationHeader);

        //    var response = _httpClient.SendAsync(request).Result; //Invoked as a fire & Forget call that generates and instantiates the httpclienthandler
        //    return JsonConvert.DeserializeObject<IEnumerable<ProjectsDto>>((await response.Content.ReadAsStringAsync()));
        //}
    }
}
