using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgIncluExclu
    {
        public int Counter { get; set; }
        public string? PkgInclu { get; set; }
        public string? PkgExeclu { get; set; }
    }
}
