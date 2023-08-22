using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblSplfareLog
    {
        public int Counter { get; set; }
        public string? Orderid { get; set; }
        public string? Agentid { get; set; }
        public string? Airline { get; set; }
        public string? LogData { get; set; }
        public string? Others { get; set; }
        public string? Sts { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
