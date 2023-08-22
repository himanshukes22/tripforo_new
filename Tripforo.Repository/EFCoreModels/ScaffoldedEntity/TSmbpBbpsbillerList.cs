using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSmbpBbpsbillerList
    {
        public long BbpsbillerId { get; set; }
        public string? ServiceType { get; set; }
        public string? Operator { get; set; }
        public string? SpKey { get; set; }
        public string? IsBillFetch { get; set; }
        public string? BillUpdation { get; set; }
        public string? BillerId { get; set; }
        public string? AgentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? FetchId { get; set; }
    }
}
