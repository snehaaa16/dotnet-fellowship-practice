using System;
using System.Collections.Generic;

class GenerateBinaryNumbers
{
    static void Main()
    {
        int n = 5;

        Queue<string> queue = new Queue<string>();

        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();

            Console.WriteLine(current);

            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
    }
}