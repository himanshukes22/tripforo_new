using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TFltMealAndBaggageRequest
    {
        public long Mbid { get; set; }
        public string? BookingRefNo { get; set; }
        public string? FltHeaderId { get; set; }
        public long? PaxId { get; set; }
        public string? TripType { get; set; }
        public string? MealCode { get; set; }
        public decimal? MealPrice { get; set; }
        public string? BaggageCode { get; set; }
        public decimal? BaggagePrice { get; set; }
        public string? AirLineCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? BaggageDesc { get; set; }
        public string? BaggageCategory { get; set; }
        public decimal? BaggagePriceWithNoTax { get; set; }
        public string? MealDesc { get; set; }
        public string? Provider { get; set; }
        public string? MealCategory { get; set; }
        public decimal? MealPriceWithNoTax { get; set; }
        public string? SeatCode { get; set; }
        public decimal? SeatPrice { get; set; }
        public string? SeatDesc { get; set; }
        public string? SeatCategory { get; set; }
        public decimal? SeatPriceWithNoTax { get; set; }
    }
}
