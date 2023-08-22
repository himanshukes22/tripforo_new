using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class DepositDetail
    {
        public int Counter { get; set; }
        public string? AgencyName { get; set; }
        public string? AgencyId { get; set; }
        public decimal? Amount { get; set; }
        public string? ModeOfPayment { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? AccountNo { get; set; }
        public string? ChequeNo { get; set; }
        public string? ChequeDate { get; set; }
        public string? TransactionId { get; set; }
        public string? BankAreaCode { get; set; }
        public string? DepositCity { get; set; }
        public string? DepositeDate { get; set; }
        public string? Remark { get; set; }
        public string? RemarkByAccounts { get; set; }
        public string? Status { get; set; }
        public string? AccountId { get; set; }
        public string? SalesExecId { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public DateTime? Date { get; set; }
        public string? UploadType { get; set; }
        public string? DepositeOffice { get; set; }
        public string? ConcernPerson { get; set; }
        public string? RecieptNo { get; set; }
        public string? BranchCode { get; set; }
        public string? AgentBankName { get; set; }
        public string? AgentType { get; set; }
        public DateTime? AcceptedDateTime { get; set; }
        public string? Distrid { get; set; }
        public string? InvoiceNo { get; set; }
        public bool? IsMobile { get; set; }
        public string? OtprefNo { get; set; }
        public string? FileUpload { get; set; }
    }
}
