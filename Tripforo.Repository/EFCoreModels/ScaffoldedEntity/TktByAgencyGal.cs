using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TktByAgencyGal
    {
        public int Counter { get; set; }
        public string? Hap { get; set; }
        public string? Userid { get; set; }
        public string? Pwd { get; set; }
        public string? Pcc { get; set; }
        public string? Url { get; set; }
        public string? Qno { get; set; }
        public string? Airline { get; set; }
        public string? AgName { get; set; }
        public bool? OnlineTkt { get; set; }
        public string? StrCode { get; set; }
        public string? Trip { get; set; }
        public string? Provider { get; set; }
        public string? TicketThrough { get; set; }
        public string? QueuePcc { get; set; }
        public string? QnoforApi { get; set; }
        public bool? ForceToHold { get; set; }
        public string? CrdType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? WebProject { get; set; }
    }
}
