using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCabinClassForOffineRecord
    {
        public long Id { get; set; }
        public string? OrderId { get; set; }
        public string? CabinClass { get; set; }
        public string? FareType { get; set; }
        public string? Rbd { get; set; }
        public string? BookingType { get; set; }
        public DateTime Date { get; set; }
    }
}
