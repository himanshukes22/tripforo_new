using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TReissueFltdetail
    {
        public int Fltid { get; set; }
        public string? Orderid { get; set; }
        public string? Refno { get; set; }
        public string? Depcityorairportcode { get; set; }
        public string? Depcityorairportname { get; set; }
        public string? Arrcityorairportcode { get; set; }
        public string? Arrcityorairportname { get; set; }
        public string? Depdate { get; set; }
        public string? Deptime { get; set; }
        public string? Arrdate { get; set; }
        public string? Arrtime { get; set; }
        public string? Airlinecode { get; set; }
        public string? Airlinename { get; set; }
        public string? Fltnumber { get; set; }
        public string? Aircraft { get; set; }
        public string? Adtfarebasis { get; set; }
        public string? Chdfarebasis { get; set; }
        public string? Inffarebasis { get; set; }
        public string? Adtrbd { get; set; }
        public string? Chdrbd { get; set; }
        public string? Infrbd { get; set; }
        public short? Avlseat { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
        public string? Depterminal { get; set; }
        public string? Arrterminal { get; set; }
        public string? Baggage { get; set; }
        public string? Class { get; set; }
        public string? NotValidBefore { get; set; }
        public string? NotValidAfter { get; set; }
        public string? Designator { get; set; }
        public int? PaxId { get; set; }
        public string? ReissueRefNo { get; set; }
        public string? Status { get; set; }
        public long? ReissuFltId { get; set; }
        public string? ExecId { get; set; }
        public string? ReissueRbd { get; set; }
        public bool? IsPnrRetreive { get; set; }
    }
}
