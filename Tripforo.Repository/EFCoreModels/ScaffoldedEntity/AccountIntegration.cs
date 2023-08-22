using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AccountIntegration
    {
        public int Counter { get; set; }
        public string? ServiceType { get; set; }
        public string? ServiceProvider { get; set; }
        public bool? BillingStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
