using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Rdspayment
    {
        public int Id { get; set; }
        public string? ReferenceNo { get; set; }
        public string? BankTxnId { get; set; }
        public string? MerchantCode { get; set; }
        public string? ReservationId { get; set; }
        public string? UserId { get; set; }
        public string? AgencyId { get; set; }
        public string? DistrId { get; set; }
        public string? AgencyName { get; set; }
        public decimal? TxnAmount { get; set; }
        public string? CurrencyType { get; set; }
        public string? Status { get; set; }
        public int? StatusFlag { get; set; }
        public string? ReturnUrl { get; set; }
        public string? AppCode { get; set; }
        public string? PymtMode { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
