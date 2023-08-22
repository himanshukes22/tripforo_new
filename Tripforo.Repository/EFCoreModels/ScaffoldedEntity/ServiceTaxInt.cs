using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ServiceTaxInt
    {
        public int Counter { get; set; }
        public string? AirlineName { get; set; }
        public string? AirlineCode { get; set; }
        public decimal? SrvTax { get; set; }
        public decimal? TranFee { get; set; }
        public decimal? Iatacomm { get; set; }
        public string? Trip { get; set; }
    }
}
