using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblTransactionOtp
    {
        public long Counter { get; set; }
        public string? Userid { get; set; }
        public string? Transid { get; set; }
        public long? LastOtp { get; set; }
        public long? UpdateOtp { get; set; }
        public string? MobileNo { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }
        public string? Reason { get; set; }
    }
}
