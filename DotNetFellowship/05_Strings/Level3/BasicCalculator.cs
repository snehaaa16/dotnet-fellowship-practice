using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class BasicCalculator
    {
        public static void StartCalculator()
        {
            int first = ReadNumber("Enter First Number: ");
            int second = ReadNumber("Enter Second Number: ");

            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + Add(first, second));
                    break;

                case 2:
                    Console.WriteLine("Result = " + Subtract(first, second));
                    break;

                case 3:
                    Console.WriteLine("Result = " + Multiply(first, second));
                    break;

                case 4:
                    if (second != 0)
                        Console.WriteLine("Result = " + Divide(first, second));
                    else
                        Console.WriteLine("Division by zero is not allowed.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        static int ReadNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Divide(int a, int b)
        {
            return (double)a / b;
        }
    }
}
