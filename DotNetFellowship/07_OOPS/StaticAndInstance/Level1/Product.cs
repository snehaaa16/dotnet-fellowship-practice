using System;

namespace _07_OOPS.StaticAndInstance
{
    internal class Product
    {
        // Instance Variables
        private string productName;
        private double price;

        // Static Variable
        private static int totalProducts = 0;

        // Constructor
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        // Instance Method
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Details");
            Console.WriteLine($"Product Name : {productName}");
            Console.WriteLine($"Price        : {price}");
            Console.WriteLine();
        }

        // Static Method
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products : {totalProducts}");
            Console.WriteLine();
        }
    }
}