using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter _converter;
    [SetUp]
    public void SetUp() { _converter = new TemperatureConverter(); }
    [Test]
    public void CelsiusToFahrenheit_Valid_ReturnsCorrect() { Assert.AreEqual(32, _converter.CelsiusToFahrenheit(0)); Assert.AreEqual(212, _converter.CelsiusToFahrenheit(100)); }
    [Test]
    public void FahrenheitToCelsius_Valid_ReturnsCorrect() { Assert.AreEqual(0, _converter.FahrenheitToCelsius(32)); Assert.AreEqual(100, _converter.FahrenheitToCelsius(212)); }
}
