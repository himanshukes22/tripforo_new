using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblFopPnrcreation
    {
        public int Counter { get; set; }
        public string? Pcc { get; set; }
        public string? Vendor { get; set; }
        public string? Fop { get; set; }
        public string? Airline { get; set; }
        public string? Provider { get; set; }
        public string? Trip { get; set; }
        public string? CardType { get; set; }
        public string? CardHolderName { get; set; }
        public string? CardNumber { get; set; }
        public string? CardExpDate { get; set; }
        public int? Cvv { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Product { get; set; }
        public string? SupplierName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? BankCountryCode { get; set; }
        public string? AddressName { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? AgencyBillingIdentifier { get; set; }
        public string? AgencyBillingPassword { get; set; }
    }
}
