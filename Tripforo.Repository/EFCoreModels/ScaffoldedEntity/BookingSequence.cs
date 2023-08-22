using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class BookingSequence
    {
        public int PnrSequenceId { get; set; }
        public string? ClientCode { get; set; }
        public string? ServiceCode { get; set; }
        public string? Sequence { get; set; }
        public int? TicketNo { get; set; }
        public bool? Status { get; set; }
        public string? Operation { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
