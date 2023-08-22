using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TIpdmtremitterRegLog
    {
        public int RemtRegLogId { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? ConsumedLimit { get; set; }
        public string? Id { get; set; }
        public string? IsVerified { get; set; }
        public string? KycDocs { get; set; }
        public string? KycStatus { get; set; }
        public string? Mobile { get; set; }
        public string? Name { get; set; }
        public string? PernTxnLimit { get; set; }
        public string? PinCode { get; set; }
        public string? RemainingLimit { get; set; }
        public string? State { get; set; }
        public string? Limitimpsmode { get; set; }
        public string? Limitneftmode { get; set; }
        public string? LimitconsumedAmount { get; set; }
        public string? LimitremainningAmount { get; set; }
        public string? AgentId { get; set; }
    }
}
