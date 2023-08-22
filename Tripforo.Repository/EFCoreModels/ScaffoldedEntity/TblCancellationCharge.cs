using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCancellationCharge
    {
        public int Id { get; set; }
        public string? AgentType { get; set; }
        public string? AgentId { get; set; }
        public string? AirlineCode { get; set; }
        public string? Mode { get; set; }
        public decimal? Amount { get; set; }
        public string? Trip { get; set; }
        public decimal? Gst { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
    }
}
