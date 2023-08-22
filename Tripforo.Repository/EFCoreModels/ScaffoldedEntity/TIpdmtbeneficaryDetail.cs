using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TIpdmtbeneficaryDetail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? AccountNumber { get; set; }
        public string? IfscCode { get; set; }
        public string? RemitterId { get; set; }
        public string? AgentId { get; set; }
        public string? Merchant { get; set; }
        public string? Mode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Status { get; set; }
    }
}
