using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Execu
    {
        public int Counter { get; set; }
        public string? UserId { get; set; }
        public string? UserPwd { get; set; }
        public string? Dept { get; set; }
        public string? UserType { get; set; }
        public string? Name { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? OwnerItz { get; set; }
        public string? Trip { get; set; }
        public string? DeptType { get; set; }
        public bool? Status { get; set; }
    }
}
