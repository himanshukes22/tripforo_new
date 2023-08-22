using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TicketingLogGal
    {
        public int Counter { get; set; }
        public string? OrderId { get; set; }
        public string? Ssreq { get; set; }
        public string? Ssres { get; set; }
        public string? Pnrrtreq { get; set; }
        public string? Pnrrtres { get; set; }
        public string? Docprdreq { get; set; }
        public string? Docprdres { get; set; }
        public string? Pnrrt2req { get; set; }
        public string? Pnrrt2res { get; set; }
        public string? Sereq { get; set; }
        public string? Seres { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Pnrbf1req { get; set; }
        public string? Pnrbf1res { get; set; }
        public string? Pnrbf2req { get; set; }
        public string? Pnrbf2res { get; set; }
        public string? Pnrbf3req { get; set; }
        public string? Pnrbf3res { get; set; }
        public string? Pnrbf4req { get; set; }
        public string? Pnrbf4res { get; set; }
    }
}
