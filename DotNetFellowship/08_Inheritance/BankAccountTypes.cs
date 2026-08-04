using System;

namespace _08_Inheritance
{
    internal class BankAccountTypes
    {
        public string AccountNumber;
        public double Balance;

        public BankAccountTypes(string AccountNumber, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("Bank Account");
        }
    }

    internal class SavingsAccount : BankAccountTypes
    {
        public double InterestRate;

        public SavingsAccount(string AccountNumber, double Balance, double InterestRate)
            : base(AccountNumber, Balance)
        {
            this.InterestRate = InterestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Balance : " + Balance);
            Console.WriteLine("Interest Rate : " + InterestRate + "%");
        }
    }

    internal class CheckingAccount : BankAccountTypes
    {
        public double WithdrawalLimit;

        public CheckingAccount(string AccountNumber, double Balance, double WithdrawalLimit)
            : base(AccountNumber, Balance)
        {
            this.WithdrawalLimit = WithdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Balance : " + Balance);
            Console.WriteLine("Withdrawal Limit : " + WithdrawalLimit);
        }
    }

    internal class FixedDepositAccount : BankAccountTypes
    {
        public int Tenure;

        public FixedDepositAccount(string AccountNumber, double Balance, int Tenure)
            : base(AccountNumber, Balance)
        {
            this.Tenure = Tenure;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account");
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Balance : " + Balance);
            Console.WriteLine("Tenure : " + Tenure + " Years");
        }
    }
}