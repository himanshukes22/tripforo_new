using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class UploadAgentTypeBak
    {
        public int Counter { get; set; }
        public string? GroupType { get; set; }
        public string? UploadCategory { get; set; }
        public string? UploadCategoryText { get; set; }
        public string? SubCategory { get; set; }
        public string? Text { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Distr { get; set; }
    }
}
