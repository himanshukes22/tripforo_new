using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPlbRef
    {
        public int Counter { get; set; }
        public string? Airportcode { get; set; }
        public string? Triptype { get; set; }
        public decimal? Yq { get; set; }
        public decimal? Yr { get; set; }
        public string? Vc { get; set; }
        public string? Trip { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
