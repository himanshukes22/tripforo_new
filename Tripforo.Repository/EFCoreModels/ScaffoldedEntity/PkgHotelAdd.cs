using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgHotelAdd
    {
        public int Counter { get; set; }
        public int? PkgId { get; set; }
        public int? HotelId { get; set; }
        public string? PkgTitle { get; set; }
        public string? PkgHotelName { get; set; }
    }
}
