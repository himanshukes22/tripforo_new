using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TSmbpCircleDetail
    {
        public int Id { get; set; }
        public string? CircleId { get; set; }
        public string? CircleName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
