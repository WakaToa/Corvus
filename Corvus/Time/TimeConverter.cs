using System;

namespace Corvus.Time
{
    public static class TimeConverter
    {
        public static DateTime TimestampToDate(this int unixTimeStamp)
        {
            var time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            time = time.AddSeconds(unixTimeStamp).ToLocalTime();
            return time;
        }

        public static string FormatReadable(this TimeSpan ts)
        {
            return $"{(int)ts.TotalHours:00}:{ts.Minutes:00}:{ts.Seconds:00}";
        }
    }
}
