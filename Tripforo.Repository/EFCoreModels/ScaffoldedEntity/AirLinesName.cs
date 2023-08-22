using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AirLinesName
    {
        public int? Id { get; set; }
        public string? AlCode { get; set; }
        public string? AlName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
