using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Ttt
    {
        public int? Slno { get; set; }
        public string? TransactionId { get; set; }
        public string? PnrNo { get; set; }
        public string? ClientTransactionId { get; set; }
        public decimal? BookingAmount { get; set; }
        public string? PgName { get; set; }
        public string? Class { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? UserId { get; set; }
        public string? PrincipalUserId { get; set; }
        public string? AmcChargeIncludingGst { get; set; }
    }
}
