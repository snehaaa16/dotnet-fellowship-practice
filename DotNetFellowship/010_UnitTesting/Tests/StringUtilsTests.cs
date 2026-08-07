using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class StringUtilsTests
{
    private StringUtils _stringUtils;
    [SetUp]
    public void SetUp() { _stringUtils = new StringUtils(); }
    [Test]
    public void Reverse_ValidString_ReturnsReversed() { Assert.AreEqual("cba", _stringUtils.Reverse("abc")); }
    [Test]
    public void IsPalindrome_PalindromeString_ReturnsTrue() { Assert.IsTrue(_stringUtils.IsPalindrome("racecar")); }
    [Test]
    public void IsPalindrome_NonPalindromeString_ReturnsFalse() { Assert.IsFalse(_stringUtils.IsPalindrome("hello")); }
    [Test]
    public void ToUpperCase_ValidString_ReturnsUpper() { Assert.AreEqual("HELLO", _stringUtils.ToUpperCase("hello")); }
}
