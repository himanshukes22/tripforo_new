using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgImage
    {
        public int PkgId { get; set; }
        public int? PkgImageId { get; set; }
        public string? PkgTitle { get; set; }
        public string? PkgImage1 { get; set; }
        public string? PkgImageDescription { get; set; }
    }
}
