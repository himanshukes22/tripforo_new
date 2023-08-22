using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Enquiry
    {
        public int Hindex { get; set; }
        public string? ReferenceNo { get; set; }
        public string? CityId { get; set; }
        public string? CityName { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int? AdultCount { get; set; }
        public int? ChildCount { get; set; }
        public int? RoomCount { get; set; }
        public string? HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? StarRating { get; set; }
        public string? RoomCategory { get; set; }
        public string? RoomId { get; set; }
        public string? MealPlan { get; set; }
        public decimal? GrossAmount { get; set; }
        public string? Suppliername { get; set; }
        public string? BookingStatus { get; set; }
        public string? Name { get; set; }
        public string? EmailId { get; set; }
        public string? ContactNo { get; set; }
        public string? ContactRemarks { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Tariff { get; set; }
        public string? AgentId { get; set; }
    }
}
