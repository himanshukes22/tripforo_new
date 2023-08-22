using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayDmtdirectBeneficiary
    {
        public long Id { get; set; }
        public long? RegRemittId { get; set; }
        public string? RemitterId { get; set; }
        public string? AgentId { get; set; }
        public string? Mobile { get; set; }
        public string? AccountNo { get; set; }
        public string? BankName { get; set; }
        public string? Ifsccode { get; set; }
        public string? BenName { get; set; }
        public string? BenId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Otp { get; set; }
        public string? Expotp { get; set; }
    }
}
