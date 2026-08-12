using System;

class InventoryNode
{
    public string ItemName;
    public int ItemId;
    public int Quantity;
    public double Price;
    public InventoryNode Next;

    public InventoryNode(string name, int id, int quantity, double price)
    {
        ItemName = name;
        ItemId = id;
        Quantity = quantity;
        Price = price;
    }
}

class InventoryManagementSystem
{
    InventoryNode head;

    public void AddAtEnd(string name, int id, int quantity, double price)
    {
        InventoryNode newNode =
            new InventoryNode(name, id, quantity, price);

        if (head == null)
        {
            head = newNode;
            return;
        }

        InventoryNode current = head;

        while (current.Next != null)
            current = current.Next;

        current.Next = newNode;
    }

    public void AddAtBeginning(string name, int id, int quantity, double price)
    {
        InventoryNode newNode =
            new InventoryNode(name, id, quantity, price);

        newNode.Next = head;
        head = newNode;
    }

    public void AddAtPosition(
        int position,
        string name,
        int id,
        int quantity,
        double price)
    {
        if (position == 1)
        {
            AddAtBeginning(name, id, quantity, price);
            return;
        }

        InventoryNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
            current = current.Next;

        if (current == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        InventoryNode newNode =
            new InventoryNode(name, id, quantity, price);

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void RemoveById(int id)
    {
        if (head == null)
            return;

        if (head.ItemId == id)
        {
            head = head.Next;
            return;
        }

        InventoryNode current = head;

        while (current.Next != null)
        {
            if (current.Next.ItemId == id)
            {
                current.Next = current.Next.Next;
                return;
            }

            current = current.Next;
        }
    }

    public void UpdateQuantity(int id, int quantity)
    {
        InventoryNode current = head;

        while (current != null)
        {
            if (current.ItemId == id)
            {
                current.Quantity = quantity;
                return;
            }

            current = current.Next;
        }
    }

    public void SearchById(int id)
    {
        InventoryNode current = head;

        while (current != null)
        {
            if (current.ItemId == id)
            {
                Console.WriteLine(
                    $"{current.ItemName} - Quantity: {current.Quantity}, Price: {current.Price}"
                );
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Item not found");
    }

    public void SearchByName(string name)
    {
        InventoryNode current = head;

        while (current != null)
        {
            if (current.ItemName == name)
            {
                Console.WriteLine(
                    $"{current.ItemName} - ID: {current.ItemId}"
                );
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Item not found");
    }

    public double TotalValue()
    {
        double total = 0;
        InventoryNode current = head;

        while (current != null)
        {
            total += current.Price * current.Quantity;
            current = current.Next;
        }

        return total;
    }

    public void Display()
    {
        InventoryNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                $"ID: {current.ItemId}, Name: {current.ItemName}, Quantity: {current.Quantity}, Price: {current.Price}"
            );

            current = current.Next;
        }
    }

    public void SortByPrice()
    {
        for (InventoryNode i = head; i != null; i = i.Next)
        {
            for (InventoryNode j = i.Next; j != null; j = j.Next)
            {
                if (i.Price > j.Price)
                {
                    SwapData(i, j);
                }
            }
        }
    }

    public void SortByName()
    {
        for (InventoryNode i = head; i != null; i = i.Next)
        {
            for (InventoryNode j = i.Next; j != null; j = j.Next)
            {
                if (string.Compare(i.ItemName, j.ItemName) > 0)
                {
                    SwapData(i, j);
                }
            }
        }
    }

    private void SwapData(InventoryNode a, InventoryNode b)
    {
        string name = a.ItemName;
        a.ItemName = b.ItemName;
        b.ItemName = name;

        int id = a.ItemId;
        a.ItemId = b.ItemId;
        b.ItemId = id;

        int quantity = a.Quantity;
        a.Quantity = b.Quantity;
        b.Quantity = quantity;

        double price = a.Price;
        a.Price = b.Price;
        b.Price = price;
    }

    static void Main()
    {
        InventoryManagementSystem inventory =
            new InventoryManagementSystem();

        inventory.AddAtEnd("Laptop", 101, 5, 50000);
        inventory.AddAtEnd("Mouse", 102, 20, 500);
        inventory.AddAtBeginning("Keyboard", 103, 10, 1000);

        Console.WriteLine("Inventory:");
        inventory.Display();

        Console.WriteLine(
            $"\nTotal Inventory Value: {inventory.TotalValue()}"
        );

        inventory.SortByPrice();

        Console.WriteLine("\nSorted By Price:");
        inventory.Display();
    }
}