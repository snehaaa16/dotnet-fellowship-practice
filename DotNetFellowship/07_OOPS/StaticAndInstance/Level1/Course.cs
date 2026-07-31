using System;

namespace _07_OOPS.StaticAndInstance
{
    internal class Course
    {
        // Instance Variables
        private string courseName;
        private int duration;
        private double fee;

        // Static Variable
        private static string instituteName = "BridgeLabz";

        // Constructor
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        // Instance Method
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course Details");
            Console.WriteLine($"Course Name : {courseName}");
            Console.WriteLine($"Duration    : {duration} Months");
            Console.WriteLine($"Fee         : {fee}");
            Console.WriteLine($"Institute   : {instituteName}");
            Console.WriteLine();
        }

        // Static Method
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
        }
    }
}