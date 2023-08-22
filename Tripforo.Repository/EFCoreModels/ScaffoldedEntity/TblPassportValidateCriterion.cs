using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPassportValidateCriterion
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public string? Sector { get; set; }
    }
}
