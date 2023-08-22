using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class IntPlb
    {
        public int Counter { get; set; }
        /// <summary>
        /// Agent Type or Distr. Id
        /// </summary>
        public string? GroupType { get; set; }
        public string? AirlineName { get; set; }
        public string? AirlineCode { get; set; }
        /// <summary>
        /// Restricted RBD
        /// </summary>
        public string? Rbd { get; set; }
        /// <summary>
        /// Restricted Origin
        /// </summary>
        public string? Sector { get; set; }
        /// <summary>
        /// Plb % on basic Fare
        /// </summary>
        public decimal? PlbOnBasic { get; set; }
        /// <summary>
        /// Plb % on Basic + YQ
        /// </summary>
        public decimal? PlbOnBasicYq { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? Remark { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Class { get; set; }
    }
}
