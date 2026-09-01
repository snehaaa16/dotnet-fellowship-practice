//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Practice
//{
//    public interface Iventilator
//    {
//        void AttachingVentilator();
//    }
//    class Hospital
//    {
//        public string HospitalName { get; set; }
//        List<Ward> wardsList = new List<Ward>();
//        public Hospital(string hospitalName)
//        {
//            HospitalName= hospitalName;
//        }
//        public void AddWard(Ward ward)
//        {
//            wardsList.Add(ward);
//        }
//    }

//    class Ward
//    {
//        public string wardName { get; set; }
//        List<Bed> bedList = new List<Bed>();

//        public Ward(string wardName)
//        {
//            this.wardName = wardName;
//        }
//        public void AddBed(Bed bed)
//        {
//            bedList.Add(bed);
//        }
//    }

//    public abstract class Bed
//    {
//        public bool IsOccupied { get; protected set; }
//        public int bedId { get; set;}
//        public Patient? CurrentPatient { get; protected set; }
//        public Bed(int bedId)
//        {
//            this.bedId = bedId;
//            IsOccupied = false;
//            CurrentPatient = null;
//        }
//        public virtual bool AllocatePatient(Patient patient)
//        {
//            if (IsOccupied) return false;
//            IsOccupied = true;
//            CurrentPatient = patient;
//            return true;
//        }

//        public virtual bool RealeasePatient()
//        {
//            if (!IsOccupied) return false;
//            IsOccupied = false;
//            CurrentPatient = null;
//            cleanUpCost(4);
//            return true;
//        }

//        public abstract int cleanUpCost(int days);
//    }
//    class GeneralBed : Bed
//    {
//        public GeneralBed(int bedId): base(bedId) { }
//        public override int cleanUpCost(int days)
//        {
//            return 1500 * days;
//        }
//    }

//    class ICUBed : Bed , Iventilator
//    {
//        public ICUBed(int bedId) : base(bedId) { }
//        public override int cleanUpCost(int days)
//        {
//            return 10000 * days;
//        }
//        public void AttachingVentilator()
//        {
//            Console.WriteLine($"Ventilator attached to ICU Bed ID: {bedId}");
//        }

//    }

//    class PediatricBed : Bed
//    {
//        public PediatricBed(int bedId) : base(bedId) { }
//        public override int cleanUpCost(int days)
//        {
//            return 3000 * days;
//        }

//    }

//    public class Patient
//    {
//        public string PatientId { get; set; }
//        public string Name { get; set; }

//        public Patient(string patientId, string name)
//        {
//            PatientId = patientId;
//            Name = name;
//        }
//    }

//    class MedicalStaff
//    {
//        public string staffId { get; protected set; }

//        public void InspectBed(Bed bed)
//        {
//            Console.WriteLine($"Staff {staffId} is inspecting Bed ID: {bed.bedId}");
//        }

//    }
//    internal class Class2
//    {
//    }
//}
