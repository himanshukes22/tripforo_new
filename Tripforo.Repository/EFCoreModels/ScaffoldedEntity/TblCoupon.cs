using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCoupon
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? Trip { get; set; }
        public string? AgentId { get; set; }
        public decimal? Amount { get; set; }
        public string? Org { get; set; }
        public string? Dest { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CouponOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string? MarkupType { get; set; }
        public string? CouponOnPaxWise { get; set; }
        public string? CouponCode { get; set; }
        public string? TravelType { get; set; }
        public int? CouponCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Ex1 { get; set; }
        public string? Ex2 { get; set; }
    }
}
