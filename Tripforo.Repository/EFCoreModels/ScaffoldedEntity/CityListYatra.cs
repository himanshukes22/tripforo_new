using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class CityListYatra
    {
        public string? AirportCode { get; set; }
        public string? AirportName { get; set; }
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public decimal? Id { get; set; }
    }
}
