using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class B2bemailAddress
    {
        public long Counter { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? Query { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
