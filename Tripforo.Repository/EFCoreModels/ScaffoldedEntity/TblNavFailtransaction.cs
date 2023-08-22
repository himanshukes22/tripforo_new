using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblNavFailtransaction
    {
        public int Counter { get; set; }
        public int? Failcounter { get; set; }
        public string? Orderid { get; set; }
        public string? Operation { get; set; }
        public string? Xmldocument { get; set; }
        public string? Other { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
