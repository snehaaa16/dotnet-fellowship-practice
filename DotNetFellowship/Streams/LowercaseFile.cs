using System;
using System.IO;

namespace Streams
{
    internal class LowercaseFile
    {
        static void Main()
        {
            string source = "input.txt";
            string destination = "output.txt";

            try
            {
                using (FileStream input = new FileStream(source, FileMode.Open))
                using (FileStream output = new FileStream(destination, FileMode.Create))
                using (BufferedStream bufferedInput = new BufferedStream(input))
                using (BufferedStream bufferedOutput = new BufferedStream(output))
                using (StreamReader reader = new StreamReader(bufferedInput))
                using (StreamWriter writer = new StreamWriter(bufferedOutput))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line.ToLower());
                    }
                }

                Console.WriteLine("File converted successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}