using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class BankAccountTests
{
    private BankAccount _account;
    [SetUp]
    public void SetUp() { _account = new BankAccount(); }
    [Test]
    public void Deposit_ValidAmount_IncreasesBalance() { _account.Deposit(100); Assert.AreEqual(100, _account.GetBalance()); }
    [Test]
    public void Withdraw_ValidAmount_DecreasesBalance() { _account.Deposit(100); _account.Withdraw(40); Assert.AreEqual(60, _account.GetBalance()); }
    [Test]
    public void Withdraw_InsufficientFunds_ThrowsInvalidOperationException() { _account.Deposit(50); Assert.Throws<InvalidOperationException>(() => _account.Withdraw(100)); }
    [Test]
    public void GetBalance_Initial_ReturnsZero() { Assert.AreEqual(0, _account.GetBalance()); }
}
