using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ImportPnrintl
    {
        public int ImportId { get; set; }
        public string? OrderId { get; set; }
        public string? Pnrno { get; set; }
        public string? Airline { get; set; }
        public string? Departure { get; set; }
        public string? Destination { get; set; }
        public string? Departdate { get; set; }
        public string? DepartTime { get; set; }
        public string? ArrivalDate { get; set; }
        public string? ArrivalTime { get; set; }
        public string? FlightNo { get; set; }
        public string? Rdb { get; set; }
        public string? Name { get; set; }
        public string? AgentId { get; set; }
        public string? AgName { get; set; }
        public string? ExecId { get; set; }
        public string? Status { get; set; }
        public bool? BlockPnr { get; set; }
        public DateTime? RequestDateTime { get; set; }
        public string? Escharge { get; set; }
        public string? Remark { get; set; }
        public string? RejRemark { get; set; }
        public string? UpdRemark { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public string? Trip { get; set; }
        public string? TripType { get; set; }
        public string? SalesExecId { get; set; }
        public string? AgentType { get; set; }
        public decimal? ImportCharge { get; set; }
        public string? ProjectId { get; set; }
        public string? BookedBy { get; set; }
        public string? Provider { get; set; }
        public string? Distrid { get; set; }
        public decimal? SrvTax { get; set; }
        public string? FltheadrColumn { get; set; }
        public string? AdtFareBasis { get; set; }
        public string? ChdFareBasis { get; set; }
        public string? InfFareBasis { get; set; }
    }
}
