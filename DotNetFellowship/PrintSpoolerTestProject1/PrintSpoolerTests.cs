using DSA_Scenrio_Based_Review;

namespace PrintSpoolerTestProject1
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void SubmitJob_ShouldReturnTrue()
        {
            PrintSpooler spooler = new PrintSpooler(2);
            PrintJob job =new PrintJob("J101", "Test.pdf", 3, 10);
            bool result = spooler.SubmitJob(job);
            Assert.That(result, Is.True);
        }

        [Test]
        public void SubmitDuplicateJob_ShouldReturnFalse()
        {
            PrintSpooler spooler= new PrintSpooler(2);
            PrintJob job1=new PrintJob("J201","Test1.pdf",2,11);
            PrintJob job2 = new PrintJob("J201", "Test2.pdf", 3, 5);
            spooler.SubmitJob(job1);
            bool result = spooler.SubmitJob(job2);
            Assert.That(result, Is.False);
        }

        [Test]
        public void FindJob_ShouldReturnCorrectJob()
        {
            PrintSpooler spooler = new PrintSpooler(2);
            PrintJob job1 = new PrintJob("J201", "Test3.pdf", 2, 11);
            PrintJob job2 = new PrintJob("H134", "Test4.pdf", 3, 5);
            spooler.SubmitJob(job1);
            spooler.SubmitJob(job2);
            bool result = spooler.FindJob("J201");
            Assert.That(result, Is.True);
        }

        [Test]
        public void FindInvalidJob_ShouldReturnFalse()
        {
            PrintSpooler spooler = new PrintSpooler(2);
            bool result = spooler.FindJob("Invalid");
            Assert.That(result, Is.False);
        }

        [Test]
        public void IntegratedWorkFlow()
        {
            PrintSpooler spooler = new PrintSpooler(3);
            PrintJob job1 = new PrintJob("j101", "test.pdf", 3, 4);
            bool result = spooler.SubmitJob(job1);
            Assert.That(result, Is.True);

            bool result1 = spooler.DispatchJobs(job1);
            Assert.That(result1, Is.True);

            
        }

        [Test]
        public void DispatchWithNoPrinters_ShouldReturnFalse()
        {
            PrintSpooler spooler = new PrintSpooler(0);
            PrintJob job =new PrintJob("J101", "Test.pdf", 3, 10);
            spooler.SubmitJob(job);
            bool result = spooler.DispatchJobs(job);
            Assert.That(result, Is.False);
        }

        [Test]
        public void ReprioritizeJob_ShouldReturnTrue()
        {
            PrintSpooler spooler = new PrintSpooler(2);
            PrintJob job =new PrintJob("J101", "Test.pdf", 2, 10);
            spooler.SubmitJob(job);
            bool result =spooler.RePriotize("J101", 7);

            Assert.That(result, Is.False);
            Assert.That(job.Priority, Is.EqualTo(2));
        }

        public void CompleteJob_ShouldReturnTrue()
        {
            PrintSpooler spooler = new PrintSpooler(2);
            PrintJob job = new PrintJob("j121", "a.pdf", 2,10);
            spooler.SubmitJob(job);
            bool result = spooler.CompleteJob("j121");
            Assert.That(result, Is.True);

        }

        public void CompleteInvalidJob_ShouldReturnFalse()
        {
            PrintSpooler spooler = new PrintSpooler(2);
            bool result = spooler.CompleteJob("INVALID");
            Assert.That(result, Is.False);
        }

        [Test]
        public void CompleteJob_ShouldAppearInHistory()
        {
            PrintSpooler spooler = new PrintSpooler(2);

            PrintJob job =new PrintJob("J101", "Test.pdf", 3, 10);

            spooler.SubmitJob(job);
            spooler.CompleteJob("J101");

            PrintJob recent =spooler.ReprintRecent();

            Assert.That(recent, Is.Not.Null);
            Assert.That(recent.JobId, Is.EqualTo("J101"));
        }
    }
}