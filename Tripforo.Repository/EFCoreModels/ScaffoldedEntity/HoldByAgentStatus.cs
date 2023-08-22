using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class HoldByAgentStatus
    {
        public int Id { get; set; }
        public string? ServiceType { get; set; }
        public string? OrderId { get; set; }
        public string? AgencyId { get; set; }
        public string? UserId { get; set; }
        public string? AgencyName { get; set; }
        public string? Status { get; set; }
        public string? Remark { get; set; }
        public string? RejectRemark { get; set; }
        public string? ExecutiveId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? IpAddress { get; set; }
    }
}
