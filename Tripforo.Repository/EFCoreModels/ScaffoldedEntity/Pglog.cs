using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Pglog
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public string? Tid { get; set; }
        public string? AgentId { get; set; }
        public string? Request { get; set; }
        public string? EncRequest { get; set; }
        public string? Response { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? ApiRequest { get; set; }
        public string? ApiResponse { get; set; }
        public string? ApiEncryptRequest { get; set; }
        public string? PostForm { get; set; }
        public string? ChcekStatusBy { get; set; }
        public bool? AddToWallet { get; set; }
        public string? CheckedIpaddress { get; set; }
    }
}
