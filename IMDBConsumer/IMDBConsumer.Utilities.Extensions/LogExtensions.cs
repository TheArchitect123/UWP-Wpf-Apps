using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace IMDBConsumer.Utilities.Extensions
{
    public static class LogExtensions
    {
        public static void LogInfo(string message)
        {
            Task.Run(() =>
            {
                using (EventLog eventLog = new EventLog("System"))
                {
                    eventLog.Source = "System";
                    eventLog.WriteEntry(message, EventLogEntryType.Information);
                }
            });
        }

        public static void LogWarning(string message)
        {
            Task.Run(() =>
            {
                using (EventLog eventLog = new EventLog("System"))
                {
                    eventLog.Source = "System";
                    eventLog.WriteEntry(message, EventLogEntryType.Warning);
                }
            });
        }

        public static void LogFailureAudit(string message)
        {
            Task.Run(() =>
            {
                using (EventLog eventLog = new EventLog("System"))
                {
                    eventLog.Source = "System";
                    eventLog.WriteEntry(message, EventLogEntryType.FailureAudit);
                }
            });
        }

        public static void LogException(this Exception ex)
        {
            Task.Run(() =>
            {
                string message = string.Empty;
                if (ex.InnerException != null)
                    message += $"{ex.InnerException.Message} \n {ex.InnerException.StackTrace}";
                else
                    message += $"{ex.Message} \n {ex.StackTrace}";

                using (EventLog eventLog = new EventLog("System"))
                {
                    eventLog.Source = "System";
                    eventLog.WriteEntry(message, EventLogEntryType.Error);
                }
            });
        }
    }
}
