using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class EmployeeBonus
    {
        public static double CalculateBonus(double salary, int yearsOfService)
        {
            if (yearsOfService > 5)
            {
                return salary * 0.05;
            }
            else
            {
                return 0;
            }
        }
    }
}