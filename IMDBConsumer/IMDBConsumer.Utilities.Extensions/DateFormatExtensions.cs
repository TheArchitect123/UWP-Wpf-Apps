namespace IMDBConsumer.Utilities.Extensions
{
    using System;

    public static class DateFormatExtensions
    {
        public static string Date(this DateTime date) => date.ToString("m");
        public static string Time(this DateTime time) => time.ToString("hh:mm tt");

        public static string FormatDefaultTime(this DateTime date) => $"{date.ToString("MMM dd")}, {date.ToString("hh:mm tt")}";
        public static string FormatStdTwitterWithExp(this DateTime date)
        {
            var timespan = (DateTime.Now - date);
            if (timespan.Days > 1)
            {
                //Day Formatting
                if (timespan.Days < 7)
                {
                    return $"{timespan.Days} days ago";
                }
                else
                {
                    if (timespan.Days <= 31)
                    {
                        if (timespan.Days == 7)
                            return "1 week ago";
                        else if (timespan.Days <= 14)
                            return $"2 weeks ago";
                        else if (timespan.Days <= 21)
                            return $"3 weeks ago";
                        else if (timespan.Days <= 28)
                            return $"1 month ago";
                    }
                    else
                    {
                        if (timespan.Days <= 365)
                        {
                            if (timespan.Days <= 62)
                                return $"2 months ago";
                            else if (timespan.Days <= 90)
                                return $"3 months ago";
                            else if (timespan.Days <= 120)
                                return $"4 months ago";
                            else if (timespan.Days <= 150)
                                return $"5 months ago";
                            else if (timespan.Days <= 180)
                                return $"6 months ago";
                            else if (timespan.Days <= 210)
                                return $"7 months ago";
                            else if (timespan.Days <= 240)
                                return $"8 months ago";
                            else if (timespan.Days <= 270)
                                return $"9 months ago";
                            else if (timespan.Days <= 300)
                                return $"10 months ago";
                            else if (timespan.Days <= 330)
                                return $"11 months ago";
                            else if (timespan.Days <= 360)
                                return $"1 year ago";
                        }
                        else
                        {
                            if (timespan.Days <= 720)
                                return $"2 years ago";
                            else if (timespan.Days <= 1020)
                                return $"3 years ago";
                        }
                    }
                }
            }
            else
            {
                //Post was done today
                if (timespan.Hours < 24)
                {
                    if (timespan.Minutes > 60)
                        return $"{timespan.Hours} hours ago";
                    else
                    {
                        if (timespan.Minutes > 1)
                            return $"{timespan.Minutes} minutes ago";
                        else
                            return $"Just now";
                    }
                }
                else
                    return "1 day ago";
            }

            return string.Empty;
        }
        public static string FormatStdDateWithExp(this DateTime date)
        {
            var timespan = (DateTime.Now - date);
            if (timespan.Days > 1)
            {
                //Day Formatting
                if (timespan.Days < 7)
                {
                    return $"{timespan.Days}d";
                }
                else
                {
                    if (timespan.Days <= 31)
                    {
                        if (timespan.Days == 7)
                            return "1w";
                        else if (timespan.Days <= 14)
                            return $"2w";
                        else if (timespan.Days <= 21)
                            return $"3w";
                        else if (timespan.Days <= 28)
                            return $"1mon";
                    }
                    else
                    {
                        if (timespan.Days <= 365)
                        {
                            if (timespan.Days <= 62)
                                return $"2mon";
                            else if (timespan.Days <= 90)
                                return $"3mon";
                            else if (timespan.Days <= 120)
                                return $"4mon";
                            else if (timespan.Days <= 150)
                                return $"5mon";
                            else if (timespan.Days <= 180)
                                return $"6mon";
                            else if (timespan.Days <= 210)
                                return $"7mon";
                            else if (timespan.Days <= 240)
                                return $"8mon";
                            else if (timespan.Days <= 270)
                                return $"9mon";
                            else if (timespan.Days <= 300)
                                return $"10mon";
                            else if (timespan.Days <= 330)
                                return $"11mon";
                            else if (timespan.Days <= 360)
                                return $"1y";
                        }
                        else
                        {
                            if (timespan.Days <= 720)
                                return $"2y";
                            else if (timespan.Days <= 1020)
                                return $"3y";
                        }
                    }
                }
            }
            else
            {
                //Post was done today
                if (timespan.Hours < 24)
                {
                    if (timespan.Minutes > 60)
                        return $"{timespan.Hours} hours";
                    else
                    {
                        if (timespan.Minutes > 1)
                            return $"{timespan.Minutes} min";
                        else
                            return $"Just now";
                    }
                }
                else
                    return "1d";
            }

            return string.Empty;
        }
    }
}
