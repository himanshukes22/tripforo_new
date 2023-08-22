using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPgRadiolist
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public string? Text { get; set; }
        public string? Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Provider { get; set; }
        public bool? Status { get; set; }
        public int? IsOrder { get; set; }
        public string? PaymentMode { get; set; }
        public string? DisplayName { get; set; }
        public bool? Flight { get; set; }
        public bool? Hotel { get; set; }
        public bool? Bus { get; set; }
        public bool? Active { get; set; }
    }
}
