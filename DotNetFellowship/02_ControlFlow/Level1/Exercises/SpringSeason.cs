using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class SpringSeason
    {
        public static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
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