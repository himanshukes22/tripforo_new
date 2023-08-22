using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAgencyDetailsUpdationLog
    {
        public int LogId { get; set; }
        public string? AgencyId { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Ip { get; set; }
        public string? UpdatedFieldLog { get; set; }
        public string? ReferenceNo { get; set; }
        public string? ServiceType { get; set; }
    }
}
