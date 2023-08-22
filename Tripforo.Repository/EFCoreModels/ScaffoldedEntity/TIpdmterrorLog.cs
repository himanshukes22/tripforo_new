using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TIpdmterrorLog
    {
        public long ErrorLogId { get; set; }
        public string? RequestDel { get; set; }
        public string? Error { get; set; }
        public string? PostUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? TrackId { get; set; }
        public string? ErrorType { get; set; }
    }
}
