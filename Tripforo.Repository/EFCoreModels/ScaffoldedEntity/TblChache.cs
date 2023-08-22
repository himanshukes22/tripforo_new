using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblChache
    {
        public int Id { get; set; }
        public string? Sector { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
        public bool? Isactive { get; set; }
        public int ExprTime { get; set; }
        public int DayLimit { get; set; }
    }
}
