namespace IMDBConsumer.Utilities.Extensions
{
    using System;
    using System.IO;

    public static class ByteSizeExtensions
    {
        public static double KB = Math.Pow(10, 3);
        public static double MB = Math.Pow(10, 6);
        public static double GB = Math.Pow(10, 9);

        public static string ConvertByteToString(this byte[] array)
        {
            //Value is a KB
            if (array.Length <= KB)
            {
                double lclKbLength = array.Length / KB;
                if (lclKbLength < 1)
                    return $"{Math.Ceiling(lclKbLength)}KB";
                else
                    return $"{lclKbLength}KB";
            }

            //Value is a MB
            if (array.Length <= MB)
            {
                double lclMbLength = array.Length / MB;
                if (lclMbLength < 1)
                    return $"{lclMbLength * 1000}KB";
                else
                    return $"{lclMbLength}MB";
            }
            else
            {
                //GB
                double lclGbLength = array.Length / GB;
                if (lclGbLength < 1)
                    return $"{Math.Ceiling(lclGbLength)}GB";
                else
                    return $"{lclGbLength}GB";
            }
        }
    }

}
