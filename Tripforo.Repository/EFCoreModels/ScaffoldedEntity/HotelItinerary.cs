using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class HotelItinerary
    {
        public int Counter { get; set; }
        public int? HotelId { get; set; }
        public int? HotelItineraryId { get; set; }
        public int? HotelNoOfDays { get; set; }
        public string? HotelItinerary1 { get; set; }
    }
}
