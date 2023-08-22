using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class HotelIncluExeclu
    {
        public int Counter { get; set; }
        public int? HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? HotelInclusion { get; set; }
        public string? HotelExeclusion { get; set; }
    }
}
