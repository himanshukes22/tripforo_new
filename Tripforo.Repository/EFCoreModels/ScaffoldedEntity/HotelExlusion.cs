using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class HotelExlusion
    {
        public int Counter { get; set; }
        public int? HotelId { get; set; }
        public int? HotelExclusionId { get; set; }
        public string? HotelExlusionDes { get; set; }
    }
}
