using System;
using System.Collections.Generic;

namespace _12_Generics
{
    // Base Class
    internal abstract class JobRole
    {
        public string RoleName { get; set; }

        public JobRole(string RoleName)
        {
            this.RoleName = RoleName;
        }

        public abstract void DisplayRole();
    }

    // Derived Class
    internal class SoftwareEngineer : JobRole
    {
        public string ProgrammingLanguage { get; set; }

        public SoftwareEngineer(string ProgrammingLanguage)
            : base("Software Engineer")
        {
            this.ProgrammingLanguage = ProgrammingLanguage;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Job Role : " + RoleName);
            Console.WriteLine("Programming Language : " + ProgrammingLanguage);
        }
    }

    // Derived Class
    internal class DataScientist : JobRole
    {
        public string Skill { get; set; }

        public DataScientist(string Skill)
            : base("Data Scientist")
        {
            this.Skill = Skill;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Job Role : " + RoleName);
            Console.WriteLine("Skill : " + Skill);
        }
    }

    // Generic Class
    internal class Resume<T> where T : JobRole
    {
        public string CandidateName { get; set; }
        public T JobRole { get; set; }

        public Resume(string CandidateName, T JobRole)
        {
            this.CandidateName = CandidateName;
            this.JobRole = JobRole;
        }

        public void DisplayResume()
        {
            Console.WriteLine("Candidate Name : " + CandidateName);
            JobRole.DisplayRole();
        }
    }

    internal class AIResumeScreeningSystem
    {
        // Generic Method
        public static void ScreenResume<T>(Resume<T> resume)
            where T : JobRole
        {
            Console.WriteLine("===== Resume Screening =====");

            resume.DisplayResume();

            Console.WriteLine("Resume Status : Selected for Screening");
        }
    }
}