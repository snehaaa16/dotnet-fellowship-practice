using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Collections
{
    internal class RotateList
    {
        static void Main()
        {
            List<int> list = new List<int>
        {
            10, 20, 30, 40, 50
        };

            int k = 2;

            for (int i = 0; i < k; i++)
            {
                int first = list[0];
                list.RemoveAt(0);
                list.Add(first);
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
