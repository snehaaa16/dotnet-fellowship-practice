using System;

namespace _09_AbstractClass_Interface
{
    interface IDepartment
    {
        void AssignDepartment(string department);
        void GetDepartmentDetails();
    }

    internal abstract class EmployeeManagementSystem
    {
        private int employeeId;
        private string name;
        private double baseSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public EmployeeManagementSystem(int employeeId, string name, double baseSalary)
        {
            EmployeeId = employeeId;
            Name = name;
            BaseSalary = baseSalary;
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Id : " + EmployeeId);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Base Salary : " + BaseSalary);
        }
    }

    internal class FullTimeEmployee : EmployeeManagementSystem, IDepartment
    {
        private string department;

        public FullTimeEmployee(int employeeId, string name, double baseSalary)
            : base(employeeId, name, baseSalary)
        {
        }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }

        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine("Department : " + department);
        }
    }

    internal class PartTimeEmployee : EmployeeManagementSystem, IDepartment
    {
        private string department;
        private int hoursWorked;

        public PartTimeEmployee(int employeeId, string name, double hourlyRate, int hoursWorked)
            : base(employeeId, name, hourlyRate)
        {
            this.hoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return BaseSalary * hoursWorked;
        }

        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine("Department : " + department);
        }
    }
}