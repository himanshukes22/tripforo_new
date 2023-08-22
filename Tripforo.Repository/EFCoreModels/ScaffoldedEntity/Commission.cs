using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Commission
    {
        public int Counter { get; set; }
        /// <summary>
        /// Agent Type or Distr. Id
        /// </summary>
        public string? GroupType { get; set; }
        public string? AirlineName { get; set; }
        public string? AirlineCode { get; set; }
        /// <summary>
        /// Commission on Basic fare
        /// </summary>
        public decimal? CommisionOnBasic { get; set; }
        public decimal? CommissionOnYq { get; set; }
        /// <summary>
        /// Coimmission on Basic + YQ
        /// </summary>
        public decimal? CommisionOnBasicYq { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Class { get; set; }
    }
}
