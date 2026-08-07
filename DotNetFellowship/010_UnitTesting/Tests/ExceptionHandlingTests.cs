using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class ExceptionHandlingTests
{
    [Test]
    public void Divide_ByZero_ThrowsArithmeticException()
    {
        var exHandler = new ExceptionHandling();
        Assert.Throws<ArithmeticException>(() => exHandler.Divide(5, 0));
    }
}
