using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Dictionary
{
    internal class Basics
    {
        static void Main(string[] args)
        {
            ////Syntax for HashMap
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Sneha");
            //dictionary[2] = "Kashish";

            ////Printing operation
            //foreach (var entry in dictionary)
            //{
            //    Console.WriteLine($"Key:{entry.Key} has Value: {entry.Value}");
            //}

            ////dictionary.Add(1, "nakul"); //System.ArgumentException: 'An item with the same key has already been added. Key: 1'
            //dictionary[1] = "nakul";

            //Console.WriteLine("After performing operation");
            //foreach (var entry in dictionary)
            //{
            //    Console.WriteLine($"Key:{entry.Key} has Value: {entry.Value}");
            //}

            var example = new Dictionary<int, string>
            {
                [1] = "sneha",
                [2] = "kashish"
            };


        }
    }
}
