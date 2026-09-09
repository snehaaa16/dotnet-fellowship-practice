using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class AuditService
    {
        public byte[] CreateAuditToken(Settlement settlement)
        {
            using MemoryStream memoryStream =new MemoryStream();

            using BinaryWriter writer =new BinaryWriter( memoryStream,Encoding.UTF8,leaveOpen: true);

            writer.Write(settlement.ClaimId);
            writer.Write(settlement.PolicyId);
            writer.Write(settlement.ClaimAmount);
            writer.Write(settlement.ApprovedAmount);
            writer.Write(settlement.Decision);

            writer.Flush();

            return memoryStream.ToArray();
        }
        public AuditToken DecodeAuditToken(byte[] binaryData)
        {
            if (binaryData == null || binaryData.Length == 0)
            {
                throw new InvalidDataException("Binary audit data is empty.");
            }

            using MemoryStream memoryStream =new MemoryStream(binaryData);

            using BinaryReader reader =new BinaryReader(memoryStream,Encoding.UTF8,leaveOpen: false);

            try
            {
                string claimId = reader.ReadString();
                string policyId = reader.ReadString();
                decimal claimAmount = reader.ReadDecimal();
                decimal approvedAmount = reader.ReadDecimal();
                string decision = reader.ReadString();

                return new AuditToken
                {
                    ClaimId = claimId,
                    PolicyId = policyId,
                    ClaimAmount = claimAmount,
                    ApprovedAmount = approvedAmount,
                    Decision = decision
                };
            }
            catch (EndOfStreamException)
            {
                throw new InvalidDataException("Binary audit data is corrupted or incomplete.");
            }
            catch (IOException)
            {
                throw new InvalidDataException("Unable to read binary audit data.");
            }
        }
        public bool Verify(Settlement settlement,AuditToken auditToken)
        {
            return
                settlement.ClaimId == auditToken.ClaimId &&
                settlement.PolicyId == auditToken.PolicyId &&
                settlement.ClaimAmount == auditToken.ClaimAmount &&
                settlement.ApprovedAmount == auditToken.ApprovedAmount &&
                settlement.Decision == auditToken.Decision;
        }
    }
}
