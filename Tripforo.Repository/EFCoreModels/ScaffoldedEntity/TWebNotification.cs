using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TWebNotification
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public string? UserType { get; set; }
        public string? SpecialType { get; set; }
        public string? Name { get; set; }
        public string? TypeOfmsg { get; set; }
        public string? PageName { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? StartHour { get; set; }
        public string? Startmin { get; set; }
        public string? StartTime { get; set; }
        public string? EndHour { get; set; }
        public string? Endmin { get; set; }
        public string? EndTime { get; set; }
    }
}
