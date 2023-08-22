using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblCorpBookedby
    {
        public int Counter { get; set; }
        public string? Bookedby { get; set; }
        public string? Agentid { get; set; }
        public string? Type { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
