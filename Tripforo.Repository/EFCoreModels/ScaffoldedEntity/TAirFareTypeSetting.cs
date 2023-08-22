using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TAirFareTypeSetting
    {
        public int Counter { get; set; }
        public string? AirCode { get; set; }
        public string? Trip { get; set; }
        public string? FareClassReq { get; set; }
        public string? FareClassRes { get; set; }
        public string? FareType { get; set; }
        public string? ProductClassReq { get; set; }
        public string? ProductClassRes { get; set; }
        public string? Fsk { get; set; }
        public decimal? CancellationPanelty { get; set; }
        public decimal? ReIssuePanelty { get; set; }
        public bool? IsRefundable { get; set; }
        public string? Provider { get; set; }
        public string? IdType { get; set; }
        public string? FareBasis { get; set; }
        public bool? IsChangeable { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Cabin { get; set; }
        public bool? IsBagFare { get; set; }
        public string? Ssrcode { get; set; }
        public bool? IsSmefare { get; set; }
    }
}
