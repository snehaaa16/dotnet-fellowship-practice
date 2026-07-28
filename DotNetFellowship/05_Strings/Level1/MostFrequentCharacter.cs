using System;

namespace _05_Strings.Level1
{
    internal class MostFrequentCharacter
    {
        public static void FindMostFrequent(string str)
        {
            int maxCount = 0;
            char maxChar = '\0';

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxChar = str[i];
                }
            }

            Console.WriteLine("Most Frequent Character: " + maxChar);
            Console.WriteLine("Frequency: " + maxCount);
        }
    }
}