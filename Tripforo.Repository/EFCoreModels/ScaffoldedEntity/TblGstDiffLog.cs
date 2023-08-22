using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblGstDiffLog
    {
        public long Counter { get; set; }
        public string? OrderId { get; set; }
        public decimal? Gstdiff { get; set; }
        public decimal? TotalGstdiff { get; set; }
        public DateTime? GstUpdateDateTime { get; set; }
    }
}
