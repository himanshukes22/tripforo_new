using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class CouponRequestResponse
    {
        public int RequestId { get; set; }
        public string? RequestString { get; set; }
        public string? Responsedata { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
