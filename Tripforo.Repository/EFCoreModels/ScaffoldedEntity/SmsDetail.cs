using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class SmsDetail
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public string? MobNo { get; set; }
        public string? MsgText { get; set; }
        public string? StatCd { get; set; }
        public DateTime? Smsdate { get; set; }
    }
}
