using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class GrpFlightDetail
    {
        public int Counter { get; set; }
        public string? RequestId { get; set; }
        public string? DepartureLocation { get; set; }
        public string? DepartureDate { get; set; }
        public string? DepartureTime { get; set; }
        public string? DepartureAirportCode { get; set; }
        public string? ArrivalLocation { get; set; }
        public string? ArrivalDate { get; set; }
        public string? ArrivalTime { get; set; }
        public string? ArrivalAirportCode { get; set; }
        public string? Aircode { get; set; }
        public string? FlightNumber { get; set; }
        public string? Stops { get; set; }
        public string? TripType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Sector { get; set; }
        public string? RefRequestId { get; set; }
        public string? FlightStatus { get; set; }
        public string? Flight { get; set; }
        public int? Sno { get; set; }
        public string? Vc { get; set; }
    }
}
