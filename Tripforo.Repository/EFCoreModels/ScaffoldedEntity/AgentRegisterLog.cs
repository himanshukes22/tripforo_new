using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AgentRegisterLog
    {
        public int Counter { get; set; }
        public DateTime TimestampCreate { get; set; }
        public string? Title { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Zipcode { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? AltEmail { get; set; }
        public string? FaxNo { get; set; }
        public string? AgencyName { get; set; }
        public string? Website { get; set; }
        public string? PanNo { get; set; }
        public string? Status { get; set; }
        public string? StaxNo { get; set; }
        public string? Remark { get; set; }
        public string? SecQes { get; set; }
        public string? SecAns { get; set; }
        public string? UserId { get; set; }
        public string? Pwd { get; set; }
        public string? AgentType { get; set; }
        public decimal? CrdLimit { get; set; }
        public DateTime? CrdTrnsDate { get; set; }
        public string? Distr { get; set; }
        public string? AgLogo { get; set; }
        public string? AgentStatus { get; set; }
        public string? Tds { get; set; }
        public string? OnlineTkt { get; set; }
        public string? SalesExecId { get; set; }
        public decimal? ExmptTds { get; set; }
        public decimal? ExmptTdsLimit { get; set; }
        public string? NavId { get; set; }
        public string? YId { get; set; }
        public bool? IsCorp { get; set; }
        public bool? IsPwd { get; set; }
        public string? DecodeItz { get; set; }
        public string? MerchantKeyItz { get; set; }
        public string? PwdItz { get; set; }
        public string? LastLoginItz { get; set; }
        public string? ModeTypeItz { get; set; }
        public string? SvcTypeItz { get; set; }
        public string? District { get; set; }
        public string? StateCode { get; set; }
        public string? Gstno { get; set; }
        public string? GstCompanyName { get; set; }
        public string? GstCompanyAddress { get; set; }
        public string? GstPhoneNo { get; set; }
        public string? GstEmail { get; set; }
        public bool? IsGstApply { get; set; }
        public string? Gstremark { get; set; }
        public DateTime? GstUpdateDate { get; set; }
        public string? GstCity { get; set; }
        public string? GstState { get; set; }
        public string? GstStateCode { get; set; }
        public string? GstPincode { get; set; }
        public string? AgencyId { get; set; }
        public decimal? AgentLimit { get; set; }
        public DateTime? AgentLimitTrnsDate { get; set; }
        public decimal? DueAmount { get; set; }
        public DateTime? DueAmtTrnsDate { get; set; }
        public decimal? VirtualCreditLimit { get; set; }
        public DateTime? VirtualFromDate { get; set; }
        public DateTime? VirtualToDate { get; set; }
        public DateTime? VirtualCreditTrnsDate { get; set; }
        public bool? IsWhiteLabel { get; set; }
        public decimal? StockistCrdLimit { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdateBy { get; set; }
    }
}
