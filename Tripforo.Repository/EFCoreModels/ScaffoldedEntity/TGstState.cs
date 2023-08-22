using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TGstState
    {
        public int Counter { get; set; }
        public string? StateName { get; set; }
        public string? StateCode { get; set; }
        public string? Gstcode { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
