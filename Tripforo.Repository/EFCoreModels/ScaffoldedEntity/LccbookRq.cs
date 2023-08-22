using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class LccbookRq
    {
        public int Sid { get; set; }
        public string? QueryData { get; set; }
        public string? Keys { get; set; }
        public string? UserData { get; set; }
        public string? AgencyData { get; set; }
        public string? PayPassword { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? Pnr { get; set; }
        public string? ServerIp { get; set; }
    }
}
