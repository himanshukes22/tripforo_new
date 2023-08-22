using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AmsRecommdationNew
    {
        public int Counter { get; set; }
        public int? ItemNo { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Tax { get; set; }
        public string? Depno1 { get; set; }
        public string? Depno2 { get; set; }
        public string? Depno3 { get; set; }
        public string? PaxFareNumDep { get; set; }
        public string? TotalFareAmount { get; set; }
        public string? TotalTaxAmount { get; set; }
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
