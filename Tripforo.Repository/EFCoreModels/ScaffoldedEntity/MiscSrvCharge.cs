using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class MiscSrvCharge
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? Trip { get; set; }
        public string? AgentId { get; set; }
        public decimal? Amount { get; set; }
        public string? GroupType { get; set; }
        public string? Org { get; set; }
        public string? Dest { get; set; }
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Commission on Basic fare
        /// </summary>
        public decimal? CommisionOnBasic { get; set; }
        public decimal? CommissionOnYq { get; set; }
        /// <summary>
        /// Coimmission on Basic + YQ
        /// </summary>
        public decimal? CommisionOnBasicYq { get; set; }
        public string? MarkupType { get; set; }
        public string? FareType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public int? FddId { get; set; }
        public bool? WithGst { get; set; }
        public string? FlightNo { get; set; }
    }
}
