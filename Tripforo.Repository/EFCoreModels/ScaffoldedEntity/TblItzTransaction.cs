using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblItzTransaction
    {
        public long Id { get; set; }
        public string? Orderid { get; set; }
        public string? AmtToDed { get; set; }
        public string? AmtToCre { get; set; }
        public string? CommissionItz { get; set; }
        public string? ConveniencefeeItz { get; set; }
        public string? EasyOrderidItz { get; set; }
        public string? EasyTranCodeItz { get; set; }
        public string? DecodeItz { get; set; }
        public string? B2cMblNoItz { get; set; }
        public string? RateGroupItz { get; set; }
        public string? SerialNoFrom { get; set; }
        public string? SerialNoTo { get; set; }
        public string? ServiceTaxItz { get; set; }
        public string? TdsItz { get; set; }
        public string? TotalAmtDedItz { get; set; }
        public string? UserNameItz { get; set; }
        public string? RefundTypeItz { get; set; }
        public string? TransType { get; set; }
        public string? AvailableBalItz { get; set; }
        public string? AccTypeNameItz { get; set; }
        public string? MessageItz { get; set; }
        public string? MerchantKeyItz { get; set; }
        public string? ErrorCodeItz { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
