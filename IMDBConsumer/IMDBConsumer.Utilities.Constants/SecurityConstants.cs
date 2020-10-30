namespace IMDBConsumer.Utilities.Constants
{
    public static class SecurityConstants
    {
        //SecurityConstants -- For SqliteEncryption
        public const string xUsername = "SecuredUsernameKey";
        public const string xPassword = "SecuredPasswordKey";
        public const string SQLCipherKey = "IMDBConsumer.SecureAccess";

        //Used for Persisting Token Information Across Sessions
        public const string GlobalTokenAccessIdentifier = "IMDBConsumerCoinTokenID";
    }
}