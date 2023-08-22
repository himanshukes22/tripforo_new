using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblClearCacheRecord
    {
        public long Id { get; set; }
        public string? Searchkey { get; set; }
        public string? Aircode { get; set; }
        public DateTime? Date { get; set; }
    }
}
