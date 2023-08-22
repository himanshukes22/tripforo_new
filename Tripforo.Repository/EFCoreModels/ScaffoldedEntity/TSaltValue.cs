using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSaltValue
    {
        public int Counter { get; set; }
        public string? SaltValue { get; set; }
        public string? ClientType { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
