using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblFqc
    {
        public int Counter { get; set; }
        public string? Rbd { get; set; }
        public string? Airline { get; set; }
        public bool? Enable { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
