using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Streams
{
    internal class BufferedFileCopy
    {
        static void Main()
        {
            string source = "largefile.txt";
            string destination1 = "normalcopy.txt";
            string destination2 = "buffercopy.txt";

            byte[] buffer = new byte[4096];

            // Normal FileStream
            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream input = new FileStream(source, FileMode.Open))
            using (FileStream output = new FileStream(destination1, FileMode.Create))
            {
                int bytes;
                while ((bytes = input.Read(buffer, 0, buffer.Length)) > 0)
                    output.Write(buffer, 0, bytes);
            }

            sw.Stop();
            Console.WriteLine("Normal Stream: " + sw.ElapsedMilliseconds + " ms");

            // BufferedStream
            sw.Restart();

            using (FileStream input = new FileStream(source, FileMode.Open))
            using (FileStream output = new FileStream(destination2, FileMode.Create))
            using (BufferedStream bufferedInput = new BufferedStream(input))
            using (BufferedStream bufferedOutput = new BufferedStream(output))
            {
                int bytes;

                while ((bytes = bufferedInput.Read(buffer, 0, buffer.Length)) > 0)
                    bufferedOutput.Write(buffer, 0, bytes);
            }

            sw.Stop();
            Console.WriteLine("Buffered Stream: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
