using System;

namespace _09_AbstractClass_Interface
{
    interface ILoanable
    {
        void ApplyForLoan();
        double CalculateLoanEligibility();
    }

    internal abstract class BankingSystem
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankingSystem(string accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public abstract double CalculateInterest();

        public void DisplayDetails()
        {
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Holder Name : " + HolderName);
            Console.WriteLine("Balance : " + Balance);
        }
    }

    internal class SavingsAccount : BankingSystem, ILoanable
    {
        public SavingsAccount(string accountNumber, string holderName, double balance)
            : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.05;
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Loan Applied Successfully");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 10;
        }
    }

    internal class CurrentAccount : BankingSystem, ILoanable
    {
        public CurrentAccount(string accountNumber, string holderName, double balance)
            : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.02;
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Loan Applied Successfully");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 8;
        }
    }
}