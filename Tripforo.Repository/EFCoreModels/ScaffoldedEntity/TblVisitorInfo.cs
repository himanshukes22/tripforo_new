using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblVisitorInfo
    {
        public int Counter { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? Emailid { get; set; }
        public string? Organisation { get; set; }
        public bool? IsgalileoCustomer { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Product { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? OtherProduct { get; set; }
    }
}
