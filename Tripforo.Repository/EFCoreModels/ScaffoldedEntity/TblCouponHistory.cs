using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCouponHistory
    {
        public int Id { get; set; }
        public string? CouponOrderId { get; set; }
        public string? CouponCode { get; set; }
        public string? AgentId { get; set; }
        public string? TripType { get; set; }
        public decimal? AppliedAmount { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
