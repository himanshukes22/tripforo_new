using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblControl
    {
        public int ControlId { get; set; }
        public string? ControlName { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? DisplayAtTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdateBy { get; set; }
    }
}
