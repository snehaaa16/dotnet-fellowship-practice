using System;
using System.Collections.Generic;
using System.Text;

namespace Streams
{
    internal class UserInputFile
    {
        static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                using (StreamWriter writer = new StreamWriter("user.txt"))
                {
                    Console.Write("Enter your name: ");
                    string name = reader.ReadLine();

                    Console.Write("Enter your age: ");
                    string age = reader.ReadLine();

                    Console.Write("Enter your favorite programming language: ");
                    string language = reader.ReadLine();

                    writer.WriteLine("Name: " + name);
                    writer.WriteLine("Age: " + age);
                    writer.WriteLine("Favorite Language: " + language);
                }
                Console.WriteLine("Data saved successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}
