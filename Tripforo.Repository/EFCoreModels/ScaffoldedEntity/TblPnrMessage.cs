using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPnrMessage
    {
        public int Counter { get; set; }
        public string? Status { get; set; }
        public string? AgentMsg { get; set; }
        public string? OtherMsg { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
