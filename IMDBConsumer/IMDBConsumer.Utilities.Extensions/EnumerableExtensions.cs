namespace IMDBConsumer.Utilities.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensions
    {
        public static int? FindIndex<T>(this IEnumerable<T> enumerable, T obj)
        {
            int? index = 0;
            var data = enumerable.GetEnumerator();

            while (data.MoveNext())
            {
                var item = data.Current;
                if (item.Equals(obj))
                {
                    var citem = enumerable.SingleOrDefault(w => w.Equals(obj));
                    if (citem != null)
                        index = enumerable.FindIndex(citem);

                    continue;
                }
            }

            return index;
        }
    }
}
