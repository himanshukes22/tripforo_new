using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class HotelCancellation
    {
        public int Counter { get; set; }
        public int? HotelCancellationId { get; set; }
        public string? HotelCancellationDes { get; set; }
        public int? HotelId { get; set; }
    }
}
