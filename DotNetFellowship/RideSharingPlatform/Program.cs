using System;

namespace RideSharingPlatform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input =
                "REQ7781|PICKUP:12.34,77.56|DEST:12.40,77.60|TIME:2026-08-15T18:45:00|RIDER:premium";

            RideRequestParser parser = new RideRequestParser();

            RideRequest ride = parser.Parse(input);

            Console.WriteLine(ride.requestId);
            Console.WriteLine(ride.pickUpLatitude);
            Console.WriteLine(ride.pickUpLongitude);
            Console.WriteLine(ride.destLatitude);
            Console.WriteLine(ride.destLongitude);
            Console.WriteLine(ride.Timestamp);
            Console.WriteLine(ride.ridetier);

            SpatialIndex<DriverAvailability> index = new SpatialIndex<DriverAvailability>();
            DriverAvailability d1 =
               new DriverAvailability(1, 12.34, 77.56, 4.8,
                   DateTimeOffset.Now, true);

            DriverAvailability d2 =
                new DriverAvailability(2, 12.35, 77.57, 4.5,
                    DateTimeOffset.Now, true);

            DriverAvailability d3 =
                new DriverAvailability(3, 13.00, 78.00, 4.9,
                    DateTimeOffset.Now, true);

            // 4. Add drivers to grid
            index.Add(d1, d1.Latitude, d1.Longitude);
            index.Add(d2, d2.Latitude, d2.Longitude);
            index.Add(d3, d3.Latitude, d3.Longitude);

            var nearby = index.GetNearby(
               ride.pickUpLatitude,
               ride.pickUpLongitude);

            Console.WriteLine("\nNearby drivers:");

            foreach (var driver in nearby)
            {
                Console.WriteLine(
                    "Driver " + driver.DriverId +
                    " Rating: " + driver.Rating);
            }

            foreach (var driver in nearby)
            {
                double distance = DistanceCalculator.Calculate(ride.pickUpLatitude,ride.pickUpLongitude,
                    driver.Latitude,driver.Longitude);

                Console.WriteLine($"Driver {driver.DriverId} - Distance: {distance}");
            }
            DriverMatcher matcher = new DriverMatcher();

            DriverAvailability bestDriver =
                matcher.FindBestDriver(
                    ride.pickUpLatitude,
                    ride.pickUpLongitude,
                    index);

            Console.WriteLine("Best Driver: " + bestDriver.DriverId);
        }
    }
}