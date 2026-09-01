using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Collections
{
    using System;
    using System.Collections;

    internal class ReverseList
    {
        static void Main()
        {
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

            for (int i = 0, j = list.Count - 1; i < j; i++, j--)
            {
                object temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
