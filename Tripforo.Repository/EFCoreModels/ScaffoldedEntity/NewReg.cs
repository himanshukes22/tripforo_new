using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class NewReg
    {
        public int Counter { get; set; }
        public DateTime TimestampCreate { get; set; }
        public string? Title { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Zipcode { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? AltEmail { get; set; }
        public string? FaxNo { get; set; }
        public string? AgencyName { get; set; }
        public string? Website { get; set; }
        public string? PanNo { get; set; }
        public string? Status { get; set; }
        public string? StaxNo { get; set; }
        public string? Remark { get; set; }
        public string? SecQes { get; set; }
        public string? SecAns { get; set; }
        public string? UserId { get; set; }
        public string? Pwd { get; set; }
        public string? AgentType { get; set; }
        public decimal? CrdLimit { get; set; }
        public DateTime? CrdTrnsDate { get; set; }
        public string? Distr { get; set; }
        public string? AgLogo { get; set; }
        public string? AgentStatus { get; set; }
        public string? Tds { get; set; }
        public string? OnlineTkt { get; set; }
        public string? SalesExecId { get; set; }
        public decimal? ExmptTds { get; set; }
        public decimal? ExmptTdsLimit { get; set; }
        public string? NavId { get; set; }
        public string? YId { get; set; }
        public bool? IsCorp { get; set; }
        public bool? IsPwd { get; set; }
    }
}
