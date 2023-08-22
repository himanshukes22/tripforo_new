using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ServiceCredential
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
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Status { get; set; }
        public string? ResultFrom { get; set; }
        public string? CrdType { get; set; }
        public string? TripType { get; set; }
        public string? TripTypeName { get; set; }
        public string? AirlineCode { get; set; }
        public string? AirlineName { get; set; }
        public bool? Cache { get; set; }
        public bool? WebResult { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? WebProject { get; set; }
        public string? Version { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? Iatanumber { get; set; }
        public string? AgencyId { get; set; }
        public string? AuthKey { get; set; }
        public string? ReferenceVersion { get; set; }
    }
}
