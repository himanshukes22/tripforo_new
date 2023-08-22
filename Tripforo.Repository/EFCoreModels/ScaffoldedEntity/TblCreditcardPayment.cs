using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCreditcardPayment
    {
        public int Counter { get; set; }
        public string? Name { get; set; }
        public string? TrackId { get; set; }
        public string? PaymentGateway { get; set; }
        public string? PaymentId { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public decimal? Amount { get; set; }
        public decimal? OriginalAmount { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public string? Status { get; set; }
        public string? Ip { get; set; }
        public string? ResponseMessage { get; set; }
        public string? ResponseCode { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? ErrorText { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Tid { get; set; }
        public string? IbtrackId { get; set; }
        public string? ServiceType { get; set; }
        public string? BankRefNo { get; set; }
        public decimal? PgAmount { get; set; }
        public string? Trip { get; set; }
        public string? ApiStatus { get; set; }
        public string? PaymentMode { get; set; }
        public string? CardName { get; set; }
        public string? OfferType { get; set; }
        public string? OfferCode { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? MerAamount { get; set; }
        public decimal? TotalCharges { get; set; }
        public decimal? TransCharges { get; set; }
        public string? ChargesType { get; set; }
        public string? CardType { get; set; }
        public string? IssuingBank { get; set; }
        public string? CardNumber { get; set; }
        public string? UnmappedStatus { get; set; }
        public string? CreditLimitUpdate { get; set; }
        public DateTime? CreditUpdateDate { get; set; }
        public string? AgencyId { get; set; }
        public string? Pgmode { get; set; }
    }
}
