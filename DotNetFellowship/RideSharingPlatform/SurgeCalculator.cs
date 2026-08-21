using System;
using System.Collections.Generic;

namespace RideSharingPlatform
{
    public class SurgeCalculator
    {
        private readonly TimeSpan window;

        public SurgeCalculator(TimeSpan window)
        {
            this.window = window;
        }

        public double Calculate(
            List<RideRequest> requests,
            List<DriverAvailability> drivers,
            DateTimeOffset currentTime)
        {
            DateTimeOffset startTime = currentTime - window;

            int pendingRequests = 0;
            int availableDrivers = 0;

            foreach (RideRequest request in requests)
            {
                if (request.Timestamp >= startTime &&
                    request.Timestamp <= currentTime)
                {
                    pendingRequests++;
                }
            }

            foreach (DriverAvailability driver in drivers)
            {
                if (driver.Timestamp >= startTime &&
                    driver.Timestamp <= currentTime &&
                    driver.IsAvailable)
                {
                    availableDrivers++;
                }
            }

            if (availableDrivers == 0)
                return 2.0;

            double ratio = (double)pendingRequests / availableDrivers;

            if (ratio < 1)
                return 1.0;

            if (ratio < 2)
                return 1.2;

            if (ratio < 3)
                return 1.5;

            return 2.0;
        }
    }
}