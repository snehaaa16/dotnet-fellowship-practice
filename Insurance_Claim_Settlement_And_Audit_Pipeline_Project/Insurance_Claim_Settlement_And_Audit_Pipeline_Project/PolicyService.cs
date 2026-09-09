using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class PolicyService
    {
        public Dictionary<string, Policy> Policies { get; private set; }

        public PolicyService(string policyFile)
        {
            Policies = LoadPolicies(policyFile);
        }

        public Dictionary<string, Policy> LoadPolicies(string policyFile)
        {
            using FileStream fs = new FileStream(policyFile,FileMode.Open,FileAccess.Read,FileShare.Read);

            using StreamReader sr = new StreamReader(fs);

            string json = sr.ReadToEnd();

            PolicyRoot? root =JsonSerializer.Deserialize<PolicyRoot>(
                    json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

            if (root == null || root.Policies == null)
            {
                throw new InvalidDataException("Invalid policies.json.");
            }

            Dictionary<string, Policy> result =new Dictionary<string, Policy>(StringComparer.OrdinalIgnoreCase);

            foreach (Policy policy in root.Policies)
            {
                if (string.IsNullOrWhiteSpace(policy.Id))
                {
                    throw new InvalidDataException("Policy id cannot be empty.");
                }

                result[policy.Id] = policy;
            }

            return result;
        }

        public Policy GetPolicy(string policyId)
        {
            if (!Policies.TryGetValue(policyId,out Policy? policy))
            {
                throw new PolicyNotFoundException(policyId);
            }

            return policy;
        }
    }
}
