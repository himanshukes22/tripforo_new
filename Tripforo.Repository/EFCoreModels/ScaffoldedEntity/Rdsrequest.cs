using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Rdsrequest
    {
        public int Id { get; set; }
        public string? ReferenceNo { get; set; }
        public string? MerchantCode { get; set; }
        public string? ReservationId { get; set; }
        public decimal? TxnAmount { get; set; }
        public string? CurrencyType { get; set; }
        public string? AppCode { get; set; }
        public string? PymtMode { get; set; }
        public string? TxnDate { get; set; }
        public string? SecurityId { get; set; }
        public string? Ru { get; set; }
        public string? CheckSum { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
