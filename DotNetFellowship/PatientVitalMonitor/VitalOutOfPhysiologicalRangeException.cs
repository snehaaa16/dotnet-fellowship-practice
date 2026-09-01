using PatientVitalMonitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientVitalSignMonitor
{
    public class VitalOutOfPhysiologicalRangeException : Exception
    {
            public VitalReading OffendingReading { get; }

            public VitalOutOfPhysiologicalRangeException(string message,VitalReading offendingReading): base(message)
            {
                OffendingReading = offendingReading;
            }

            public VitalOutOfPhysiologicalRangeException(string message,VitalReading offendingReading,Exception innerException): base(message, innerException)
            {
                OffendingReading = offendingReading;
            }
    }
}
