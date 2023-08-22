using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TIpdmtfundTransferDetail
    {
        public long FundTransId { get; set; }
        public string? AgentId { get; set; }
        public string? RemitterMobile { get; set; }
        public string? BenificieryId { get; set; }
        public string? Amount { get; set; }
        public string? TxnMode { get; set; }
        public string? IpayReferenceId { get; set; }
        public string? IpayRefNumber { get; set; }
        public string? IpayOprId { get; set; }
        public string? TransactionId { get; set; }
        public string? FundTransStatus { get; set; }
        public string? Merchant { get; set; }
        public string? Mode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? TrackId { get; set; }
    }
}
