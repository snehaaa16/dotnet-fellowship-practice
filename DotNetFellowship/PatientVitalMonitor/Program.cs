using PatientVitalMonitor;
using PatientVitalSignMonitor;

public class Program
{
    public static void Main()
    {

        VitalMonitor monitor = new VitalMonitor();

        monitor.SubscribeConsoleAlert();

        monitor.NotificationPipeline = reading =>
        {
            Console.WriteLine($"LOG: Normal reading -> {reading}");
        };

        using (MonitoringSession session = new MonitoringSession())
        {
            DateTime now = DateTime.Now;
            var readings = new List<VitalReading>
                {
                    new VitalReading(
                        "P1",
                        VitalType.HeartRate,
                        72,
                        now.AddMinutes(-3)),

                    new VitalReading(
                        "P1",
                        VitalType.HeartRate,
                        130,
                        now.AddMinutes(-2)),

                    new VitalReading(
                        "P1",
                        VitalType.HeartRate,
                        68,
                        now.AddMinutes(-1))
                };

            monitor.ProcessSession(
                session,
                readings);

            Console.WriteLine(monitor.GetSessionSummary(session));

            Console.WriteLine($"Total abnormal events: " + $"{monitor.AbnormalReadingCount}");

            var normalAverages = monitor.ComputeNormalReadingAverages();

            foreach (var item in normalAverages)
            {
                Console.WriteLine($"{item.Key}: {item.Value:F2}");
            }

            var averages = monitor.ComputeVitalAverages();

            foreach (var item in averages)
            {
                Console.WriteLine(
                    $"{item.Key}: {item.Value:F2}");
            }

            foreach (var reading in monitor.GetRecentReadings(5, now))
            {
                Console.WriteLine(reading);
            }

            Console.WriteLine("\nPatient with most abnormal readings: " + $"{monitor.GetPatientWithMostAbnormalReadings()}");
        }
    }
}