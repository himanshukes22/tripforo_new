using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class YatraBillingLog
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string? BillNo { get; set; }
        public string? BillType { get; set; }
        /// <summary>
        /// 0-success,3-failure
        /// </summary>
        public int RetVal { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
