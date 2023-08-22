using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AirlineTicketNumberLog
    {
        public int Counter { get; set; }
        public int? PaxId { get; set; }
        public string? TicketNumber { get; set; }
        public string? Pnr { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
