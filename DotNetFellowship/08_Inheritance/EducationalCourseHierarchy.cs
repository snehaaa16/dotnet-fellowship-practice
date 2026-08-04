using System;

namespace _08_Inheritance
{
    internal class EducationalCourseHierarchy
    {
        public string CourseName;
        public string Duration;

        public EducationalCourseHierarchy(string CourseName, string Duration)
        {
            this.CourseName = CourseName;
            this.Duration = Duration;
        }

        public virtual void DisplayCourse()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Duration : " + Duration);
        }
    }

    internal class OnlineCourse : EducationalCourseHierarchy
    {
        public string Platform;
        public bool IsRecorded;

        public OnlineCourse(string CourseName, string Duration, string Platform, bool IsRecorded)
            : base(CourseName, Duration)
        {
            this.Platform = Platform;
            this.IsRecorded = IsRecorded;
        }

        public override void DisplayCourse()
        {
            base.DisplayCourse();
            Console.WriteLine("Platform : " + Platform);
            Console.WriteLine("Recorded : " + IsRecorded);
        }
    }

    internal class PaidOnlineCourse : OnlineCourse
    {
        public double Fee;
        public double Discount;

        public PaidOnlineCourse(string CourseName, string Duration, string Platform, bool IsRecorded, double Fee, double Discount)
            : base(CourseName, Duration, Platform, IsRecorded)
        {
            this.Fee = Fee;
            this.Discount = Discount;
        }

        public override void DisplayCourse()
        {
            base.DisplayCourse();
            Console.WriteLine("Fee : " + Fee);
            Console.WriteLine("Discount : " + Discount + "%");
        }
    }
}