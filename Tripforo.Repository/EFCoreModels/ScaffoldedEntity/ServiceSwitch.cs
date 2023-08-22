using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ServiceSwitch
    {
        public int Counter { get; set; }
        public string? ServiceType { get; set; }
        public string? AvailableOn { get; set; }
        public bool? AvailableFlag { get; set; }
        public string? Trip { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? ServiceProviderType { get; set; }
    }
}
