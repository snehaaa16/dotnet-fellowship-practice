using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class SumUntilZero
    {
        public static double CalculateSum()
        {
            double total = 0.0;
            double number = Convert.ToDouble(Console.ReadLine());
            while (number != 0)
            {
                total += number;
                number = Convert.ToDouble(Console.ReadLine());
            }
            return total;
        }
    }
}