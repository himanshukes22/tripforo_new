using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TInstantPayBankDetail
    {
        public long Id { get; set; }
        public string? BankId { get; set; }
        public string? BankName { get; set; }
        public string? ImpsEnabled { get; set; }
        public string? AepsEnabled { get; set; }
        public string? BankSortName { get; set; }
        public string? BranchIfsc { get; set; }
        public string? IfscAlias { get; set; }
        public string? BankIin { get; set; }
        public string? IsDown { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
