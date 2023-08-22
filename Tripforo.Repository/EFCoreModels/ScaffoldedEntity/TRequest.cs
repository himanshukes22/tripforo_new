using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TRequest
    {
        public int Sno { get; set; }
        public string? Requestedby { get; set; }
        public DateTime? Requesteddate { get; set; }
        public string? Hod { get; set; }
        public string? Pnr { get; set; }
        public string? Opsexecutive { get; set; }
        public string? Paymentstatus { get; set; }
        public string? Bookingstatus { get; set; }
        public decimal? Amountpaid { get; set; }
        public string? Servicetype { get; set; }
        public string? Isofficial { get; set; }
        public string? Usertype { get; set; }
        public string? Requestid { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
