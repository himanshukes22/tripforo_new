using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class SmsEmailMaster
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? MobileNo { get; set; }
        public bool? SmsStatus { get; set; }
        public string? EmailId { get; set; }
        public bool? EmaliStatus { get; set; }
        public bool? Status { get; set; }
        public string? Remark { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
