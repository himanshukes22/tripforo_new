using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class BankDetail
    {
        public int Counter { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? Area { get; set; }
        public string? AccountNumber { get; set; }
        public string? Neftcode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Distrid { get; set; }
    }
}
