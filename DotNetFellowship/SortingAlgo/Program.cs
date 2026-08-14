//1.Bubble Sort - Sort Student Marks
//Problem Statement:
//A school maintains student marks in an array. Implement Bubble Sort in C# to sort the student marks in ascending order.
using SortingAlgo;
int[] marks = { 75, 45, 90, 60, 30 };
BubbleSort.Sort(marks);
Console.WriteLine("Sorted Marks:");
foreach (int mark in marks)
{
    Console.Write(mark + " ");
}

//2.Insertion Sort - Sort Employee IDs
//Problem Statement:
//A company stores employee IDs in an unsorted array. Implement Insertion Sort in C# to sort the employee IDs in ascending order.
int[] employeeIds = { 105, 101, 109, 103, 102 };
InsertionSort.Sort(employeeIds);
Console.WriteLine("Sorted Employee IDs:");
foreach (int id in employeeIds)
{
    Console.Write(id + " ");
}

//3.Merge Sort - Sort an Array of Book Prices
//Problem Statement:
//A bookstore maintains a list of book prices in an array. Implement Merge Sort in C# to sort the prices in ascending order.

int[] prices = { 450, 120, 800, 300, 200 };
MergeSort.Sort(prices, 0, prices.Length - 1);
Console.WriteLine("Sorted Book Prices:");
foreach (int price in prices)
{
    Console.Write(price + " ");
}

//4.Quick Sort - Sort Product Prices
//Problem Statement:
//An e-commerce company wants to display product prices in ascending order. Implement Quick Sort in C# to sort the product prices.
int[] pricess = { 500, 200, 800, 100, 300 };
QuickSort.Sort(pricess, 0, pricess.Length - 1);
Console.WriteLine("Sorted Product Prices:");
foreach (int price in pricess)
{
    Console.Write(price + " ");
}

//5.Selection Sort - Sort Exam Scores
//Problem Statement:
//A university needs to sort students’ exam scores in ascending order. Implement Selection Sort in C# to achieve this.
int[] scores = { 85, 45, 90, 60, 30 };
SelectionSort.Sort(scores);
Console.WriteLine("Sorted Exam Scores:");
foreach (int score in scores)
{
    Console.Write(score + " ");
}

//6.Heap Sort - Sort Job Applicants by Salary
//Problem Statement:
//A company receives job applications with different expected salary demands. Implement Heap Sort in C# to sort these salary demands in ascending order.
int[] salaries = { 50000, 30000, 70000, 45000, 60000 };
HeapSort.Sort(salaries);
Console.WriteLine("Sorted Salary Demands:");
foreach (int salary in salaries)
{
    Console.Write(salary + " ");
}

//7.Counting Sort - Sort Student Ages
//Problem Statement:
//A school collects students’ ages (ranging from 10 to 18) and wants them sorted. Implement Counting Sort in C# for this task.
int[] ages = { 15, 12, 18, 10, 16, 14, 12, 17 };
CountingSort.Sort(ages);
Console.WriteLine("Sorted Student Ages:");
foreach (int age in ages)
{
    Console.Write(age + " ");
}