using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblLccresult
    {
        public long Counter { get; set; }
        public string? Flight { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; }
        public string? Departuretime { get; set; }
        public string? Arrivaltime { get; set; }
        public string? Adultfare { get; set; }
        public string? Childfare { get; set; }
        public string? Infantfare { get; set; }
        public string? Totalpackagecost { get; set; }
        public string? Sessionid { get; set; }
        public string? Flightcount { get; set; }
        public string? Hiddenvalue { get; set; }
        public string? Radioselector { get; set; }
    }
}
