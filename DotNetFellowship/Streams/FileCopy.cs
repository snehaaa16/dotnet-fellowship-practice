using System;
using System.Collections.Generic;
using System.Text;

namespace Streams
{
    internal class FileCopy
    {
        static void Main()
        {
            string source = "source.txt";
            string destination = "copy.txt";

            try
            {
                if (!File.Exists(source))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                using (FileStream input = new FileStream(source, FileMode.Open, FileAccess.Read))
                using (FileStream output = new FileStream(destination, FileMode.Create, FileAccess.Write))
                {
                    int data;

                    while ((data = input.ReadByte()) != -1)
                    {
                        output.WriteByte((byte)data);
                    }
                }

                Console.WriteLine("File copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}
