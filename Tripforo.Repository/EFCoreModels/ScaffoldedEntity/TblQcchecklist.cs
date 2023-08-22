using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblQcchecklist
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string? TableName { get; set; }
        public string? ExecutiveId { get; set; }
        public string? Remark { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
