using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AmsAvailability
    {
        public int Counter { get; set; }
        public int? SegmentRef { get; set; }
        public int? Ref { get; set; }
        public string? Ref2 { get; set; }
        public string? Unitqualifier { get; set; }
        public string? Ref3 { get; set; }
        public string? Unitqualifier2 { get; set; }
        public string? DateDeparture { get; set; }
        public string? TimeDeparture { get; set; }
        public string? DateArr { get; set; }
        public string? TimeArr { get; set; }
        public string? Location1 { get; set; }
        public string? Terminal1 { get; set; }
        public string? Location2 { get; set; }
        public string? Terminal2 { get; set; }
        public string? MarketingC { get; set; }
        public string? OpretC { get; set; }
        public int? FlightNo { get; set; }
        public string? EqType { get; set; }
        public string? ETick { get; set; }
        public string? PDQua { get; set; }
        public string? Status { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Searchvalue { get; set; }
    }
}
