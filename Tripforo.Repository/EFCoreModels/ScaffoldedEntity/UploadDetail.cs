using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class UploadDetail
    {
        public int Counter { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string? Remark { get; set; }
        public string? UpdatedRemark { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public string? AccId { get; set; }
        public string? UpdatedAccId { get; set; }
        public string? YtrRcptNo { get; set; }
        public string? Ipaddress { get; set; }
        public string? UploadType { get; set; }
        public string? LastAvlBal { get; set; }
        public string? CurrAvlBal { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? TransactionIdorChequeNo { get; set; }
        public string? DepositeBankName { get; set; }
        public string? RemarkSales { get; set; }
        public decimal? Amount { get; set; }
        public bool? DebitPortalBalance { get; set; }
        public DateTime? UpdatedDateSales { get; set; }
        public string? Distrid { get; set; }
        public string? InvoiceNo { get; set; }
        public string? BankName { get; set; }
        public string? BankCode { get; set; }
        public string? Narration { get; set; }
        public string? ModuleType { get; set; }
        public decimal? DueAmount { get; set; }
        public decimal? CreditLimit { get; set; }
    }
}
