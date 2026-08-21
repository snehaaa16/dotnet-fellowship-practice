using System;
using System.Text.RegularExpressions;

namespace RideSharingPlatform
{
    public class RideRequestParser
    {
        private const string Pattern =
    @"^(?<requestId>[A-Z]{3}[0-9]{4})\|PICKUP:(?<pickupLat>-?\d+(\.\d+)?),(?<pickupLon>-?\d+(\.\d+)?)\|DEST:(?<destLat>-?\d+(\.\d+)?),(?<destLon>-?\d+(\.\d+)?)\|TIME:(?<timestamp>\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2})\|RIDER:(?<riderTier>premium|regular)$";

        public RideRequest Parse(string input)
        {
            Match match = Regex.Match(input, Pattern);

            if (!match.Success)
                throw new FormatException("Invalid ride request");

            return new RideRequest(
                match.Groups["requestId"].Value,
                double.Parse(match.Groups["pickupLat"].Value),
                double.Parse(match.Groups["pickupLon"].Value),
                double.Parse(match.Groups["destLat"].Value),
                double.Parse(match.Groups["destLon"].Value),
                DateTimeOffset.Parse(match.Groups["timestamp"].Value),
                Enum.Parse<RiderTier>(match.Groups["riderTier"].Value, true)
            );
        }
    }
}