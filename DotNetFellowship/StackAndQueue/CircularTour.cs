using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueAndHashMap
{
    internal class CircularTour
    {
        public static int FindStartingPoint(int[] petrol, int[] distance)
        {
            int totalPetrol = 0;
            int totalDistance = 0;

            int currentPetrol = 0;
            int start = 0;

            for (int i = 0; i < petrol.Length; i++)
            {
                totalPetrol += petrol[i];
                totalDistance += distance[i];

                currentPetrol += petrol[i] - distance[i];

                if (currentPetrol < 0)
                {
                    start = i + 1;
                    currentPetrol = 0;
                }
            }

            if (totalPetrol < totalDistance)
                return -1;

            return start;
        }

        static void Main()
        {
            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };

            int result = FindStartingPoint(petrol, distance);

            if (result == -1)
            {
                Console.WriteLine("No possible starting point");
            }
            else
            {
                Console.WriteLine(
                    $"Starting petrol pump index: {result}"
                );
            }
        }
    }
}
