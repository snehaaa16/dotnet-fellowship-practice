using System;
using System.Collections.Generic;
using System.Text;

namespace _07_OOPS.Static_This_Readonly_IsOperator
{
    internal class BankAccountSystem
    {
        // Static Variable
        public static string BankName = "State Bank of India";

        // Static Variable
        private static int totalAccounts = 0;

        // Instance Variable
        public string AccountHolderName;

        // Readonly Variable
        public readonly int AccountNumber;

        // Constructor
        public BankAccountSystem(string AccountHolderName, int AccountNumber)
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            totalAccounts++;
        }

        // Static Method
        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts : " + totalAccounts);
        }

        // Instance Method
        public void DisplayDetails()
        {
            Console.WriteLine("Bank Name : " + BankName);
            Console.WriteLine("Account Holder : " + AccountHolderName);
            Console.WriteLine("Account Number : " + AccountNumber);
        }
    }
}
