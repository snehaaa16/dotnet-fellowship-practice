using System;

namespace _05_Strings.Level2
{
    internal class Timezone
    {
        public static void DisplayTimeZones()
        {
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById(
                OperatingSystem.IsWindows() ? "India Standard Time" : "Asia/Kolkata");

            TimeZoneInfo gmtZone = TimeZoneInfo.Utc;

            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById(
                OperatingSystem.IsWindows() ? "Pacific Standard Time" : "America/Los_Angeles");

            Console.WriteLine("GMT : " + TimeZoneInfo.ConvertTime(utcTime, gmtZone));
            Console.WriteLine("IST : " + TimeZoneInfo.ConvertTime(utcTime, istZone));
            Console.WriteLine("PST : " + TimeZoneInfo.ConvertTime(utcTime, pstZone));
        }
    }
}