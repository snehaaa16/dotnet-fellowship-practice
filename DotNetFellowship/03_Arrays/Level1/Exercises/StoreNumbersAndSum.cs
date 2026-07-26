using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class StoreNumbersAndSum
    {
        public static void StoreNumbers()
        {
            double[] numbers = new double[10];
            double total = 0.0;
            int index = 0;

            while (true)
            {
                double number = Convert.ToDouble(Console.ReadLine());

                if (number <= 0)
                {
                    break;
                }

                if (index == 10)
                {
                    break;
                }

                numbers[index] = number;
                index++;
            }

            Console.WriteLine("Numbers Entered:");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }

            Console.WriteLine("Sum = " + total);
        }
    }
}
