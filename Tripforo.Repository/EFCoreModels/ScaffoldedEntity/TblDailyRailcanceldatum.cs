using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblDailyRailcanceldatum
    {
        public double? SlNo { get; set; }
        public double? TransactionId { get; set; }
        public double? PnrNo { get; set; }
        public double? OperatorId { get; set; }
        public string? PgName { get; set; }
        public string? Class { get; set; }
        public double? RefundAmount { get; set; }
        public string? WaitingAutoCancelled { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? ActualRefundDate { get; set; }
        public string? TdrCan { get; set; }
        public string? UserId { get; set; }
        public string? PrincipalUserId { get; set; }
        public double? CancellationId { get; set; }
        public int Counter { get; set; }
        public int? Ledgerentry { get; set; }
    }
}
