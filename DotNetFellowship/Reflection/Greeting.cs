using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Greeting : IGreeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello Sneha!");
        }
    }
}
