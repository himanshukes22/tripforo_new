using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblState
    {
        public int Counter { get; set; }
        public string? State { get; set; }
        public string? Stateid { get; set; }
        public string? Country { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
