using System;

namespace _04_Methods.Level1
{
    public class ChocolateDistribution
    {
        public static int[] FindChocolateDistribution(int chocolates, int children)
        {
            int eachChild = chocolates / children;
            int remaining = chocolates % children;

            return new int[] { eachChild, remaining };
        }
    }
}