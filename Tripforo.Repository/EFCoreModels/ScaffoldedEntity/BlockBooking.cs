using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class BlockBooking
    {
        public int Id { get; set; }
        public string? Src { get; set; }
        public string? Dest { get; set; }
        public string? Airline { get; set; }
        public string? AirlineNo { get; set; }
        public decimal? FarePerPax { get; set; }
        public string? TravelDateStart { get; set; }
        public string? TravelDateEnd { get; set; }
        public string? ValidityEndDate { get; set; }
        public bool? IsActive { get; set; }
        public string? Trip { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
