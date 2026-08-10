using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Collections
{
    internal class FindFrequency
    {
        static void Main()
        {
            List<string> list = new List<string>
        {
            "apple", "banana", "apple", "orange"
        };

            Dictionary<string, int> frequency =
                new Dictionary<string, int>();

            foreach (string item in list)
            {
                if (frequency.ContainsKey(item))
                    frequency[item]++;
                else
                    frequency[item] = 1;
            }

            foreach (var item in frequency)
                Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
