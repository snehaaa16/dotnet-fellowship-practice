using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class FactorialRecursion
    {
        public static void CalculateFactorial()
        {
            int number = ReadNumber();

            long result = Factorial(number);

            Console.WriteLine("Factorial = " + result);
        }

        static int ReadNumber()
        {
            Console.Write("Enter a Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static long Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
