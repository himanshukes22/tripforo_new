using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSmsCredential
    {
        public int Counter { get; set; }
        public string? Url { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public string? SenderId { get; set; }
        public string? Module { get; set; }
        public bool? Status { get; set; }
        public string? FeedId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
