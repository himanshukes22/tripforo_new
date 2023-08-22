using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblInsertCrossfarexml
    {
        public int Counter { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public string? Url { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
