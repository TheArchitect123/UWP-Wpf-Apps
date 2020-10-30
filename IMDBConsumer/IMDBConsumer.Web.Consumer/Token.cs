using System;

namespace IMDBConsumer.Web.Dto
{
    /// <summary>
    /// Holds the access information required in order to authenticate 
    /// </summary>
    public class Token
    {
        //Access Token Information
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        public string authorizationHeader { get; set; }

        //Expiration -- If Expired make sure to regenerate this object through the app, to avoid login redirects
        public DateTime expiresOnUtc { get; set; }

        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
