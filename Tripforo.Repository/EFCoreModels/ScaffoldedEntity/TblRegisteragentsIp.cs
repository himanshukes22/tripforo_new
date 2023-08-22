using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblRegisteragentsIp
    {
        public int Counter { get; set; }
        public string? AgentId { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? StrText { get; set; }
    }
}
