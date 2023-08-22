using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ReIssueIntl
    {
        public long Counter { get; set; }
        public string? PnrLocator { get; set; }
        public string? TktNo { get; set; }
        public string? Sector { get; set; }
        public string? FlightNo { get; set; }
        public string? Departure { get; set; }
        public string? Destination { get; set; }
        public string? Title { get; set; }
        public string? PaxFname { get; set; }
        public string? PaxLname { get; set; }
        public string? PaxType { get; set; }
        public string? BookingDate { get; set; }
        public string? DepartureDate { get; set; }
        public string? UserId { get; set; }
        public string? AgencyName { get; set; }
        public bool? BlockIssue { get; set; }
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
        public string? ReIssueCharge { get; set; }
        public string? ServiceCharge { get; set; }
        public string? FareDiff { get; set; }
        public string? RegardingIssue { get; set; }
        public string? Status { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string? ExecutiveId { get; set; }
        public string? Deptime { get; set; }
        public string? AirPnr { get; set; }
        public string? RejectionComment { get; set; }
        public string? Remark { get; set; }
        public string? Vc { get; set; }
        public string? OrderId { get; set; }
        public string? ReIssueId { get; set; }
        public string? Trip { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? AcceptDate { get; set; }
        public int? PaxId { get; set; }
        public string? Distrid { get; set; }
        public decimal? Scsrvtax { get; set; }
    }
}
