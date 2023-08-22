using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TDmtmarkupCharge
    {
        public int Id { get; set; }
        public string? GroupType { get; set; }
        public string? ChargesType { get; set; }
        public string? Amount { get; set; }
        public string? Charges { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UploadedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
