using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblDeleteCacheSector
    {
        public int Id { get; set; }
        public string? Sector { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
        public string? Url { get; set; }
        public string? Airline { get; set; }
        public DateTime? JourneyDate { get; set; }
    }
}
