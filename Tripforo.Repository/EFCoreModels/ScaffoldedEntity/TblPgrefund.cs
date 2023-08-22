using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPgrefund
    {
        public int Counter { get; set; }
        public decimal? RefundAmount { get; set; }
        public string? OrderId { get; set; }
        public string? RefundStatus { get; set; }
        public string? AgentId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? RefundBy { get; set; }
        public DateTime? RefundDate { get; set; }
        public string? RefundMode { get; set; }
        public string? InitiatedBy { get; set; }
        public string? RefundFor { get; set; }
    }
}
