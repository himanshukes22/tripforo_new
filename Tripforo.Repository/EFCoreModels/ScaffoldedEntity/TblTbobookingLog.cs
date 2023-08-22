using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblTbobookingLog
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? OrderId { get; set; }
        public string? PnrNo { get; set; }
        public DateTime BookingDate { get; set; }
        public string? BookReq { get; set; }
        public string? BookRes { get; set; }
        public string? RePriceReq { get; set; }
        public string? RePriceRes { get; set; }
        public string? Others { get; set; }
    }
}
