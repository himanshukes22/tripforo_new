using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PaxInformation
    {
        public int Counter { get; set; }
        public string? PnrLocator { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Paxtype { get; set; }
        public string? TktNo { get; set; }
    }
}
