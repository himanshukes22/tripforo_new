using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblLccLccCredential
    {
        public string? Airlinecode { get; set; }
        public string? Promotionaluserid { get; set; }
        public string? Promotionalpassword { get; set; }
        public string? Promotionalcreditpassword { get; set; }
        public string? Staruserid { get; set; }
        public string? Starpassword { get; set; }
        public string? Starcreditpassword { get; set; }
        public string? Searchenable { get; set; }
        public string? Bookenable { get; set; }
        public int Counter { get; set; }
        public string? Searchviewstate { get; set; }
    }
}
