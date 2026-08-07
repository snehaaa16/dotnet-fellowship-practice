using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class EvenCheckerTests
{
    private EvenChecker _evenChecker;
    [SetUp]
    public void SetUp() { _evenChecker = new EvenChecker(); }
    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_TestCases(int number, bool expected) { Assert.AreEqual(expected, _evenChecker.IsEven(number)); }
}
