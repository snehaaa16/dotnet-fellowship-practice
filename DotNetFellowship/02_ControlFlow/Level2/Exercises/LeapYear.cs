using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            if (year < 1582)
            {
                return false;
            }
            else if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}