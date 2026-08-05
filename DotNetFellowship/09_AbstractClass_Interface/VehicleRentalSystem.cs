using System;

namespace _09_AbstractClass_Interface
{
    interface IInsurable
    {
        double CalculateInsurance();
        void GetInsuranceDetails();
    }

    internal abstract class VehicleRentalSystem
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;
        private string insurancePolicyNumber;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }

        protected string InsurancePolicyNumber
        {
            get { return insurancePolicyNumber; }
            set { insurancePolicyNumber = value; }
        }

        public VehicleRentalSystem(string vehicleNumber, string type,
            double rentalRate, string insurancePolicyNumber)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
            InsurancePolicyNumber = insurancePolicyNumber;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayDetails()
        {
            Console.WriteLine("Vehicle Number : " + VehicleNumber);
            Console.WriteLine("Type : " + Type);
            Console.WriteLine("Rental Rate : " + RentalRate);
        }
    }

    internal class RentalCar : VehicleRentalSystem, IInsurable
    {
        public RentalCar(string vehicleNumber, string type,
            double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, type, rentalRate, insurancePolicyNumber)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 500;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance : " + CalculateInsurance());
        }
    }

    internal class RentalBike : VehicleRentalSystem, IInsurable
    {
        public RentalBike(string vehicleNumber, string type,
            double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, type, rentalRate, insurancePolicyNumber)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 200;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance : " + CalculateInsurance());
        }
    }

    internal class RentalTruck : VehicleRentalSystem, IInsurable
    {
        public RentalTruck(string vehicleNumber, string type,
            double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, type, rentalRate, insurancePolicyNumber)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance : " + CalculateInsurance());
        }
    }
}