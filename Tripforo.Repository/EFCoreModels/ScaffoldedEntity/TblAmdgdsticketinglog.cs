using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblAmdgdsticketinglog
    {
        public int Counter { get; set; }
        public string? Orderid { get; set; }
        public string? SigninReq { get; set; }
        public string? SigninRes { get; set; }
        public string? RetrivepnrReq { get; set; }
        public string? RetrivepnrRes { get; set; }
        public string? CripticReq { get; set; }
        public string? CripticRes { get; set; }
        public string? SignoutReq { get; set; }
        public string? SignoutRes { get; set; }
        public string? Other { get; set; }
        public DateTime? Createddate { get; set; }
        public string? RetrivepnrtktReq { get; set; }
        public string? RetrivepnrtktRes { get; set; }
        public string? RepriceReq { get; set; }
        public string? RepriceRes { get; set; }
        public string? RetstReq { get; set; }
        public string? RetstRes { get; set; }
        public string? RepnrretriveReq { get; set; }
        public string? RepnrretriveRes { get; set; }
    }
}
