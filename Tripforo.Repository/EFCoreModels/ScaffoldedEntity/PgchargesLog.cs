using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PgchargesLog
    {
        public int Id { get; set; }
        public string? TrackId { get; set; }
        public string? AgentId { get; set; }
        public string? AgentType { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? OriginalAmount { get; set; }
        public decimal? Charges { get; set; }
        public decimal? NewCharge { get; set; }
        public string? ChargesType { get; set; }
        public string? PaymentMode { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
