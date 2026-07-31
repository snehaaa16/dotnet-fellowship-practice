using System;

namespace _07_OOPS.AccessModifiers
{
    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string accountHolder, double balance)
            : base(accountNumber, accountHolder, balance)
        {
        }

        public void DisplaySavingsAccount()
        {
            Console.WriteLine("Savings Account");
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Account Holder : {accountHolder}");
            Console.WriteLine($"Balance        : {GetBalance()}");
            Console.WriteLine();
        }
    }
}