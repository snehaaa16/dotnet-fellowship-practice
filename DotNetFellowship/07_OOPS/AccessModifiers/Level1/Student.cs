using System;

namespace _07_OOPS.AccessModifiers
{
    internal class Student
    {
        // Public Variable
        public int rollNumber;

        // Protected Variable
        protected string name;

        // Private Variable
        private double cgpa;

        // Constructor
        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        // Public Getter
        public double GetCGPA()
        {
            return cgpa;
        }

        // Public Setter
        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Roll Number : {rollNumber}");
            Console.WriteLine($"Name        : {name}");
            Console.WriteLine($"CGPA        : {cgpa}");
            Console.WriteLine();
        }
    }
}