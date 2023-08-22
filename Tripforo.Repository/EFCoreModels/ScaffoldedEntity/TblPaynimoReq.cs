using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPaynimoReq
    {
        public long Counter { get; set; }
        public string? AgentId { get; set; }
        public string? RequestType { get; set; }
        public string? MerchantCode { get; set; }
        public string? MerchantTxnRefNumber { get; set; }
        public string? Itc { get; set; }
        public string? Amount { get; set; }
        public string? CurrencyCode { get; set; }
        public string? UniqueCustomerId { get; set; }
        public string? ReturnUrl { get; set; }
        public string? S2sreturnUrl { get; set; }
        public string? TpsltxnId { get; set; }
        public string? ShoppingCartDetails { get; set; }
        public string? TxnDate { get; set; }
        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? BankCode { get; set; }
        public string? CustomerName { get; set; }
        public string? CardId { get; set; }
        public string? AccountNo { get; set; }
        public string? IsKey { get; set; }
        public string? IsIv { get; set; }
        public string? Provider { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
