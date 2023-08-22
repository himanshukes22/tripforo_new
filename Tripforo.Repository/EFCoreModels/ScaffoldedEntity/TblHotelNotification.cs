using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblHotelNotification
    {
        public int Sno { get; set; }
        public string? AgentId { get; set; }
        public DateTime? NotiUpdated { get; set; }
        public bool? NotiActiveStatus { get; set; }
    }
}
