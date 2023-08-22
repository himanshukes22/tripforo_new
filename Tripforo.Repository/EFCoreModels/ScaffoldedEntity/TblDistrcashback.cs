using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblDistrcashback
    {
        public int Counter { get; set; }
        public string? Distrid { get; set; }
        public decimal? Aircb { get; set; }
        public decimal? Railcb { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
