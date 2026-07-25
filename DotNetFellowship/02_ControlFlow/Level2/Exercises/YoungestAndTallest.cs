using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class YoungestAndTallest
    {
        public static void FindYoungestAndTallest(int amarAge, int akbarAge, int anthonyAge, double amarHeight, double akbarHeight, double anthonyHeight)
        {
            if (amarAge < akbarAge && amarAge < anthonyAge)
            {
                Console.WriteLine("Youngest = Amar");
            }
            else if (akbarAge < amarAge && akbarAge < anthonyAge)
            {
                Console.WriteLine("Youngest = Akbar");
            }
            else
            {
                Console.WriteLine("Youngest = Anthony");
            }
            if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
            {
                Console.WriteLine("Tallest = Amar");
            }
            else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight)
            {
                Console.WriteLine("Tallest = Akbar");
            }
            else
            {
                Console.WriteLine("Tallest = Anthony");
            }
        }
    }
}