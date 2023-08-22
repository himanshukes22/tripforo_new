using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAgentbookingInfo
    {
        public long Counter { get; set; }
        public string? OrderId { get; set; }
        public string? BookingInfo { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
