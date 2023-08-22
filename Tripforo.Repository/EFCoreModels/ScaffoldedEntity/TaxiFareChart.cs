using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TaxiFareChart
    {
        public int Id { get; set; }
        public string? CarName { get; set; }
        public double? FirstKm { get; set; }
        public double? Fare { get; set; }
        public double? Rate { get; set; }
        public double? ExtraKm { get; set; }
        public double? ExtraHour { get; set; }
        public string? PackageType { get; set; }
        public string? DayNight { get; set; }
        public string? City { get; set; }
        public string? ToFrom { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? FareType { get; set; }
    }
}
