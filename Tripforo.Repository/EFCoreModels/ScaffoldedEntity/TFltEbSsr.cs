using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TFltEbSsr
    {
        public int Sno { get; set; }
        public string? SsrCode { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public string? Vc { get; set; }
        public string? Trip { get; set; }
    }
}
