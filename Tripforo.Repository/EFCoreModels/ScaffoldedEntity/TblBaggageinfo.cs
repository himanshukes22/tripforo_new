using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblBaggageinfo
    {
        public int Counter { get; set; }
        public string? BaggageName { get; set; }
        public string? Weight { get; set; }
        public string? Trip { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Airline { get; set; }
        public string? Class { get; set; }
        public bool? IsBagFare { get; set; }
    }
}
