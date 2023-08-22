using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class UserIdmapping
    {
        public int Counter { get; set; }
        public string? UserId { get; set; }
        public string? TableRef { get; set; }
        public string? TypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Distr { get; set; }
    }
}
