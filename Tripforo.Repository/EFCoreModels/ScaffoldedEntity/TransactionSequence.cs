using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TransactionSequence
    {
        public int Index { get; set; }
        public string? ClientCode { get; set; }
        public string? ServiceCode { get; set; }
        public int? TicketNo { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
