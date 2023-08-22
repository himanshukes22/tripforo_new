using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TUserTypeId
    {
        public long Counter { get; set; }
        public string? DeptName { get; set; }
        public string? TypeId { get; set; }
        public string? TypeName { get; set; }
        public string? UserType { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
