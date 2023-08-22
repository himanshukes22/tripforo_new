using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TableWebhandeler
    {
        public int Counter { get; set; }
        public string? Id { get; set; }
        public string? Orderid { get; set; }
        public string? Imagename { get; set; }
        public string? Ip { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
