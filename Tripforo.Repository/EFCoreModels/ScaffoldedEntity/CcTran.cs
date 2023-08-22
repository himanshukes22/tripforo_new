using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class CcTran
    {
        public int Counter { get; set; }
        public string? AccUser { get; set; }
        public string? PnrLocator { get; set; }
        public string? SysIden { get; set; }
        public DateTime? TransDate { get; set; }
        public string? Amount { get; set; }
        public string? Email { get; set; }
        public string? TransactionId { get; set; }
        public string? PaymentId { get; set; }
        public string? TrackId { get; set; }
        public string? Status { get; set; }
    }
}
