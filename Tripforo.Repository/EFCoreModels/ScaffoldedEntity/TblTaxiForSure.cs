using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblTaxiForSure
    {
        public int Sno { get; set; }
        public int? CityCode { get; set; }
        public string? CityName { get; set; }
        public string? LocationId { get; set; }
        public string? LoactionName { get; set; }
        public string? LocLattitude { get; set; }
        public string? LocLongitude { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
