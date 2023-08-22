using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Otptransaction
    {
        public int Id { get; set; }
        public string? RefNo { get; set; }
        public string? ServiceType { get; set; }
        public string? Otp { get; set; }
        public string? Otpid { get; set; }
        public string? Otpmobile { get; set; }
        public string? Otpemail { get; set; }
        public string? UserId { get; set; }
        public string? AgencyId { get; set; }
        public string? DistrId { get; set; }
        public string? Ipaddress { get; set; }
        public string? Remark { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? OtpcreatedBy { get; set; }
        public string? CreatedBy { get; set; }
    }
}
