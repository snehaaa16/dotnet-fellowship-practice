using System;

namespace _07_OOPS.AccessModifiers
{
    internal class Employee
    {
        // Public
        public int employeeID;

        // Protected
        protected string department;

        // Private
        private double salary;

        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine($"Employee ID : {employeeID}");
            Console.WriteLine($"Department  : {department}");
            Console.WriteLine($"Salary      : {salary}");
            Console.WriteLine();
        }
    }
}