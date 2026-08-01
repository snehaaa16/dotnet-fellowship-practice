using System;

namespace _07_OOPS.Static_This_Readonly_IsOperator
{
    internal class ShoppingCartSystem
    {
        // Static Variable
        public static double Discount = 10;

        // Instance Variables
        public string ProductName;
        public double Price;
        public int Quantity;

        // Readonly Variable
        public readonly int ProductID;

        // Constructor
        public ShoppingCartSystem(string ProductName, double Price, int Quantity, int ProductID)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
            this.ProductID = ProductID;
        }

        // Static Method
        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }

        // Instance Method
        public void DisplayDetails()
        {
            Console.WriteLine("Product ID : " + ProductID);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Quantity : " + Quantity);
            Console.WriteLine("Discount : " + Discount + "%");
        }
    }
}