using System;

namespace _07_OOPS.Static_This_Readonly_IsOperator
{
    internal class VehicleRegistrationSystem
    {
        // Static Variable
        public static double RegistrationFee = 5000;

        // Instance Variables
        public string OwnerName;
        public string VehicleType;

        // Readonly Variable
        public readonly string RegistrationNumber;

        // Constructor
        public VehicleRegistrationSystem(string OwnerName, string VehicleType, string RegistrationNumber)
        {
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
            this.RegistrationNumber = RegistrationNumber;
        }

        // Static Method
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }

        // Instance Method
        public void DisplayDetails()
        {
            Console.WriteLine("Owner Name : " + OwnerName);
            Console.WriteLine("Vehicle Type : " + VehicleType);
            Console.WriteLine("Registration Number : " + RegistrationNumber);
            Console.WriteLine("Registration Fee : " + RegistrationFee);
        }
    }
}