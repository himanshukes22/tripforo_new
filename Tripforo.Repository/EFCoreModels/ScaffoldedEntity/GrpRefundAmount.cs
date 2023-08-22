using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class GrpRefundAmount
    {
        public long Counter { get; set; }
        public string? RefRequestedId { get; set; }
        public string? RequestedId { get; set; }
        public DateTime? CanceledDate { get; set; }
        public string? CanceledBy { get; set; }
        public string? Remarks { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Journey { get; set; }
        public decimal? BookingFare { get; set; }
        public decimal? CancellationCharge { get; set; }
        public decimal? ServiceCharge { get; set; }
        public decimal? TotalRefund { get; set; }
        public string? Status { get; set; }
        public string? CancelStatus { get; set; }
        public decimal? PgCharge { get; set; }
        public string? PrevReissueId { get; set; }
        public string? JouneryDate { get; set; }
        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public int? Sno { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Trip { get; set; }
        public string? TripType { get; set; }
        public int? TotalPax { get; set; }
        public string? PaymentMode { get; set; }
        public decimal? Pgcharges { get; set; }
        public string? CancelRemarks { get; set; }
        public string? AgentId { get; set; }
        public string? RefundRequestId { get; set; }
        public string? BookingName { get; set; }
        public string? RefundedBy { get; set; }
        public DateTime? RefundedDate { get; set; }
        public string? RejectedBy { get; set; }
        public DateTime? RejectedDate { get; set; }
    }
}
