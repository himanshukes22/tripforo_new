using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayRemitterReg
    {
        public long RegId { get; set; }
        public string? Mobile { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PinCode { get; set; }
        public string? AgentUserId { get; set; }
        public string? RemitterId { get; set; }
        public string? Status { get; set; }
        public string? IsKycstatus { get; set; }
        public string? VerifiedStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? LocalAddress { get; set; }
    }
}
