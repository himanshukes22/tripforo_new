using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblDistrcashbackDetail
    {
        public int Counter { get; set; }
        public string? Cborderno { get; set; }
        public string? Distrid { get; set; }
        public decimal? Airticket { get; set; }
        public decimal? Airsale { get; set; }
        public decimal? Aircb { get; set; }
        public decimal? Aircbdistr { get; set; }
        public decimal? Railticket { get; set; }
        public decimal? Railsale { get; set; }
        public decimal? Railcb { get; set; }
        public decimal? Railcbdistr { get; set; }
        public DateTime? Cbdate { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
