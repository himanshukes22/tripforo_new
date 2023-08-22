using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCreditDebitNode
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyId { get; set; }
        public string? DistributerId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string? Remark { get; set; }
        public string? ServiceType { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? ReferenceId { get; set; }
        public string? Pnr { get; set; }
    }
}
