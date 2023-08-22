using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCommon
    {
        public long Id { get; set; }
        public string? OrderId { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public string? RequestType { get; set; }
        public string? Service { get; set; }
        public string? Status { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
