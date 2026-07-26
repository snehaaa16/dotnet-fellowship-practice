using _03_Arrays.Level1.Exercises;
using _03_Arrays.Level2.Exercises;


//Write a program to take user input for the age of all 10 students in a class and check whether the student
//can vote depending on his/her age is greater or equal to 18.
int[] ages = new int[10];
for (int i = 0; i < ages.Length; i++)
{
    Console.Write("Enter age of student " + (i + 1) + ": ");
    ages[i] = Convert.ToInt32(Console.ReadLine());
}
VotingEligibilityArray.CheckVotingEligibility(ages);


//Write a program to take user input for 5 numbers and check whether a number is positive, negative, or zero.
//Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of
//the array and display if they equal, greater or less
int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter number " + (i + 1) + ": ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
NumberAnalysisArray.AnalyzeNumbers(numbers);


//Create a program to print a multiplication table of a number.
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] table = MultiplicationTableArray.GenerateTable(number);
for (int i = 0; i < table.Length; i++)
{
    Console.WriteLine(number + " * " + (i + 1) + " = " + table[i]);
}


//Write a program to store multiple values in an array up to a maximum of 10 or until the user enters a 0 or a
//negative number. Show all the numbers as well as the sum of all numbers 
StoreNumbersAndSum.StoreNumbers();


//Create a program to find the multiplication table of a number entered by the user from 6 to 9 and display the result
Console.Write("Enter a number: ");
number = Convert.ToInt32(Console.ReadLine());
int[] multiplicationResult = MultiplicationTableSixToNine.GenerateTable(number);
for (int i = 6; i <= 9; i++)
{
    Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 6]);
}


//Create a program to find the mean height of players present in a football team.
double[] heights = new double[11];
for (int i = 0; i < heights.Length; i++)
{
    Console.Write("Enter height of player " + (i + 1) + ": ");
    heights[i] = Convert.ToDouble(Console.ReadLine());
}
double mean = MeanHeightFootballTeam.CalculateMean(heights);
Console.WriteLine("Mean Height = " + mean);

//Create a program to save odd and even numbers into odd and even arrays between 1 to the number entered by the user.
//Finally, print the odd and even numbers array
Console.Write("Enter a natural number: ");
number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Invalid Input");
    return;
}
OddEvenArrays.SeparateOddEven(number);


//Create a program to find the factors of a number taken as user input, store the factors in an array, and display
//the factors
Console.Write("Enter a number: ");
number = Convert.ToInt32(Console.ReadLine());
FactorsInArray.FindFactors(number);

//Working with Multi - Dimensional Arrays. Write a C# program to create a 2D Array and Copy the 2D Array into a
//single dimension array
Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
Console.WriteLine("Enter Matrix Elements:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int[] array = MatrixToSingleArray.ConvertToSingleArray(matrix);
Console.WriteLine("Single Dimensional Array:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}


//Write a program FizzBuzz, take a number as user input and if it is a positive integer loop from 0 to the number
//and save the number, but for multiples of 3 save "Fizz" instead of the number, for multiples of 5 save "Buzz",
//and for multiples of both save "FizzBuzz". Finally, print the array results for each index position in the
//format Position 1 = 1, …, Position 3 = Fizz,...
Console.Write("Enter a positive number: ");
number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("Invalid Input");
    return;
}
string[] result = FizzBuzzArray.GenerateFizzBuzz(number);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine("Position " + i + " = " + result[i]);
}

//Create a program to find the bonus of 10 employees based on their years of service and the total bonus amount the company Zara has to pay, along with the old and new salary.
double[] salary = new double[10];
double[] years = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Employee " + (i + 1));

    Console.Write("Enter Salary: ");
    salary[i] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Years of Service: ");
    years[i] = Convert.ToDouble(Console.ReadLine());

    if (salary[i] <= 0 || years[i] < 0)
    {
        Console.WriteLine("Invalid Input. Enter Again.");
        i--;
    }
}

EmployeeBonusArray.CalculateBonus(salary, years);

//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
string[] names = { "Amar", "Akbar", "Anthony" };
int[] Ages = new int[3];
double[] Heights = new double[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(names[i]);

    Console.Write("Enter Age: ");
    Ages[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Height: ");
    Heights[i] = Convert.ToDouble(Console.ReadLine());
}

YoungestAndTallestFriends.FindYoungestAndTallest(Ages, Heights);

//Create a program to store the digits of the number in an array and find the largest and second largest element of the array.
Console.Write("Enter a number: ");
number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
LargestAndSecondLargestDigit.FindLargestAndSecondLargest(number);


//Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop.Here we want to modify to increase the size of the array i, e maxDigit by 10 if the index is equal to maxDigit. This is done to consider all digits to find the largest and second-largest number 
Console.Write("Enter a number: ");
long num = Convert.ToInt64(Console.ReadLine());

if (num < 0)
{
    num = -num;
}

LargestAndSecondLargestDynamic.FindLargestAndSecondLargest(num);


//Create a program to take a number as input and reverse the number. To do this, store the digits of the number in an array and display the array in reverse order
Console.Write("Enter a number: ");
int numm= Convert.ToInt32(Console.ReadLine());
if (numm < 0)
{
    numm = -numm;
}
ReverseNumberUsingArray.ReverseNumber(numm);

//An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in the team. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
Console.Write("Enter Number of Persons: ");
number = Convert.ToInt32(Console.ReadLine());

double[] weight = new double[number];
double[] height = new double[number];

for (int i = 0; i < number; i++)
{
    Console.WriteLine("Person " + (i + 1));

    Console.Write("Enter Weight (kg): ");
    weight[i] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Height (cm): ");
    height[i] = Convert.ToDouble(Console.ReadLine());

    if (weight[i] <= 0 || height[i] <= 0)
    {
        Console.WriteLine("Invalid Input. Enter Again.");
        i--;
    }
}
BMIArray.CalculateBMI(weight, height);


//Rewrite the above program using multi-dimensional array to store height, weight, and BMI in 2D array for all the persons
Console.Write("Enter Number of Persons: ");
number = Convert.ToInt32(Console.ReadLine());
double[][] personData = new double[number][];
for (int i = 0; i < number; i++)
{
    personData[i] = new double[3];
}
for (int i = 0; i < number; i++)
{
    Console.WriteLine("Person " + (i + 1));

    Console.Write("Enter Weight (kg): ");
    personData[i][0] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Height (cm): ");
    personData[i][1] = Convert.ToDouble(Console.ReadLine());

    if (personData[i][0] <= 0 || personData[i][1] <= 0)
    {
        Console.WriteLine("Invalid Input. Enter Again.");
        i--;
    }
}
BMI2DArray.CalculateBMI(personData);


//Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the percentage and then calculate the grade  as per the following guidelines 
Console.Write("Enter Number of Students: ");
number = Convert.ToInt32(Console.ReadLine());
int[,] marks = new int[number, 3];
for (int i = 0; i < number; i++)
{
    Console.WriteLine("Student " + (i + 1));

    Console.Write("Enter Physics Marks: ");
    marks[i, 0] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Chemistry Marks: ");
    marks[i, 1] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Maths Marks: ");
    marks[i, 2] = Convert.ToInt32(Console.ReadLine());

    if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
    {
        Console.WriteLine("Invalid Marks. Enter Again.");
        i--;
    }
}
StudentGradeCalculator.CalculateGrade(marks);


//Rewrite the above program to store the marks of the students in physics, chemistry, and maths in a 2D array and then compute the percentage and gradeCreate a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit
Console.Write("Enter Number of Students: ");
number = Convert.ToInt32(Console.ReadLine());

int[,] Marks = new int[number, 3];

for (int i = 0; i < number; i++)
{
    Console.WriteLine("Student " + (i + 1));

    Console.Write("Physics: ");
    Marks[i, 0] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Chemistry: ");
    Marks[i, 1] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Maths: ");
    Marks[i, 2] = Convert.ToInt32(Console.ReadLine());

    if (Marks[i, 0] < 0 || Marks[i, 1] < 0 || Marks[i, 2] < 0)
    {
        Console.WriteLine("Invalid Marks. Enter Again.");
        i--;
    }
}
StudentGradeCalculator2D.CalculateGrade(Marks);


//Create a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit
Console.Write("Enter a number: ");
long numb = Convert.ToInt64(Console.ReadLine());
DigitFrequencyArray.FindDigitFrequency(numb);