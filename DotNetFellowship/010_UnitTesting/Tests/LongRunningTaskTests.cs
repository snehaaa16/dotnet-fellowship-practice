using System;
using System.Threading.Tasks;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class LongRunningTaskTests
{
    [Test]
    [Timeout(4000)]
    public void Execute_CompletesSuccessfully()
    {
        var task = new LongRunningTask();
        Assert.IsTrue(task.Execute());
    }
    
    [Test]
    [Timeout(2000)]
    public void Execute_VerifyTimeoutBehavior()
    {
        var task = new LongRunningTask();
        var t = Task.Run(() => task.Execute());
        Assert.IsFalse(t.Wait(1000), "Task should timeout and not complete within 1000ms");
    }
}
