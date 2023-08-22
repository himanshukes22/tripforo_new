using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FltHeader
    {
        public int HeaderId { get; set; }
        /// <summary>
        /// Unique referance number(8 digit)
        /// </summary>
        public string? OrderId { get; set; }
        /// <summary>
        /// Eg: DEL-LHR in case of Oneway and DEL-LHR-DEL in case of round trip
        /// </summary>
        public string? Sector { get; set; }
        /// <summary>
        /// Request,Hold,Confirm,Ticketed
        /// </summary>
        public string? Status { get; set; }
        /// <summary>
        /// Pending,Processed,Ticketed
        /// </summary>
        public string? MordifyStatus { get; set; }
        public string? GdsPnr { get; set; }
        public string? AirlinePnr { get; set; }
        public string? Vc { get; set; }
        /// <summary>
        /// Total Travel Duration
        /// </summary>
        public string? Duration { get; set; }
        /// <summary>
        /// Oneway(O), RoundTrip(R), Multicity(M)
        /// </summary>
        public string? TripType { get; set; }
        /// <summary>
        /// Domestic (D), International (I)
        /// </summary>
        public string? Trip { get; set; }
        public string? TourCode { get; set; }
        public decimal? TotalBookingCost { get; set; }
        public decimal? TotalAfterDis { get; set; }
        public decimal? Sfdis { get; set; }
        /// <summary>
        /// Markup amount after pnr creation
        /// </summary>
        public decimal? AdditionalMarkup { get; set; }
        /// <summary>
        /// Number of Adult
        /// </summary>
        public int? Adult { get; set; }
        /// <summary>
        /// Number of child
        /// </summary>
        public int? Child { get; set; }
        /// <summary>
        /// Number of infant
        /// </summary>
        public int? Infant { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public string? DistrId { get; set; }
        public string? ExecutiveId { get; set; }
        /// <summary>
        /// Credit limt (CL) or Credit card (CC)
        /// </summary>
        public string? PaymentType { get; set; }
        public string? PgTitle { get; set; }
        public string? PgFname { get; set; }
        public string? PgLname { get; set; }
        public string? PgMobile { get; set; }
        public string? PgEmail { get; set; }
        public string? Remark { get; set; }
        public string? RejectedRemark { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? ResuId { get; set; }
        public decimal? ResuCharge { get; set; }
        public decimal? ResuServiseCharge { get; set; }
        public decimal? ResuFareDiff { get; set; }
        public int? PaxId { get; set; }
        public decimal? ImportCharge { get; set; }
        public bool? Yflag { get; set; }
        public bool? Ycrn { get; set; }
        public bool? YCanFare { get; set; }
        public string? ProjectId { get; set; }
        public string? BillNoCorp { get; set; }
        public string? BookedBy { get; set; }
        public bool? IsMobile { get; set; }
        public string? FareType { get; set; }
        public string? ReferenceNo { get; set; }
        public string? Apiid { get; set; }
        public string? PartnerName { get; set; }
        public string? PreHoldRemark { get; set; }
        public string? PreHoldUpdatedBy { get; set; }
        public DateTime? PreholdUpdateDate { get; set; }
        public string? PaymentMode { get; set; }
        public string? PgTid { get; set; }
        public decimal? PgCharges { get; set; }
        public string? FareRule { get; set; }
        public bool? ReIssueRefundStatus { get; set; }
        public bool? Msent { get; set; }
        public string? Gstno { get; set; }
        public string? GstCompanyName { get; set; }
        public string? GstCompanyAddress { get; set; }
        public string? GstPhoneNo { get; set; }
        public string? GstEmail { get; set; }
        public string? Gstremark { get; set; }
        public string? SearchId { get; set; }
        public string? Pnrid { get; set; }
        public string? TicketId { get; set; }
        public decimal? HoldCharge { get; set; }
        public bool? IsHoldByAgent { get; set; }
        public DateTime? HoldDateTime { get; set; }
        public decimal? CreditNode { get; set; }
        public decimal? DebitNode { get; set; }
        public decimal? Gstdiff { get; set; }
        public DateTime? GstUpdateDateTime { get; set; }
        public bool? BookedByStaff { get; set; }
        public string? StaffId { get; set; }
        public string? CouponCode { get; set; }
    }
}
