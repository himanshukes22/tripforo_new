using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblQuery
    {
        public int Id { get; set; }
        public string? Querystring { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
