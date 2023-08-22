using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Testcomm
    {
        public int Counter { get; set; }
        public string? GroupType { get; set; }
        public string? AirlineName { get; set; }
        public string? AirlineCode { get; set; }
        public decimal? CommisionOnBasic { get; set; }
        public decimal? CommissionOnYq { get; set; }
        public decimal? CommisionOnBasicYq { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
