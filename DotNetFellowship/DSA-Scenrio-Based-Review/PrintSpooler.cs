using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Scenrio_Based_Review
{
    public class PrintSpooler
    {
        public CircularQueue printerQueue;
        public ActiveJob activeJobs = new ActiveJob();

        public JobStack history = new JobStack();
        public ErrorLog errorLog = new ErrorLog();

        private Dictionary<string, PrintJob> jobs = new Dictionary<string, PrintJob>();

        private List<PrintJob> completedJobs = new List<PrintJob>();

        public PrintSpooler(int printerCount)
        {
            if (printerCount > 0)
            {
                printerQueue = new CircularQueue(printerCount);
            }
        }
        public bool SubmitJob(PrintJob job)
        {
            if (jobs.ContainsKey(job.JobId))
            {
                Console.WriteLine("Duplicate Job Id");
                return false;
            }
            jobs.Add(job.JobId, job);
            activeJobs.Add(job);
            return true;
        }

        public bool DispatchJob(string jobId)
        {
            if (printerQueue == null || printerQueue.Count() == 0)
            {
                Console.WriteLine("No printers available");
                return false;
            }

            if (!jobs.ContainsKey(jobId))
            {
                Console.WriteLine("No job found with this id");
                return false;
            }

            int printer = printerQueue.GetPrinter();

            Console.WriteLine(
                $"Job {jobId} dispatched to Printer {printer}");

            return true;
        }
        public bool CompleteJob(string jobId)
        {
            if (!jobs.ContainsKey(jobId))
                return false;

            PrintJob job = jobs[jobId];

            activeJobs.Remove(jobId);
            history.Push(job);
            completedJobs.Add(job);

            return true;
        }

        public bool CancelJob(string jobId)
        {
            if (!jobs.ContainsKey(jobId))
                return false;

            return activeJobs.Remove(jobId);
        }

        public bool RePriotize(string jobId, int priority)
        {
            return activeJobs.RePriotize(jobId, priority);
        }

        public PrintJob ReprintRecent()
        {
            return history.Peek();
        }

        public bool FindJob(string jobId)
        {
            if (jobs.ContainsKey(jobId))
                return true;

            return false;
        }

        public void PrinterFailure(int printerId, string message)
        {
            errorLog.Add($"Printer {printerId}: {message}");
        }

        public void DisplayActiveJobs()
        {
            Console.WriteLine("Active jobs-: ");
            activeJobs.DisplayForward();
        }
        public void DisplayActiveJobsBackward()
        {
            Console.WriteLine("Active Backward jobs");
            activeJobs.DisplayBackward();
        }

        public void DisplayErrors()
        {
            Console.Write("\nPrinter Errors: ");
            errorLog.Display();
        }

        public void SortJobs()
        {
            completedJobs.Sort((a, b) => b.Priority.CompareTo(a.Priority));
        }

        public PrintJob BinarySearch(string jobId)
        {
            completedJobs.Sort((a, b) => a.JobId.CompareTo(b.JobId));

            int low = 0;
            int high = completedJobs.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                int result = completedJobs[mid].JobId.CompareTo(jobId);

                if (result == 0)
                    return completedJobs[mid];

                if (result < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return null;
        }

    }
}






