using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class MailerQuery
    {
        public string? Days { get; set; }
        public string? PackageName { get; set; }
        public string? Destination { get; set; }
        public string? Name { get; set; }
        public string? DepartureDate { get; set; }
        public string? CreatedDate { get; set; }
        public string? TotalPassenger { get; set; }
        public string? Email { get; set; }
        public string? ContactNo { get; set; }
        public string? Description { get; set; }
    }
}
