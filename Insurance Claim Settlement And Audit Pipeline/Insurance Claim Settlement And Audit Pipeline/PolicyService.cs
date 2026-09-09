using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class PolicyService
    {
        public Dictionary<string, Policy> policies;

        public PolicyService(string policyFile)
        {
            policies = LoadPolicies(policyFile);
        }
        public Dictionary<string,Policy> LoadPolicies(string policyFile)
        {
            using FileStream fs = new FileStream(policyFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            using StreamReader sr = new StreamReader(fs);
            string json = sr.ReadToEnd();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            PolicyRoot? root = JsonSerializer.Deserialize<PolicyRoot>(json,options);
            if(root==null || root.policies == null)
            {
                throw new InvalidDataException("invalid policies.json");
            }
            return root.policies.ToDictionary(p => p.Id, StringComparer.OrdinalIgnoreCase);
        }

        public Policy GetPolicy(string policyId)
        {
            if(policies.TryGetValue(policyId,out Policy? policy))
            {
                throw new PolicyNotFoundException(policyId);
            }
            return policy;
        }

    }
}
