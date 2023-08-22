using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FlightBooking
    {
        public int Counter { get; set; }
        public string? PnrLocator { get; set; }
        public string? Sector { get; set; }
        public string? DeptDate { get; set; }
        public string? RetDate { get; set; }
        public string? Departure { get; set; }
        public string? Destination { get; set; }
        public string? DepartureDate { get; set; }
        public string? DepartureTime { get; set; }
        public string? ArrivalDate { get; set; }
        public string? ArrivalTime { get; set; }
        public string? FlightNo { get; set; }
        public string? Airline { get; set; }
        public DateTime? BookingDate { get; set; }
        public string? TotalNoAdult { get; set; }
        public string? TotalNoChild { get; set; }
        public string? TotalNoInfant { get; set; }
        public string? TotalAdult { get; set; }
        public string? AdultTax { get; set; }
        public string? TotalChild { get; set; }
        public string? ChildTax { get; set; }
        public string? TotalInfant { get; set; }
        public string? InfantTax { get; set; }
        public string? TotalBookingCost { get; set; }
        public string? PnrStatus { get; set; }
        public string? UserId { get; set; }
        public string? PaxFname { get; set; }
        public string? PaxLname { get; set; }
        public string? PaxAddress { get; set; }
        public string? PaxCity { get; set; }
        public string? PaxState { get; set; }
        public string? PaxCountry { get; set; }
        public string? PaxPin { get; set; }
        public string? PaxMobile { get; set; }
        public string? PaxEmail { get; set; }
        public string? CardType { get; set; }
        public string? CardNumber { get; set; }
        public string? Expression { get; set; }
        public string? Cvv { get; set; }
        public string? Distributor { get; set; }
        public string? AirPnr { get; set; }
        public string? Class { get; set; }
        public string? TFee { get; set; }
        public string? STax { get; set; }
        public string? TktExe { get; set; }
        public string? AgName { get; set; }
        public string? PaymentType { get; set; }
        public string? AgentMrk { get; set; }
        public string? TourCode { get; set; }
        public string? ReIssueCharge { get; set; }
        public string? ServiceCharge { get; set; }
        public string? FareDiff { get; set; }
        public string? Vc { get; set; }
    }
}
