using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Collections
{
    internal class CheckSetsEqual
    {
        static void Main()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

            Console.WriteLine(set1.SetEquals(set2));
        }
    }
}
