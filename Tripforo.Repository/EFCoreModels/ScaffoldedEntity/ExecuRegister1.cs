using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ExecuRegister1
    {
        public int Counter { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }
        public string? RoleType { get; set; }
        public string? Name { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastChangeDate { get; set; }
    }
}
