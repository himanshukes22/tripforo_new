using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class CreditLimitTransaction
    {
        public int Counter { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyId { get; set; }
        public string? AgencyName { get; set; }
        public string? DistrId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ExecutiveId { get; set; }
        public string? Ipaddress { get; set; }
        public decimal? AvalBalDebit { get; set; }
        public decimal? AvalBalCredit { get; set; }
        public decimal? AvalBalance { get; set; }
        public decimal? CrdLimitDebit { get; set; }
        public decimal? CrdLimitCredit { get; set; }
        public decimal? CurrentCrdLimit { get; set; }
        public decimal? DueAmountDebit { get; set; }
        public decimal? DueAmountCredit { get; set; }
        public decimal? TotalDueAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? BookingType { get; set; }
        public string? Remark { get; set; }
        public string? BookedBy { get; set; }
        public string? PaymentMode { get; set; }
        public decimal? SetCreditLimit { get; set; }
        public DateTime? LimitExpiryDate { get; set; }
    }
}
