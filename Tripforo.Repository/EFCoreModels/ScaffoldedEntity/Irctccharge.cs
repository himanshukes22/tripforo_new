using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Irctccharge
    {
        public int Id { get; set; }
        public string? ServiceCode { get; set; }
        public decimal? Charges { get; set; }
        public string? ChargesType { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime? ValidFrom { get; set; }
        public bool? Status { get; set; }
        public string? Ip { get; set; }
        public string? GroupType { get; set; }
        public string? UserId { get; set; }
        public string? AgencyId { get; set; }
        public string? AgencyName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public decimal? Pgmin { get; set; }
        public decimal? Pgmax { get; set; }
    }
}
