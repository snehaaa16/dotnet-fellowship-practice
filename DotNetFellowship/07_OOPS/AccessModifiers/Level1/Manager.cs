using System;

namespace _07_OOPS.AccessModifiers
{
    internal class Manager : Employee
    {
        public Manager(int employeeID, string department, double salary)
            : base(employeeID, department, salary)
        {
        }

        public void DisplayManager()
        {
            Console.WriteLine("Manager Details");
            Console.WriteLine($"Employee ID : {employeeID}");
            Console.WriteLine($"Department  : {department}");
            Console.WriteLine($"Salary      : {GetSalary()}");
            Console.WriteLine();
        }
    }
}