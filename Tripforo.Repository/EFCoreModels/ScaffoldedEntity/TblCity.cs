using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCity
    {
        public int Counter { get; set; }
        public string? City { get; set; }
        public string? Stateid { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
