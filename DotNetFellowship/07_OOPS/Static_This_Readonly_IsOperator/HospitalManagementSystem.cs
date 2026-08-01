using System;

namespace _07_OOPS.Static_This_Readonly_IsOperator
{
    internal class HospitalManagementSystem
    {
        // Static Variable
        public static string HospitalName = "City Hospital";

        // Static Variable
        private static int totalPatients = 0;

        // Instance Variables
        public string Name;
        public int Age;
        public string Ailment;

        // Readonly Variable
        public readonly int PatientID;

        // Constructor
        public HospitalManagementSystem(string Name, int Age, string Ailment, int PatientID)
        {
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;
            this.PatientID = PatientID;
            totalPatients++;
        }

        // Static Method
        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients : " + totalPatients);
        }

        // Instance Method
        public void DisplayDetails()
        {
            Console.WriteLine("Hospital Name : " + HospitalName);
            Console.WriteLine("Patient ID : " + PatientID);
            Console.WriteLine("Patient Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Ailment : " + Ailment);
        }
    }
}