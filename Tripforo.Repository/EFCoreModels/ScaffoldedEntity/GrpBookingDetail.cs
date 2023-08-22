using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class GrpBookingDetail
    {
        public int Counter { get; set; }
        public string? RequestId { get; set; }
        public string? TripType { get; set; }
        public string? Trip { get; set; }
        public int? NoOfPax { get; set; }
        public int? AdultCount { get; set; }
        public int? ChildCount { get; set; }
        public int? InfantCount { get; set; }
        public string? ServiceType { get; set; }
        public decimal? ExpactedPrice { get; set; }
        public string? PaymentStatus { get; set; }
        public string? Remarks { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? BookedPrice { get; set; }
        public decimal? BalancePrice { get; set; }
        public string? BkgPartnerName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UserType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? ProbableDays { get; set; }
        public string? Gdspnr { get; set; }
        public string? Airlinepnr { get; set; }
        public string? Status { get; set; }
        public decimal? ProcessingFee { get; set; }
        public decimal? RefundedBalance { get; set; }
        public string? RefundedId { get; set; }
        public string? ExecutiveId { get; set; }
        public bool? IsPaxDeatils { get; set; }
        public string? OrequestId { get; set; }
        public decimal? ObookSelectedPrice { get; set; }
        public decimal? RbookSelectedPrice { get; set; }
        public string? RrequestId { get; set; }
        public string? BookingName { get; set; }
        public string? AcceptBy { get; set; }
        public string? RejectBy { get; set; }
        public bool? IsActive { get; set; }
        public string? PaymentLink { get; set; }
        public string? PaymentMode { get; set; }
        public string? PgTid { get; set; }
        public decimal? PgCharges { get; set; }
        public int? Sno { get; set; }
        public string? GdspnrInbond { get; set; }
        public string? AirlineInbond { get; set; }
        public string? CancellationRemarks { get; set; }
        public DateTime? AcceptDate { get; set; }
        public DateTime? RejectDate { get; set; }
        public string? QuotedBy { get; set; }
        public DateTime? QuotedDate { get; set; }
        public string? FreezedBy { get; set; }
        public DateTime? FreezedDate { get; set; }
        public string? PayementBy { get; set; }
        public DateTime? PayementDate { get; set; }
        public string? TicketedBy { get; set; }
        public DateTime? TicketedDate { get; set; }
        public string? CancelledBy { get; set; }
        public DateTime? CancelledDate { get; set; }
    }
}
