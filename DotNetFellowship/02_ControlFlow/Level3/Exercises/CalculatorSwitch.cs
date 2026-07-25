using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class CalculatorSwitch
    {
        public static double Calculate(double first, double second, string op)
        {
            switch (op)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    return first / second;
                default:
                    Console.WriteLine("Invalid Operator");
                    return 0;
            }
        }
    }
}