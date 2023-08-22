using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblWait
    {
        public long Id { get; set; }
        public string? Airline { get; set; }
        public string? Sector { get; set; }
        public string? AgentId { get; set; }
        public string? WaitInSec { get; set; }
        public string? SearchId { get; set; }
        public string? SearchDate { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
