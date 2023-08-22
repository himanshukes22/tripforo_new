using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class RdspaymentResponse
    {
        public int Id { get; set; }
        public string? ReferenceNo { get; set; }
        public string? BankTxnId { get; set; }
        public string? EncryptedRes { get; set; }
        public string? DecryptedRes { get; set; }
        public string? PostHtml { get; set; }
        public string? Status { get; set; }
        public string? Remark { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
