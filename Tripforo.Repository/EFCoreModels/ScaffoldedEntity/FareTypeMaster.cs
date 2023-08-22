using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FareTypeMaster
    {
        public int Id { get; set; }
        public string? FareType { get; set; }
        public string? DisplayName { get; set; }
        public string? DisplayName2 { get; set; }
        public string? DisplayName3 { get; set; }
        public string? DisplayName4 { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Remark { get; set; }
    }
}
