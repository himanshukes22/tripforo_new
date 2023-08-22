using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class StaffTransaction
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public string? ServiceType { get; set; }
        public decimal? TransAmount { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? AvalBal { get; set; }
        public string? StaffUserId { get; set; }
        public string? StaffId { get; set; }
        public decimal? AgentBal { get; set; }
        public decimal? AgentLimit { get; set; }
        public decimal? DueAmount { get; set; }
        public string? OwnerId { get; set; }
        public string? AgencyId { get; set; }
        public string? DistrId { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? AgentMobile { get; set; }
        public string? Ipaddress { get; set; }
        public string? Remark { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UserType { get; set; }
        public string? Module { get; set; }
        public bool? CheckBalance { get; set; }
        public string? PaymentLog { get; set; }
    }
}
