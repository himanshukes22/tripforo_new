using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PgRefundAmount
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public string? ReferenceNo { get; set; }
        public string? RefundRefNo { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public decimal? RefundAmount { get; set; }
        public string? RefundRemark { get; set; }
        public string? ApiStatus { get; set; }
        public string? RefundStatus { get; set; }
        public string? FailureReason { get; set; }
        public string? ErrorCode { get; set; }
        public string? RequestJson { get; set; }
        public string? EncRequest { get; set; }
        public string? ResponseJson { get; set; }
        public string? EncResponse { get; set; }
        public string? OrderStatus { get; set; }
        public string? RefundFor { get; set; }
        public string? ServiceType { get; set; }
        public string? RefundedBy { get; set; }
        public DateTime? RefundedDate { get; set; }
        public int? PaxId { get; set; }
        public decimal? PgCharges { get; set; }
        public decimal? Tds { get; set; }
    }
}
