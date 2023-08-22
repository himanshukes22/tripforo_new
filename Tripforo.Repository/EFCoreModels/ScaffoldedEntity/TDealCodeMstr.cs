using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TDealCodeMstr
    {
        public int Id { get; set; }
        /// <summary>
        /// Agent Type or Distr. Id
        /// </summary>
        public string? GroupType { get; set; }
        public string? AgentId { get; set; }
        public string? AirCode { get; set; }
        public string? AirlineName { get; set; }
        public string? FltNo { get; set; }
        public string? TripType { get; set; }
        public string? TripTypeName { get; set; }
        public string? OrginAirport { get; set; }
        public string? DestAirport { get; set; }
        public string? OrginCountry { get; set; }
        public string? DestCountry { get; set; }
        public string? DTCode { get; set; }
        public string? CodeType { get; set; }
        public string? AppliedOn { get; set; }
        public string? IdType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
