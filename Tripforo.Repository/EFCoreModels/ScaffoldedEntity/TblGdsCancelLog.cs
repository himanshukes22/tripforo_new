using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblGdsCancelLog
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string? Pnr { get; set; }
        public string? TicketNo { get; set; }
        public string? RetrieReq { get; set; }
        public string? RetrieResp { get; set; }
        public string? CancelReq { get; set; }
        public string? CancelResp { get; set; }
        public string? DivideReq { get; set; }
        public string? DivideResp { get; set; }
        public string? EndTransactionReq1 { get; set; }
        public string? EndTransactionResp1 { get; set; }
        public string? EndTransactionReq2 { get; set; }
        public string? EndTransactionResp2 { get; set; }
        public string? EndTransactionReq34 { get; set; }
        public string? EndTransactionResp34 { get; set; }
        public string? StorePriceReq { get; set; }
        public string? StorePriceResp { get; set; }
        public string? RetrieReq2 { get; set; }
        public string? RetrieResp2 { get; set; }
        public string? EndTransactionReq56 { get; set; }
        public string? EndTransactionResp56 { get; set; }
        public DateTime? CancelDate { get; set; }
        public string? NewPnr { get; set; }
    }
}
