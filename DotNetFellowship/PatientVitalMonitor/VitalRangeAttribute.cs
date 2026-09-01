using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PatientVitalMonitor
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, AllowMultiple=false)]
    public class VitalRangeAttribute : Attribute
    {
        public double Min { get; }
        public double Max { get; }

        public VitalRangeAttribute(double Min,double Max)
        {
            this.Min = Min;
            this.Max = Max;
        }

    }
}




