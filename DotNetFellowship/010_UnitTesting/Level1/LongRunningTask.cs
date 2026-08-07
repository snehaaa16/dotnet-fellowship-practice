using System;
using System.Threading;
namespace _010_UnitTesting;
public class LongRunningTask
{
    public bool Execute()
    {
        Thread.Sleep(3000);
        return true;
    }
}
