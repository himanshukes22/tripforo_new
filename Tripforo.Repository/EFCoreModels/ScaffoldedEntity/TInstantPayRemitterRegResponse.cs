using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayRemitterRegResponse
    {
        public long RegRespoId { get; set; }
        public string? RemitterId { get; set; }
        public string? AgentUserId { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? IsVerified { get; set; }
        public string? Kycdoc { get; set; }
        public string? Kycstatus { get; set; }
        public string? Mobile { get; set; }
        public string? Name { get; set; }
        public string? PernTxnLimit { get; set; }
        public string? PinCode { get; set; }
        public string? State { get; set; }
        public string? CreditLimit { get; set; }
        public string? ConsumedAmount { get; set; }
        public string? RemainingLimit { get; set; }
        public string? Impsmode { get; set; }
        public string? Neftmode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
