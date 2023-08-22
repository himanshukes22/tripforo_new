using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblSearchResultBlock
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? Provider { get; set; }
        public bool? Rtf { get; set; }
        public string? Trip { get; set; }
        public string? AirlineType { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? GroupType { get; set; }
        public string? AgentId { get; set; }
        public string? FareType { get; set; }
        public string? FareTypeName { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? AgentIdExclude { get; set; }
        public bool? Exclude { get; set; }
    }
}
