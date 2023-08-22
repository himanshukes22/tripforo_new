using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Infrant
    {
        public int EmpId { get; set; }
        public string? ProxyId { get; set; }
        public string? SirName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? AgentId { get; set; }
        public string? Ffno { get; set; }
        public string? PassportNo { get; set; }
        public string? Ppexp { get; set; }
        public string? VisaDet { get; set; }
    }
}
