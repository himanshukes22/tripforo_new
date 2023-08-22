using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AdvAvailability
    {
        public string? DestFrom { get; set; }
        public string? DestTo { get; set; }
        public string? DepartureDate { get; set; }
        public string? DepartureTime { get; set; }
        public string? ArrivalDate { get; set; }
        public string? ArrivalTime { get; set; }
        public string? MarketingCompany { get; set; }
        public string? FlightIdentification { get; set; }
        public string? LineItemNumber { get; set; }
        public string? ServiceClass { get; set; }
        public string? Searchvalue { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
