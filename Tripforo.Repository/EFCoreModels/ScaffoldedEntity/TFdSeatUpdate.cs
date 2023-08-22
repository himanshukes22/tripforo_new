using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TFdSeatUpdate
    {
        public int Id { get; set; }
        public string? Orderid { get; set; }
        public string? Status { get; set; }
        public string? Sno { get; set; }
        public string? Pseat { get; set; }
        public string? Cseat { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Pnr { get; set; }
        public string? UsedSeat { get; set; }
        public string? AvlSeat { get; set; }
        public string? PusedSeat { get; set; }
        public string? PavlSeat { get; set; }
    }
}
