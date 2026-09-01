using PatientVitalMonitor;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PatientVitalSignMonitor
{
    public class VitalMonitor
    {
        public Dictionary<VitalType, Predicate<VitalReading>> rules;
        public List<VitalReading> allReadings = new();
        public event EventHandler<VitalReading>? AbnormalReadingDetected;
          public Action<VitalReading>? NotificationPipeline { get; set; }
          public int AbnormalReadingCount { get; set; }
        public VitalMonitor()
        {
            rules = new Dictionary<VitalType, Predicate<VitalReading>>();
            foreach (VitalType type in Enum.GetValues<VitalType>())
            {
                var range = GetVitalRange(type);
                rules[type] = CreateRangeRule(range.Min, range.Max);
            }
            AbnormalReadingDetected += CounterAccumulator;
        }
    public static VitalRangeAttribute GetVitalRange(VitalType vitalType)
    {
       FieldInfo? field = typeof(VitalType).GetField(vitalType.ToString());
       if (field == null)throw new InvalidOperationException($"No metadata found for {vitalType}.");
       VitalRangeAttribute? attribute =field.GetCustomAttribute<VitalRangeAttribute>();
       if (attribute == null) throw new InvalidOperationException($"No VitalRangeAttribute found for {vitalType}.");
       return attribute;
     }
     public static Predicate<VitalReading> CreateRangeRule(double min,double max)
     {
          return reading => reading.value < min ||reading.value > max;
     }

     public void SetRule(VitalType vitalType,Predicate<VitalReading> rule)
     {
          rules[vitalType] = rule;
     }

     public void SubscribeConsoleAlert()
     {
          AbnormalReadingDetected += ConsoleAlertHandler;
     }

    public void CounterAccumulator(object? sender,VitalReading Reading)
    {
            AbnormalReadingCount++;
    }
        public bool ProcessReading(VitalReading reading, MonitoringSession session)
        { 
            //if (session.IsDisposed) throw new ObjectDisposedException(nameof(MonitoringSession));
            if (IsPhysiologicallyImpossible(reading))
            {
                throw new VitalOutOfPhysiologicalRangeException($"Physiologically impossible {reading.VitalType} value: {reading.value}", reading);
            }

            bool duplicateTimestamp = session.Readings.Any(r =>
                r.patientId == reading.patientId &&
                r.VitalType == reading.VitalType &&
                r.Timestamp == reading.Timestamp);

            if (duplicateTimestamp)
            {
                Console.WriteLine($"Duplicate timestamp for " + $"{reading.patientId}/{reading.VitalType}");
            }

            session.AddReading(reading);
            allReadings.Add(reading);

            bool abnormal = rules[reading.VitalType](reading);

            if (abnormal)
            {
                DispatchAbnormalEventSafely(reading);
            }
            else
            {
                NotificationPipeline?.Invoke(reading);
            }

            return !abnormal;
        }

        public bool IsPhysiologicallyImpossible(VitalReading reading)
        {
            return reading.value <= 0;
        }

        public void ConsoleAlertHandler(object? sender,VitalReading reading)
        {
            Console.WriteLine($"Patient {reading.patientId} - " +$"{reading.VitalType} = {reading.value}");
        }


        public void DispatchAbnormalEventSafely(VitalReading reading)
        {
            var handlers = AbnormalReadingDetected;

            if (handlers == null)
                return;

            foreach (EventHandler<VitalReading> handler in handlers.GetInvocationList())
            {
                try
                {
                    handler(this, reading);
                }
                catch (Exception ex)
                {
                    Console.WriteLine( $"Event handler failed: {ex.Message}");
                }
            }
        }

        public Dictionary<VitalType, double>ComputeNormalReadingAverages()
        {
            return allReadings
                .Where(r => !rules[r.VitalType](r))
                .GroupBy(r => r.VitalType)
                .ToDictionary(g => g.Key,g => g.Average(r => r.value));
        }

        public IEnumerable<VitalReading> GetRecentReadings(int minutes,DateTime now)
        {
            DateTime cutoff = now.AddMinutes(-minutes);
            return allReadings
                .Where(r => r.Timestamp >= cutoff && r.Timestamp <= now);
        }

        public Dictionary<VitalType, double> ComputeVitalAverages()
        {
            return allReadings
                .GroupBy(r => r.VitalType)
                .ToDictionary(
                    g => g.Key,
                    g => g.Average(r => r.value));
        }

        public IEnumerable<object> GroupByPatientAndVital()
        {
            return allReadings
                .GroupBy(r => new
                {
                    r.patientId,
                    r.VitalType
                })
                .Select(g => new
                {
                    g.Key.patientId,
                    g.Key.VitalType,
                    Average = g.Average(r => r.value),
                    Count = g.Count()
                });
        }

        public string GetSessionSummary(MonitoringSession session)
        {
            //if (session.IsDisposed)
            //{
            //    return "Session disposed: no readings available.";
            //}

            int abnormalCount = session.Readings.Count(r => rules[r.VitalType](r));

            string? mostAbnormalPatient = session.Readings
                .Where(r => rules[r.VitalType](r))
                .GroupBy(r => r.patientId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            if (mostAbnormalPatient == null)
            {
                return "Session Summary: 0 abnormal readings.";
            }

            int patientAbnormalCount = session.Readings
                .Count(r =>
                    r.patientId == mostAbnormalPatient &&
                    rules[r.VitalType](r));

            return $"Patient {mostAbnormalPatient}: " +$"{patientAbnormalCount} abnormal reading(s)";
        }

        public void ProcessSession(MonitoringSession session,IEnumerable<VitalReading> readings)
        {
            try
            {
                foreach (VitalReading reading in readings)
                {
                    ProcessReading(reading, session);
                }
            }
            catch (VitalOutOfPhysiologicalRangeException ex)
            {
                Console.WriteLine($"Custom exception: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine( $"Argument exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"SESSION CLEANUP " + $"DeviceHandle {session.DeviceHandle.HandleId} " + "processing ended.");
            }
        }
        public string? GetPatientWithMostAbnormalReadings()
        {
            var result = allReadings
                .Where(r => rules[r.VitalType](r))
                .GroupBy(r => r.patientId)
                .Select(g => new
                {
                    patientId = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(x => x.Count)
                .FirstOrDefault();

            return result?.patientId;
        }

    }
}
