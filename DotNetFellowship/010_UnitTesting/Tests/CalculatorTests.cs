using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;
    [SetUp]
    public void SetUp() { _calculator = new Calculator(); }
    [Test]
    public void Add_ValidInputs_ReturnsSum() { Assert.AreEqual(5, _calculator.Add(2, 3)); }
    [Test]
    public void Subtract_ValidInputs_ReturnsDifference() { Assert.AreEqual(1, _calculator.Subtract(4, 3)); }
    [Test]
    public void Multiply_ValidInputs_ReturnsProduct() { Assert.AreEqual(12, _calculator.Multiply(3, 4)); }
    [Test]
    public void Divide_ValidInputs_ReturnsQuotient() { Assert.AreEqual(3, _calculator.Divide(12, 4)); }
    [Test]
    public void Divide_ByZero_ThrowsArithmeticException() { Assert.Throws<ArithmeticException>(() => _calculator.Divide(10, 0)); }
}
