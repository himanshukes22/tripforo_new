using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AmountVerification
    {
        public int Counter { get; set; }
        public string? Amount { get; set; }
        public string? EmailId { get; set; }
        public string? VerficationCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModification { get; set; }
    }
}
