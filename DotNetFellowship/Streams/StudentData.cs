using System;
using System.IO;

namespace Streams
{
    internal class StudentData
    {
        static void Main()
        {
            string file = "student.dat";

            try
            {
                // Write data
                using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
                {
                    writer.Write(101);
                    writer.Write("Sneha");
                    writer.Write(8.5);
                }

                // Read data
                using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
                {
                    int rollNo = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine("Roll No: " + rollNo);
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("GPA: " + gpa);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}