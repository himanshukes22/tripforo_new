using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AirportName
    {
        public string? AirportCode { get; set; }
        public string? AirportName1 { get; set; }
        public string? CityName { get; set; }
        public string? CityCode { get; set; }
        public string? Country { get; set; }
        public string? Regioun { get; set; }
        public long Counter { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
