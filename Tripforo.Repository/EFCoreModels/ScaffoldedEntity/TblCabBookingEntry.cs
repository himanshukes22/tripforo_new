using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCabBookingEntry
    {
        public int Sno { get; set; }
        public string? Name { get; set; }
        public string? MobileNo { get; set; }
        public string? PickUpCity { get; set; }
        public string? Location { get; set; }
        public string? DropLocation { get; set; }
        public string? PickUpAdd { get; set; }
        public string? PickUpDate { get; set; }
        public string? PickUpTime { get; set; }
        public DateTime? BookingDate { get; set; }
        public string? AgentId { get; set; }
        public string? Status { get; set; }
        public string? Comment { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Execid { get; set; }
        public string? TaxiBookingId { get; set; }
        public string? OrderId { get; set; }
        public string? DropAdd { get; set; }
        public decimal? MarkUpAmt { get; set; }
        public string? BookingRequest { get; set; }
        public string? BookingResponse { get; set; }
        public string? CancelRemarks { get; set; }
        public string? PayStatus { get; set; }
        public string? CustomerId { get; set; }
        public string? Distrid { get; set; }
    }
}
