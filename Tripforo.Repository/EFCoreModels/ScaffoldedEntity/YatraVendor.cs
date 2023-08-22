using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class YatraVendor
    {
        public decimal Counter { get; set; }
        public string PortalVc { get; set; } = null!;
        public string PortalVendorName { get; set; } = null!;
        public string? YatraVc { get; set; }
        public string? YatraVendorName { get; set; }
        public string? Trip { get; set; }
        public string? ServiceType { get; set; }
    }
}
