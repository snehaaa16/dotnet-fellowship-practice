using System;

namespace _05_Strings.Level1
{
    internal class CompareStrings
    {
        public static void Compare(string str1, string str2)
        {
            int minLength = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (str1[i] < str2[i])
                {
                    Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + "\"");
                    return;
                }
                else if (str1[i] > str2[i])
                {
                    Console.WriteLine("\"" + str2 + "\" comes before \"" + str1 + "\"");
                    return;
                }
            }

            if (str1.Length < str2.Length)
            {
                Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + "\"");
            }
            else if (str1.Length > str2.Length)
            {
                Console.WriteLine("\"" + str2 + "\" comes before \"" + str1 + "\"");
            }
            else
            {
                Console.WriteLine("Both strings are equal.");
            }
        }
    }
}