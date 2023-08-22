using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblTboticketLog
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? OrderId { get; set; }
        public string? PnrNo { get; set; }
        public DateTime TicketDate { get; set; }
        public string? TicketReq { get; set; }
        public string? TicketRes { get; set; }
        public string? Others { get; set; }
    }
}
