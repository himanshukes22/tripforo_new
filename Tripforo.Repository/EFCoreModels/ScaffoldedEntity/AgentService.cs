using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AgentService
    {
        public int? AgentIndex { get; set; }
        public string? UserName { get; set; }
        public bool IsFlight { get; set; }
        public bool IsHotel { get; set; }
        public bool IsActivity { get; set; }
        public bool IsCruise { get; set; }
        public bool IsSightSeeing { get; set; }
        public bool IsTransfer { get; set; }
        public bool IsPackage { get; set; }
        public bool? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
