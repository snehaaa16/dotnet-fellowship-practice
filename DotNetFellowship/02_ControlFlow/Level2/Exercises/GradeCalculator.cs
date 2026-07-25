using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class GradeCalculator
    {
        public static void CalculateGrade(int physics, int chemistry, int maths)
        {
            double percentage = (physics + chemistry + maths) / 3.0;
            Console.WriteLine("Percentage = " + percentage);
            if (percentage >= 90)
            {
                Console.WriteLine("Grade = A");
                Console.WriteLine("Remarks = Excellent");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine("Grade = B");
                Console.WriteLine("Remarks = Very Good");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade = C");
                Console.WriteLine("Remarks = Good");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Grade = D");
                Console.WriteLine("Remarks = Pass");
            }
            else
            {
                Console.WriteLine("Grade = F");
                Console.WriteLine("Remarks = Fail");
            }
        }
    }
}