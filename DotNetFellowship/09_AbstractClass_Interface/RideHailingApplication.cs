using System;

namespace _09_AbstractClass_Interface
{
    interface IGPS
    {
        void GetCurrentLocation();
        void UpdateLocation(string location);
    }

    internal abstract class RideHailingApplication
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;

        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public double RatePerKm
        {
            get { return ratePerKm; }
            set { ratePerKm = value; }
        }

        public RideHailingApplication(int vehicleId, string driverName, double ratePerKm)
        {
            VehicleId = vehicleId;
            DriverName = driverName;
            RatePerKm = ratePerKm;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle Id : " + VehicleId);
            Console.WriteLine("Driver Name : " + DriverName);
            Console.WriteLine("Rate Per Km : " + RatePerKm);
        }
    }

    internal class Car : RideHailingApplication, IGPS
    {
        private string location;

        public Car(int vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Location : " + location);
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }

    internal class Bike : RideHailingApplication, IGPS
    {
        private string location;

        public Bike(int vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Location : " + location);
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }

    internal class Auto : RideHailingApplication, IGPS
    {
        private string location;

        public Auto(int vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Location : " + location);
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }
}