using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblTaxiBookingMarkupDetail
    {
        public int Counter { get; set; }
        public string? AgentId { get; set; }
        public string? AgentType { get; set; }
        public string? ApplicableOn { get; set; }
        public decimal? MarkingAmountOnId { get; set; }
        public decimal? MarkingAmountOnType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string? DiscountMarkupType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
