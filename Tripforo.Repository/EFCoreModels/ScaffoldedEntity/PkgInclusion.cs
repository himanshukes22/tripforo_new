using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgInclusion
    {
        public int PkgId { get; set; }
        public int? PkgInclusionId { get; set; }
        public string? PkgInclusionDescription { get; set; }
    }
}
