using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TFlightDetail
    {
        public int Sno { get; set; }
        public string? DepartLoc { get; set; }
        public string Requestid { get; set; } = null!;
        public string? ArrivalLoc { get; set; }
        public string? Flight { get; set; }
        public string? FlightNum { get; set; }
        public string? Airline { get; set; }
        public DateTime? Departdate { get; set; }
        public string? Departtime { get; set; }
        public DateTime? Arrvldate { get; set; }
        public int? ProbableDays { get; set; }
        public int? NoOfPsgr { get; set; }
        public string? TripType { get; set; }
        public string? DomOrIntl { get; set; }
        public string? Remarks { get; set; }
    }
}
