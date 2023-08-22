using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblMailingCredentialItz
    {
        public int Counter { get; set; }
        public string? Mailingdepartment { get; set; }
        public string? Mailfrom { get; set; }
        public string? Mailto { get; set; }
        public string? Cc { get; set; }
        public string? Bcc { get; set; }
        public string? Smtpclient { get; set; }
        public string? Subject { get; set; }
        public string? Agentid { get; set; }
        public DateTime? Createddate { get; set; }
        public string? UserId { get; set; }
        public string? Pass { get; set; }
        public string? Body { get; set; }
        public bool? Status { get; set; }
        public string? Regards { get; set; }
    }
}
