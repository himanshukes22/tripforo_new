using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class LccauthenticationTable
    {
        public int Sid { get; set; }
        public string? UserId { get; set; }
        public string? UserPwd { get; set; }
        public string? UserIpaddress { get; set; }
        public string? Lccairlines { get; set; }
        public bool? RailFlag { get; set; }
        public string? BookLcc { get; set; }
        public string? CouponFareCredentials { get; set; }
        public string? Lcccredentials { get; set; }
        public string? LccagencyContact { get; set; }
        public string? FareTolerance { get; set; }
        public string? CorporateFlag { get; set; }
        public string? CorporateCredentials { get; set; }
        public string? CorporateFare { get; set; }
        public string? SpecialCredentials { get; set; }
        public string? ActiveFlag { get; set; }
        public string? ActualUrl { get; set; }
        public string? IntlLccairlines { get; set; }
        public string? LeisureCredentials { get; set; }
        public string? TicketingIds { get; set; }
        public string? LccbalanceCheck { get; set; }
        public string? MerchantLoginCredentials { get; set; }
        public string? MerchantId { get; set; }
        public string? UptoDateGds { get; set; }
        public string? MakeOfflineGds { get; set; }
        public string? AutoTicketing { get; set; }
        public string? CreditCard { get; set; }
        public string? Pgcharges { get; set; }
        public string? GalTktIntl { get; set; }
        public string? TourCode { get; set; }
        public string? FormofPayment { get; set; }
        public string? ExchangeRates { get; set; }
        public string? GoAirCodes { get; set; }
        public string? IntTicketingPcc { get; set; }
    }
}
