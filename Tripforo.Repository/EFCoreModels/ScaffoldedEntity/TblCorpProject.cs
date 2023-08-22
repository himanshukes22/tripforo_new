using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCorpProject
    {
        public int Counter { get; set; }
        public string? AgentId { get; set; }
        public string? ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
