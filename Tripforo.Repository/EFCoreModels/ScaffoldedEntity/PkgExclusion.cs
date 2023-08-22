using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgExclusion
    {
        public int PkgId { get; set; }
        public int? PkgExclusionsId { get; set; }
        public string? PkgExclusionsDescription { get; set; }
    }
}
