using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class SearchLog
    {
        public string? RequestXml { get; set; }
        public string? ResponseXml { get; set; }
        public string? DestFrmDestTo { get; set; }
        public string? SearchValue { get; set; }
    }
}
