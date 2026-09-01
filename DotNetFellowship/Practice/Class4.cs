//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Xml.Linq;

//namespace Practice
//{
//    public class Store
//    {
//        List<Branch> branchList=new List<Branch>();
//    }

//    public class Branch
//    {
        
//    }

//    public class Product
//    {
//        private int productId {  get; set; }
//        private string name { get; set; }

//        private int price { get; set; }
//        public string Category { get; set; }
//        public Product(int productId, string name, int price, string category)
//        {
//            this.productId = productId;
//            this.name = name;
//            this.price = price;
//            Category = category;
//        }

//    }

//    public class StockItem
//    {
//        public Product ItemProduct { get; private set; } // Shared Info
//        public int Quantity { get; private set; }         // Branch-Specific Quantity

//        public StockItem(Product product, int initialQuantity)
//        {
//            ItemProduct = product;
//            Quantity = initialQuantity;
//        }
//        public void AddStock(int qty) => Quantity += qty;
//        public bool DeductStock(int qty)
//        {
//            if (Quantity < qty) return false;
//            Quantity -= qty;
//            return true;
//        }

//    }

//    public class Supplier
//    {
//        public string SupplierId { get; set; }
//        public string Name { get; set; }

//        public Supplier(string supplierId, string name)
//        {
//            SupplierId = supplierId;
//            Name = name;
//        }

//    }

//    public class PurchaseOrder
//    {
//            public string OrderId { get; set; }
//            public Supplier OrderSupplier { get; private set; }
//            public Branch TargetBranch { get; private set; }
//            public Product OrderedProduct { get; private set; }
//            public int Quantity { get; private set; }
//            public bool IsFulfilled { get; private set; }

//            public PurchaseOrder(string orderId, Supplier supplier, Branch branch, Product product, int quantity)
//            {
//                OrderId = orderId;
//                OrderSupplier = supplier;
//                TargetBranch = branch;
//                OrderedProduct = product;
//                Quantity = quantity;
//                IsFulfilled = false;
//            }

//            // Action method to process purchase order and update branch stock
//            public void FulfillOrder()
//            {
//                if (IsFulfilled) return;

//                // Target branch ki stock update ho rahi hai
//                TargetBranch.AddStock(OrderedProduct, Quantity);
//                IsFulfilled = true;
//                Console.WriteLine($"PO {OrderId}: {Quantity} units of {OrderedProduct.Name} supplied by {OrderSupplier.Name} to {TargetBranch.BranchName}.");
//            }

//    }

//    public class SalesOrder
//    {

//    }

//    public class Customer
//    {

//    }

//    public class Invoice
//    {

//    }

//    public class DiscountPolicy
//    {

//    }
//    internal class Class4
//    {
//    }
//}
