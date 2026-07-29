using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class GcdLcmCalculator
    {
        public static void Calculate()
        {
            int first = ReadNumber("Enter First Number: ");
            int second = ReadNumber("Enter Second Number: ");

            int gcd = FindGCD(first, second);
            int lcm = FindLCM(first, second);

            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);
        }

        static int ReadNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        static int FindLCM(int a, int b)
        {
            return (a * b) / FindGCD(a, b);
        }
    }
}
