using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class LccTraceId
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? FlightInfo { get; set; }
        public string? TraceId { get; set; }
        public string? Pnr { get; set; }
        public DateTime BookingDate { get; set; }
        public string? BookReq { get; set; }
        public string? BookRes { get; set; }
    }
}
