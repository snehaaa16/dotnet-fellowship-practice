//Problem -: Write a program to check if a number is divisible by 5
//I/P => number
//O/P => Is the number ___ divisible by 5? ___

using System;

namespace _02_ControlFlow.Level1.Exercises
{
    internal class CheckDivisibilityBy5
    {
       public static bool divisibleChecker(int num)
        {
            return num % 5 == 0;
        }
    }
}
