using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class LeapYearSingleCondition
    {
        public static bool IsLeapYear(int year)
        {
            if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
}