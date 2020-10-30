namespace IMDBConsumer.Utilities.Extensions
{
    using System;
    using System.Threading.Tasks;

    public static class TaskExtensions
    {
        public static TimeSpan Minutes = TimeSpan.FromDays(1);
        public static TimeSpan Seconds = TimeSpan.FromSeconds(5);

        public static Task WaitUntilComplete(this Task task, TimeSpan? delay, Func<bool> action)
        {
            var timeout = delay.GetValueOrDefault(Seconds);

            return task;
        }

        public static Task WaitUntilCompleteAsync(this Task task, TimeSpan? delay, Func<Task<bool>> action)
        {
            var timeout = delay.GetValueOrDefault(Seconds);
            if (action != null)
                action.Invoke();

            return task;
        }
    }

}
