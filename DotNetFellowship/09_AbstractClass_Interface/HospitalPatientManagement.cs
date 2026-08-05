using System;

namespace _09_AbstractClass_Interface
{
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    internal abstract class HospitalPatientManagement
    {
        private int patientId;
        private string name;
        private int age;
        private string diagnosis;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        protected string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        public HospitalPatientManagement(int patientId, string name, int age)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("Patient Id : " + PatientId);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
        }
    }

    internal class InPatient : HospitalPatientManagement, IMedicalRecord
    {
        private string record;

        public InPatient(int patientId, string name, int age)
            : base(patientId, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 10000;
        }

        public void AddRecord(string record)
        {
            this.record = record;
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Record : " + record);
        }
    }

    internal class OutPatient : HospitalPatientManagement, IMedicalRecord
    {
        private string record;

        public OutPatient(int patientId, string name, int age)
            : base(patientId, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 1000;
        }

        public void AddRecord(string record)
        {
            this.record = record;
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Record : " + record);
        }
    }
}