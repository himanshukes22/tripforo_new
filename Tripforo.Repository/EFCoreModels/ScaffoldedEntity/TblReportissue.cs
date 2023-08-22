using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblReportissue
    {
        public int Counter { get; set; }
        public string? UserId { get; set; }
        public string? ContactNo { get; set; }
        public string? EmailId { get; set; }
        public string? Name { get; set; }
        public string? AgencyName { get; set; }
        public string? Department { get; set; }
        public string? Issues { get; set; }
        public DateTime? Createddate { get; set; }
        public string? Mtype { get; set; }
        public string? Trip { get; set; }
    }
}
