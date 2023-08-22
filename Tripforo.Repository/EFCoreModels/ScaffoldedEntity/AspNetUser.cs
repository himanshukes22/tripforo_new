using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            Roles = new HashSet<AspNetRole>();
        }

        public string Id { get; set; } = null!;
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNo { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Zipcode { get; set; }
        public string? Address { get; set; }
        public string? AgencyName { get; set; }
        public string? Email { get; set; }
        public string? Landmark { get; set; }
        public string? GroundFloor { get; set; }
        public string? OfficeArea { get; set; }
        public string? Phone { get; set; }
        public string? ContactPerson { get; set; }
        public string? AlternateEmail { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Qualification { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Occupation { get; set; }
        public string? PanCardNo { get; set; }
        public string? PanCardHolderName { get; set; }
        public string? Income { get; set; }
        public string? NatureOfBusiness { get; set; }
        public string? YearOfIncorporation { get; set; }
        public string? AadhaarCardNo { get; set; }
        public string? AadhaarCardHolderName { get; set; }
        public string? OtherPortal { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? Source { get; set; }
        public string? CallBackUrl { get; set; }
        public string? Gstnnumber { get; set; }
        public string? CompanyName { get; set; }
        public string? UserStatus { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal Balance { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; } = null!;

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

        public virtual ICollection<AspNetRole> Roles { get; set; }
    }
}
