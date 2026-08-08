using System;
using System.Collections.Generic;

namespace _10_Generics
{
    // Base Class
    internal abstract class WarehouseItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public WarehouseItem(int ItemId, string ItemName)
        {
            this.ItemId = ItemId;
            this.ItemName = ItemName;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Item ID : " + ItemId);
            Console.WriteLine("Item Name : " + ItemName);
        }
    }

    // Derived Classes
    internal class Electronics : WarehouseItem
    {
        public string Brand { get; set; }

        public Electronics(int ItemId, string ItemName, string Brand)
            : base(ItemId, ItemName)
        {
            this.Brand = Brand;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Brand : " + Brand);
        }
    }

    internal class Groceries : WarehouseItem
    {
        public string ExpiryDate { get; set; }

        public Groceries(int ItemId, string ItemName, string ExpiryDate)
            : base(ItemId, ItemName)
        {
            this.ExpiryDate = ExpiryDate;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Expiry Date : " + ExpiryDate);
        }
    }

    internal class Furniture : WarehouseItem
    {
        public string Material { get; set; }

        public Furniture(int ItemId, string ItemName, string Material)
            : base(ItemId, ItemName)
        {
            this.Material = Material;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Material : " + Material);
        }
    }

    // Generic Class with Constraint
    internal class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DisplayAllItems()
        {
            foreach (T item in items)
            {
                item.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}