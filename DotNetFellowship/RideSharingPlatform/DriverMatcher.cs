using System;

namespace RideSharingPlatform
{
    public class DriverMatcher
    {
        public DriverAvailability? FindBestDriver(
            double pickupLat,
            double pickupLon,
            SpatialIndex<DriverAvailability> index)
        {
            var drivers = index.GetNearby(pickupLat, pickupLon);

            DriverAvailability? bestDriver = null;
            double minDistance = double.MaxValue;

            foreach (var driver in drivers)
            {
                if (!driver.IsAvailable)
                    continue;

                double distance = DistanceCalculator.Calculate(
                    pickupLat,
                    pickupLon,
                    driver.Latitude,
                    driver.Longitude);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    bestDriver = driver;
                }
            }

            return bestDriver;
        }
    }
}