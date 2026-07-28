//Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
//Take user input for principal, rate, time
//Write a method to calculate the simple interest given principle, rate and time as parameters
//Output “The Simple Interest is ___ for Principal ___, Rate of Interest ___ and Time ___”

using _04_Methods.Level1;
using _04_Methods.Level2;
using _04_Methods.Level3;
using _04_Methods.Level3.NumberChecker;

Console.Write("Enter Principal: ");
    double principal = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Rate: ");
    double rate = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Time: ");
    double time = Convert.ToDouble(Console.ReadLine());

    double simpleInterest = SimpleInterest.CalculateSimpleInterest(principal, rate, time);

    Console.WriteLine($"\nThe Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");

//Create a program to find the maximum number of handshakes among N number of students.
//Write a method to use the combination formulae to calculate the number of handshakes

Console.Write("Enter number of students: ");
int numberOfStudents = Convert.ToInt32(Console.ReadLine());

int handshakes = MaximumHandshakes.CalculateHandshakes(numberOfStudents);

Console.WriteLine($"Maximum number of handshakes = {handshakes}");


//An athlete runs in a triangular park with sides provided as input by the 
//user in meters. If the athlete wants to complete a 5 km run, then how many 
//rounds must the athlete complete
Console.Write("Enter Side 1 (meters): ");
double side1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Side 2 (meters): ");
double side2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Side 3 (meters): ");
double side3 = Convert.ToDouble(Console.ReadLine());

double rounds = TriangularParkRounds.CalculateRounds(side1, side2, side3);

Console.WriteLine($"Rounds Required to Complete 5 km = {rounds:F2}");

//Write a program to check whether a number is positive, negative, or zero.
Console.Write("Enter a Number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = PositiveNegativeZero.CheckNumber(number);

if (result == 1)
    Console.WriteLine("The number is Positive.");
else if (result == -1)
    Console.WriteLine("The number is Negative.");
else
    Console.WriteLine("The number is Zero.");


//Write a program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
Console.Write("Enter Month: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Day: ");
int day = Convert.ToInt32(Console.ReadLine());

bool isSpring = SpringSeason.IsSpringSeason(month, day);

if (isSpring)
    Console.WriteLine("It's a Spring Season.");
else
    Console.WriteLine("Not a Spring Season.");

//Write a program to find the sum of n natural numbers using loop
Console.Write("Enter a Number: ");
int numb = Convert.ToInt32(Console.ReadLine());

int sum = SumOfNaturalNumbers.FindSum(numb);

Console.WriteLine("Sum = " + sum);

//.Write a program to find the smallest and the largest of the 3 numbers.
Console.Write("Enter First Number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Second Number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Third Number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int[] minMax = SmallestLargest.FindSmallestAndLargest(number1, number2, number3);

Console.WriteLine("Smallest = " + minMax[0]);
Console.WriteLine("Largest = " + minMax[1]);

//Write a program to take 2 numbers and print their quotient and reminder
Console.Write("Enter Number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());

int[] quotientResult = QuotientRemainder.FindRemainderAndQuotient(num, divisor);

Console.WriteLine("Quotient = " + quotientResult[0]);
Console.WriteLine("Remainder = " + quotientResult[1]);

//Create a program to divide N number of chocolates among M children. Print the number of chocolates each child will get and also the remaining chocolates.
Console.Write("Enter Number of Chocolates: ");
int chocolates = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number of Children: ");
int children = Convert.ToInt32(Console.ReadLine());

int[] chocolateResult = ChocolateDistribution.FindChocolateDistribution(chocolates, children);

Console.WriteLine("Each Child Gets = " + chocolateResult[0]);
Console.WriteLine("Remaining Chocolates = " + chocolateResult[1]);

//Write a program calculate the wind chill temperature given the temperature and wind speedWrite a program to calculate various trigonometric functions using Math class given an angle in degrees
Console.Write("Enter Temperature: ");
double temperature = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Wind Speed: ");
double windSpeed = Convert.ToDouble(Console.ReadLine());

double windChill = WindChillCalculator.CalculateWindChill(temperature, windSpeed);

Console.WriteLine("Wind Chill = " + windChill);

//Write a program to calculate various trigonometric functions using Math class given an angle in degrees
Console.Write("Enter Angle in Degrees: ");
double angle = Convert.ToDouble(Console.ReadLine());

double[] trigo= TrigonometricFunctions.CalculateTrigonometricFunctions(angle);

Console.WriteLine("Sin = " + trigo[0]);
Console.WriteLine("Cos = " + trigo[1]);
Console.WriteLine("Tan = " + trigo[2]);

//Create a program to find the factors of a number taken as user input, store the factors in an array and display the factors. Also find the sum, sum of square of factors and product of the factors and display the results
Console.Write("Enter Number: ");
int nu = Convert.ToInt32(Console.ReadLine());

int[] factors = FactorsOfNumber.FindFactors(nu);

Console.Write("Factors: ");
foreach (int factor in factors)
{
    Console.Write(factor + " ");
}

Console.WriteLine("\nSum = " + FactorsOfNumber.FindSum(factors));
Console.WriteLine("Product = " + FactorsOfNumber.FindProduct(factors));
Console.WriteLine("Sum of Squares = " + FactorsOfNumber.FindSumOfSquares(factors));


//Write a program to find the sum of n natural numbers using recursive method and compare the result with the formulae n*(n+1)/2 and show the result from both computations is correct. 
Console.Write("Enter a Natural Number: ");
number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Not a Natural Number");
    return;
}

int recursion = SumOfNaturalNumbersRecursion.FindSumRecursion(number);
int formula = SumOfNaturalNumbersRecursion.FindSumFormula(number);

Console.WriteLine("Recursive Sum = " + recursion);
Console.WriteLine("Formula Sum = " + formula);

if (recursion == formula)
    Console.WriteLine("Both results are equal.");
else
    Console.WriteLine("Results are not equal.");
//Write a program that takes a year as input and outputs the Year is a Leap Year or not.
Console.Write("Enter Year: ");
int year = Convert.ToInt32(Console.ReadLine());

if (LeapYearChecker.IsLeapYear(year))
    Console.WriteLine("Leap Year");
else
    Console.WriteLine("Not a Leap Year");

//Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods.
Console.Write("Enter Kilometers: ");
double km = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Miles = " + UnitConverterLength1.ConvertKmToMiles(km));

Console.Write("Enter Miles: ");
double miles = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Kilometers = " + UnitConverterLength1.ConvertMilesToKm(miles));

Console.Write("Enter Meters: ");
double meters = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Feet = " + UnitConverterLength1.ConvertMetersToFeet(meters));

Console.Write("Enter Feet: ");
double feet = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Meters = " + UnitConverterLength1.ConvertFeetToMeters(feet));

//Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods.
Console.Write("Enter Fahrenheit: ");
double fahrenheit = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Celsius = " + UnitConverterLength2.ConvertFahrenheitToCelsius(fahrenheit));

Console.Write("Enter Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Fahrenheit = " + UnitConverterLength2.ConvertCelsiusToFahrenheit(celsius));

Console.Write("Enter Pounds: ");
double pounds = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Kilograms = " + UnitConverterLength2.ConvertPoundsToKilograms(pounds));

Console.Write("Enter Kilograms: ");
double kilograms = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Pounds = " + UnitConverterLength2.ConvertKilogramsToPounds(kilograms));

Console.Write("Enter Gallons: ");
double gallons = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Liters = " + UnitConverterLength2.ConvertGallonsToLiters(gallons));

Console.Write("Enter Liters: ");
double liters = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Gallons = " + UnitConverterLength2.ConvertLitersToGallons(liters));

//Write a program to take user input for the age of all 10 students in a class and check whether the student can vote depending on his/her age is greater or equal to 18.
int[] ages = new int[10];

for (int i = 0; i < ages.Length; i++)
{
    Console.Write($"Enter Age of Student {i + 1}: ");
    ages[i] = Convert.ToInt32(Console.ReadLine());

    if (StudentVoteChecker.CanStudentVote(ages[i]))
        Console.WriteLine("Eligible to Vote");
    else
        Console.WriteLine("Not Eligible to Vote");
}

//Create a program to find the youngest friends among 3 Amar, Akbar and Anthony based on their ages and tallest among the friends based on their heights and display it
string[] names = { "Amar", "Akbar", "Anthony" };

int[] agess = new int[3];
int[] heights = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"Enter Age of {names[i]}: ");
    ages[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Enter Height of {names[i]} (cm): ");
    heights[i] = Convert.ToInt32(Console.ReadLine());
}

int youngest = YoungestAndTallestFriend.FindYoungest(agess);
int tallest = YoungestAndTallestFriend.FindTallest(heights);

for (int i = 0; i < 3; i++)
{
    if (ages[i] == youngest)
        Console.WriteLine($"Youngest Friend: {names[i]}");

    if (heights[i] == tallest)
        Console.WriteLine($"Tallest Friend: {names[i]}");
}

//Write a program to take user input for 5 numbers and check whether a number is positive or negative. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they are equal, greater, or less
int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter Number {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());

    if (NumberAnalyzer.IsPositive(numbers[i]))
    {
        Console.Write("Positive ");

        if (NumberAnalyzer.IsEven(numbers[i]))
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
    else
    {
        Console.WriteLine("Negative");
    }
}

result = NumberAnalyzer.CompareNumbers(numbers[0], numbers[4]);

if (result == 1)
    Console.WriteLine("First element is Greater.");
else if (result == 0)
    Console.WriteLine("Both elements are Equal.");
else
    Console.WriteLine("First element is Smaller.");
//An organization took up the exercise to find the Body Mass Index (BMI) of all the persons in the team of 10 members. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
double[,] persons = new double[10, 3];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Enter Weight of Person {i + 1} (kg): ");
    persons[i, 0] = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Enter Height of Person {i + 1} (cm): ");
    persons[i, 1] = Convert.ToDouble(Console.ReadLine());
}

BMICalculator.CalculateBMI(persons);

string[] status = BMICalculator.GetBMIStatus(persons);

Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{persons[i, 0]}\t{persons[i, 1]}\t{Math.Round(persons[i, 2], 2)}\t{status[i]}");
}

//Write a program Quadratic to find the roots of the equation ax2+ bx + c. Use Math functions Math.pow() and Math.sqrt()
Console.Write("Enter a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter c: ");
double c = Convert.ToDouble(Console.ReadLine());

double[] roots = QuadraticEquation.FindRoots(a, b, c);

if (roots.Length == 0)
{
    Console.WriteLine("No Real Roots");
}
else
{
    foreach (double root in roots)
        Console.WriteLine("Root = " + root);
}

//Write a program that generates five 4 digit random values and then finds their average value, and their minimum and maximum value. Use Math.Random(), Math.Min(), and Math.Max().
int[] numbersArray = RandomNumberStatistics.Generate4DigitRandomArray(5);

Console.WriteLine("Random Numbers:");

foreach (int numberr in numbersArray)
{
    Console.Write(numberr + " ");
}

Console.WriteLine();

double[] ressult = RandomNumberStatistics.FindAverageMinMax(numbersArray);

Console.WriteLine("Average = " + Math.Round(ressult[0], 2));
Console.WriteLine("Minimum = " + ressult[1]);
Console.WriteLine("Maximum = " + ressult[2]);

//Create a program to find the shortest, tallest, and mean height of players present in a football team.
int[] Heights = FootballTeamStatistics.GenerateHeights(11);

Console.WriteLine("Player Heights:");

foreach (int height in Heights)
{
    Console.Write(height + " ");
}

Console.WriteLine();

Console.WriteLine("Total Height = " + FootballTeamStatistics.FindSum(Heights));

Console.WriteLine("Mean Height = " +
    Math.Round(FootballTeamStatistics.FindMeanHeight(Heights), 2));

Console.WriteLine("Shortest Height = " +
    FootballTeamStatistics.FindShortestHeight(Heights));

Console.WriteLine("Tallest Height = " +
    FootballTeamStatistics.FindTallestHeight(Heights));

//Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods

Console.Write("Enter Number: ");
 number = Convert.ToInt32(Console.ReadLine());

int[] digits = PalindromeAndReverse.GetDigits(number);

Console.Write("Digits: ");
foreach (int digit in digits)
{
    Console.Write(digit + " ");
}

Console.WriteLine();

int[] reverse = PalindromeAndReverse.ReverseDigits(digits);

Console.Write("Reverse: ");
foreach (int digit in reverse)
{
    Console.Write(digit + " ");
}

Console.WriteLine();

Console.WriteLine("Arrays Equal = " +
    PalindromeAndReverse.CompareArrays(digits, reverse));

Console.WriteLine("Palindrome = " +
    PalindromeAndReverse.IsPalindrome(digits));

Console.WriteLine("Duck Number = " +
    PalindromeAndReverse.IsDuckNumber(digits));
//Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
Console.Write("Enter Number: ");
 number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Prime Number      : " + SpecialNumbers.IsPrime(number));
Console.WriteLine("Neon Number       : " + SpecialNumbers.IsNeon(number));
Console.WriteLine("Spy Number        : " + SpecialNumbers.IsSpy(number));
Console.WriteLine("Automorphic Number: " + SpecialNumbers.IsAutomorphic(number));
Console.WriteLine("Buzz Number       : " + SpecialNumbers.IsBuzz(number));

//Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
Console.Write("Enter Number: ");
number = Convert.ToInt32(Console.ReadLine());

int[] factorss = FactorsAndPerfectNumbers.FindFactors(number);

Console.Write("Factors: ");

foreach (int factor in factorss)
{
    Console.Write(factor + " ");
}

Console.WriteLine();

Console.WriteLine("Greatest Factor = " +
    FactorsAndPerfectNumbers.FindGreatestFactor(factorss));

Console.WriteLine("Sum of Factors = " +
    FactorsAndPerfectNumbers.FindSumOfFactors(factorss));

Console.WriteLine("Product of Factors = " +
    FactorsAndPerfectNumbers.FindProductOfFactors(factorss));

Console.WriteLine("Product of Cube of Factors = " +
    FactorsAndPerfectNumbers.FindProductOfCubeOfFactors(factors));

Console.WriteLine("Perfect Number = " +
    FactorsAndPerfectNumbers.IsPerfectNumber(number));

Console.WriteLine("Abundant Number = " +
    FactorsAndPerfectNumbers.IsAbundantNumber(number));

Console.WriteLine("Deficient Number = " +
    FactorsAndPerfectNumbers.IsDeficientNumber(number));

Console.WriteLine("Strong Number = " +
    FactorsAndPerfectNumbers.IsStrongNumber(number));

//Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
Console.Write("Enter a Number: ");
number = Convert.ToInt32(Console.ReadLine());

if (HarshadAndFrequency.IsHarshadNumber(number))
{
    Console.WriteLine(number + " is a Harshad Number.");
}
else
{
    Console.WriteLine(number + " is not a Harshad Number.");
}

int[] frequency = HarshadAndFrequency.DigitFrequency(number);

HarshadAndFrequency.DisplayFrequency(frequency);

//Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
Console.Write("Enter a Number: ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Count of Digits : " +
    DigitOperations.CountDigits(number));

Console.WriteLine("Sum of Digits : " +
    DigitOperations.SumOfDigits(number));

Console.WriteLine("Reverse Number : " +
    DigitOperations.ReverseNumber(number));

Console.WriteLine("Largest Digit : " +
    DigitOperations.LargestDigit(number));

Console.WriteLine("Smallest Digit : " +
    DigitOperations.SmallestDigit(number));

//Write a program to generate a six-digit OTP number using Math.Random() method.Validate the numbers are unique by generating the OTP number 10 times and ensuring all the 10 OTPs are not the same
int[] otpArray = OTPGenerator.GenerateOTPArray(10);

Console.WriteLine("Generated OTPs:");

foreach (int otp in otpArray)
{
    Console.WriteLine(otp);
}

if (OTPGenerator.AreOTPsUnique(otpArray))
{
    Console.WriteLine("\nAll OTPs are Unique.");
}
else
{
    Console.WriteLine("\nDuplicate OTPs Found.");
}

//Create a program to display a calendar for a given month and year. The program should take the month and year as input from the user and display the calendar for that month. E.g. for 07 2005 user input, the program should display the calendar as shown below
Console.Write("Enter Month (1-12): ");
month = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Year: ");
year = Convert.ToInt32(Console.ReadLine());

CalendarDisplay.DisplayCalendar(month, year);

//Write a program Euclidean distance between two points as well as the equation of the line using those two points.Use Math functions Math.Pow() and Math.Sqrt()
Console.Write("Enter x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = EuclideanDistanceAndLine.FindDistance(x1, y1, x2, y2);

Console.WriteLine("\nDistance = " + Math.Round(distance, 2));

double[] Result = EuclideanDistanceAndLine.FindLineEquation(x1, y1, x2, y2);

if (Result.Length == 0)
{
    Console.WriteLine("The line is vertical. Slope is undefined.");
}
else
{
    Console.WriteLine("Slope (m) = " + Result[0]);
    Console.WriteLine("Y-Intercept (b) = " + Result[1]);
    Console.WriteLine($"Equation: y = {Result[0]}x + {Result[1]}");
}

//Write a program to find the 3 points that are collinear using the slope formulae and area of triangle formulae. check  A (2, 4), B (4, 6) and C (6, 8) are Collinear for sampling. 
Console.Write("Enter x1: ");
double pointAX = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y1: ");
double pointAY = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter x2: ");
double pointBX = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y2: ");
double pointBY = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter x3: ");
double pointCX = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y3: ");
double pointCY = Convert.ToDouble(Console.ReadLine());

bool slopeResult = CollinearPoints.CheckBySlope(
    pointAX, pointAY,
    pointBX, pointBY,
    pointCX, pointCY);

bool areaResult = CollinearPoints.CheckByArea(
    pointAX, pointAY,
    pointBX, pointBY,
    pointCX, pointCY);

Console.WriteLine();

Console.WriteLine("Slope Method : " +
    (slopeResult ? "Collinear" : "Not Collinear"));

Console.WriteLine("Area Method  : " +
    (areaResult ? "Collinear" : "Not Collinear"));

//Create a program to find the bonus of 10 employees based on their years of service as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus, along with the old and new salary.
double[,] employeeData =
    EmployeeBonusCalculator.GenerateEmployeeData(10);

double[,] salaryDetails =
    EmployeeBonusCalculator.CalculateBonus(employeeData);

EmployeeBonusCalculator.DisplayReport(salaryDetails);

//Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the total, average, and the percentage score 
Console.Write("Enter Number of Students: ");
int totalStudents = Convert.ToInt32(Console.ReadLine());

int[,] studentMarks =
    StudentScoreCard.GenerateMarks(totalStudents);

double[,] studentResult =
    StudentScoreCard.CalculateResult(studentMarks);

StudentScoreCard.DisplayScoreCard(studentMarks, studentResult);
//Write a program to perform matrix manipulation operations like addition, subtraction, multiplication, and transpose. Also finding the determinant and inverse of a matrix. The program should take random matrices as input and display the result of the operations.
//Write a Method to find the transpose of a matrix
//Write a Method to find the determinant of a 2x2 matrix
//Write a Method to find the determinant of a 3x3 matrix
//Write a Method to find the inverse of a 2x2 matrix
//Write a Method to find the inverse of a 3x3 matrix
//Write a Method to display a matrix
Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = MatrixOperations.GenerateMatrix(rows, columns);
int[,] matrix2 = MatrixOperations.GenerateMatrix(rows, columns);

Console.WriteLine("\nMatrix 1");
MatrixOperations.DisplayMatrix(matrix1);

Console.WriteLine("\nMatrix 2");
MatrixOperations.DisplayMatrix(matrix2);

// Addition
Console.WriteLine("\nAddition");
int[,] addition = MatrixOperations.AddMatrices(matrix1, matrix2);
MatrixOperations.DisplayMatrix(addition);

// Subtraction
Console.WriteLine("\nSubtraction");
int[,] subtraction = MatrixOperations.SubtractMatrices(matrix1, matrix2);
MatrixOperations.DisplayMatrix(subtraction);

// Multiplication
if (columns == rows)
{
    Console.WriteLine("\nMultiplication");
    int[,] multiplication = MatrixOperations.MultiplyMatrices(matrix1, matrix2);
    MatrixOperations.DisplayMatrix(multiplication);
}
else
{
    Console.WriteLine("\nMultiplication is not possible.");
}

// Transpose
Console.WriteLine("\nTranspose of Matrix 1");
int[,] transpose = MatrixOperations.TransposeMatrix(matrix1);
MatrixOperations.DisplayMatrix(transpose);

// Determinant and Inverse
if (rows == 2 && columns == 2)
{
    Console.WriteLine("\nDeterminant = " +
        MatrixOperations2.FindDeterminant2x2(matrix1));

    Console.WriteLine("\nInverse of Matrix");
    double[,] inverse = MatrixOperations2.FindInverse2x2(matrix1);
    MatrixOperations2.DisplayMatrix(inverse);
}
else if (rows == 3 && columns == 3)
{
    Console.WriteLine("\nDeterminant = " +
        MatrixOperations2.FindDeterminant3x3(matrix1));

    Console.WriteLine("\nInverse of Matrix");
    double[,] inverse = MatrixOperations2.FindInverse3x3(matrix1);
    MatrixOperations2.DisplayMatrix(inverse);
}
else
{
    Console.WriteLine("\nDeterminant and Inverse are available only for 2x2 and 3x3 matrices.");
}
