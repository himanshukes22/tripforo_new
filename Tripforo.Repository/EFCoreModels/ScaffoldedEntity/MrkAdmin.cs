using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class MrkAdmin
    {
        public int Counter { get; set; }
        public string? UserId { get; set; }
        public string? Airline { get; set; }
        public string? MarkUp { get; set; }
        public string? MarkupType { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
