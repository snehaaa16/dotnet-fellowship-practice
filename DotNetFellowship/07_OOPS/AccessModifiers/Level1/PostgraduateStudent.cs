using System;

namespace _07_OOPS.AccessModifiers
{
    internal class PostgraduateStudent : Student
    {
        public PostgraduateStudent(int rollNumber, string name, double cgpa)
            : base(rollNumber, name, cgpa)
        {
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Postgraduate Student");
            Console.WriteLine($"Roll Number : {rollNumber}");

            // Protected member can be accessed here
            Console.WriteLine($"Name        : {name}");

            // Cannot access cgpa directly because it is private
            Console.WriteLine($"CGPA        : {GetCGPA()}");
        }
    }
}