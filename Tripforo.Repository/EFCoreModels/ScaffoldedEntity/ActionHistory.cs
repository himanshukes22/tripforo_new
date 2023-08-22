using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ActionHistory
    {
        public int Id { get; set; }
        public string? ReferenceNo { get; set; }
        public string? Comment { get; set; }
        public DateTime? ActionOn { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
    }
}
