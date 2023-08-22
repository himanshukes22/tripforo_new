using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class LccBookingLog
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? OrderId { get; set; }
        public string? PnrNo { get; set; }
        public DateTime BookingDate { get; set; }
        public string? BookReq { get; set; }
        public string? BookRes { get; set; }
        public string? AddPayReq { get; set; }
        public string? AddPayRes { get; set; }
        public string? ConfirmPayRes { get; set; }
        public string? Sjkreq { get; set; }
        public string? Sjkres { get; set; }
        public string? Uppaxreq { get; set; }
        public string? Uppaxres { get; set; }
        public string? Apbreq { get; set; }
        public string? Apbres { get; set; }
        public string? Others { get; set; }
        public string? Ucconreq { get; set; }
        public string? Ucconres { get; set; }
        public string? Statereq { get; set; }
        public string? Stateres { get; set; }
        public string? Sbreq { get; set; }
        public string? Sbres { get; set; }
    }
}
