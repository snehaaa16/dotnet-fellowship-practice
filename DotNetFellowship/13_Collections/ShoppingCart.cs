using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingCart
{
    static void Main()
    {
        Dictionary<string, double> cart =
            new Dictionary<string, double>();

        cart["Laptop"] = 70000;
        cart["Mouse"] = 1000;
        cart["Keyboard"] = 2000;

        var sortedCart =
            cart.OrderBy(item => item.Value);

        foreach (var item in sortedCart)
        {
            Console.WriteLine(
                item.Key + " : ₹" + item.Value);
        }
    }
}