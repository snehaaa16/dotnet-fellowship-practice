using System;
using System.IO;

namespace Streams
{
    internal class ImageByteArray
    {
        static void Main()
        {
            string source = "image.jpg";
            string destination = "copy.jpg";

            try
            {
                byte[] data = File.ReadAllBytes(source);

                using (MemoryStream memory = new MemoryStream(data))
                using (FileStream output = new FileStream(destination, FileMode.Create))
                {
                    memory.CopyTo(output);
                }

                Console.WriteLine("Image copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}