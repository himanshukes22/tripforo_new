using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgBooking
    {
        public int Counter { get; set; }
        public int? PkgId { get; set; }
        public int? HotelId { get; set; }
        public string? PkgTitle { get; set; }
        public string? PkgLocation { get; set; }
        public decimal? PkgPrice { get; set; }
        public string? PkgHotelName { get; set; }
        public string? PkgHotelLocation { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public string? Address { get; set; }
        public string? AdditonalNotes { get; set; }
        public DateTime? BookingDate { get; set; }
    }
}
