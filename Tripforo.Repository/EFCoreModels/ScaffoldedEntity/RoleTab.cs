using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class RoleTab
    {
        public int RoleId { get; set; }
        public string? Role { get; set; }
        public string? RoleType { get; set; }
    }
}
