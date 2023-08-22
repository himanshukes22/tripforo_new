using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Bookinglog1
    {
        public int Counter { get; set; }
        public string? SearchValue { get; set; }
        public string? SellReq { get; set; }
        public string? SellRes { get; set; }
        public string? AddmultiReq { get; set; }
        public string? AddmultiRes { get; set; }
        public string? PriceReq { get; set; }
        public string? PriceRes { get; set; }
        public string? TstReq { get; set; }
        public string? TstRes { get; set; }
        public string? PnrReq { get; set; }
        public string? PnrRes { get; set; }
        public DateTime DateTime { get; set; }
    }
}
