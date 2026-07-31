using System;

namespace _07_OOPS.StaticAndInstance
{
    internal class Vehicle
    {
        // Instance Variables
        private string ownerName;
        private string vehicleType;

        // Static Variable
        private static double registrationFee = 5000;

        // Constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        // Instance Method
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Vehicle Details");
            Console.WriteLine($"Owner Name       : {ownerName}");
            Console.WriteLine($"Vehicle Type     : {vehicleType}");
            Console.WriteLine($"Registration Fee : {registrationFee}");
            Console.WriteLine();
        }

        // Static Method
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }
    }
}