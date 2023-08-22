﻿using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class WorldAirportInfo
    {
        public string? AirportCode { get; set; }
        public string? AirportName { get; set; }
        public string? CityName { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? WorldAreaCode { get; set; }
        public long Counter { get; set; }
        public int? Isorder { get; set; }
        public int? Isactive { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
