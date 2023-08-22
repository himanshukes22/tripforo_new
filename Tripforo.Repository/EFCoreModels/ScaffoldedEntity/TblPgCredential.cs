using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPgCredential
    {
        public int Counter { get; set; }
        public string? Provider { get; set; }
        public string? ProviderUrl { get; set; }
        public string? SuccessUrl { get; set; }
        public string? FailureUrl { get; set; }
        public string? MerchantId { get; set; }
        public string? MerchantKey { get; set; }
        public string? MerchantPswd { get; set; }
        public string? HashSequence { get; set; }
        public bool? Status { get; set; }
        public string? CancelUrl { get; set; }
        public string? WebServiceUrl { get; set; }
        public string? MercUnqRef { get; set; }
        public string? ChannelId { get; set; }
        public string? IndustryTypeId { get; set; }
        public string? Website { get; set; }
        public string? Txntype { get; set; }
        public string? Zppayoption { get; set; }
        public string? Purpose { get; set; }
        public string? ProductId { get; set; }
        public string? HashReqKey { get; set; }
        public string? AesreqKey { get; set; }
        public string? AesreqSaltIvkey { get; set; }
        public string? HashResKey { get; set; }
        public string? AesresKey { get; set; }
        public string? AesresSaltIvkey { get; set; }
        public string? PaymentMode { get; set; }
    }
}
