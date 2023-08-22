using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class CityList
    {
        public int? Id { get; set; }
        public string? AirportCode { get; set; }
        public string? AirportName { get; set; }
        public string? CityName { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? WorldAreaCode { get; set; }
        public string? Orderseq { get; set; }
    }
}
