using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSmbpBbpspaymentOptional
    {
        public long OptionalId { get; set; }
        public string? AgentId { get; set; }
        public string? ClientRefId { get; set; }
        public string? Optional { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
