using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class EmailBody
    {
        public int Id { get; set; }
        public string? EmailHead { get; set; }
        public string? EmailBody1 { get; set; }
        public bool? Status { get; set; }
    }
}
