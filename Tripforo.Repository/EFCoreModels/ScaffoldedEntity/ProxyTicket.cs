using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ProxyTicket
    {
        public int ProxyId { get; set; }
        public string? BookingType { get; set; }
        public string? TravelType { get; set; }
        public string? ProxyFrom { get; set; }
        public string? ProxyTo { get; set; }
        public string? DepartDate { get; set; }
        public string? ReturnDate { get; set; }
        public string? DepartTime { get; set; }
        public string? ReturnTime { get; set; }
        public int? Adult { get; set; }
        public int? Child { get; set; }
        public int? Infrant { get; set; }
        public string? Class { get; set; }
        public string? Airlines { get; set; }
        public string? Classes { get; set; }
        public string? PaymentMode { get; set; }
        public string? Remark { get; set; }
        public string? AgentId { get; set; }
        public string? AgName { get; set; }
        public string? ExecId { get; set; }
        public string? Status { get; set; }
        public bool? BlockProxy { get; set; }
        public DateTime? RequestDateTime { get; set; }
        public string? RejectComment { get; set; }
        public string? UpdateRemark { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public string? ProxyType { get; set; }
        public decimal? SrvChargeOneWay { get; set; }
        public decimal? SrvChargeTwoWay { get; set; }
        public string? OrderIdOneWay { get; set; }
        public string? OrderIdTwoWay { get; set; }
        public string? RbdoneWay { get; set; }
        public string? RbdtwoWay { get; set; }
        public string? SalesExecId { get; set; }
        public string? AgentType { get; set; }
        public decimal? ProxyChargeOw { get; set; }
        public decimal? ProxyChargeRt { get; set; }
        public string? ProjectId { get; set; }
        public string? BookedBy { get; set; }
        public string? Distrid { get; set; }
        public string? ExpectedAmount { get; set; }
        public bool? NameGiven { get; set; }
        public string? FlightNo { get; set; }
        public string? DepartureTerminal { get; set; }
        public string? AirlinePnr { get; set; }
    }
}
