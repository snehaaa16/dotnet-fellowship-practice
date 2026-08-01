using System;

namespace _07_OOPS.Static_This_Readonly_IsOperator
{
    internal class UniversityStudentManagement
    {
        // Static Variable
        public static string UniversityName = "Chitkara University";

        // Static Variable
        private static int totalStudents = 0;

        // Instance Variables
        public string Name;
        public char Grade;

        // Readonly Variable
        public readonly int RollNumber;

        // Constructor
        public UniversityStudentManagement(string Name, int RollNumber, char Grade)
        {
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;
            totalStudents++;
        }

        // Static Method
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students : " + totalStudents);
        }

        // Instance Method
        public void DisplayDetails()
        {
            Console.WriteLine("University Name : " + UniversityName);
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Roll Number : " + RollNumber);
            Console.WriteLine("Grade : " + Grade);
        }
    }
}