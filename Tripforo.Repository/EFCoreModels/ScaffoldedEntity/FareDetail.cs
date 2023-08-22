using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FareDetail
    {
        public int Counter { get; set; }
        public int? ItemNo { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalTax { get; set; }
        public string? Depno { get; set; }
        public string? PaxFareNumDep { get; set; }
        public string? AdtFareAmount { get; set; }
        public string? AdtFareTax { get; set; }
        public string? Searchvalue { get; set; }
        public string? Childfareamount { get; set; }
        public string? Childamounttax { get; set; }
        public string? Infantfareamount { get; set; }
        public string? Infantamounttax { get; set; }
        public string? Cls { get; set; }
        public string? Avlstatus { get; set; }
        public string? Segment { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Company { get; set; }
        public string? FareBasis { get; set; }
        public string? Fbpaxtype { get; set; }
    }
}
