using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AgentVisaQuery
    {
        public int Counter { get; set; }
        public string? QueryId { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Query { get; set; }
        public string? Destination { get; set; }
        public string? Status { get; set; }
        public string? ExcutiveId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
