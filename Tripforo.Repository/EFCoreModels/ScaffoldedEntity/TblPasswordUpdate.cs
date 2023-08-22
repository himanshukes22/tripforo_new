using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblPasswordUpdate
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? Pwd { get; set; }
        public string? Newpwd { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
