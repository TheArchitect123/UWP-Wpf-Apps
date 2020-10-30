using System.Net;

namespace IMDBConsumer.Utilities.Extensions
{
    public static class WebExtensions
    {
        public static bool IsResourceAvailable(this string resource)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(resource))
                {
                    HttpWebRequest request = WebRequest.Create($"{resource}") as HttpWebRequest;
                    request.Method = "GET";
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    if (response.StatusCode == HttpStatusCode.OK)
                        return true;
                    else
                        return false;
                }
                else
                    return false;

            }
            catch
            {
                return false;
            }
        }
    }
}
