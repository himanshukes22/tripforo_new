using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSmbpBbpsbillerLabelDatum
    {
        public long LabelDataId { get; set; }
        public string? BillerId { get; set; }
        public string? Index { get; set; }
        public string? Labels { get; set; }
        public string? FieldMinLen { get; set; }
        public string? FieldMaxLen { get; set; }
        public string? AgentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? FetchId { get; set; }
    }
}
