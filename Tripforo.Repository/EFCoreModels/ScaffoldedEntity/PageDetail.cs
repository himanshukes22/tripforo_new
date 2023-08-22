using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PageDetail
    {
        public int PageId { get; set; }
        public string PageName { get; set; } = null!;
        public string PageUrl { get; set; } = null!;
        public int RootPageId { get; set; }
        public string IsParentPage { get; set; } = null!;
        public int? PageOrder { get; set; }
    }
}
