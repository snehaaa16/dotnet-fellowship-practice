using PatientVitalMonitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientVitalSignMonitor
{
    public enum VitalType
    {
        [VitalRangeAttribute(60,100)]
        HeartRate,
        [VitalRangeAttribute(90,120)]
        BloodPressureSystolic,

        [VitalRangeAttribute(10,100)]
        OxygenSaturation
    }
}
