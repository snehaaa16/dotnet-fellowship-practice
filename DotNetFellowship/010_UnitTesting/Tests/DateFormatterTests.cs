using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class DateFormatterTests
{
    private DateFormatter _formatter;
    [SetUp]
    public void SetUp() { _formatter = new DateFormatter(); }
    [Test]
    public void FormatDate_ValidDate_ReturnsFormatted() { Assert.AreEqual("25-12-2023", _formatter.FormatDate("2023-12-25")); }
    [Test]
    public void FormatDate_InvalidDate_ThrowsFormatException() { Assert.Throws<FormatException>(() => _formatter.FormatDate("25-12-2023")); Assert.Throws<FormatException>(() => _formatter.FormatDate("invalid")); }
}
