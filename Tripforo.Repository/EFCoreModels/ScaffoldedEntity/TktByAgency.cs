using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TktByAgency
    {
        public int Counter { get; set; }
        public string? CorporateId { get; set; }
        public string? OfficeId { get; set; }
        public string? Password { get; set; }
        public string? ValCar { get; set; }
        public string? AgName { get; set; }
        public bool? OnlineTkt { get; set; }
        public string? SigninXml { get; set; }
        public string? WebProject { get; set; }
    }
}
