using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class GdsbookingLog
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string? Pnr { get; set; }
        public string? Ssreq { get; set; }
        public string? Ssres { get; set; }
        public string? Pnbfreq1 { get; set; }
        public string? Pnbfres1 { get; set; }
        public string? Pnbfreq2 { get; set; }
        public string? Pnbfres2 { get; set; }
        public string? Pnbfreq3 { get; set; }
        public string? Pnbfres3 { get; set; }
        public string? Sereq { get; set; }
        public string? Seres { get; set; }
        public string? Others { get; set; }
        public DateTime? BookingDate { get; set; }
    }
}
