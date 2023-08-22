using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPackageSlider
    {
        public int PackageId { get; set; }
        public string? PackageTitle { get; set; }
        public string? Destination { get; set; }
        public decimal? MinCost { get; set; }
        public string? ImagePath { get; set; }
    }
}
