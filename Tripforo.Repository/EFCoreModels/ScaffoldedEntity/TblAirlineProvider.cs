using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAirlineProvider
    {
        public int Counter { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderName { get; set; }
        public bool Lcc { get; set; }
        public bool Gds { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
