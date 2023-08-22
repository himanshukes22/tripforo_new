using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Otphistory
    {
        public int Id { get; set; }
        public string? Otpid { get; set; }
        public string? UserId { get; set; }
        public string? AgencyId { get; set; }
        public string? Otp { get; set; }
        public bool? Status { get; set; }
        public string? MobileNo { get; set; }
        public bool? Mstatus { get; set; }
        public string? EmailId { get; set; }
        public bool? EmailStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? Ipaddress { get; set; }
        public string? Remark { get; set; }
    }
}
