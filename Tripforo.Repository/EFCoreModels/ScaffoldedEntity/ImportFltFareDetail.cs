using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ImportFltFareDetail
    {
        public int FareId { get; set; }
        public string? OrderId { get; set; }
        public decimal? BaseFare { get; set; }
        public decimal? Yq { get; set; }
        public decimal? Yr { get; set; }
        public decimal? Wo { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Qtax { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? TotalFare { get; set; }
        public decimal? ServiceTax { get; set; }
        public decimal? TranFee { get; set; }
        public decimal? AdminMrk { get; set; }
        public decimal? AgentMrk { get; set; }
        public decimal? DistrMrk { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? Plb { get; set; }
        public decimal? Discount { get; set; }
        public decimal? CashBack { get; set; }
        public decimal? Tds { get; set; }
        public decimal? TdsOn { get; set; }
        public decimal? TotalAfterDis { get; set; }
        public decimal? AvlBalance { get; set; }
        public string? PaxType { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Yflag { get; set; }
        public bool? Ycrn { get; set; }
        public bool? YCanFare { get; set; }
        public decimal? MgtFee { get; set; }
        public decimal? ServiceTax1 { get; set; }
        public decimal? Discount1 { get; set; }
        public string? FareType { get; set; }
        public decimal? Gst { get; set; }
    }
}
