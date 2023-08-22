using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPackage
    {
        public int PkgId { get; set; }
        public decimal? Price { get; set; }
        public string? ImagePath { get; set; }
        public string? PackageUrl { get; set; }
        public string? PackageTitle { get; set; }
        public string? ImageName { get; set; }
        public bool? Active { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
