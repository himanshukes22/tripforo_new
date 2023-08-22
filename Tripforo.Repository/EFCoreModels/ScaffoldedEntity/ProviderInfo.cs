using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ProviderInfo
    {
        public int Id { get; set; }
        public string? StateCode { get; set; }
        public string? Provider { get; set; }
        public int? GroupId { get; set; }
        public int? Code { get; set; }
    }
}
