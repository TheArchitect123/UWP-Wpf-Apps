namespace IMDBConsumer.Utilities.Extensions
{
    using System;

    public static class ExceptionExtension
    {
        public static Exception HandleException(this Exception ex, out string message, out string stacktrace)
        {
            message = ex.Message;
            stacktrace = ex.StackTrace;

            if (string.IsNullOrEmpty(message))
                message = "An unknown error has occurred";

            //Output a local notification here
            LogExtensions.LogException(ex);
            return ex;
        }
    }
}
