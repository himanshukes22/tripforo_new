using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblRoutelistAv
    {
        public int Counter { get; set; }
        public string? Origin { get; set; }
        public string? Originname { get; set; }
        public string? Dest { get; set; }
        public string? Destname { get; set; }
        public string? Provider { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
