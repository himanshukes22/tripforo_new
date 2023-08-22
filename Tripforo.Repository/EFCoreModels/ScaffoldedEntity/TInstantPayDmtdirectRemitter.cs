using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayDmtdirectRemitter
    {
        public long Id { get; set; }
        public string? RemitterId { get; set; }
        public string? AgentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public string? Pincode { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsKyc { get; set; }
        public string? Kycstatus { get; set; }
        public bool? ShowKycform { get; set; }
        public string? Gender { get; set; }
        public string? Dob { get; set; }
        public string? Idproof { get; set; }
        public string? IdproofNumber { get; set; }
        public string? FrontImg { get; set; }
        public string? BackImg { get; set; }
        public string? Remark { get; set; }
        public bool? IsVerified { get; set; }
        public string? Otp { get; set; }
        public string? OtpexpTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? TransferOtp { get; set; }
        public string? TransferOtpexpDate { get; set; }
    }
}
