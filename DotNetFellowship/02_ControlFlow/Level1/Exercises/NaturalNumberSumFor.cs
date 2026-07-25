using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class NaturalNumberSumFor
    {
        public static void CompareSum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            int formulaSum = number * (number + 1) / 2;
            Console.WriteLine("Sum using for loop = " + sum);
            Console.WriteLine("Sum using formula = " + formulaSum);
            if (sum == formulaSum)
            {
                Console.WriteLine("Both computations are correct.");
            }
            else
            {
                Console.WriteLine("Both computations are not correct.");
            }
        }
    }
}