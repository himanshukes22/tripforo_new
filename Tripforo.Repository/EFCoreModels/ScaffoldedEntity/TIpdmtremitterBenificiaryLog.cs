using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TIpdmtremitterBenificiaryLog
    {
        public long RemtBenLogId { get; set; }
        public string? Account { get; set; }
        public string? Bank { get; set; }
        public string? Id { get; set; }
        public string? Ifsc { get; set; }
        public string? Imps { get; set; }
        public string? LastSuccessDate { get; set; }
        public string? LastSuccessImps { get; set; }
        public string? LastSuccessName { get; set; }
        public string? Mobile { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? Remitterid { get; set; }
        public string? Remittermobile { get; set; }
        public string? AgentId { get; set; }
    }
}
