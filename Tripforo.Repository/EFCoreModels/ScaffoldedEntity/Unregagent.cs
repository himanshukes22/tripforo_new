using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Unregagent
    {
        public int Id { get; set; }
        public string? Agentid { get; set; }
        public string? Emailid { get; set; }
        public string? Mobileno { get; set; }
        public DateTime? Createddate { get; set; }
        public bool? Regesterd { get; set; }
    }
}
