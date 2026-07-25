using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class SumUntilZeroOrNegative
    {
        public static double CalculateSum()
        {
            double total = 0.0;
            while (true)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number <= 0)
                {
                    break;
                }
                total += number;
            }
            return total;
        }
    }
}