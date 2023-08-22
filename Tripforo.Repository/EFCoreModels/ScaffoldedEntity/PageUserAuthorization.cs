using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PageUserAuthorization
    {
        public int Counter { get; set; }
        public long? PageId { get; set; }
        public string? TypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Enable { get; set; }
    }
}
