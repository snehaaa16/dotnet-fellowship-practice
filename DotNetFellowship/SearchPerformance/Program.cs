using System;
using System.Diagnostics;
using PerformanceComparison;

int[] data = new int[1000000];

for (int i = 0; i < data.Length; i++)
    data[i] = i + 1;

int target = 999999;

Stopwatch sw = new Stopwatch();

sw.Start();
SearchPerformance.LinearSearch(data, target);
sw.Stop();

Console.WriteLine("Linear Search: " + sw.ElapsedMilliseconds + " ms");

sw.Restart();
SearchPerformance.BinarySearch(data, target);
sw.Stop();

Console.WriteLine("Binary Search: " + sw.ElapsedMilliseconds + " ms");


int[] data1 = { 5, 2, 8, 1, 3 };

Stopwatch sw1 = new Stopwatch();

sw.Start();

SearchPerformance.BubbleSort(data);

sw.Stop();

Console.WriteLine("Bubble Sort: " + sw.ElapsedMilliseconds + " ms");

Console.WriteLine("Sorted Data:");

foreach (int num in data)
{
    Console.Write(num + " ");
}

int[] data2 = { 5, 2, 8, 1, 3 };

sw.Restart();

SearchPerformance.MergeSort(data2);

sw.Stop();

Console.WriteLine("Merge Sort: " + sw.ElapsedMilliseconds + " ms");

foreach (int num in data2)
{
    Console.Write(num + " ");
}

int[] data3 = { 5, 2, 8, 1, 3 };

sw.Restart();

SearchPerformance.QuickSort(data3, 0, data3.Length - 1);

sw.Stop();

Console.WriteLine("Quick Sort: " + sw.ElapsedMilliseconds + " ms");

foreach (int num in data3)
{
    Console.Write(num + " ");
}

int count = 100000;

sw.Restart();

StringPerformance.UsingString(count);

sw.Stop();

Console.WriteLine("String: " + sw.ElapsedMilliseconds + " ms");


sw.Restart();

StringPerformance.UsingStringBuilder(count);

sw.Stop();

Console.WriteLine("StringBuilder: " + sw.ElapsedMilliseconds + " ms");

string filePath = "largefile.txt";

sw.Restart();

FileReadingPerformance.ReadUsingStreamReader(filePath);

sw.Stop();

Console.WriteLine("StreamReader: " + sw.ElapsedMilliseconds + " ms");


sw.Restart();

FileReadingPerformance.ReadUsingFileStream(filePath);

sw.Stop();

Console.WriteLine("FileStream: " + sw.ElapsedMilliseconds + " ms");

int n = 30;
sw.Restart();
FibonacciPerformance.FibonacciRecursive(n);
sw.Stop();
Console.WriteLine("Recursive: " + sw.ElapsedMilliseconds + " ms");

sw.Restart();
FibonacciPerformance.FibonacciIterative(n);
sw.Stop();
Console.WriteLine("Iterative: " + sw.ElapsedMilliseconds + " ms");