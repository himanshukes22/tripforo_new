using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FareRule
    {
        public int Sid { get; set; }
        public string Type { get; set; } = null!;
        public string PenaltyCode { get; set; } = null!;
        public string FareBasis { get; set; } = null!;
        public string? CancellationPolicy { get; set; }
        public string? ReissuancePolicy { get; set; }
        public string? ServiceFee { get; set; }
        public string? SpecialOffer { get; set; }
        public string? MerchantId { get; set; }
        public string? ActiveFlag { get; set; }
        public string? AirlineCode { get; set; }
        public string? Cancelationamount { get; set; }
        public string? Typeofcancelation { get; set; }
    }
}
