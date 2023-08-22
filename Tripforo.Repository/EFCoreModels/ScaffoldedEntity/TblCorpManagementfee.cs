using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCorpManagementfee
    {
        public long Counter { get; set; }
        public string? Type { get; set; }
        public string? Airlinecode { get; set; }
        public string? Airlinename { get; set; }
        public decimal? Mgtonbasic { get; set; }
        public decimal? Mgtonyq { get; set; }
        public decimal? Mgtonbasicyq { get; set; }
        public decimal? Mgtontotal { get; set; }
        public string? Trip { get; set; }
        public DateTime? Updateddate { get; set; }
        public DateTime? Cretaeddate { get; set; }
    }
}
