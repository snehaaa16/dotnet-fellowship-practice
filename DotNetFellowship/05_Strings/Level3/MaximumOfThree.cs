using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class MaximumOfThree
    {
        public static void FindMaximum()
        {
            int num1 = ReadNumber("Enter First Number: ");
            int num2 = ReadNumber("Enter Second Number: ");
            int num3 = ReadNumber("Enter Third Number: ");

            int max = GetMaximum(num1, num2, num3);

            Console.WriteLine("Maximum Number = " + max);
        }

        static int ReadNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GetMaximum(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            return max;
        }
    }
}
