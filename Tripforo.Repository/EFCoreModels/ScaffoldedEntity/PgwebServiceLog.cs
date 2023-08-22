using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class PgwebServiceLog
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public string? ApiName { get; set; }
        public string? ToHash { get; set; }
        public string? Hashed { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public string? Status { get; set; }
        public string? ExMessage { get; set; }
        public string? ExStackTrace { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
