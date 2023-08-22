using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblDepositeoffice
    {
        public int Counter { get; set; }
        public string? Office { get; set; }
        public string? Distrid { get; set; }
        public DateTime? Cretaeddate { get; set; }
    }
}
