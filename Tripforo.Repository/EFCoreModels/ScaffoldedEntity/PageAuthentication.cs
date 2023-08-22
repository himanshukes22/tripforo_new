using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PageAuthentication
    {
        public long PageId { get; set; }
        public string? PageName { get; set; }
        public string? PageUrl { get; set; }
        public long? PageParentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
