using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAirLinePromoCode
    {
        public long CounterId { get; set; }
        public string? PromoCode { get; set; }
        public DateTime TravelPeriodFrom { get; set; }
        public DateTime TravelPeriodTo { get; set; }
        public DateTime BookingPeriodFrom { get; set; }
        public DateTime BookingPeriodTo { get; set; }
        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
        public string? Supplier { get; set; }
    }
}
