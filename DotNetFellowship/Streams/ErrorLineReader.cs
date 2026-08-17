using System;
using System.IO;

namespace Streams
{
    internal class ErrorLineReader
    {
        static void Main()
        {
            string file = "largefile.txt";

            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("error", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}