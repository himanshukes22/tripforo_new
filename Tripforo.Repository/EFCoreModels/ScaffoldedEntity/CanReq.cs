using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class CanReq
    {
        public string? Pnr { get; set; }
        public string? Remarks { get; set; }
        public string? Status { get; set; }
        public DateTime? CanDate { get; set; }
        public string? UserId { get; set; }
        public string? AgName { get; set; }
    }
}
