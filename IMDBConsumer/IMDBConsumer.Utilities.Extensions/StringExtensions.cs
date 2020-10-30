namespace IMDBConsumer.Utilities.Extensions
{
    using System;
    using System.Net;
    using System.Text;

    public static class StringExtensions
    {
        public static string SetTitleCase(this string detail) => System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(detail);

        public static bool ValidateUrl(this string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            if (response.StatusCode != HttpStatusCode.OK)
                return true;
            else
                return false;
        }

        public static string TimePosted(this DateTime date)
        {
            //calcualte the time relative to the current time and use it to determine whether the time is 2 days ago, or 2 weeks ago, or 2 years ago

            return "";
        }

        public static string FormatJson(this string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                StringBuilder jsonFormatter = new StringBuilder();
                jsonFormatter.Append(json);
                jsonFormatter.Replace("\\", string.Empty);
                return jsonFormatter.ToString().Trim('"');
            }
            else
                return json;
        }

        public static string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public static string FormatCount(this int number)
        {
            if (number == 0)
                return $"{0}";
            else
            {
                if (number < 1000)
                    return $"{number}";
                else
                {
                    if (number > 1000 && number < 10000)
                    {
                        double fcnum = number / 10;
                        return $"{fcnum}K";
                    }
                    else if (number > 10000 && number < 100000)
                    {
                        double fcnum = number / 100;
                        return $"{fcnum}K";
                    }

                    else if (number > 100000 && number < 1000000)
                    {
                        double fcnum = number / 1000;
                        return $"{fcnum}K";
                    }
                    else
                    {
                        double fcnum = number / 1000000;
                        return $"{fcnum}M";
                    }
                }
            }
        }
    }
}