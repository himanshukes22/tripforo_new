using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCouponCrd
    {
        public int Id { get; set; }
        public string? Airline { get; set; }
        public string? UserId { get; set; }
        public string? Pass { get; set; }
        public string? CorporateId { get; set; }
        public bool? Status { get; set; }
        public DateTime? Date { get; set; }
    }
}
