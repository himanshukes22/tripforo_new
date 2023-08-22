using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayInitiatePayout
    {
        public long InitiatePayoutId { get; set; }
        public string? AgentId { get; set; }
        public string? RemitterMobile { get; set; }
        public string? SpKey { get; set; }
        public string? BeneName { get; set; }
        public string? CreditAmount { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? EndpointIp { get; set; }
        public string? AlertMobile { get; set; }
        public string? AlertEmail { get; set; }
        public string? OtpAuth { get; set; }
        public string? Otp { get; set; }
        public string? Remarks { get; set; }
        public string? ExternalRef { get; set; }
        public string? IpayId { get; set; }
        public string? TransferValue { get; set; }
        public string? TypePricing { get; set; }
        public string? CommercialValue { get; set; }
        public string? ValueTds { get; set; }
        public string? Ccf { get; set; }
        public string? VendorCcf { get; set; }
        public string? ChargedAmt { get; set; }
        public string? PayoutCreditRefid { get; set; }
        public string? PayoutAccount { get; set; }
        public string? PayoutIfsc { get; set; }
        public string? PayoutName { get; set; }
        public string? Timestamp { get; set; }
        public string? IpayUuid { get; set; }
        public string? Orderid { get; set; }
        public string? Environment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? TrackId { get; set; }
        public string? Status { get; set; }
        public string? RemitterId { get; set; }
        public string? BankName { get; set; }
        public string? PaymentType { get; set; }
        public string? RemtRemark { get; set; }
        public string? LedgerAmount { get; set; }
        public string? BenificieryId { get; set; }
        public bool? Refund { get; set; }
        public bool? RefundId { get; set; }
    }
}
