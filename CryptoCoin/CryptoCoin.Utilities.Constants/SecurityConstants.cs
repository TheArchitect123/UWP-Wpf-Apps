namespace CryptoCoin.Utilities.Constants
{
    public static class SecurityConstants
    {
        //SecurityConstants -- For SqliteEncryption
        public const string xUsername = "SecuredUsernameKey";
        public const string xPassword = "SecuredPasswordKey";
        public const string SQLCipherKey = "CryptoCoin.SecureAccess";

        //Credentials required for Access Token 
        public const string xRemoteUsernameAccess = "interview-test@drawboard.com";
        public const string xRemotePasswordsAccess = "CryptoCoin-test";

        //Used for Persisting Token Information Across Sessions
        public const string GlobalTokenAccessIdentifier = "CryptoCoinTokenID";
    }
}