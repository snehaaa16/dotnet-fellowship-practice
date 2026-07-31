using System;

namespace _07_OOPS.Constructors.Level1
{
    internal class CarRental
    {
        private string customerName;
        private string carModel;
        private int rentalDays;
        private double totalCost;

        // Default Constructor
        public CarRental()
        {
            customerName = "Unknown";
            carModel = "Not Assigned";
            rentalDays = 0;
            CalculateTotalCost();
        }

        // Parameterized Constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            totalCost = rentalDays * 1500;
        }

        public void DisplayRentalDetails()
        {
            Console.WriteLine("Car Rental Details");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Car Model     : {carModel}");
            Console.WriteLine($"Rental Days   : {rentalDays}");
            Console.WriteLine($"Total Cost    : {totalCost}");
            Console.WriteLine();
        }
    }
}