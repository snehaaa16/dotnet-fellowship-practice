using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class PrimeNumberChecker
    {
        public static void CheckPrime()
        {
            int number = ReadNumber();

            if (IsPrime(number))
            {
                Console.WriteLine(number + " is a Prime Number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime Number.");
            }
        }

        static int ReadNumber()
        {
            Console.Write("Enter a Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
