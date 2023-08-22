using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSmbpBbpspayment
    {
        public long BbpspaymentId { get; set; }
        public string? AgentId { get; set; }
        public string? ClientRefId { get; set; }
        public string? Number { get; set; }
        public string? Spkey { get; set; }
        public string? CircleId { get; set; }
        public string? Amount { get; set; }
        public string? TransactionId { get; set; }
        public string? AvlBalance { get; set; }
        public string? OptTransactionId { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Refund { get; set; }
        public string? RefundId { get; set; }
    }
}
