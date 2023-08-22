using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAmdgdsbookinglog
    {
        public int Counter { get; set; }
        public string? Orderid { get; set; }
        public string? Pnr { get; set; }
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
        public string? Other { get; set; }
        public DateTime? Bookingdate { get; set; }
    }
}
