using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AirportInfo
    {
        public long Counter { get; set; }
        public string? Airportid { get; set; }
        public double? Runway { get; set; }
        public double? Latitudedeg { get; set; }
        public double? Latitudemin { get; set; }
        public double? Longitudedeg { get; set; }
        public double? Longitudemi { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public double? Zone { get; set; }
        public bool Major { get; set; }
        public double? Dst { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
