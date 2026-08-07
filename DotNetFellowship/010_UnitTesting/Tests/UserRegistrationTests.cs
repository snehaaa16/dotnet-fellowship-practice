using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration _registration;
    [SetUp]
    public void SetUp() { _registration = new UserRegistration(); }
    [Test]
    public void RegisterUser_ValidData_ReturnsTrue() { Assert.IsTrue(_registration.RegisterUser("user1", "test@test.com", "password123")); }
    [Test]
    public void RegisterUser_EmptyUsername_ThrowsArgumentException() { Assert.Throws<ArgumentException>(() => _registration.RegisterUser("", "test@test.com", "password123")); }
    [Test]
    public void RegisterUser_InvalidEmail_ThrowsArgumentException() { Assert.Throws<ArgumentException>(() => _registration.RegisterUser("user1", "test.com", "password123")); }
    [Test]
    public void RegisterUser_InvalidPassword_ThrowsArgumentException() { Assert.Throws<ArgumentException>(() => _registration.RegisterUser("user1", "test@test.com", "pass")); }
}
