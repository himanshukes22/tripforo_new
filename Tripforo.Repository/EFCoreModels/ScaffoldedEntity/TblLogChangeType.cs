using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblLogChangeType
    {
        public int Counter { get; set; }
        public string? Userid { get; set; }
        public string? Newagenttype { get; set; }
        public string? Oldagnettype { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? UpdateBy { get; set; }
    }
}
