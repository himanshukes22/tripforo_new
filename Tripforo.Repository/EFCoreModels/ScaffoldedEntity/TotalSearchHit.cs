using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TotalSearchHit
    {
        public int Id { get; set; }
        public string? Sector { get; set; }
        public DateTime Createdate { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Updatedate { get; set; }
        public int? Daylimit { get; set; }
        public int? Expiretime { get; set; }
        public string? Url { get; set; }
        public string? Response { get; set; }
        public string? Airline { get; set; }
        public DateTime? JourneyDate { get; set; }
        public long? HitsCount { get; set; }
    }
}
