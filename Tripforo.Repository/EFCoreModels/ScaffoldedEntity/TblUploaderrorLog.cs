using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblUploaderrorLog
    {
        public int Counter { get; set; }
        public string? Agentid { get; set; }
        public string? Agencyname { get; set; }
        public string? Invoiceno { get; set; }
        public string? Accountid { get; set; }
        public string? Ip { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public string? Bookingtype { get; set; }
        public string? Remark { get; set; }
        public string? Uploadtype { get; set; }
        public double? AvlBalance { get; set; }
        public string? Error { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
