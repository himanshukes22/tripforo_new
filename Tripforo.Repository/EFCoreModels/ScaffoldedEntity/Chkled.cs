using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Chkled
    {
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? AvailBalance { get; set; }
        public int Id { get; set; }
        public string? Stat { get; set; }
    }
}
