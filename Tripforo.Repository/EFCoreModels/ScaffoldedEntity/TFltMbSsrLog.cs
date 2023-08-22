using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TFltMbSsrLog
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string Signature { get; set; } = null!;
        public string? Ssrxml { get; set; }
        public string? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? HeaderTbc { get; set; }
    }
}
