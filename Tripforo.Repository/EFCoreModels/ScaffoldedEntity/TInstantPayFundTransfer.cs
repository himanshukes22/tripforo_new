using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayFundTransfer
    {
        public long FundTransId { get; set; }
        public string? AgentId { get; set; }
        public string? RemitterMobile { get; set; }
        public string? BenificieryId { get; set; }
        public string? Amount { get; set; }
        public string? TxnMode { get; set; }
        public string? IpayId { get; set; }
        public string? RefNo { get; set; }
        public string? OprId { get; set; }
        public string? Name { get; set; }
        public string? OpeningBal { get; set; }
        public string? ChargedAmt { get; set; }
        public string? LockedAmt { get; set; }
        public string? CcfBank { get; set; }
        public string? BankAlias { get; set; }
        public string? Timestamp { get; set; }
        public string? IpayUuid { get; set; }
        public string? Orderid { get; set; }
        public string? Environment { get; set; }
        public string? Status { get; set; }
        public string? TrackId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? RemitterId { get; set; }
        public string? RefundId { get; set; }
        public bool? Refund { get; set; }
        public string? PaymentType { get; set; }
        public string? LedgerAmount { get; set; }
        public string? TransTrackId { get; set; }
    }
}
