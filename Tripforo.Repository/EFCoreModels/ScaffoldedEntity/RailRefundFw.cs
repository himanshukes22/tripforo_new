using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class RailRefundFw
    {
        public int SlNo { get; set; }
        public string? TransactionId { get; set; }
        public decimal? RefundAmount { get; set; }
        public DateTime? ActualRefundDate { get; set; }
        public string? UserId { get; set; }
        public string? AgentId { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
