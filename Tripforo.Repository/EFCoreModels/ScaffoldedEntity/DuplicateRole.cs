using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class DuplicateRole
    {
        public int Sno { get; set; }
        public string UserId { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
