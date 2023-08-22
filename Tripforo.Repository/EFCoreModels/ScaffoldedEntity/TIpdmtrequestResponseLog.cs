using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TIpdmtrequestResponseLog
    {
        public long RrlogId { get; set; }
        public string? RequestDel { get; set; }
        public string? ResponseDel { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? PostUrl { get; set; }
        public string? ActionType { get; set; }
        public string? TrackId { get; set; }
    }
}
