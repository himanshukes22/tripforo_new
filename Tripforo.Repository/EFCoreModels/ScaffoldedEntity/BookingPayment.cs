using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class BookingPayment
    {
        public long PaymentId { get; set; }
        public string? ReferenceNo { get; set; }
        public decimal? AmountPaid { get; set; }
        public string? BookingType { get; set; }
        public string? ClientCode { get; set; }
        public string? Status { get; set; }
        public DateTime? CreateOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? TrackId { get; set; }
    }
}
