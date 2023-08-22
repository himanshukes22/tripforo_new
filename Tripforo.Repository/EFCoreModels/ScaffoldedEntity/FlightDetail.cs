using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FlightDetail
    {
        public int Counter { get; set; }
        public int? SegmentRef { get; set; }
        public int? FltRef { get; set; }
        public string? EftRef { get; set; }
        public string? McxRef { get; set; }
        public string? DateOfDeparture { get; set; }
        public string? TimeOfDeparture { get; set; }
        public string? DateOfArrival { get; set; }
        public string? TimeOfArrival { get; set; }
        public string? LocationId1 { get; set; }
        public string? LocationId2 { get; set; }
        public string? MarketingCarrier { get; set; }
        public string? OperatingCarrier { get; set; }
        public string? EquipmentType { get; set; }
        public int? FlightNumber { get; set; }
        public string? ElectronicTicketing { get; set; }
        public string? ProductDetailQualifier { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Searchvalue { get; set; }
        public string? Status { get; set; }
    }
}
