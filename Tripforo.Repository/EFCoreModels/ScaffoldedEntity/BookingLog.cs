using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class BookingLog
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? BookReq { get; set; }
        public string? BookRes { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
