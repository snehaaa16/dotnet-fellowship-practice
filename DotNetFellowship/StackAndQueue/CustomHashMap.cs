using System;

namespace StackAndQueueAndHashMap
{
    internal class CustomHashMap
    {
        class Node
        {
            public int Key;
            public string Value;
            public Node Next;

            public Node(int key, string value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        Node[] buckets;

        public CustomHashMap(int size)
        {
            buckets = new Node[size];
        }

        // Key ko bucket index mein convert karta hai
        private int GetIndex(int key)
        {
            return Math.Abs(key) % buckets.Length;
        }

        // Insert / Update
        public void Put(int key, string value)
        {
            int index = GetIndex(key);

            Node current = buckets[index];

            // Check if key already exists
            while (current != null)
            {
                if (current.Key == key)
                {
                    current.Value = value;
                    return;
                }

                current = current.Next;
            }

            // New node
            Node newNode = new Node(key, value);

            // New node ko bucket ki beginning mein add karo
            newNode.Next = buckets[index];
            buckets[index] = newNode;
        }

        // Get value
        public string Get(int key)
        {
            int index = GetIndex(key);

            Node current = buckets[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }

                current = current.Next;
            }

            return null;
        }

        // Check key
        public bool ContainsKey(int key)
        {
            int index = GetIndex(key);

            Node current = buckets[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        // Remove key
        public void Remove(int key)
        {
            int index = GetIndex(key);

            Node current = buckets[index];
            Node previous = null;

            while (current != null)
            {
                if (current.Key == key)
                {
                    if (previous == null)
                    {
                        // First node remove
                        buckets[index] = current.Next;
                    }
                    else
                    {
                        // Middle/last node remove
                        previous.Next = current.Next;
                    }

                    return;
                }

                previous = current;
                current = current.Next;
            }
        }

        // Display HashMap
        public void Display()
        {
            for (int i = 0; i < buckets.Length; i++)
            {
                Console.Write($"Bucket {i}: ");

                Node current = buckets[i];

                while (current != null)
                {
                    Console.Write(
                        $"[{current.Key}, {current.Value}] -> "
                    );

                    current = current.Next;
                }

                Console.WriteLine("null");
            }
        }

        static void Main(string[] args)
        {
            CustomHashMap map = new CustomHashMap(5);

            map.Put(1, "Aman");
            map.Put(6, "Riya");
            map.Put(11, "Sneha");
            map.Put(2, "Karan");

            Console.WriteLine("HashMap:");
            map.Display();

            Console.WriteLine("\nValue of key 6:");
            Console.WriteLine(map.Get(6));

            Console.WriteLine("\nDoes key 11 exist?");
            Console.WriteLine(map.ContainsKey(11));

            map.Remove(6);

            Console.WriteLine("\nAfter removing key 6:");
            map.Display();
        }
    }
}