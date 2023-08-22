using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblNavOrderrecord
    {
        public long Counter { get; set; }
        public string? Orderid { get; set; }
        public string? Operation { get; set; }
        public string? Ticketno { get; set; }
        public string? Oldticketno { get; set; }
        public bool? Flag { get; set; }
        public string? Xmldocument { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }
        public string? Oldorderid { get; set; }
    }
}
