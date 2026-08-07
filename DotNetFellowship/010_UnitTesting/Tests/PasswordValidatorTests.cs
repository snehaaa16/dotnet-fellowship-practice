using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator _validator;
    [SetUp]
    public void SetUp() { _validator = new PasswordValidator(); }
    [TestCase("ValidPass1", true)]
    [TestCase("short1A", false)]
    [TestCase("nouppercase1", false)]
    [TestCase("NoDigitHere", false)]
    public void IsValidPassword_Tests(string password, bool expected) { Assert.AreEqual(expected, _validator.IsValidPassword(password)); }
}
