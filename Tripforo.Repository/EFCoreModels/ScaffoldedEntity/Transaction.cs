using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Transaction
    {
        public int TransactionIndex { get; set; }
        public string? Product { get; set; }
        public string? TransactionId { get; set; }
        public string? ReferenceNo { get; set; }
        public string? ParentTransactionId { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
