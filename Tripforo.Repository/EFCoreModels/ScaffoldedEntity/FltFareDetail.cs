using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FltFareDetail
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
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Yflag { get; set; }
        public bool? Ycrn { get; set; }
        public bool? YCanFare { get; set; }
        public decimal? MgtFee { get; set; }
        public decimal? ServiceTax1 { get; set; }
        public decimal? Discount1 { get; set; }
        public string? FareType { get; set; }
        public decimal? In { get; set; }
        public decimal? Jn { get; set; }
        public decimal? Oc { get; set; }
        public decimal? Iatacommission { get; set; }
        public decimal? Cgst { get; set; }
        public decimal? Sgst { get; set; }
        public decimal? Utgst { get; set; }
        public decimal? Igst { get; set; }
        public decimal? K3 { get; set; }
        public decimal? F2 { get; set; }
        public decimal? G1 { get; set; }
        public decimal? Ym { get; set; }
        public decimal? SttotalDiscount { get; set; }
        public decimal? Stdiscount { get; set; }
        public decimal? StcashBack { get; set; }
        public decimal? Sttds { get; set; }
        public decimal? SttdsOn { get; set; }
        public decimal? Stdiscount1 { get; set; }
        public decimal? StnetFare { get; set; }
        public decimal? AgnetFare { get; set; }
        public decimal? AdnetFare { get; set; }
        public decimal? TicketcopymarkupforTax { get; set; }
        public decimal? TicketcopymarkupforTc { get; set; }
        public decimal? Gstdiff { get; set; }
        public DateTime? GstUpdateDateTime { get; set; }
    }
}
