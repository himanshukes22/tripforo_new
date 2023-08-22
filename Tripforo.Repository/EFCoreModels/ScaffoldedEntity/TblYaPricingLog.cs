using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblYaPricingLog
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string? PriceReq { get; set; }
        public string? PriceRes { get; set; }
        public DateTime? CreatedDare { get; set; }
    }
}
