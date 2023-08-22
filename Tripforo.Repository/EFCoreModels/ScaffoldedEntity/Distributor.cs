using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Distributor
    {
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public string? Url { get; set; }
        public string? DistributorId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Flag { get; set; }
    }
}
