using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblUserLoginTime
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? Ipadress { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
