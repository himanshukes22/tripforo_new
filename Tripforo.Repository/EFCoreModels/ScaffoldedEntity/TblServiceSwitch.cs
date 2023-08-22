using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblServiceSwitch
    {
        public int Counter { get; set; }
        public string? Airline { get; set; }
        public string? Provider { get; set; }
        public bool? Rtf { get; set; }
        public string? Trip { get; set; }
        public string? AirlineType { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
