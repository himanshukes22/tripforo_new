using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AvailabilityResult
    {
        public string? Url { get; set; }
        public string? Req { get; set; }
        public string? Res { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
