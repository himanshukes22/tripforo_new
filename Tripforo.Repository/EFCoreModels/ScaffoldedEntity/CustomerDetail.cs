using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class CustomerDetail
    {
        public int CustId { get; set; }
        public string? UserId { get; set; }
        public string? Title { get; set; }
        public string? Fname { get; set; }
        public string? Mname { get; set; }
        public string? Lname { get; set; }
        public string? Address1 { get; set; }
        public string? Addess2 { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Mobile { get; set; }
        public string? Phone { get; set; }
        public string? EmailId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
