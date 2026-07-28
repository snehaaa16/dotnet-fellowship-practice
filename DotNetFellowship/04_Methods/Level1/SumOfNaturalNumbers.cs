using System;

namespace _04_Methods.Level1
{
    public class SumOfNaturalNumbers
    {
        public static int FindSum(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}