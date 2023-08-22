using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCharterFlightDetail
    {
        public int Counter { get; set; }
        public string? OrgDestFrom { get; set; }
        public string? OrgDestTo { get; set; }
        public string? DepartureLocation { get; set; }
        public string? DepartureCityName { get; set; }
        public string? ArrivalLocation { get; set; }
        public string? ArrivalCityName { get; set; }
        public string? DepartureDate { get; set; }
        public string? DepartureTime { get; set; }
        public string? ArrivalDate { get; set; }
        public string? ArrivalTime { get; set; }
        public string? MarketingCarrier { get; set; }
        public string? FlightNo { get; set; }
        public string? Rbd { get; set; }
        public string? ValidatingCarrier { get; set; }
        public decimal? TotalFare { get; set; }
        public decimal? BaseFare { get; set; }
        public decimal? Yq { get; set; }
        public decimal? Ot { get; set; }
        public string? AirlineName { get; set; }
        public string? Sector { get; set; }
        public string? Stops { get; set; }
        public bool? Status { get; set; }
        public string? FareType { get; set; }
        public string? Trip { get; set; }
        public decimal? InfTotalFare { get; set; }
        public decimal? InfBaseFare { get; set; }
        public decimal? InfYq { get; set; }
        public decimal? InfOt { get; set; }
        public decimal? SrvCharge { get; set; }
    }
}
