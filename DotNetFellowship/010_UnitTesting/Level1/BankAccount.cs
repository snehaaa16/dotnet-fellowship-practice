using System;
namespace _010_UnitTesting;
public class BankAccount
{
    private double _balance;
    public void Deposit(double amount)
    {
        if (amount < 0) throw new ArgumentException("Amount must be positive");
        _balance += amount;
    }
    public void Withdraw(double amount)
    {
        if (amount < 0) throw new ArgumentException("Amount must be positive");
        if (amount > _balance) throw new InvalidOperationException("Insufficient balance");
        _balance -= amount;
    }
    public double GetBalance() => _balance;
}
