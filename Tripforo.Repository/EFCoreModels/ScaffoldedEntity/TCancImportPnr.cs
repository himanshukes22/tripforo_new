using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TCancImportPnr
    {
        public long Counter { get; set; }
        public string? PnrLocator { get; set; }
        public string? OrderId { get; set; }
        public string? TktNo { get; set; }
        public string? Sector { get; set; }
        public string? Departure { get; set; }
        public string? Destination { get; set; }
        public string? Title { get; set; }
        public string? PaxFname { get; set; }
        public string? PaxLname { get; set; }
        public string? PaxType { get; set; }
        public string? BookingDate { get; set; }
        public string? DepartureDate { get; set; }
        public string? CorpId { get; set; }
        public string? CorpName { get; set; }
        public string? EntityId { get; set; }
        public string? EntityName { get; set; }
        public string? CorpType { get; set; }
        public bool? BlockCancel { get; set; }
        public string? BaseFare { get; set; }
        public string? Tax { get; set; }
        public string? Yq { get; set; }
        public string? ServiceTax { get; set; }
        public string? TranFees { get; set; }
        public string? Discount { get; set; }
        public string? Cb { get; set; }
        public string? Tds { get; set; }
        public string? TotalFare { get; set; }
        public string? TotalFareAfterDiscount { get; set; }
        public int? CancellationCharge { get; set; }
        public int? ServiceCharge { get; set; }
        public decimal? RefundFare { get; set; }
        public string? RegardingCancel { get; set; }
        public string? Status { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string? ExecutiveId { get; set; }
        public string? RejectComment { get; set; }
        public string? Vc { get; set; }
        public string? Trip { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? DepTime { get; set; }
        public string? ArrTime { get; set; }
        public string? AirLinePnr { get; set; }
        public string? RefundId { get; set; }
        public int? PaxId { get; set; }
        public string? FlightNo { get; set; }
        public DateTime? AcceptDate { get; set; }
        public string? RequestRemarks { get; set; }
        public string? UpdateRemark { get; set; }
        public bool? Yflag { get; set; }
        public string? ProjectId { get; set; }
        public decimal? MgtFee { get; set; }
        public string? CancelledBy { get; set; }
        public string? BillNoCorp { get; set; }
        public string? BillNoAir { get; set; }
        public string? Distrid { get; set; }
        public decimal? Scsrvtax { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreditNoteNo { get; set; }
        public string? Segments { get; set; }
        public string? RefNo { get; set; }
        public string? Ipaddress { get; set; }
        public string? Taid { get; set; }
        public string? Tauserid { get; set; }
        public string? Error { get; set; }
        public decimal? OnlineRefAmount { get; set; }
        public decimal? Yr { get; set; }
        public decimal? Wo { get; set; }
        public decimal? In { get; set; }
        public decimal? Jn { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Adminmrk { get; set; }
        public decimal? MsCgst { get; set; }
        public decimal? MsSgst { get; set; }
        public decimal? MsIgst { get; set; }
        public decimal? BfCgst { get; set; }
        public decimal? BfSgst { get; set; }
        public decimal? BfIgst { get; set; }
        public decimal? YqCgst { get; set; }
        public decimal? YqSgst { get; set; }
        public decimal? YqIgst { get; set; }
        public decimal? YrCgst { get; set; }
        public decimal? YrSgst { get; set; }
        public decimal? YrIgst { get; set; }
        public decimal? Octax { get; set; }
        public decimal? ScCgst { get; set; }
        public decimal? ScSgst { get; set; }
        public decimal? ScIgst { get; set; }
    }
}
