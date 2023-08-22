using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblReferenceNo
    {
        public int Id { get; set; }
        public string? ServiceType { get; set; }
        public string? Prefix { get; set; }
        public int? PrefixId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
