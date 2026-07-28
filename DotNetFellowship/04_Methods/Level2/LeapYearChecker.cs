using System;

namespace _04_Methods.Level2
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (year < 1582)
                return false;

            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}