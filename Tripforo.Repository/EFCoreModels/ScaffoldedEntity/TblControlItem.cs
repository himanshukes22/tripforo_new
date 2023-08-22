using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblControlItem
    {
        public int ItemId { get; set; }
        public int? ControlId { get; set; }
        public string? ItemTitle { get; set; }
        public string? ItemSubTitle { get; set; }
        public decimal? Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? LinkedUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdateBy { get; set; }
        public string? ControlName { get; set; }
    }
}
