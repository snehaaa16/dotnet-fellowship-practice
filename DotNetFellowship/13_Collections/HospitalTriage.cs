using System;

class HospitalTriage
{
    static void Main()
    {
        PriorityQueue<string, int> patients =
            new PriorityQueue<string, int>();

        patients.Enqueue("John", -3);
        patients.Enqueue("Alice", -5);
        patients.Enqueue("Bob", -2);

        while (patients.Count > 0)
        {
            Console.WriteLine(patients.Dequeue());
        }
    }
}