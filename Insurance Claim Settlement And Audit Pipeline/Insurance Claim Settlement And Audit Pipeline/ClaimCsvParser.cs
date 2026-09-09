using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{

    public static class ClaimCsvParser
    {
        public static Claim Parse(string line, int lineNumber)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                throw new ClaimException($"Line {lineNumber}: Empty CSV record.");
            }

            string[] parts = line.Split(',');

            if (parts.Length != 5)
            {
                throw new ClaimException($"Line {lineNumber}: Invalid CSV format. Expected 5 fields.");
            }

            string claimId = parts[0].Trim();
            string policyId = parts[1].Trim();
            string amountText = parts[2].Trim();
            string claimType = parts[3].Trim();
            string dateText = parts[4].Trim();

            if (!decimal.TryParse(amountText,NumberStyles.Number,CultureInfo.InvariantCulture,out decimal claimAmount))
            {
                throw new ClaimException($"Line {lineNumber}: Invalid claim amount '{amountText}'.");
            }

            if (!DateTime.TryParseExact(
                    dateText,
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime submittedDate))
            {
                throw new ClaimException($"Line {lineNumber}: Invalid submitted date '{dateText}'.");
            }

            return new Claim
            {
                ClaimId = claimId,
                PolicyId = policyId,
                ClaimAmount = claimAmount,
                ClaimType = claimType.ToUpperInvariant(),
                SubmittedDate = submittedDate
            };
        }
    }
}
