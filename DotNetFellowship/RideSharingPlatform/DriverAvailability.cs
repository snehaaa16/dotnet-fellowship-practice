using System;
using System.Collections.Generic;
using System.Text;

namespace RideSharingPlatform
{
    public class DriverAvailability
    {
        public int DriverId { get; }
        public double Latitude { get; }
        public double Longitude { get; }
        public double Rating { get; }
        public DateTimeOffset Timestamp { get; }
        public bool IsAvailable { get; }

        public DriverAvailability(int driverId,double latitude,double longitude,double rating,DateTimeOffset timestamp,bool isAvailable)
        {
            DriverId = driverId;
            Latitude = latitude;
            Longitude = longitude;
            Rating = rating;
            Timestamp = timestamp;
            IsAvailable = isAvailable;
        }
    }
}
