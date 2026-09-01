using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
