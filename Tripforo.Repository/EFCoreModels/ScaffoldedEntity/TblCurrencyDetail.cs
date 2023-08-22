using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCurrencyDetail
    {
        public long Id { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
        public string? CurrancyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
        public string? Tccode { get; set; }
        public bool? Active { get; set; }
        public string? Ipaddress { get; set; }
        public string? CurrencyName { get; set; }
        public string? Symbol { get; set; }
    }
}
