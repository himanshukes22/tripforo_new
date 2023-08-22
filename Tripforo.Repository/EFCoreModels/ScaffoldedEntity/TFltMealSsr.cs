using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TFltMealSsr
    {
        public int Sno { get; set; }
        public string SsrCode { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? InternationalPrice { get; set; }
        public decimal? DomesticPrice { get; set; }
        public string? AircraftType { get; set; }
        public string? Vc { get; set; }
        public string? SsrCategory { get; set; }
        public decimal? FltDuration { get; set; }
        public string? SsrCat2 { get; set; }
        public bool? Enable { get; set; }
    }
}
