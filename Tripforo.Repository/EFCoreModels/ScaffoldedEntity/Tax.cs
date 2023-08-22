using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Tax
    {
        public string? From { get; set; }
        public string? To { get; set; }
        public double? Flag { get; set; }
    }
}
