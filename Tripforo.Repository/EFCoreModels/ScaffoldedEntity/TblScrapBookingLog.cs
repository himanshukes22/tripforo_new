using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblScrapBookingLog
    {
        public long Id { get; set; }
        public string? OrderId { get; set; }
        public string? Pnr { get; set; }
        public string? Vc { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public string? Other { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
