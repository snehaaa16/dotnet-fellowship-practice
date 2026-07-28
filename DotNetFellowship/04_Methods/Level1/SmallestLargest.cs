using System;

namespace _04_Methods.Level1
{
    public class SmallestLargest
    {
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = Math.Min(number1, Math.Min(number2, number3));
            int largest = Math.Max(number1, Math.Max(number2, number3));

            return new int[] { smallest, largest };
        }
    }
}