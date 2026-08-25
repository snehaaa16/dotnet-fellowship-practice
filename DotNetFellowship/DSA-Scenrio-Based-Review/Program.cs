using DSA_Scenrio_Based_Review;

PrintSpooler spooler = new PrintSpooler(4);

PrintJob j1 =new PrintJob("J101", "Report.pdf", 3, 20);

PrintJob j2 =new PrintJob("J102", "Resume.pdf", 5, 10);

PrintJob j3 =new PrintJob("J103", "Assignment.pdf", 2, 30);

spooler.SubmitJob(j1);
spooler.SubmitJob(j2);
spooler.SubmitJob(j3);

spooler.DispatchJobs(j1);
spooler.DispatchJobs(j2);
spooler.DispatchJobs(j3);


spooler.RePriotize("J101", 5);

spooler.DisplayActiveJobs();

spooler.CompleteJob("J101");

Console.WriteLine("\nRecent Job: " + spooler.ReprintRecent().JobId);

Console.WriteLine("\nLookup: " + spooler.FindJob("J102"));

spooler.PrinterFailure( 2,"Paper Jam");

spooler.DisplayErrors();

spooler.CancelJob("J103");

spooler.DisplayActiveJobs();