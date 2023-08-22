using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AgentStaffRegister
    {
        public int Id { get; set; }
        public string? StaffId { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public string? OwnerId { get; set; }
        public string? AgencyId { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public decimal? CreditLimit { get; set; }
        public DateTime? CreditLimitTrnsDate { get; set; }
        public decimal? StaffLimit { get; set; }
        public DateTime? StaffLimitTrnsDate { get; set; }
        public string? UserType { get; set; }
        public string? RoleType { get; set; }
        public bool? Status { get; set; }
        public bool? Flight { get; set; }
        public bool? Hotel { get; set; }
        public bool? Bus { get; set; }
        public bool? Rail { get; set; }
        public bool? Cab { get; set; }
        public bool? Holidays { get; set; }
        public bool? GiftCard { get; set; }
        public bool? HomeStay { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? DelStatus { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? CheckBalance { get; set; }
    }
}
