using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ExecIpaddress
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? Ipaddress { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Iplocation { get; set; }
        public bool? Status { get; set; }
    }
}
