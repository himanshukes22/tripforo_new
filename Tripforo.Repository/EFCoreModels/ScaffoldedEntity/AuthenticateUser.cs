using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class AuthenticateUser
    {
        public int Counter { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? AuthenticatedIp { get; set; }
        public string? Airline { get; set; }
        public bool? Enable { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
