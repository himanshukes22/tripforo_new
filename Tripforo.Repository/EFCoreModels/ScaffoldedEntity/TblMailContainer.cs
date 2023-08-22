using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblMailContainer
    {
        public long MailId { get; set; }
        public string? MailModule { get; set; }
        public string? MailContent { get; set; }
        public string? MailSubject { get; set; }
        public string? MailCc { get; set; }
        public string? MailBcc { get; set; }
        public string? MailFrom { get; set; }
        public string? MailHostPwd { get; set; }
        public string? AttachementPath { get; set; }
        public string? FileType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? MailCredencialId { get; set; }
        public string? MailCredencialPwd { get; set; }
    }
}
