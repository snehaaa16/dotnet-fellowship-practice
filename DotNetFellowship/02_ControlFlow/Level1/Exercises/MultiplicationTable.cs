using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class MultiplicationTable
    {
        public static void PrintTable(int number)
        {
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + (number * i));
            }
        }
    }
}