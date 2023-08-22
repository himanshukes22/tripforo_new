using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class CommissionNewBak
    {
        public int Id { get; set; }
        public string? GroupType { get; set; }
        public string? AirlineCode { get; set; }
        public string? AirlineName { get; set; }
        public string? TripType { get; set; }
        public string? TripTypeName { get; set; }
        public decimal? CommisionOnBasic { get; set; }
        public decimal? CommissionOnYq { get; set; }
        public decimal? CommisionOnBasicYq { get; set; }
        public decimal? PlbOnBasic { get; set; }
        public decimal? PlbOnBasicYq { get; set; }
        public decimal? CashBackAmt { get; set; }
        public string? BookingFromDate { get; set; }
        public string? BookingToDate { get; set; }
        public string? OnwardTravelFromDate { get; set; }
        public string? OnwardTravelToDate { get; set; }
        public string? ReturnTravelFromDate { get; set; }
        public string? ReturnTravelToDate { get; set; }
        public string? BookingClassInclude { get; set; }
        public string? BookingClassExclude { get; set; }
        public string? FareBasisInclude { get; set; }
        public string? FareBasisExclude { get; set; }
        public string? OrginAirportInclude { get; set; }
        public string? OrginAirportExclude { get; set; }
        public string? DestinationAirportInclude { get; set; }
        public string? DestinationAirportExclude { get; set; }
        public string? FlightNoInclude { get; set; }
        public string? FlightNoExclude { get; set; }
        public string? OperatingCarrierInclude { get; set; }
        public string? OperatingCarrierExclude { get; set; }
        public string? MarketingCarrierInclude { get; set; }
        public string? MarketingCarrierExclude { get; set; }
        public string? CabinClassInclude { get; set; }
        public string? CabinClassExclude { get; set; }
        public string? FareType { get; set; }
        public string? FareTypeName { get; set; }
        public string? BookingChannel { get; set; }
        public string? OriginCountryInclude { get; set; }
        public string? OriginCountryExclude { get; set; }
        public string? DestCountryInclude { get; set; }
        public string? DestCountryExclude { get; set; }
        public bool? Active { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? RestrictionOn { get; set; }
        public string? Ppptype { get; set; }
        public string? AgentId { get; set; }
        public string? Distr { get; set; }
        public int? Idbk { get; set; }
    }
}
