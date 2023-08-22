using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblViewedHotel
    {
        public int Sno { get; set; }
        public string? AgentId { get; set; }
        public string? OrderId { get; set; }
        public DateTime? ViewDate { get; set; }
    }
}
