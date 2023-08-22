using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgItinerary
    {
        public int PkgId { get; set; }
        public int? PkgItineraryId { get; set; }
        public string? PkgTitle { get; set; }
        public int? PkgItineraryNoOfDays { get; set; }
        public string? PkgItineraryDescription { get; set; }
    }
}
