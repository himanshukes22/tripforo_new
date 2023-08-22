using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class VisaDetail
    {
        public int Counter { get; set; }
        public string? Country { get; set; }
        public string? Details { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
