using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSeat
    {
        public int Counter { get; set; }
        public long? PaxId { get; set; }
        public string? OrderId { get; set; }
        public string? SeatDesignator { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public string? Vc { get; set; }
        public string? FlightNumber { get; set; }
        public string? FlightTime { get; set; }
        public int? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? SeatAlignment { get; set; }
        public string? Ref { get; set; }
        public bool? Paid { get; set; }
        public string? Carrier { get; set; }
        public string? ClassOfService { get; set; }
        public string? Equipment { get; set; }
        public string? GroupNo { get; set; }
        public bool? IsSeat { get; set; }
        public string? SeatStatus { get; set; }
        public int? IsMaxSeat { get; set; }
        public string? MaxSeatSsrcode { get; set; }
        public string? SsrrefNo { get; set; }
        public string? RefNo { get; set; }
    }
}
