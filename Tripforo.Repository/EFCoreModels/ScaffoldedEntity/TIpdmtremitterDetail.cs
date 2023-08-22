using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TIpdmtremitterDetail
    {
        public int Id { get; set; }
        public string? Mobile { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PinCode { get; set; }
        public string? Mode { get; set; }
        public string? AgentId { get; set; }
        public string? RemitterId { get; set; }
        public string? Status { get; set; }
        public bool? IsKycstatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? VerifiedStatus { get; set; }
    }
}
