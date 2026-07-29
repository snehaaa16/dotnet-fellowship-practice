using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class FibonacciGenerator
    {
        public static void GenerateSeries()
        {
            int terms = ReadTerms();

            PrintFibonacci(terms);
        }

        static int ReadTerms()
        {
            Console.Write("Enter Number of Terms: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintFibonacci(int terms)
        {
            int first = 0;
            int second = 1;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(first + " ");

                int next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
