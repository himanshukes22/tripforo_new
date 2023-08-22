using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayRemitterDetail
    {
        public long RegId { get; set; }
        public string? RegMobile { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PinCode { get; set; }
        public string? CurrentAddress { get; set; }
        public string? AgentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public string? PincodeRes { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Kycstatus { get; set; }
        public string? Consumedlimit { get; set; }
        public string? Remaininglimit { get; set; }
        public string? Kycdocs { get; set; }
        public bool? IsVerified { get; set; }
        public string? PermTxnLimit { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreditLimit { get; set; }
    }
}
