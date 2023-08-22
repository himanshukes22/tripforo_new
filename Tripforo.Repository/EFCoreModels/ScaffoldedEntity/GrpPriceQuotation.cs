using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class GrpPriceQuotation
    {
        public int Counter { get; set; }
        public string? RequestId { get; set; }
        public decimal? QuotePrice { get; set; }
        public string? BkgPartnerName { get; set; }
        public string? Remarks { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? RefRequestId { get; set; }
        public string? ValidOffer { get; set; }
        public int? Sno { get; set; }
    }
}
