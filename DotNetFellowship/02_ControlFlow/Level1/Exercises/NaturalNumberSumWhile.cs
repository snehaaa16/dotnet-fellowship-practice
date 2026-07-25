using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class NaturalNumberSumWhile
    {
        public static void CompareSum(int number)
        {
            int sum = 0;
            int i = 1;
            while (i <= number)
            {
                sum += i;
                i++;
            }
            int formulaSum = number * (number + 1) / 2;
            Console.WriteLine("Sum using while loop = " + sum);
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