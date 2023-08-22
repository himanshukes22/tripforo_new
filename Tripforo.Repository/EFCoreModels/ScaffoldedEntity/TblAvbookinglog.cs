using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAvbookinglog
    {
        public long Counter { get; set; }
        public string? Orderid { get; set; }
        public string? Pnr { get; set; }
        public string? Holdreq { get; set; }
        public string? Holdencryptedres { get; set; }
        public string? Holdres { get; set; }
        public string? Bookingreq { get; set; }
        public string? Bookingencryptedres { get; set; }
        public string? Bookingres { get; set; }
        public string? Fareruleoneway { get; set; }
        public string? Fareruleroundtrip { get; set; }
        public string? Other { get; set; }
        public string? Provider { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
