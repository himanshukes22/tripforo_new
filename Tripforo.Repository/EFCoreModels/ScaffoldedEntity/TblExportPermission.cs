using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblExportPermission
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? Role { get; set; }
        public string? RoleType { get; set; }
        public string? PageName { get; set; }
        public int? PageId { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
    }
}
