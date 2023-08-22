using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class RailBookingHistory
    {
        public int Id { get; set; }
        public string? ReferenceNo { get; set; }
        public string? ReservationId { get; set; }
        public string? BankTxnId { get; set; }
        public string? UserId { get; set; }
        public string? AgencyId { get; set; }
        public string? DistrId { get; set; }
        public string? AgencyName { get; set; }
        public string Type { get; set; } = null!;
        public decimal? TxnAmt { get; set; }
        public decimal? Pgcharge { get; set; }
        public decimal? AgentCharge { get; set; }
        public decimal? GstOnAgentCharge { get; set; }
        public decimal? TotalAmt { get; set; }
        public string? ChargesType { get; set; }
        public decimal? Charges { get; set; }
        public decimal? Pgmin { get; set; }
        public decimal? Pgmax { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
