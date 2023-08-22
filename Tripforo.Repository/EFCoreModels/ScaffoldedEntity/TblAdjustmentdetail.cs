using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAdjustmentdetail
    {
        public int Counter { get; set; }
        public string? Invoiceno { get; set; }
        public string? Agentid { get; set; }
        public string? Agencyname { get; set; }
        public string? Bankname { get; set; }
        public string? Bankcode { get; set; }
        public decimal? Amount { get; set; }
        public int? Cifcounter { get; set; }
        public string? Remark { get; set; }
        public string? Uploadtype { get; set; }
        public string? Accountid { get; set; }
        public DateTime? Createddate { get; set; }
        public string? Narration { get; set; }
    }
}
