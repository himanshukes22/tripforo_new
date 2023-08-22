using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class OlOfflineSeriesRequest
    {
        public long Counter { get; set; }
        public string? AirlineName { get; set; }
        public string? AirlineCode { get; set; }
        public string? Sector { get; set; }
        public int? Amount { get; set; }
        public int? AvailableSeat { get; set; }
        public string? DepartDate { get; set; }
        public string? RetDate { get; set; }
        public int? NoOfPax { get; set; }
        public int? NoOfAdult { get; set; }
        public int? NoOfChild { get; set; }
        public int? NoOfInfant { get; set; }
        public string? ExecRemark { get; set; }
        public string? RejectedRemark { get; set; }
        public string? Status { get; set; }
        public string? AgentId { get; set; }
        public string? AgencyName { get; set; }
        public string? Distr { get; set; }
        public string? ExecutiveId { get; set; }
        public string? Ip { get; set; }
        public int? SeriesId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Trip { get; set; }
        public int? OfflineHold { get; set; }
        public int? OfflineConfirm { get; set; }
    }
}
