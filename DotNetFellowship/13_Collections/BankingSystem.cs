using System;
using System.Collections.Generic;

class BankingSystem
{
    static void Main()
    {
        Dictionary<int, double> accounts =
            new Dictionary<int, double>();

        accounts[101] = 50000;
        accounts[102] = 30000;
        accounts[103] = 70000;

        Queue<(int account, double amount)> withdrawals =
            new Queue<(int, double)>();

        withdrawals.Enqueue((101, 5000));
        withdrawals.Enqueue((102, 10000));
        withdrawals.Enqueue((103, 2000));

        while (withdrawals.Count > 0)
        {
            var request = withdrawals.Dequeue();

            if (accounts[request.account] >= request.amount)
            {
                accounts[request.account] -= request.amount;

                Console.WriteLine(
                    "Withdrawal successful: " +
                    request.account);
            }
            else
            {
                Console.WriteLine(
                    "Insufficient balance: " +
                    request.account);
            }
        }
    }
}