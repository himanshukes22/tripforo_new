using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TCanLog
    {
        public int Counter { get; set; }
        public string? Orderid { get; set; }
        public string? Refno { get; set; }
        public string? Vc { get; set; }
        public string? BkgReq { get; set; }
        public string? BkgRes { get; set; }
        public string? CanReq { get; set; }
        public string? CanRes { get; set; }
        public string? AddpayReq { get; set; }
        public string? AddpayRes { get; set; }
        public string? BkgcommitReq { get; set; }
        public string? BkgcommitRes { get; set; }
        public string? Refundamount { get; set; }
        public DateTime? Createddate { get; set; }
        public string? Error { get; set; }
    }
}
