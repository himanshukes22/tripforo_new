using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSmbpresponseLog
    {
        public long ResponseId { get; set; }
        public string? PostUrl { get; set; }
        public string? RequestRemark { get; set; }
        public string? RequestJson { get; set; }
        public string? ResponseJson { get; set; }
        public string? ActionType { get; set; }
        public string? AgentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ClientRefId { get; set; }
    }
}
