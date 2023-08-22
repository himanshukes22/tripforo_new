using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCredentialPnrcreation
    {
        public int Counter { get; set; }
        public string? CorporateId { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public string? LoginId { get; set; }
        public string? LoginPwd { get; set; }
        public string? ServerUrlOrIp { get; set; }
        public string? BkgServerUrlOrIp { get; set; }
        public string? Port { get; set; }
        public string? Provider { get; set; }
        public string? Apisource { get; set; }
        public string? CarrierAcc { get; set; }
        public string? ServerIp { get; set; }
        public decimal? InfBasic { get; set; }
        public decimal? InfTax { get; set; }
        public string? SearchType { get; set; }
        public string? Vc { get; set; }
        public string? Trip { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Status { get; set; }
        public string? CrdType { get; set; }
        public string? WebProject { get; set; }
    }
}
