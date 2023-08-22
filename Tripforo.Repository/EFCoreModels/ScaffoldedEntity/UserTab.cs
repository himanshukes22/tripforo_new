using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class UserTab
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserType { get; set; } = null!;
    }
}
