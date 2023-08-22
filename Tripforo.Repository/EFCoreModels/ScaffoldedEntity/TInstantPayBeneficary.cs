using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayBeneficary
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Account { get; set; }
        public string? IfscCode { get; set; }
        public string? RemitterId { get; set; }
        public string? AgentId { get; set; }
        public string? BeneficiaryId { get; set; }
        public string? Status { get; set; }
        public string? TimeStamp { get; set; }
        public string? IpayUuid { get; set; }
        public string? OrderId { get; set; }
        public string? Environment { get; set; }
        public string? Bank { get; set; }
        public string? Imps { get; set; }
        public string? LastSuccessDate { get; set; }
        public string? LastSuccessImps { get; set; }
        public string? LastSuccessName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? ReqBank { get; set; }
    }
}
