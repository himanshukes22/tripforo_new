using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblLogImportPnr
    {
        public string? OrderId { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
