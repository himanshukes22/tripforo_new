using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblNavCredential
    {
        public int Counter { get; set; }
        public string? DomainName { get; set; }
        public string? UserName { get; set; }
        public string? Pwd { get; set; }
        public string? ServiceUrl { get; set; }
        public DateTime? CeartedDate { get; set; }
    }
}
