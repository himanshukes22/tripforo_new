using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblMidServiceCall
    {
        public int Sno { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? FromDate { get; set; }
        public int? NoOfHowManyDays { get; set; }
        public bool? Active { get; set; }
        public int? Adult { get; set; }
        public int? Child { get; set; }
        public int? Infrant { get; set; }
        public string? AirlineCode { get; set; }
        public string? ProviderType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
    }
}
