using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblFltAbacusTransaction
    {
        public int Counter { get; set; }
        public string? TransactionName { get; set; }
        public string? MessageHeaderId { get; set; }
        public string? Version { get; set; }
        public string? PartyIdType { get; set; }
        public string? PartyIdToValue { get; set; }
        public string? PartyIdFromValue { get; set; }
        public string? Cpaid { get; set; }
        public string? ConversationId { get; set; }
        public string? ServiceType { get; set; }
        public string? ServiceValue { get; set; }
        public string? Action { get; set; }
        public string? PseudoCityCode { get; set; }
        public string? RequestedId { get; set; }
        public string? RequestedType { get; set; }
        public string? CompanyCode { get; set; }
        public string? CompanyType { get; set; }
        public string? MdrsubsetCode { get; set; }
        public string? MaxResponses { get; set; }
        public string? QueueNumber { get; set; }
        public string? ShortText { get; set; }
        public string? TicketTimeLimit { get; set; }
        public string? TicketType { get; set; }
        public string? TicketingPseudoCode { get; set; }
        public decimal? AirTicketCommision { get; set; }
        public string? LineAddressPrinters { get; set; }
        public string? LineAddressHardCopy { get; set; }
    }
}
