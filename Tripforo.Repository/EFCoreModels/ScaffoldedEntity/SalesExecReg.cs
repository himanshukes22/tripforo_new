using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class SalesExecReg
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Location { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailId { get; set; }
        public string? Password { get; set; }
        public string? Status { get; set; }
        public DateTime? RegDate { get; set; }
        public string? UserType { get; set; }
    }
}
