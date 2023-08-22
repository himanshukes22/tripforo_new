using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class LccFlightAvailability
    {
        public string? MktCarrier { get; set; }
        public string? FlightNo { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public string? DeptTime { get; set; }
        public string? DeptDate { get; set; }
        public string? ArrDate { get; set; }
        public string? ArrTime { get; set; }
        public string? TotalFare { get; set; }
        public string? TotalTax { get; set; }
        public string? AdtBasic { get; set; }
        public string? AdtTax { get; set; }
        public string? AdtSur { get; set; }
        public string? AdtTotal { get; set; }
        public string? ChdBasic { get; set; }
        public string? ChdTax { get; set; }
        public string? ChdSur { get; set; }
        public string? ChdTotal { get; set; }
        public string? InfBasic { get; set; }
        public string? InfTax { get; set; }
        public string? InfSur { get; set; }
        public string? InfTotal { get; set; }
        public string? SearchValue { get; set; }
        public string? Class { get; set; }
        public string? FlightDuration { get; set; }
        public string? FareBasis { get; set; }
        public string? Stops { get; set; }
        public string? Helpkey { get; set; }
        public string? Sno { get; set; }
        public string? FltDetail { get; set; }
        public string? Fulsur { get; set; }
        public string? FltCnt { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
