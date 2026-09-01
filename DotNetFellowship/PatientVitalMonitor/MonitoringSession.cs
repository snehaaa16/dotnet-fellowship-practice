using PatientVitalMonitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientVitalSignMonitor
{
    public class MonitoringSession : IDisposable
    {
        public bool disposed;

        public DeviceHandle DeviceHandle { get; }

        public List<VitalReading> Readings { get; } = new();

        public MonitoringSession()
        {
            DeviceHandle = new DeviceHandle();
        }
        public void IsDisposed(MonitoringSession session)
        {
            
        }
        public void AddReading(VitalReading reading)
        {
            if (disposed) throw new ObjectDisposedException(nameof(MonitoringSession));
            Readings.Add(reading);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return ;
            if (disposing)
            {
                Readings.Clear();
            }
            DeviceHandle.Release();

            disposed = true;
        }
    }
}














































