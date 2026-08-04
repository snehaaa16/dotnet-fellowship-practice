using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Inheritance
{
    internal class EmployeeManagementSystem
    {
        public string Name;
        public int Id;
        public double Salary;

        public EmployeeManagementSystem(string Name, int Id, double Salary)
        {
            this.Name = Name;
            this.Id = Id;
            this.Salary = Salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Salary : " + Salary);
        }
    }

    // Derived Class
    internal class Manager : EmployeeManagementSystem
    {
        public int TeamSize;

        public Manager(string Name, int Id, double Salary, int TeamSize)
            : base(Name, Id, Salary)
        {
            this.TeamSize = TeamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Team Size : " + TeamSize);
        }
    }

    // Derived Class
    internal class Developer : EmployeeManagementSystem
    {
        public string ProgrammingLanguage;

        public Developer(string Name, int Id, double Salary, string ProgrammingLanguage)
            : base(Name, Id, Salary)
        {
            this.ProgrammingLanguage = ProgrammingLanguage;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Programming Language : " + ProgrammingLanguage);
        }
    }

    // Derived Class
    internal class Intern : EmployeeManagementSystem
    {
        public string InternshipDuration;

        public Intern(string Name, int Id, double Salary, string InternshipDuration)
            : base(Name, Id, Salary)
        {
            this.InternshipDuration = InternshipDuration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Internship Duration : " + InternshipDuration);
        }
    }
}
}
