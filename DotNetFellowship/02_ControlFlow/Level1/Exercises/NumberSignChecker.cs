using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class NumberSignChecker
    {
        public static string CheckNumberSign(int number)
        {
            if (number > 0) { return "Positive"; }
            else if (number < 0) { return "Negative"; }
            else { return "Zero"; }
        }
    }
}
