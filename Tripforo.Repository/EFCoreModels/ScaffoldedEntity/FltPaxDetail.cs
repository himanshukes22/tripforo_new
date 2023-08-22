using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FltPaxDetail
    {
        public int PaxId { get; set; }
        public string? OrderId { get; set; }
        public string? TransactionId { get; set; }
        public string? Title { get; set; }
        public string? Fname { get; set; }
        public string? Mname { get; set; }
        public string? Lname { get; set; }
        public string? PaxType { get; set; }
        public string? TicketNumber { get; set; }
        public string? Dob { get; set; }
        public string? Ffnumber { get; set; }
        public string? Ffairline { get; set; }
        public string? MealType { get; set; }
        public string? SeatType { get; set; }
        public bool? IsPrimary { get; set; }
        public string? InfAssociatePaxName { get; set; }
        public string? MordifyStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Yflag { get; set; }
        public bool? Ycrn { get; set; }
        public string? Gender { get; set; }
        public string? PassportExpireDate { get; set; }
        public string? PassportNo { get; set; }
        public string? IssueCountryCode { get; set; }
        public string? NationalityCode { get; set; }
        public string? VisaDet { get; set; }
    }
}
