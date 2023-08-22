using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class HotelDetail
    {
        public int Counter { get; set; }
        public int? HotelId { get; set; }
        public int? HotelCode { get; set; }
        public string? HotelName { get; set; }
        public string? RoomType { get; set; }
        public string? HotelCategory { get; set; }
        public string? Address { get; set; }
        public int? HotelPrice { get; set; }
        public string? CityName { get; set; }
        public string? StateName { get; set; }
        public string? CountryName { get; set; }
        public int? ZipCode { get; set; }
        public string? HotelDes { get; set; }
        public string? HotelAccommodation { get; set; }
        public string? HotelCheckingPolicy { get; set; }
        public string? HotelCheckoutPolicy { get; set; }
        public bool? Status { get; set; }
        public string? Amenity { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
