using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class EmployeeBonusArray
    {
        public static void CalculateBonus(double[] salary, double[] years)
        {
            double[] bonus = new double[10];
            double[] newSalary = new double[10];

            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            for (int i = 0; i < salary.Length; i++)
            {
                if (years[i] > 5)
                {
                    bonus[i] = salary[i] * 0.05;
                }
                else
                {
                    bonus[i] = salary[i] * 0.02;
                }

                newSalary[i] = salary[i] + bonus[i];

                totalBonus += bonus[i];
                totalOldSalary += salary[i];
                totalNewSalary += newSalary[i];
            }

            Console.WriteLine("Employee Details:");

            for (int i = 0; i < salary.Length; i++)
            {
                Console.WriteLine("Employee " + (i + 1));
                Console.WriteLine("Old Salary = " + salary[i]);
                Console.WriteLine("Bonus = " + bonus[i]);
                Console.WriteLine("New Salary = " + newSalary[i]);
            }

            Console.WriteLine("Total Old Salary = " + totalOldSalary);
            Console.WriteLine("Total Bonus = " + totalBonus);
            Console.WriteLine("Total New Salary = " + totalNewSalary);
        }
    }
}