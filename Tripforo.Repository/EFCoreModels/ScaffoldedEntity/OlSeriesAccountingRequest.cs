using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class OlSeriesAccountingRequest
    {
        public long Counter { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public int? Amount { get; set; }
        public string? ExecutiveRemark { get; set; }
        public string? ExecutiveId { get; set; }
        public string? AccId { get; set; }
        public string? Ip { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? AccountRemark { get; set; }
        public string? AccountRejectRemark { get; set; }
    }
}
