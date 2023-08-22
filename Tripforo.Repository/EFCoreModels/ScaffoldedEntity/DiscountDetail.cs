using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class DiscountDetail
    {
        public long DisId { get; set; }
        public string? Trip { get; set; }
        public int? Percentage { get; set; }
        public string? Agent { get; set; }
        public string? Star { get; set; }
        public string? City { get; set; }
        public DateTime SubmitDate { get; set; }
        public string? Status { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
