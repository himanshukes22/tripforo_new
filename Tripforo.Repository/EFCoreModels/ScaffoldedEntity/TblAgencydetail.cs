using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAgencydetail
    {
        public int Counter { get; set; }
        public string? AgencyName { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactNo { get; set; }
        public string? EmailId { get; set; }
        public string? QueryFor { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? DateOfVisit { get; set; }
        public string? Timing { get; set; }
    }
}
