using System;

namespace _04_Methods.Level1
{
    public class QuotientRemainder
    {
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;

            return new int[] { quotient, remainder };
        }
    }
}