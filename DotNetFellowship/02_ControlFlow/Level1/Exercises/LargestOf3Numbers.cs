using System;
using System.Collections.Generic;
using System.Text;

//Write a program to check if the first, second, or third number is the largest of the three.
//I/P => number1, number2, number3
//O/P => 
//Is the first number the largest? ____
//Is the second number the largest? ___


namespace _02_ControlFlow.Level1.Exercises
{
    internal class LargestOf3Numbers
    {
        public static int LargestNumber(int num1, int num2, int num3)
        {
            if(num1>num2 && num1>num3) { return num1; }
            else if(num2> num1 && num2 > num3) { return num2; }
            else { return num3; }
        }
    }
}
