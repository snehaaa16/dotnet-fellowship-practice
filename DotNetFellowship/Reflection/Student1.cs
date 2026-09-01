using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Student1
    {
        public string Name { get; set; }

        public Student1()
        {
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
        }
    }
}
