using System;

namespace _05_Strings.Level1
{
    internal class SubstringOccurrences
    {
        public static void CountOccurrences(string str, string sub)
        {
            int count = 0;

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                if (str.Substring(i, sub.Length) == sub)
                {
                    count++;
                }
            }

            Console.WriteLine("Occurrences: " + count);
        }
    }
}