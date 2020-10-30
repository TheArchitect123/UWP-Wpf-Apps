using System;
using System.IO;

namespace IMDBConsumer.Utilities.Extensions
{
    public static class FileExtensions
    {
        private static string TempFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Temp");
        public static string CompressFile(this string sourceFileName, string fileName)
        {

            return "";
        }

        public static bool ClearCache(this string cachePath)
        {
            try
            {
                foreach (var item in Directory.GetFiles(cachePath))
                    File.Delete(item); //Clears the specified Cache of all files in the returned path
            }
            catch { return false; }

            return true;
        }
    }
}
