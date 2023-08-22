using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblFareRule
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string? FareRule { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
