using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ExpiryCreditLimitHistory
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? AgencyId { get; set; }
        public decimal? OldCrdLimit { get; set; }
        public decimal? NewCrdLimit { get; set; }
        public decimal? OldAgentLimit { get; set; }
        public decimal? NewAgentLimit { get; set; }
        public decimal? ExpireLimit { get; set; }
        public decimal? DueAmount { get; set; }
        public DateTime? LimitExpiryDate { get; set; }
        public string? Remark { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
