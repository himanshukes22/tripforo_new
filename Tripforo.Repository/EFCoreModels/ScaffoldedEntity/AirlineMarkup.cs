using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AirlineMarkup
    {
        public int Counter { get; set; }
        public string? UserId { get; set; }
        public string? Airline { get; set; }
        public string? Markup { get; set; }
        public string? MarkupType { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updatedate { get; set; }
        public string? Updateby { get; set; }
    }
}
