using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FltDetail
    {
        public int FltId { get; set; }
        public string? OrderId { get; set; }
        /// <summary>
        /// 3 letter city or airport code
        /// </summary>
        public string? DepCityOrAirportCode { get; set; }
        public string? DepCityOrAirportName { get; set; }
        /// <summary>
        /// 3 Letter city OrAirport code
        /// </summary>
        public string? ArrCityOrAirportCode { get; set; }
        public string? ArrCityOrAirportName { get; set; }
        /// <summary>
        /// Departure date (ddmmyy)
        /// </summary>
        public string? DepDate { get; set; }
        /// <summary>
        /// Departure time (hhmm)
        /// </summary>
        public string? DepTime { get; set; }
        /// <summary>
        /// Arrival date (ddmmyy)
        /// </summary>
        public string? ArrDate { get; set; }
        /// <summary>
        /// Arrival time (hhmm)
        /// </summary>
        public string? ArrTime { get; set; }
        /// <summary>
        /// 2 Letter airline code
        /// </summary>
        public string? AirlineCode { get; set; }
        public string? AirlineName { get; set; }
        public string? FltNumber { get; set; }
        public string? AirCraft { get; set; }
        public string? AdtFareBasis { get; set; }
        public string? ChdFareBasis { get; set; }
        public string? InfFareBasis { get; set; }
        public string? AdtRbd { get; set; }
        public string? ChdRbd { get; set; }
        public string? InfRbd { get; set; }
        public short? AvlSeat { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Yflag { get; set; }
        public bool? Ycrn { get; set; }
    }
}
