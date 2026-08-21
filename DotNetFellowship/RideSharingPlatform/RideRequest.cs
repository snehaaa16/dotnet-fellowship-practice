using RideSharingPlatform;
using System;
using System.Collections.Generic;
using System.Text;

namespace RideSharingPlatform
{
    public class RideRequest
    {
        public string requestId { get; }
        public double pickUpLatitude {  get; }
        public double pickUpLongitude {  get; }

        public double destLatitude {  get; }
        public double destLongitude {  get; }
        public DateTimeOffset Timestamp { get; }

        public RiderTier ridetier;
        public RideRequest() { }

        public RideRequest(string requestId, double pickUpLatitude, double pickUpLongitude, double destLatitude, double destLongitude, DateTimeOffset timestamp, RiderTier ridetier)
        {
            this.requestId = requestId;
            this.pickUpLatitude = pickUpLatitude;
            this.pickUpLongitude = pickUpLongitude;
            this.destLatitude = destLatitude;
            this.destLongitude = destLongitude;
            Timestamp = timestamp;
            this.ridetier = ridetier;
        }
    }
}













