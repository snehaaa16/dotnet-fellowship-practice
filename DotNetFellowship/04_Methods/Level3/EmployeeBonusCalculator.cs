using System;

namespace _04_Methods.Level3
{
    public class EmployeeBonusCalculator
    {
        // Generate Salary and Years of Service
        public static double[,] GenerateEmployeeData(int employeeCount)
        {
            Random random = new Random();

            double[,] employeeData = new double[employeeCount, 2];

            for (int employeeIndex = 0; employeeIndex < employeeCount; employeeIndex++)
            {
                employeeData[employeeIndex, 0] = random.Next(10000, 100000); // Salary
                employeeData[employeeIndex, 1] = random.Next(1, 11);         // Years of Service
            }

            return employeeData;
        }

        // Calculate Bonus and New Salary
        public static double[,] CalculateBonus(double[,] employeeData)
        {
            int employeeCount = employeeData.GetLength(0);

            double[,] salaryDetails = new double[employeeCount, 4];

            for (int employeeIndex = 0; employeeIndex < employeeCount; employeeIndex++)
            {
                double currentSalary = employeeData[employeeIndex, 0];
                double serviceYears = employeeData[employeeIndex, 1];

                double bonusAmount;

                if (serviceYears > 5)
                    bonusAmount = currentSalary * 0.05;
                else
                    bonusAmount = currentSalary * 0.02;

                double updatedSalary = currentSalary + bonusAmount;

                salaryDetails[employeeIndex, 0] = currentSalary;
                salaryDetails[employeeIndex, 1] = serviceYears;
                salaryDetails[employeeIndex, 2] = bonusAmount;
                salaryDetails[employeeIndex, 3] = updatedSalary;
            }

            return salaryDetails;
        }

        // Display Report
        public static void DisplayReport(double[,] salaryDetails)
        {
            double totalOldSalary = 0;
            double totalBonus = 0;
            double totalNewSalary = 0;

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Emp\tOld Salary\tYears\tBonus\t\tNew Salary");
            Console.WriteLine("--------------------------------------------------------------------------------");

            for (int employeeIndex = 0; employeeIndex < salaryDetails.GetLength(0); employeeIndex++)
            {
                Console.WriteLine(
                    $"{employeeIndex + 1}\t" +
                    $"{salaryDetails[employeeIndex, 0]}\t\t" +
                    $"{salaryDetails[employeeIndex, 1]}\t" +
                    $"{Math.Round(salaryDetails[employeeIndex, 2], 2)}\t\t" +
                    $"{Math.Round(salaryDetails[employeeIndex, 3], 2)}");

                totalOldSalary += salaryDetails[employeeIndex, 0];
                totalBonus += salaryDetails[employeeIndex, 2];
                totalNewSalary += salaryDetails[employeeIndex, 3];
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Total Old Salary : " + Math.Round(totalOldSalary, 2));
            Console.WriteLine("Total Bonus      : " + Math.Round(totalBonus, 2));
            Console.WriteLine("Total New Salary : " + Math.Round(totalNewSalary, 2));
        }
    }
}