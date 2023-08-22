using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AdminMarkup
    {
        public int Counter { get; set; }
        /// <summary>
        /// Agent User ID  or Distr User ID
        /// </summary>
        public string? Userid { get; set; }
        /// <summary>
        /// Two Letter Airline code
        /// </summary>
        public string? AirlineCode { get; set; }
        public string? AirlineName { get; set; }
        /// <summary>
        /// Markup Type  : Fixed (F) or Percentage (P)
        /// </summary>
        public string? MarkupType { get; set; }
        /// <summary>
        /// Domestic (D) or International ( I )
        /// </summary>
        public string? Trip { get; set; }
        /// <summary>
        /// fixed type value or percentage type value
        /// </summary>
        public string? MarkupValue { get; set; }
        /// <summary>
        /// Distributor Id
        /// </summary>
        public string? Distr { get; set; }
        /// <summary>
        /// Mark up display in Transaction fee (TRN) or Taxes (TAX)
        /// </summary>
        public string? Show { get; set; }
        /// <summary>
        /// Type of User(AGENT OR DISTR)
        /// </summary>
        public string? Type { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
