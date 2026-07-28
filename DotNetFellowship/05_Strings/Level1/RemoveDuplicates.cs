using System;

namespace _05_Strings.Level1
{
    internal class RemoveDuplicates
    {
        public static void RemoveDuplicateCharacters(string str)
        {
            string result = "";

            foreach (char ch in str)
            {
                if (!result.Contains(ch))
                {
                    result += ch;
                }
            }

            Console.WriteLine("String after removing duplicates: " + result);
        }
    }
}