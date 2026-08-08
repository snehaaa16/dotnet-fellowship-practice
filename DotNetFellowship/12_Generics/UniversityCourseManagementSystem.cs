using System;
using System.Collections.Generic;

namespace _12_Generics
{
    // Base Class
    internal abstract class CourseType
    {
        public string EvaluationType { get; set; }

        public CourseType(string EvaluationType)
        {
            this.EvaluationType = EvaluationType;
        }

        public abstract void DisplayEvaluation();
    }

    // Derived Class
    internal class ExamCourse : CourseType
    {
        public int ExamMarks { get; set; }

        public ExamCourse(int ExamMarks)
            : base("Exam")
        {
            this.ExamMarks = ExamMarks;
        }

        public override void DisplayEvaluation()
        {
            Console.WriteLine("Evaluation Type : " + EvaluationType);
            Console.WriteLine("Exam Marks : " + ExamMarks);
        }
    }

    // Derived Class
    internal class AssignmentCourse : CourseType
    {
        public int AssignmentCount { get; set; }

        public AssignmentCourse(int AssignmentCount)
            : base("Assignment")
        {
            this.AssignmentCount = AssignmentCount;
        }

        public override void DisplayEvaluation()
        {
            Console.WriteLine("Evaluation Type : " + EvaluationType);
            Console.WriteLine("Assignment Count : " + AssignmentCount);
        }
    }

    // Generic Class with Constraint
    internal class Course<T> where T : CourseType
    {
        public string CourseName { get; set; }
        public string Department { get; set; }
        public T Evaluation { get; set; }

        public Course(string CourseName, string Department, T Evaluation)
        {
            this.CourseName = CourseName;
            this.Department = Department;
            this.Evaluation = Evaluation;
        }

        public void DisplayCourse()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Department : " + Department);
            Evaluation.DisplayEvaluation();
        }
    }

    internal class UniversityCourseManagementSystem
    {
        public static void DisplayCourses<T>(List<T> courses)
            where T : CourseType
        {
            foreach (T course in courses)
            {
                course.DisplayEvaluation();
                Console.WriteLine();
            }
        }
    }
}