using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ControlFlow.Level1.Exercises
{
    internal class SmallestOf3Numbers
    {
        public static bool IsFirstSmallest(int num1, int num2, int num3)
        {
            return num1 < num2 && num1 < num3;
        }
    }
}
