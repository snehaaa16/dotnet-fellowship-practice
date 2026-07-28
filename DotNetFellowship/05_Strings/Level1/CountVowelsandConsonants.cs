using System;

namespace _05_Strings.Level1
{
    internal class CountVowelsandConsonants
    {
        public static void Count(string str)
        {
            int vowels = 0;
            int consonants = 0;

            str = str.ToLower();

            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine("Number of Vowels: " + vowels);
            Console.WriteLine("Number of Consonants: " + consonants);
        }
    }
}