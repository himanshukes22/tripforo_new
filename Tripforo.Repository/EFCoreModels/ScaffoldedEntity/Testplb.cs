using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Testplb
    {
        public int Counter { get; set; }
        public string? GroupType { get; set; }
        public string? AirlineName { get; set; }
        public string? AirlineCode { get; set; }
        public string? Rbd { get; set; }
        public string? Sector { get; set; }
        public decimal? PlbOnBasic { get; set; }
        public decimal? PlbOnBasicYq { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? Remark { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
