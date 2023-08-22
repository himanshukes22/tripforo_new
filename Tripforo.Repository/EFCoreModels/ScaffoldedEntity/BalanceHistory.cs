using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class BalanceHistory
    {
        public long HistoryId { get; set; }
        public long? PaymentId { get; set; }
        public string? ClientCode { get; set; }
        public string? TransactionType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AvailableBalance { get; set; }
        public string? ReferenceNo { get; set; }
        public string? Service { get; set; }
        public DateTime? InsertedOn { get; set; }
        public string? InsertedBy { get; set; }
        public string? Remarks { get; set; }
        public string? TrackId { get; set; }
        public decimal? CreditAmount { get; set; }
    }
}
