using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class MarqueeDetail
    {
        public int Counter { get; set; }
        public string? ServiceType { get; set; }
        public string? Message { get; set; }
        public bool? Isstatus { get; set; }
    }
}
