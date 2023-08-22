﻿using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblBranch
    {
        public long BranchId { get; set; }
        public string? Branch { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
        public bool? Status { get; set; }
    }
}
