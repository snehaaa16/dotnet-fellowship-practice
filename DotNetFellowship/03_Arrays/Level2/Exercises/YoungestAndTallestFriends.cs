using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class YoungestAndTallestFriends
    {
        public static void FindYoungestAndTallest(int[] ages, double[] heights)
        {
            string[] names = { "Amar", "Akbar", "Anthony" };

            int youngestIndex = 0;
            int tallestIndex = 0;

            for (int i = 1; i < 3; i++)
            {
                if (ages[i] < ages[youngestIndex])
                {
                    youngestIndex = i;
                }

                if (heights[i] > heights[tallestIndex])
                {
                    tallestIndex = i;
                }
            }

            Console.WriteLine("Youngest Friend = " + names[youngestIndex]);
            Console.WriteLine("Tallest Friend = " + names[tallestIndex]);
        }
    }
}