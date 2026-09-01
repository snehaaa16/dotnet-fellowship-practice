using PatientVitalSignMonitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientVitalMonitor
{
    public class VitalReading
    {
        public string patientId { get; }
        public VitalType VitalType { get; }
        public int value { get; }
        public DateTime Timestamp { get; }

        public VitalReading(string patientId, VitalType VitalType, int value,DateTime Timestamp)
        {
            if (string.IsNullOrWhiteSpace(patientId))
                throw new ArgumentException("PatientId cannot be empty.");

            if (Timestamp < DateTime.MinValue)
                throw new ArgumentOutOfRangeException("Timestamp cannot be negative.");

            if (double.IsNaN(value) || double.IsInfinity(value))
                throw new ArgumentOutOfRangeException("Vital value must be a valid finite number.");

            this.patientId = patientId;
            this.VitalType = VitalType;
            this.value = value;
            this.Timestamp = Timestamp;
        }
        public override string ToString()
        {
            return $"Patient Id : {patientId} | Vital Type : {VitalType} | Value : {value} | Timestamp : {Timestamp:HH:mm:ss}";
        }

    }
}
