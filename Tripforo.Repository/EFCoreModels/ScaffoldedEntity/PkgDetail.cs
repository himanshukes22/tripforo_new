using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PkgDetail
    {
        public int Counter { get; set; }
        public long? PkgId { get; set; }
        public string? PkgTitle { get; set; }
        public string? PkgType { get; set; }
        public string? PkgTheme { get; set; }
        public string? PkgLocation { get; set; }
        public string? PkgDestinetionCity { get; set; }
        public int? PkgNoofday { get; set; }
        public int? PkgNoofnight { get; set; }
        public decimal? PkgPrice { get; set; }
        public DateTime? PkgStartdate { get; set; }
        public DateTime? PkgEnddate { get; set; }
        public string? PkgDescription { get; set; }
        public string? PkgCreatedby { get; set; }
        public DateTime? PkgCreateddate { get; set; }
        public string? PkgUpdateby { get; set; }
        public DateTime? PkgUpdatedate { get; set; }
        public bool? PkgStatus { get; set; }
        public bool? PkgHotelMark { get; set; }
        public string? PkgImage { get; set; }
        public bool? PkgOfferPrice { get; set; }
        public decimal? PkgOfferPriceValue { get; set; }
        public string? PkgInclusion { get; set; }
        public string? PkgExeclusion { get; set; }
        public string? PkgItinerary { get; set; }
        public string? PkgPolicy { get; set; }
        public string? PkgOffer { get; set; }
    }
}
