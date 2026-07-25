using _02_ControlFlow.Level1.Exercises;
using _02_ControlFlow.Level2.Exercises;
using System;
using System.Collections.Generic;
using System.Text;

//Write a program to check if a number is divisible by 5
//I/P => number
//O/P => Is the number ___ divisible by 5? ___
int num = Convert.ToInt32(Console.ReadLine());
bool check = CheckDivisibilityBy5.divisibleChecker(num);
Console.WriteLine(check);


//Write a program to check if the first, second, or third number is the largest of the three.
//I/P => number1, number2, number3
//O/P => 
//Is the first number the largest? ____
//Is the second number the largest? ___
bool varForNum1 = false;
bool varForNum2 = false;
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int result = LargestOf3Numbers.LargestNumber(num1, num2, num3);
if(num1==result) { varForNum1 = true; }
else if(num2==result) { varForNum2 = true; }
Console.WriteLine("Is the first number the largest? " + varForNum1);
Console.WriteLine("Is the second number the largest? " + varForNum2);

//Write a program to check if the first is the smallest of the 3 numbers.
//I/P => number1, number2, number3
//O/P => Is the first number the smallest? ____
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());
bool final = SmallestOf3Numbers.IsFirstSmallest(num1, num2, num3);
Console.WriteLine("Is the first number the smallest? " + final);


//Write a program to check for the natural number and write the sum of n natural numbers
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int sum = NaturalNumberSum.CalculateSum(number);
    Console.WriteLine($"The sum of {number} natural numbers is {sum}");
}
else
{
    Console.WriteLine($"The number {number} is not a natural number");
}

//Write a program to check whether a person can vote, depending on whether his/her age is
//greater than or equal to 18.
int age = Convert.ToInt32(Console.ReadLine());
bool canVote = VotingEligibility.CanVote(age);
if (canVote)
{
    Console.WriteLine($"The person's age is {age} and can vote.");
}
else
{
    Console.WriteLine($"The person's age is {age} and cannot vote.");
}

//Write a program to check whether a number is positive, negative, or zero.
int number1 = Convert.ToInt32(Console.ReadLine());
string resultt = NumberSignChecker.CheckNumberSign(number1);
Console.WriteLine(resultt);


int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 > 0)
{
    long resulttt = FactorialFor.CalculateFactorial(number);
    Console.WriteLine(resulttt);
}
else
{
    Console.WriteLine("Not a natural number");
}

//Write a program SpringSeason that takes two int values month and day from the command line
//and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
int month = Convert.ToInt32(Console.ReadLine());
int day = Convert.ToInt32(Console.ReadLine());
bool res = SpringSeason.IsSpringSeason(month, day);
if (res)
{
    Console.WriteLine("Its a Spring Season");
}
else
{
    Console.WriteLine("Not a Spring Season");
}

//Write a program to count down the number from the user input value to 1 using a while
//loop for a rocket launch
int counter = Convert.ToInt32(Console.ReadLine());
RocketCountdownWhile.Countdown(counter);

//Rewrite program 8 to do the countdown using the for-loop
int counterr = Convert.ToInt32(Console.ReadLine());
RocketCountdownFor.Countdown(counterr);

//Write a program to find the sum of numbers until the user enters 0
double finalResult = SumUntilZero.CalculateSum();
Console.WriteLine("Total Sum = " + finalResult);

//Rewrite the program 10 to find the sum until the user enters 0 or a negative number
//using while loop and break statement
double finalResultt = SumUntilZeroOrNegative.CalculateSum();
Console.WriteLine("Total Sum = " + finalResultt);

//Write a program to find the sum of n natural numbers using while loop compare the result with
//the formulae n*(n+1)/2 and show the result from both computations was correct.
number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    NaturalNumberSumWhile.CompareSum(number);
}
else
{
    Console.WriteLine("The number is not a natural number.");
}

//Rewrite the program number 12 with the for loop instead of a while loop to find the sum
//of n Natural Numbers
number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    NaturalNumberSumFor.CompareSum(number);
}
else
{
    Console.WriteLine("The number is not a natural number.");
}

//Write a Program to find the factorial of an integer entered by the user.
number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    long fin = FactorialWhile.CalculateFactorial(number);
    Console.WriteLine("Factorial = " + fin);
}
else
{
    Console.WriteLine("The number is not a natural number.");
}

//Create a program to print odd and even numbers between 1 to the number entered by the user.
number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    OddEvenNumbers.PrintOddEven(number);
}
else
{
    Console.WriteLine("The number is not a natural number.");
}

//Create a program to find the bonus of employees based on their years of service.
double salary = Convert.ToDouble(Console.ReadLine());
int yearsOfService = Convert.ToInt32(Console.ReadLine());
double bonus = EmployeeBonus.CalculateBonus(salary, yearsOfService);
Console.WriteLine("Bonus Amount = " + bonus);

//Create a program to find the multiplication table of a number entered by the user from 6 to 9.
number = Convert.ToInt32(Console.ReadLine());
MultiplicationTable.PrintTable(number);

//Write a LeapYear program that takes a year as input and outputs the Year is a Leap Year
//or not a Leap Year. 
int year = Convert.ToInt32(Console.ReadLine());
bool Result = LeapYear.IsLeapYear(year);
if (Result)
{
    Console.WriteLine("Year is a Leap Year");
}
else
{
    Console.WriteLine("Year is not a Leap Year");
}

//Rewrite program 1 to determine Leap Year with single if condition using logical and && and or || operators
year = Convert.ToInt32(Console.ReadLine());
bool Fin = LeapYearSingleCondition.IsLeapYear(year);
if (Fin)
{
    Console.WriteLine("Year is a Leap Year");
}
else
{
    Console.WriteLine("Year is not a Leap Year");
}

//Write a program to input marks and 3 subjects physics, chemistry and maths.
//Compute the percentage and then calculate the grade as per the following guidelines 
int physics = Convert.ToInt32(Console.ReadLine());
int chemistry = Convert.ToInt32(Console.ReadLine());
int maths = Convert.ToInt32(Console.ReadLine());
GradeCalculator.CalculateGrade(physics, chemistry, maths);

//Write a Program to check if the given number is a prime number or not
number = Convert.ToInt32(Console.ReadLine());
bool Primeresult = PrimeNumber.IsPrime(number);
if (Primeresult)
{
    Console.WriteLine(number + " is a Prime Number");
}
else
{
    Console.WriteLine(number + " is not a Prime Number");
}

//Write a program FizzBuzz, take a number as user input, and if it is a positive integer loop
//from 0 to the number and print the number, but for multiples of 3 print "Fizz" instead of the
//number, for multiples of 5 print "Buzz", and for multiples of both print "FizzBuzz".
number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    FizzBuzzFor.PrintFizzBuzz(number);
}
else
{
    Console.WriteLine("Please enter a positive integer.");
}

//Rewrite the program 5 FizzBuzz using while loop
number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    FizzBuzzWhile.PrintFizzBuzz(number);
}
else
{
    Console.WriteLine("Please enter a positive integer.");
}

//Create a program to find the BMI of a person
double weight = Convert.ToDouble(Console.ReadLine());
double height = Convert.ToDouble(Console.ReadLine());
BMI.CalculateBMI(weight, height);

//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on
//their ages and the tallest among the friends based on their heights
int amarAge = Convert.ToInt32(Console.ReadLine());
int akbarAge = Convert.ToInt32(Console.ReadLine());
int anthonyAge = Convert.ToInt32(Console.ReadLine());
double amarHeight = Convert.ToDouble(Console.ReadLine());
double akbarHeight = Convert.ToDouble(Console.ReadLine());
double anthonyHeight = Convert.ToDouble(Console.ReadLine());
YoungestAndTallest.FindYoungestAndTallest(amarAge, akbarAge, anthonyAge, amarHeight, akbarHeight, anthonyHeight);

//Create a program to print the greatest factor of a number beside itself using a loop.
number = Convert.ToInt32(Console.ReadLine());
int Numresult = GreatestFactor.FindGreatestFactor(number);
Console.WriteLine("Greatest Factor = " + Numresult);

//Create a program to find the power of a number.
number = Convert.ToInt32(Console.ReadLine());
int power = Convert.ToInt32(Console.ReadLine());
int Powresult = PowerOfNumber.FindPower(number, power);
Console.WriteLine(Powresult);

//Create a program to find the factors of a number taken as user input.
number = Convert.ToInt32(Console.ReadLine());
FactorsOfNumber.PrintFactors(number);

//Create a program to find all the multiple of a number taken as user input below 100.
number = Convert.ToInt32(Console.ReadLine());
MultiplesBelow100.PrintMultiples(number);

//Create a program to check if a number is Armstrong or not. Use the hints to show the steps clearly in
//the code
number = Convert.ToInt32(Console.ReadLine());
bool Armresult = ArmstrongNumber.IsArmstrong(number);
if (Armresult)
{
    Console.WriteLine(number + " is an Armstrong Number");
}
else
{
    Console.WriteLine(number + " is not an Armstrong Number");
}

//Create a program to count the number of digits in an integer.
number = Convert.ToInt32(Console.ReadLine());
int DigitsResult = CountDigits.FindDigitCount(number);
Console.WriteLine("Number of Digits = " + DigitsResult);

//Create a program to check if a number taken from the user is a Harshad Number.
number = Convert.ToInt32(Console.ReadLine());
bool HarshadResult = HarshadNumber.IsHarshadNumber(number);
if (HarshadResult)
{
    Console.WriteLine(number + " is a Harshad Number");
}
else
{
    Console.WriteLine(number + " is not a Harshad Number");
}

//Create a program to check if a number is an Abundant Number.
number = Convert.ToInt32(Console.ReadLine());
bool Aburesult = AbundantNumber.IsAbundantNumber(number);
if (Aburesult)
{
    Console.WriteLine(number + " is an Abundant Number");
}
else
{
    Console.WriteLine(number + " is not an Abundant Number");
}

//Write a program DayOfWeek that takes a date as input and prints the day of the week that
//the date falls on. Your program should take three command-line arguments: m(month), d(day),
//and y(year). For m use 1 for January, 2 for February, and so forth. For output print 0 for
//Sunday, 1 for Monday, 2 for Tuesday, and so forth. Use the following formulas, for the
//Gregorian calendar (where / denotes integer division):
int Month = Convert.ToInt32(Console.ReadLine());
int Day = Convert.ToInt32(Console.ReadLine());
int Year = Convert.ToInt32(Console.ReadLine());
int rlt = DaysOfWeek.FindDayOfWeek(month, day, year);
Console.WriteLine(rlt);


//Write a program to create a calculator using switch...case.
double first = Convert.ToDouble(Console.ReadLine());
double second = Convert.ToDouble(Console.ReadLine());
string op = Console.ReadLine();
double CalResult = CalculatorSwitch.Calculate(first, second, op);
if (op == "+" || op == "-" || op == "*" || op == "/")
{
    Console.WriteLine("Result = " + CalResult);
}
