using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class HotelImage
    {
        public int Counter { get; set; }
        public int? HotelId { get; set; }
        public int? HotelImgaeId { get; set; }
        public string? HotelImage1 { get; set; }
        public string? HotelImageDes { get; set; }
        public string? HotelName { get; set; }
        public string? HotelRoomImage { get; set; }
        public string? HotelRoomDes { get; set; }
        public string? HotelDiningImage { get; set; }
        public string? HotelDiningDes { get; set; }
        public string? HotelAmenetiesImage { get; set; }
        public string? HotelAmentiesDes { get; set; }
    }
}
