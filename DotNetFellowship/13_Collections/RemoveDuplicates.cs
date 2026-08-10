using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Collections
{
    internal class RemoveDuplicates
    {
        static void Main()
        {
            List<int> list = new List<int>
        {
            3, 1, 2, 2, 3, 4
        };

            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int item in list)
            {
                if (seen.Add(item))
                    result.Add(item);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
