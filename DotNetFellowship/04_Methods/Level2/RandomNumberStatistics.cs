using System;

namespace _04_Methods.Level2
{
    public class RandomNumberStatistics
    {
        public static int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1000, 10000);
            }

            return numbers;
        }

        public static double[] FindAverageMinMax(int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;

                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }

            double average = (double)sum / numbers.Length;

            return new double[] { average, min, max };
        }
    }
}