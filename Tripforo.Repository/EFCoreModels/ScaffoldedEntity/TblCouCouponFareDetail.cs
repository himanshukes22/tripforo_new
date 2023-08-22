using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCouCouponFareDetail
    {
        public long Counter { get; set; }
        public string? CouPnr { get; set; }
        public string? FlightNo { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; }
        public string? DepartureDate { get; set; }
        public string? AdultFare { get; set; }
        public string? ChildFare { get; set; }
        public string? InfantFare { get; set; }
        public decimal? TotalFare { get; set; }
        public decimal? PortalFare { get; set; }
        public string? FltDepart { get; set; }
        public string? FltArr { get; set; }
        public string? Via { get; set; }
        public string? TrackId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? RowId { get; set; }
    }
}
