using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Methods.Level1
{
    internal class SimpleInterest
    {
        public static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }
}
