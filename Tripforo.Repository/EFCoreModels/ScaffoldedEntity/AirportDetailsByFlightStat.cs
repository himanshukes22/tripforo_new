using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AirportDetailsByFlightStat
    {
        public string? Fs { get; set; }
        public string? Faa { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? StateCode { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public string? RegionName { get; set; }
        public string? TimeZoneRegionName { get; set; }
        public string? LocalTime { get; set; }
        public double? UtcOffsetHours { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? ElevationFeet { get; set; }
        public double? Classification { get; set; }
        public bool Active { get; set; }
        public string? DelayIndexUrl { get; set; }
        public string? WeatherUrl { get; set; }
        public string? Iata { get; set; }
        public string? Icao { get; set; }
        public string? CityCode { get; set; }
        public string? Street1 { get; set; }
        public string? Street2 { get; set; }
        public string? PostalCode { get; set; }
        public string? WeatherZone { get; set; }
    }
}
