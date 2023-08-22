using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblTbocancelLog
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string? TicketNo { get; set; }
        public string? CancelReq { get; set; }
        public string? CancelResp { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
