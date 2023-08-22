using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TransReport
    {
        public int Counter { get; set; }
        public string? UserId { get; set; }
        public string? PnrLocator { get; set; }
        public string? PnrStatus { get; set; }
        public DateTime? BookingDate { get; set; }
        public string? Credit { get; set; }
        public string? Discount { get; set; }
        public string? AvalBal { get; set; }
        public string? CashBack { get; set; }
        public string? Debit { get; set; }
        public string? Tds { get; set; }
        public string? Sector { get; set; }
        public string? PaxFname { get; set; }
        public string? FlightNo { get; set; }
        public string? PaxMobile { get; set; }
        public string? PaxEmail { get; set; }
        public string? Rm { get; set; }
        public string? PaymentType { get; set; }
        public string? AgentMrk { get; set; }
        public string? Distr { get; set; }
        public string? FareAftdis { get; set; }
        public string? Tax { get; set; }
        public string? Yq { get; set; }
        public string? STax { get; set; }
        public string? TotBf { get; set; }
        public string? AgName { get; set; }
        public string? Sfdis { get; set; }
        public string? Tf { get; set; }
        public string? BookingType { get; set; }
        public decimal? DueAmount { get; set; }
        public decimal? CreditLimit { get; set; }
        public string? OrderId { get; set; }
    }
}
