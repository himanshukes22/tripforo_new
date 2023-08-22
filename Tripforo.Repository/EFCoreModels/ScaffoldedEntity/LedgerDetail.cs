using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class LedgerDetail
    {
        public int Counter { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public string? InvoiceNo { get; set; }
        public string? PnrNo { get; set; }
        public string? TicketNo { get; set; }
        public string? TicketingCarrier { get; set; }
        public string? YatraAccountId { get; set; }
        public string? AccountId { get; set; }
        public string? ExecutiveId { get; set; }
        public string? Ipaddress { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? AvalBalance { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? BookingType { get; set; }
        public string? Remark { get; set; }
        public int? PaxId { get; set; }
        public string? BillNoCorp { get; set; }
        public string? ProjectId { get; set; }
        public string? BookedBy { get; set; }
        public string? Distrid { get; set; }
        public string? PaymentMode { get; set; }
        public decimal? Tds { get; set; }
        public decimal? DueAmount { get; set; }
        public decimal? CreditLimit { get; set; }
        public bool? CreditLimitFlag { get; set; }
        public string? TransType { get; set; }
    }
}
