using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblModuleAccess
    {
        public int Counter { get; set; }
        public string? Userid { get; set; }
        public string? Module { get; set; }
        public string? Moduletype { get; set; }
        public bool? Status { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
