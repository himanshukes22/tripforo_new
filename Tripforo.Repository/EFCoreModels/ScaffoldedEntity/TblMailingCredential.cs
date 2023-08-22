using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblMailingCredential
    {
        public int Counter { get; set; }
        public string? Mailingdepartment { get; set; }
        public string? Mailfrom { get; set; }
        public string? Mailto { get; set; }
        public string? Cc { get; set; }
        public string? Bcc { get; set; }
        public string? Smtpclient { get; set; }
        public string? Mailtext { get; set; }
        public DateTime? Createddate { get; set; }
        public string? UserId { get; set; }
        public string? Pass { get; set; }
        public string? Body { get; set; }
        public string? Distrid { get; set; }
        public string? Regards { get; set; }
    }
}
