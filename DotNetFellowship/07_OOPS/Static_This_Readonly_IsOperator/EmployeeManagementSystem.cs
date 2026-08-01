using System;

namespace _07_OOPS.Static_This_Readonly_IsOperator
{
    internal class EmployeeManagementSystem
    {
        // Static Variable
        public static string CompanyName = "Microsoft";

        // Static Variable
        private static int totalEmployees = 0;

        // Instance Variables
        public string Name;
        public string Designation;

        // Readonly Variable
        public readonly int Id;

        // Constructor
        public EmployeeManagementSystem(string Name, int Id, string Designation)
        {
            this.Name = Name;
            this.Id = Id;
            this.Designation = Designation;
            totalEmployees++;
        }

        // Static Method
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees : " + totalEmployees);
        }

        // Instance Method
        public void DisplayDetails()
        {
            Console.WriteLine("Company Name : " + CompanyName);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Employee ID : " + Id);
            Console.WriteLine("Designation : " + Designation);
        }
    }
}