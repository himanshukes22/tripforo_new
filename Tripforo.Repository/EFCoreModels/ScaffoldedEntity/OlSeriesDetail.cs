using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class OlSeriesDetail
    {
        public long Counter { get; set; }
        public string? AirlineName { get; set; }
        public string? AirlineCode { get; set; }
        public string? Sector { get; set; }
        public int? Amount { get; set; }
        public int? AvailableSeat { get; set; }
        public string? DepartDate { get; set; }
        public string? RetDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Trip { get; set; }
        public string? ExecId { get; set; }
        public int? HoldSeat { get; set; }
        public int? ConfirmSeat { get; set; }
        public int? OfflineHold { get; set; }
        public int? OfflineConfirm { get; set; }
    }
}
