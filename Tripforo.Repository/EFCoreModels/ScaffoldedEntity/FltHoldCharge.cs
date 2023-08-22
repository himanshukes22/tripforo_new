using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FltHoldCharge
    {
        public int Id { get; set; }
        public string? TripType { get; set; }
        public string? TripTypeName { get; set; }
        public string? GroupType { get; set; }
        public string? AgentId { get; set; }
        public string? AirCode { get; set; }
        public string? AirlineName { get; set; }
        public decimal? Charges { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
