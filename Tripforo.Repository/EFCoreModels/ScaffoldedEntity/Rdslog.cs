using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Rdslog
    {
        public int Id { get; set; }
        public string? ReferenceNo { get; set; }
        public string? MerchantCode { get; set; }
        public string? ReservationId { get; set; }
        public string? EncryptedReq { get; set; }
        public string? DecryptedReq { get; set; }
        public string? Type { get; set; }
        public string? Remark { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
