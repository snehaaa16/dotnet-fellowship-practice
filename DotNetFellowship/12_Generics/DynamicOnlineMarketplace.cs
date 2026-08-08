using System;
using System.Collections.Generic;

namespace _12_Generics
{
    // Base Product Class
    internal class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string ProductName, double Price)
        {
            this.ProductName = ProductName;
            this.Price = Price;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Price : " + Price);
        }
    }

    // Category Classes
    internal class BookCategory
    {
        public string Genre { get; set; }

        public BookCategory(string Genre)
        {
            this.Genre = Genre;
        }
    }

    internal class ClothingCategory
    {
        public string Size { get; set; }

        public ClothingCategory(string Size)
        {
            this.Size = Size;
        }
    }

    // Generic Product Class
    internal class GenericProduct<T> where T : class
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public T Category { get; set; }

        public GenericProduct(string ProductName, double Price, T Category)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.Category = Category;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Category : " + typeof(T).Name);
        }
    }

    internal class DynamicOnlineMarketplace
    {
        // Generic Method
        public static void ApplyDiscount<T>(T product, double percentage)
            where T : Product
        {
            double discount = product.Price * percentage / 100;

            product.Price = product.Price - discount;

            Console.WriteLine("Discount : " + discount);
            Console.WriteLine("Final Price : " + product.Price);
        }
    }
}