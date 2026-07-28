using System;

namespace _05_Strings.Level1
{
    internal class RemoveSpecificCharacter
    {
        public static void RemoveCharacter(string str, char removeChar)
        {
            string result = "";

            foreach (char ch in str)
            {
                if (ch != removeChar)
                {
                    result += ch;
                }
            }

            Console.WriteLine("Modified String: " + result);
        }
    }
}