using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Order
    {
        public string? OrderId { get; set; }
        public string? CustomerId { get; set; }
        public string? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipCountry { get; set; }
    }
}
