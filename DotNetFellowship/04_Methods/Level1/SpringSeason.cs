using System;

namespace _04_Methods.Level1
{
    public class SpringSeason
    {
        public static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) ||
                (month == 4) ||
                (month == 5) ||
                (month == 6 && day <= 20))
            {
                return true;
            }

            return false;
        }
    }
}