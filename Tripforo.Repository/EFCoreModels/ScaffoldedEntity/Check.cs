using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class Check
    {
        public int Id { get; set; }
        public string? Gptype { get; set; }
        public string? Aircode { get; set; }
        public string? Sector { get; set; }
        public string? Depdate { get; set; }
        public string? ReturnDate { get; set; }
        public string? FareType { get; set; }
        public decimal? BaseFare { get; set; }
        public decimal? Yq { get; set; }
        public int? PaxCnt { get; set; }
        public string? Rbd { get; set; }
        public string? CabinClass { get; set; }
        public string? Farebasis { get; set; }
        public string? OrgCountry { get; set; }
        public string? DestCountry { get; set; }
        public string? FltNum { get; set; }
        public string? Opc { get; set; }
        public string? MktC { get; set; }
        public string? BkgChannel { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
