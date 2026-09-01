using System;
using System.Collections.Generic;
using NUnit.Framework;
using RideSharingPlatform;

namespace TestingProject
{
    public class RideRequestParserTests
    {
        // 1. Negative latitude
        [Test]
        public void NegativeCoordinateParsing()
        {
            string input =
                "REQ7781|PICKUP:-12.34,77.56|DEST:12.40,77.60|TIME:2026-08-15T18:45:00|RIDER:premium";

            RideRequestParser parser = new RideRequestParser();
            RideRequest ride = parser.Parse(input);

            Assert.That(ride.pickUpLatitude, Is.EqualTo(-12.34));
        }


        // 2. Negative longitude
        [Test]
        public void NegativeLongitude()
        {
            string input =
                "REQ7781|PICKUP:12.34,77.56|DEST:12.40,-77.60|TIME:2026-08-15T18:45:00|RIDER:premium";

            RideRequestParser parser = new RideRequestParser();
            RideRequest ride = parser.Parse(input);

            Assert.That(ride.destLongitude, Is.EqualTo(-77.60));
        }


        // 3. Variable decimal precision
        [Test]
        public void VariableDecimalPrecision()
        {
            string input =
                "REQ7781|PICKUP:12.3,-77.56789|DEST:12.40,77.60|TIME:2026-08-15T18:45:00|RIDER:premium";

            RideRequestParser parser = new RideRequestParser();
            RideRequest ride = parser.Parse(input);

            Assert.That(ride.pickUpLatitude, Is.EqualTo(12.3));
            Assert.That(ride.pickUpLongitude, Is.EqualTo(-77.56789));
        }


        // 4. Malformed coordinate pair
        [Test]
        public void MalformedCoordinatePair()
        {
            string input =
                "REQ7781|PICKUP:12.34|DEST:12.40,77.60|TIME:2026-08-15T18:45:00|RIDER:premium";

            RideRequestParser parser = new RideRequestParser();

            Assert.Throws<FormatException>(() => parser.Parse(input));
        }


        // 5. Surge multiplier
        [Test]
        public void SurgeMultiplier()
        {
            DateTimeOffset currentTime =
                new DateTimeOffset(
                    2026, 8, 15, 18, 45, 0,
                    TimeSpan.Zero);

            List<RideRequest> requests =
                new List<RideRequest>();

            for (int i = 0; i < 12; i++)
            {
                requests.Add(new RideRequest(
                    "REQ" + (1000 + i),
                    12.34,
                    77.56,
                    12.40,
                    77.60,
                    currentTime,
                    RiderTier.Premium));
            }

            List<DriverAvailability> drivers =
                new List<DriverAvailability>();

            for (int i = 1; i <= 4; i++)
            {
                drivers.Add(new DriverAvailability(
                    i,
                    12.34,
                    77.56,
                    4.5,
                    currentTime,
                    true));
            }

            SurgeCalculator calculator =
                new SurgeCalculator(TimeSpan.FromMinutes(5));

            double result = calculator.Calculate(
                requests,
                drivers,
                currentTime);

            Assert.That(result, Is.EqualTo(2.0));
        }


        // 6. Zero available drivers
        [Test]
        public void ZeroAvailableDrivers()
        {
            DateTimeOffset currentTime =
                new DateTimeOffset(
                    2026, 8, 15, 18, 45, 0,
                    TimeSpan.Zero);

            List<RideRequest> requests =
                new List<RideRequest>();

            requests.Add(new RideRequest(
                "REQ1001",
                12.34,
                77.56,
                12.40,
                77.60,
                currentTime,
                RiderTier.Premium));

            List<DriverAvailability> drivers =
                new List<DriverAvailability>();

            SurgeCalculator calculator =
                new SurgeCalculator(TimeSpan.FromMinutes(5));

            Assert.DoesNotThrow(() =>
                calculator.Calculate(
                    requests,
                    drivers,
                    currentTime));
        }


        // 7. Nearby driver search
        [Test]
        public void NearbyDriverSearch()
        {
            SpatialIndex<DriverAvailability> index =
                new SpatialIndex<DriverAvailability>();

            DriverAvailability d1 =
                new DriverAvailability(
                    1, 12.34, 77.56, 4.5,
                    DateTimeOffset.Now, true);

            DriverAvailability d2 =
                new DriverAvailability(
                    2, 12.35, 77.57, 4.5,
                    DateTimeOffset.Now, true);

            DriverAvailability d3 =
                new DriverAvailability(
                    3, 13.00, 78.00, 4.5,
                    DateTimeOffset.Now, true);

            index.Add(d1, d1.Latitude, d1.Longitude);
            index.Add(d2, d2.Latitude, d2.Longitude);
            index.Add(d3, d3.Latitude, d3.Longitude);

            List<DriverAvailability> nearby =
                index.GetNearby(12.34, 77.56);

            Assert.That(nearby, Does.Contain(d1));
            Assert.That(nearby, Does.Contain(d2));
            Assert.That(nearby, Does.Not.Contain(d3));
        }


       

        // 9. Recent time window
        [Test]
        public void RecentTimeWindow()
        {
            DateTimeOffset currentTime =
                new DateTimeOffset(
                    2026, 8, 15, 18, 45, 0,
                    TimeSpan.Zero);

            List<RideRequest> requests =
                new List<RideRequest>();

            // Recent request
            requests.Add(new RideRequest(
                "REQ1001",
                12.34,
                77.56,
                12.40,
                77.60,
                currentTime.AddMinutes(-2),
                RiderTier.Premium));

            // Old requests
            requests.Add(new RideRequest(
                "REQ1002",
                12.34,
                77.56,
                12.40,
                77.60,
                currentTime.AddMinutes(-10),
                RiderTier.Premium));

            requests.Add(new RideRequest(
                "REQ1003",
                12.34,
                77.56,
                12.40,
                77.60,
                currentTime.AddMinutes(-20),
                RiderTier.Premium));

            List<DriverAvailability> drivers =
                new List<DriverAvailability>();

            drivers.Add(new DriverAvailability(
                1,
                12.34,
                77.56,
                4.5,
                currentTime.AddMinutes(-1),
                true));

            drivers.Add(new DriverAvailability(
                2,
                12.34,
                77.56,
                4.5,
                currentTime.AddMinutes(-1),
                true));

            SurgeCalculator calculator =
                new SurgeCalculator(TimeSpan.FromMinutes(5));

            double result = calculator.Calculate(
                requests,
                drivers,
                currentTime);

            // 1 recent request / 2 available drivers = 0.5
            // Surge = 1.0x
            Assert.That(result, Is.EqualTo(1.0));
        }
    }
}