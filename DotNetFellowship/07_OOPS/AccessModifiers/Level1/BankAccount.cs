using System;

namespace _07_OOPS.AccessModifiers
{
    internal class BankAccount
    {
        // Public
        public string accountNumber;

        // Protected
        protected string accountHolder;

        // Private
        private double balance;

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public void DisplayAccount()
        {
            Console.WriteLine("Bank Account Details");
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Account Holder : {accountHolder}");
            Console.WriteLine($"Balance        : {balance}");
            Console.WriteLine();
        }
    }
}