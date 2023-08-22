using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Notification
    {
        public int Index { get; set; }
        public string? Activity { get; set; }
        public string? Source { get; set; }
        public DateTime? InsertedOn { get; set; }
        public string? InsertedBy { get; set; }
        public DateTime? CheckedOn { get; set; }
        public string? CheckedBy { get; set; }
        public string? UserId { get; set; }
        public bool? IsChecked { get; set; }
        public string? Product { get; set; }
    }
}
