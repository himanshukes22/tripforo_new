using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Cancellation
    {
        public long Counter { get; set; }
        public string? PnrLocator { get; set; }
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
        public string? UserId { get; set; }
        public string? AgencyName { get; set; }
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
        public int? RefundFare { get; set; }
        public string? RegardingCancel { get; set; }
        public string? Status { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string? ExecutiveId { get; set; }
        public string? RejectComment { get; set; }
        public string? Vc { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public string? ExecutiveRemark { get; set; }
        public string? UpdateRemark { get; set; }
    }
}
