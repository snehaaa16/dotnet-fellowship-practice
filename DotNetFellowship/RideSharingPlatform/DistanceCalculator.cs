using System;

namespace RideSharingPlatform
{
    public class DistanceCalculator
    {
        public static double Calculate(double lat1, double lon1,double lat2, double lon2)
        {
            double lat = lat1 - lat2;
            double lon = lon1 - lon2;

            return Math.Sqrt(lat * lat + lon * lon);
        }
    }
}