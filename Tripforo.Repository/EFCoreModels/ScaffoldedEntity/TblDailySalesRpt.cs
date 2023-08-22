using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblDailySalesRpt
    {
        public int Counter { get; set; }
        public DateTime? Inputdate { get; set; }
        public string? AgencyCity { get; set; }
        public string? AgenctName { get; set; }
        public string? CtcPerson { get; set; }
        public string? CtcPersonNo { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UserId { get; set; }
    }
}
