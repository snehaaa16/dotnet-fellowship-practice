using System;

namespace _05_Strings.Level1
{
    internal class LongestWord
    {
        public static void FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');

            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine("Longest Word: " + longestWord);
        }
    }
}