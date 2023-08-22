using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ResultSessionDetail
    {
        public long Rsindex { get; set; }
        public string? ClientCode { get; set; }
        public string? ResultSessionKey { get; set; }
        public DateTime? CreateOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
