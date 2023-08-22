using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblServiceproviderEnable
    {
        public int Counter { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceCode { get; set; }
        public bool? Enable { get; set; }
        public string? Vc { get; set; }
        public string? Trip { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
