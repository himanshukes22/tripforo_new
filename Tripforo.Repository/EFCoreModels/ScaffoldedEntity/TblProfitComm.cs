using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblProfitComm
    {
        public int Counter { get; set; }
        public string? Vc { get; set; }
        public decimal? Basic { get; set; }
        public decimal? BasicYq { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
