using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class ExceptionLog
    {
        public int Id { get; set; }
        public string? Module { get; set; }
        public string? ClassName { get; set; }
        public string? MethodName { get; set; }
        public string? ErrorCode { get; set; }
        public string? ExMessage { get; set; }
        public string? ExStackTrace { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
