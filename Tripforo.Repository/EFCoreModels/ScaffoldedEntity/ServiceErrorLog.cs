using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ServiceErrorLog
    {
        public int LogId { get; set; }
        public string? PageName { get; set; }
        public string? ErrorMessage { get; set; }
        public int? LineNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
