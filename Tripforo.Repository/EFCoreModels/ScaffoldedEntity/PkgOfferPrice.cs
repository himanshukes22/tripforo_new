using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgOfferPrice
    {
        public int PkgId { get; set; }
        public int? PkgOfferId { get; set; }
        public decimal? PkgPrice { get; set; }
        public decimal? PkgOfferPrice1 { get; set; }
        public string? PkgTitle { get; set; }
    }
}
