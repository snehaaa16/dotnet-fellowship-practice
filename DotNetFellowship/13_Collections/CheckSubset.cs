using System;
using System.Collections.Generic;

class CheckSubset
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

        Console.WriteLine(set1.IsSubsetOf(set2));
    }
}