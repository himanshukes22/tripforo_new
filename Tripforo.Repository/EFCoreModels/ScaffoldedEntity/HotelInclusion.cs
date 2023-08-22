using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class HotelInclusion
    {
        public int Counter { get; set; }
        public int? HotelId { get; set; }
        public int? HotelInclusionId { get; set; }
        public string? HotelInclusionDes { get; set; }
    }
}
