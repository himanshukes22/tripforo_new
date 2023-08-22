using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblLcccouponbookinglog
    {
        public long Counter { get; set; }
        public string? Trackid { get; set; }
        public string? Sessionid { get; set; }
        public string? BookingRequest { get; set; }
        public string? BookingResponse { get; set; }
        public string? Agentid { get; set; }
        public DateTime? BookingDate { get; set; }
    }
}
