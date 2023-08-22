using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AirLineName
    {
        public int Counter { get; set; }
        public string? AlCode { get; set; }
        public string? AlName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
