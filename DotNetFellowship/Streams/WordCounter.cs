using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Streams
{
    internal class WordCounter
    {
        static void Main()
        {
            string file = "input.txt";

            try
            {
                Dictionary<string, int> words = new Dictionary<string, int>();

                using (StreamReader reader = new StreamReader(file))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] wordList = line.ToLower()
                                               .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in wordList)
                        {
                            if (words.ContainsKey(word))
                                words[word]++;
                            else
                                words[word] = 1;
                        }
                    }
                }

                var top5 = words.OrderByDescending(x => x.Value).Take(5);

                foreach (var word in top5)
                    Console.WriteLine(word.Key + " : " + word.Value);
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}