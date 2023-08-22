using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductDesc { get; set; } = null!;
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? IsSalable { get; set; }
        public decimal Price { get; set; }
    }
}
