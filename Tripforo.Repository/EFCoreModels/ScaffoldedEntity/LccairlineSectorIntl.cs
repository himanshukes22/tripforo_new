using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class LccairlineSectorIntl
    {
        public int Id { get; set; }
        public string AirLineCode { get; set; } = null!;
        public string SecFrom { get; set; } = null!;
        public string SecTo { get; set; } = null!;
        public string? AirlineName { get; set; }
    }
}
