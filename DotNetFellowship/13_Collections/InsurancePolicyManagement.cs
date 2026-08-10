using System;
using System.Collections.Generic;

class Policy
{
    public string PolicyNumber;
    public string CoverageType;
    public DateTime ExpiryDate;

    public Policy(string number, string coverage, DateTime expiry)
    {
        PolicyNumber = number;
        CoverageType = coverage;
        ExpiryDate = expiry;
    }
}

class InsurancePolicyManagement
{
    static void Main()
    {
        Dictionary<string, Policy> policies =
            new Dictionary<string, Policy>();

        policies["P101"] =
            new Policy("P101", "Health", DateTime.Now.AddDays(10));

        policies["P102"] =
            new Policy("P102", "Car", DateTime.Now.AddDays(50));

        policies["P103"] =
            new Policy("P103", "Health", DateTime.Now.AddDays(20));

        Console.WriteLine("All Policies:");

        foreach (var policy in policies.Values)
            Console.WriteLine(policy.PolicyNumber);

        Console.WriteLine("\nExpiring Within 30 Days:");

        foreach (var policy in policies.Values)
        {
            if (policy.ExpiryDate <= DateTime.Now.AddDays(30))
                Console.WriteLine(policy.PolicyNumber);
        }

        Console.WriteLine("\nHealth Policies:");

        foreach (var policy in policies.Values)
        {
            if (policy.CoverageType == "Health")
                Console.WriteLine(policy.PolicyNumber);
        }
    }
}