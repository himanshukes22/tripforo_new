using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class FlyrajaContext : DbContext
    {
        public FlyrajaContext()
        {
        }

        public FlyrajaContext(DbContextOptions<FlyrajaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountIntegration> AccountIntegrations { get; set; } = null!;
        public virtual DbSet<ActionHistory> ActionHistories { get; set; } = null!;
        public virtual DbSet<ActiveAirline> ActiveAirlines { get; set; } = null!;
        public virtual DbSet<AdminB2b> AdminB2bs { get; set; } = null!;
        public virtual DbSet<AdminMarkup> AdminMarkups { get; set; } = null!;
        public virtual DbSet<Adult> Adults { get; set; } = null!;
        public virtual DbSet<AdvAvailability> AdvAvailabilities { get; set; } = null!;
        public virtual DbSet<AgentCd> AgentCds { get; set; } = null!;
        public virtual DbSet<AgentMarkup> AgentMarkups { get; set; } = null!;
        public virtual DbSet<AgentRegister> AgentRegisters { get; set; } = null!;
        public virtual DbSet<AgentRegister05082019> AgentRegister05082019s { get; set; } = null!;
        public virtual DbSet<AgentRegister06082019> AgentRegister06082019s { get; set; } = null!;
        public virtual DbSet<AgentRegister1406> AgentRegister1406s { get; set; } = null!;
        public virtual DbSet<AgentRegisterLog> AgentRegisterLogs { get; set; } = null!;
        public virtual DbSet<AgentService> AgentServices { get; set; } = null!;
        public virtual DbSet<AgentStaffRegister> AgentStaffRegisters { get; set; } = null!;
        public virtual DbSet<AgentVisaQuery> AgentVisaQueries { get; set; } = null!;
        public virtual DbSet<Agentreg1> Agentreg1s { get; set; } = null!;
        public virtual DbSet<AirLineName> AirLineNames { get; set; } = null!;
        public virtual DbSet<AirLinesName> AirLinesNames { get; set; } = null!;
        public virtual DbSet<Aircode> Aircodes { get; set; } = null!;
        public virtual DbSet<AirlineMarkup> AirlineMarkups { get; set; } = null!;
        public virtual DbSet<AirlinePa> AirlinePas { get; set; } = null!;
        public virtual DbSet<AirlineTicketNumberLog> AirlineTicketNumberLogs { get; set; } = null!;
        public virtual DbSet<AirportDetailsByFlightStat> AirportDetailsByFlightStats { get; set; } = null!;
        public virtual DbSet<AirportInfo> AirportInfos { get; set; } = null!;
        public virtual DbSet<AirportName> AirportNames { get; set; } = null!;
        public virtual DbSet<AmountVerification> AmountVerifications { get; set; } = null!;
        public virtual DbSet<AmsAvailability> AmsAvailabilities { get; set; } = null!;
        public virtual DbSet<AmsAvailabilityNew> AmsAvailabilityNews { get; set; } = null!;
        public virtual DbSet<AmsRecommdation> AmsRecommdations { get; set; } = null!;
        public virtual DbSet<AmsRecommdationNew> AmsRecommdationNews { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AuthenticateUser> AuthenticateUsers { get; set; } = null!;
        public virtual DbSet<AvailabilityResult> AvailabilityResults { get; set; } = null!;
        public virtual DbSet<B2bemailAddress> B2bemailAddresses { get; set; } = null!;
        public virtual DbSet<BalanceHistory> BalanceHistories { get; set; } = null!;
        public virtual DbSet<BankDetail> BankDetails { get; set; } = null!;
        public virtual DbSet<BillingCountry> BillingCountries { get; set; } = null!;
        public virtual DbSet<BlockBooking> BlockBookings { get; set; } = null!;
        public virtual DbSet<BookingLog> BookingLogs { get; set; } = null!;
        public virtual DbSet<BookingPayment> BookingPayments { get; set; } = null!;
        public virtual DbSet<BookingSequence> BookingSequences { get; set; } = null!;
        public virtual DbSet<Bookinglog1> Bookinglogs1 { get; set; } = null!;
        public virtual DbSet<CanReq> CanReqs { get; set; } = null!;
        public virtual DbSet<Cancellation> Cancellations { get; set; } = null!;
        public virtual DbSet<CancellationIntl> CancellationIntls { get; set; } = null!;
        public virtual DbSet<CancellationIntlMass> CancellationIntlMasses { get; set; } = null!;
        public virtual DbSet<CcTran> CcTrans { get; set; } = null!;
        public virtual DbSet<Check> Checks { get; set; } = null!;
        public virtual DbSet<CheckRecord> CheckRecords { get; set; } = null!;
        public virtual DbSet<Child> Children { get; set; } = null!;
        public virtual DbSet<Chkled> Chkleds { get; set; } = null!;
        public virtual DbSet<CityList> CityLists { get; set; } = null!;
        public virtual DbSet<CityListYatra> CityListYatras { get; set; } = null!;
        public virtual DbSet<Commission> Commissions { get; set; } = null!;
        public virtual DbSet<CommissionNew> CommissionNews { get; set; } = null!;
        public virtual DbSet<CommissionNewBak> CommissionNewBaks { get; set; } = null!;
        public virtual DbSet<CommissionnewBackup> CommissionnewBackups { get; set; } = null!;
        public virtual DbSet<CouponRequestResponse> CouponRequestResponses { get; set; } = null!;
        public virtual DbSet<CreditLimitTransaction> CreditLimitTransactions { get; set; } = null!;
        public virtual DbSet<CreditLimitTransactionDistrAgent> CreditLimitTransactionDistrAgents { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; } = null!;
        public virtual DbSet<DepositDetail> DepositDetails { get; set; } = null!;
        public virtual DbSet<DiscountDetail> DiscountDetails { get; set; } = null!;
        public virtual DbSet<Distributor> Distributors { get; set; } = null!;
        public virtual DbSet<DuplicateRole> DuplicateRoles { get; set; } = null!;
        public virtual DbSet<EmailBody> EmailBodies { get; set; } = null!;
        public virtual DbSet<Enquiry> Enquiries { get; set; } = null!;
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; } = null!;
        public virtual DbSet<ExecIpaddress> ExecIpaddresses { get; set; } = null!;
        public virtual DbSet<Execu> Execus { get; set; } = null!;
        public virtual DbSet<ExecuRegister> ExecuRegisters { get; set; } = null!;
        public virtual DbSet<ExecuRegister1> ExecuRegister1s { get; set; } = null!;
        public virtual DbSet<ExpiryCreditLimitHistory> ExpiryCreditLimitHistories { get; set; } = null!;
        public virtual DbSet<FareDetail> FareDetails { get; set; } = null!;
        public virtual DbSet<FareRule> FareRules { get; set; } = null!;
        public virtual DbSet<FareTypeMaster> FareTypeMasters { get; set; } = null!;
        public virtual DbSet<FlightBooking> FlightBookings { get; set; } = null!;
        public virtual DbSet<FlightDetail> FlightDetails { get; set; } = null!;
        public virtual DbSet<FlightSearchResult> FlightSearchResults { get; set; } = null!;
        public virtual DbSet<FltDetail> FltDetails { get; set; } = null!;
        public virtual DbSet<FltFareDetail> FltFareDetails { get; set; } = null!;
        public virtual DbSet<FltHeader> FltHeaders { get; set; } = null!;
        public virtual DbSet<FltHoldCharge> FltHoldCharges { get; set; } = null!;
        public virtual DbSet<FltImportPnrSetting> FltImportPnrSettings { get; set; } = null!;
        public virtual DbSet<FltPaxDetail> FltPaxDetails { get; set; } = null!;
        public virtual DbSet<GdsbookingLog> GdsbookingLogs { get; set; } = null!;
        public virtual DbSet<GrpBookingDetail> GrpBookingDetails { get; set; } = null!;
        public virtual DbSet<GrpFlightDetail> GrpFlightDetails { get; set; } = null!;
        public virtual DbSet<GrpPaxDetail> GrpPaxDetails { get; set; } = null!;
        public virtual DbSet<GrpPriceQuotation> GrpPriceQuotations { get; set; } = null!;
        public virtual DbSet<GrpRefundAmount> GrpRefundAmounts { get; set; } = null!;
        public virtual DbSet<Gstdetail> Gstdetails { get; set; } = null!;
        public virtual DbSet<GtaCountryList> GtaCountryLists { get; set; } = null!;
        public virtual DbSet<HoldByAgentStatus> HoldByAgentStatuses { get; set; } = null!;
        public virtual DbSet<HomeNotification> HomeNotifications { get; set; } = null!;
        public virtual DbSet<HotelCancellation> HotelCancellations { get; set; } = null!;
        public virtual DbSet<HotelDetail> HotelDetails { get; set; } = null!;
        public virtual DbSet<HotelExlusion> HotelExlusions { get; set; } = null!;
        public virtual DbSet<HotelImage> HotelImages { get; set; } = null!;
        public virtual DbSet<HotelIncluExeclu> HotelIncluExeclus { get; set; } = null!;
        public virtual DbSet<HotelInclusion> HotelInclusions { get; set; } = null!;
        public virtual DbSet<HotelItinerary> HotelItineraries { get; set; } = null!;
        public virtual DbSet<ImportFltFareDetail> ImportFltFareDetails { get; set; } = null!;
        public virtual DbSet<ImportPnr> ImportPnrs { get; set; } = null!;
        public virtual DbSet<ImportPnrintl> ImportPnrintls { get; set; } = null!;
        public virtual DbSet<Infrant> Infrants { get; set; } = null!;
        public virtual DbSet<IntPlb> IntPlbs { get; set; } = null!;
        public virtual DbSet<Irctccharge> Irctccharges { get; set; } = null!;
        public virtual DbSet<LccBookingLog> LccBookingLogs { get; set; } = null!;
        public virtual DbSet<LccFlightAvailability> LccFlightAvailabilities { get; set; } = null!;
        public virtual DbSet<LccTraceId> LccTraceIds { get; set; } = null!;
        public virtual DbSet<LccairlineSector> LccairlineSectors { get; set; } = null!;
        public virtual DbSet<LccairlineSectorIntl> LccairlineSectorIntls { get; set; } = null!;
        public virtual DbSet<LccauthenticationTable> LccauthenticationTables { get; set; } = null!;
        public virtual DbSet<LccbookRq> LccbookRqs { get; set; } = null!;
        public virtual DbSet<LedgerDetail> LedgerDetails { get; set; } = null!;
        public virtual DbSet<MailNotificationCredential> MailNotificationCredentials { get; set; } = null!;
        public virtual DbSet<MailerQuery> MailerQueries { get; set; } = null!;
        public virtual DbSet<MarqueeDetail> MarqueeDetails { get; set; } = null!;
        public virtual DbSet<MarqueeMsg> MarqueeMsgs { get; set; } = null!;
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = null!;
        public virtual DbSet<MiscSrvCharge> MiscSrvCharges { get; set; } = null!;
        public virtual DbSet<MobileSmsMaster> MobileSmsMasters { get; set; } = null!;
        public virtual DbSet<MrkAdmin> MrkAdmins { get; set; } = null!;
        public virtual DbSet<MstService> MstServices { get; set; } = null!;
        public virtual DbSet<NewReg> NewRegs { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<OlOfflineSeriesRequest> OlOfflineSeriesRequests { get; set; } = null!;
        public virtual DbSet<OlSeriesAccountingRequest> OlSeriesAccountingRequests { get; set; } = null!;
        public virtual DbSet<OlSeriesDetail> OlSeriesDetails { get; set; } = null!;
        public virtual DbSet<OlSeriesRequest> OlSeriesRequests { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Otphistory> Otphistories { get; set; } = null!;
        public virtual DbSet<Otptransaction> Otptransactions { get; set; } = null!;
        public virtual DbSet<PageAuthentication> PageAuthentications { get; set; } = null!;
        public virtual DbSet<PageAuthorized> PageAuthorizeds { get; set; } = null!;
        public virtual DbSet<PageDetail> PageDetails { get; set; } = null!;
        public virtual DbSet<PageUserAuthorization> PageUserAuthorizations { get; set; } = null!;
        public virtual DbSet<PaxInformation> PaxInformations { get; set; } = null!;
        public virtual DbSet<PgRefundAmount> PgRefundAmounts { get; set; } = null!;
        public virtual DbSet<Pgcharge> Pgcharges { get; set; } = null!;
        public virtual DbSet<PgchargesLog> PgchargesLogs { get; set; } = null!;
        public virtual DbSet<Pglog> Pglogs { get; set; } = null!;
        public virtual DbSet<PgwebServiceLog> PgwebServiceLogs { get; set; } = null!;
        public virtual DbSet<PkgBooking> PkgBookings { get; set; } = null!;
        public virtual DbSet<PkgDetail> PkgDetails { get; set; } = null!;
        public virtual DbSet<PkgExclusion> PkgExclusions { get; set; } = null!;
        public virtual DbSet<PkgHotelAdd> PkgHotelAdds { get; set; } = null!;
        public virtual DbSet<PkgImage> PkgImages { get; set; } = null!;
        public virtual DbSet<PkgIncluExclu> PkgIncluExclus { get; set; } = null!;
        public virtual DbSet<PkgInclusion> PkgInclusions { get; set; } = null!;
        public virtual DbSet<PkgItinerary> PkgItineraries { get; set; } = null!;
        public virtual DbSet<PkgOfferPrice> PkgOfferPrices { get; set; } = null!;
        public virtual DbSet<PkgPolicy> PkgPolicies { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProviderInfo> ProviderInfos { get; set; } = null!;
        public virtual DbSet<ProxyIpdetail> ProxyIpdetails { get; set; } = null!;
        public virtual DbSet<ProxyTicket> ProxyTickets { get; set; } = null!;
        public virtual DbSet<QuickContact> QuickContacts { get; set; } = null!;
        public virtual DbSet<RailAgent> RailAgents { get; set; } = null!;
        public virtual DbSet<RailBookingHistory> RailBookingHistories { get; set; } = null!;
        public virtual DbSet<RailRefundFw> RailRefundFws { get; set; } = null!;
        public virtual DbSet<Rdslog> Rdslogs { get; set; } = null!;
        public virtual DbSet<Rdspayment> Rdspayments { get; set; } = null!;
        public virtual DbSet<RdspaymentResponse> RdspaymentResponses { get; set; } = null!;
        public virtual DbSet<Rdsrequest> Rdsrequests { get; set; } = null!;
        public virtual DbSet<RdsverificationResponse> RdsverificationResponses { get; set; } = null!;
        public virtual DbSet<ReIssue> ReIssues { get; set; } = null!;
        public virtual DbSet<ReIssueIntl> ReIssueIntls { get; set; } = null!;
        public virtual DbSet<ResultSessionDetail> ResultSessionDetails { get; set; } = null!;
        public virtual DbSet<RoleTab> RoleTabs { get; set; } = null!;
        public virtual DbSet<SalesExecReg> SalesExecRegs { get; set; } = null!;
        public virtual DbSet<SearchLog> SearchLogs { get; set; } = null!;
        public virtual DbSet<SelectedFlightDetail> SelectedFlightDetails { get; set; } = null!;
        public virtual DbSet<SelectedFlightDetailsGal> SelectedFlightDetailsGals { get; set; } = null!;
        public virtual DbSet<ServiceCredential> ServiceCredentials { get; set; } = null!;
        public virtual DbSet<ServiceCredentialsTemp> ServiceCredentialsTemps { get; set; } = null!;
        public virtual DbSet<ServiceCredentialsTest> ServiceCredentialsTests { get; set; } = null!;
        public virtual DbSet<ServiceErrorLog> ServiceErrorLogs { get; set; } = null!;
        public virtual DbSet<ServiceSwitch> ServiceSwitches { get; set; } = null!;
        public virtual DbSet<ServiceSwitchCache> ServiceSwitchCaches { get; set; } = null!;
        public virtual DbSet<ServiceTaxInt> ServiceTaxInts { get; set; } = null!;
        public virtual DbSet<SmsDetail> SmsDetails { get; set; } = null!;
        public virtual DbSet<SmsEmailMaster> SmsEmailMasters { get; set; } = null!;
        public virtual DbSet<SmsserviceType> SmsserviceTypes { get; set; } = null!;
        public virtual DbSet<StInt> StInts { get; set; } = null!;
        public virtual DbSet<StaffTransaction> StaffTransactions { get; set; } = null!;
        public virtual DbSet<StatusTable> StatusTables { get; set; } = null!;
        public virtual DbSet<TAirFareTypeSetting> TAirFareTypeSettings { get; set; } = null!;
        public virtual DbSet<TCanLog> TCanLogs { get; set; } = null!;
        public virtual DbSet<TCancImportPnr> TCancImportPnrs { get; set; } = null!;
        public virtual DbSet<TDealCodeMstr> TDealCodeMstrs { get; set; } = null!;
        public virtual DbSet<TDmtmarkupCharge> TDmtmarkupCharges { get; set; } = null!;
        public virtual DbSet<TFdSeatUpdate> TFdSeatUpdates { get; set; } = null!;
        public virtual DbSet<TFlightDetail> TFlightDetails { get; set; } = null!;
        public virtual DbSet<TFltEbSsr> TFltEbSsrs { get; set; } = null!;
        public virtual DbSet<TFltMbSsrLog> TFltMbSsrLogs { get; set; } = null!;
        public virtual DbSet<TFltMealAndBaggageRequest> TFltMealAndBaggageRequests { get; set; } = null!;
        public virtual DbSet<TFltMealSsr> TFltMealSsrs { get; set; } = null!;
        public virtual DbSet<TFltdetailsCancellation> TFltdetailsCancellations { get; set; } = null!;
        public virtual DbSet<TGstState> TGstStates { get; set; } = null!;
        public virtual DbSet<TInstantPayBankDetail> TInstantPayBankDetails { get; set; } = null!;
        public virtual DbSet<TInstantPayBeneficary> TInstantPayBeneficaries { get; set; } = null!;
        public virtual DbSet<TInstantPayDmtdirectBeneficiary> TInstantPayDmtdirectBeneficiaries { get; set; } = null!;
        public virtual DbSet<TInstantPayDmtdirectRemitter> TInstantPayDmtdirectRemitters { get; set; } = null!;
        public virtual DbSet<TInstantPayErrorLog> TInstantPayErrorLogs { get; set; } = null!;
        public virtual DbSet<TInstantPayFundTransfer> TInstantPayFundTransfers { get; set; } = null!;
        public virtual DbSet<TInstantPayInitiatePayout> TInstantPayInitiatePayouts { get; set; } = null!;
        public virtual DbSet<TInstantPayRemitterDetail> TInstantPayRemitterDetails { get; set; } = null!;
        public virtual DbSet<TInstantPayRemitterReg> TInstantPayRemitterRegs { get; set; } = null!;
        public virtual DbSet<TInstantPayRemitterRegResponse> TInstantPayRemitterRegResponses { get; set; } = null!;
        public virtual DbSet<TInstantPayResponseLog> TInstantPayResponseLogs { get; set; } = null!;
        public virtual DbSet<TIpdmtbeneficaryDetail> TIpdmtbeneficaryDetails { get; set; } = null!;
        public virtual DbSet<TIpdmterrorLog> TIpdmterrorLogs { get; set; } = null!;
        public virtual DbSet<TIpdmtfundTransferDetail> TIpdmtfundTransferDetails { get; set; } = null!;
        public virtual DbSet<TIpdmtremitterBenificiaryLog> TIpdmtremitterBenificiaryLogs { get; set; } = null!;
        public virtual DbSet<TIpdmtremitterDetail> TIpdmtremitterDetails { get; set; } = null!;
        public virtual DbSet<TIpdmtremitterRegLog> TIpdmtremitterRegLogs { get; set; } = null!;
        public virtual DbSet<TIpdmtrequestResponseLog> TIpdmtrequestResponseLogs { get; set; } = null!;
        public virtual DbSet<TReissueFltdetail> TReissueFltdetails { get; set; } = null!;
        public virtual DbSet<TRequest> TRequests { get; set; } = null!;
        public virtual DbSet<TSaltValue> TSaltValues { get; set; } = null!;
        public virtual DbSet<TSeat> TSeats { get; set; } = null!;
        public virtual DbSet<TSeatMstr> TSeatMstrs { get; set; } = null!;
        public virtual DbSet<TSeatRequestTraveller> TSeatRequestTravellers { get; set; } = null!;
        public virtual DbSet<TSmbpBbpsbillerLabelDatum> TSmbpBbpsbillerLabelData { get; set; } = null!;
        public virtual DbSet<TSmbpBbpsbillerList> TSmbpBbpsbillerLists { get; set; } = null!;
        public virtual DbSet<TSmbpBbpspayment> TSmbpBbpspayments { get; set; } = null!;
        public virtual DbSet<TSmbpBbpspaymentOptional> TSmbpBbpspaymentOptionals { get; set; } = null!;
        public virtual DbSet<TSmbpCircleDetail> TSmbpCircleDetails { get; set; } = null!;
        public virtual DbSet<TSmbperrorLog> TSmbperrorLogs { get; set; } = null!;
        public virtual DbSet<TSmbpresponseLog> TSmbpresponseLogs { get; set; } = null!;
        public virtual DbSet<TSmsCredential> TSmsCredentials { get; set; } = null!;
        public virtual DbSet<TUserTypeId> TUserTypeIds { get; set; } = null!;
        public virtual DbSet<TWebNotification> TWebNotifications { get; set; } = null!;
        public virtual DbSet<TableWebhandeler> TableWebhandelers { get; set; } = null!;
        public virtual DbSet<Tax> Taxes { get; set; } = null!;
        public virtual DbSet<TaxiFareChart> TaxiFareCharts { get; set; } = null!;
        public virtual DbSet<TblAdjustmentdetail> TblAdjustmentdetails { get; set; } = null!;
        public virtual DbSet<TblAgencyDetailsUpdationLog> TblAgencyDetailsUpdationLogs { get; set; } = null!;
        public virtual DbSet<TblAgencydetail> TblAgencydetails { get; set; } = null!;
        public virtual DbSet<TblAgentbookingInfo> TblAgentbookingInfos { get; set; } = null!;
        public virtual DbSet<TblAirLinePromoCode> TblAirLinePromoCodes { get; set; } = null!;
        public virtual DbSet<TblAirlineProvider> TblAirlineProviders { get; set; } = null!;
        public virtual DbSet<TblAmdgdsbookinglog> TblAmdgdsbookinglogs { get; set; } = null!;
        public virtual DbSet<TblAmdgdsticketinglog> TblAmdgdsticketinglogs { get; set; } = null!;
        public virtual DbSet<TblAvbookinglog> TblAvbookinglogs { get; set; } = null!;
        public virtual DbSet<TblBaggageinfo> TblBaggageinfos { get; set; } = null!;
        public virtual DbSet<TblBaggageinfo1> TblBaggageinfos1 { get; set; } = null!;
        public virtual DbSet<TblBranch> TblBranches { get; set; } = null!;
        public virtual DbSet<TblCabBookingEntry> TblCabBookingEntries { get; set; } = null!;
        public virtual DbSet<TblCabinClassForOffineRecord> TblCabinClassForOffineRecords { get; set; } = null!;
        public virtual DbSet<TblCancellationCharge> TblCancellationCharges { get; set; } = null!;
        public virtual DbSet<TblChache> TblChaches { get; set; } = null!;
        public virtual DbSet<TblChacheSector> TblChacheSectors { get; set; } = null!;
        public virtual DbSet<TblChacheSectorBackup> TblChacheSectorBackups { get; set; } = null!;
        public virtual DbSet<TblCharterFlightDetail> TblCharterFlightDetails { get; set; } = null!;
        public virtual DbSet<TblCity> TblCities { get; set; } = null!;
        public virtual DbSet<TblClearCacheRecord> TblClearCacheRecords { get; set; } = null!;
        public virtual DbSet<TblCommon> TblCommons { get; set; } = null!;
        public virtual DbSet<TblCompanyaddress> TblCompanyaddresses { get; set; } = null!;
        public virtual DbSet<TblConfiguredMail> TblConfiguredMails { get; set; } = null!;
        public virtual DbSet<TblControl> TblControls { get; set; } = null!;
        public virtual DbSet<TblControlItem> TblControlItems { get; set; } = null!;
        public virtual DbSet<TblCorpBookedby> TblCorpBookedbies { get; set; } = null!;
        public virtual DbSet<TblCorpManagementfee> TblCorpManagementfees { get; set; } = null!;
        public virtual DbSet<TblCorpProject> TblCorpProjects { get; set; } = null!;
        public virtual DbSet<TblCouCouponFareDetail> TblCouCouponFareDetails { get; set; } = null!;
        public virtual DbSet<TblCoupon> TblCoupons { get; set; } = null!;
        public virtual DbSet<TblCouponCrd> TblCouponCrds { get; set; } = null!;
        public virtual DbSet<TblCouponHistory> TblCouponHistories { get; set; } = null!;
        public virtual DbSet<TblCredentialPnrcreation> TblCredentialPnrcreations { get; set; } = null!;
        public virtual DbSet<TblCredentialPnrcreationTest> TblCredentialPnrcreationTests { get; set; } = null!;
        public virtual DbSet<TblCreditDebitNode> TblCreditDebitNodes { get; set; } = null!;
        public virtual DbSet<TblCreditcardPayment> TblCreditcardPayments { get; set; } = null!;
        public virtual DbSet<TblCurrencyDetail> TblCurrencyDetails { get; set; } = null!;
        public virtual DbSet<TblDailyRailcanceldatum> TblDailyRailcanceldata { get; set; } = null!;
        public virtual DbSet<TblDailySalesRpt> TblDailySalesRpts { get; set; } = null!;
        public virtual DbSet<TblDeleteCacheSector> TblDeleteCacheSectors { get; set; } = null!;
        public virtual DbSet<TblDepositeoffice> TblDepositeoffices { get; set; } = null!;
        public virtual DbSet<TblDistrcashback> TblDistrcashbacks { get; set; } = null!;
        public virtual DbSet<TblDistrcashbackDetail> TblDistrcashbackDetails { get; set; } = null!;
        public virtual DbSet<TblExportPermission> TblExportPermissions { get; set; } = null!;
        public virtual DbSet<TblFareRule> TblFareRules { get; set; } = null!;
        public virtual DbSet<TblFltAbacusTransaction> TblFltAbacusTransactions { get; set; } = null!;
        public virtual DbSet<TblFopPnrcreation> TblFopPnrcreations { get; set; } = null!;
        public virtual DbSet<TblFqc> TblFqcs { get; set; } = null!;
        public virtual DbSet<TblGdsCancelLog> TblGdsCancelLogs { get; set; } = null!;
        public virtual DbSet<TblGstDiffLog> TblGstDiffLogs { get; set; } = null!;
        public virtual DbSet<TblHotelNotification> TblHotelNotifications { get; set; } = null!;
        public virtual DbSet<TblInsertCrossfarexml> TblInsertCrossfarexmls { get; set; } = null!;
        public virtual DbSet<TblItemPageLine> TblItemPageLines { get; set; } = null!;
        public virtual DbSet<TblItzTransaction> TblItzTransactions { get; set; } = null!;
        public virtual DbSet<TblLccLccCredential> TblLccLccCredentials { get; set; } = null!;
        public virtual DbSet<TblLcccouponbookinglog> TblLcccouponbookinglogs { get; set; } = null!;
        public virtual DbSet<TblLccresult> TblLccresults { get; set; } = null!;
        public virtual DbSet<TblLogAirlineStatus> TblLogAirlineStatuses { get; set; } = null!;
        public virtual DbSet<TblLogChangeType> TblLogChangeTypes { get; set; } = null!;
        public virtual DbSet<TblLogImportPnr> TblLogImportPnrs { get; set; } = null!;
        public virtual DbSet<TblMailContainer> TblMailContainers { get; set; } = null!;
        public virtual DbSet<TblMailingCredential> TblMailingCredentials { get; set; } = null!;
        public virtual DbSet<TblMailingCredentialItz> TblMailingCredentialItzs { get; set; } = null!;
        public virtual DbSet<TblMailingCredentialItzB2c> TblMailingCredentialItzB2cs { get; set; } = null!;
        public virtual DbSet<TblMailingCredentialItzBookmyfly> TblMailingCredentialItzBookmyflys { get; set; } = null!;
        public virtual DbSet<TblMidServiceCall> TblMidServiceCalls { get; set; } = null!;
        public virtual DbSet<TblModuleAccess> TblModuleAccesses { get; set; } = null!;
        public virtual DbSet<TblNavCredential> TblNavCredentials { get; set; } = null!;
        public virtual DbSet<TblNavFailtransaction> TblNavFailtransactions { get; set; } = null!;
        public virtual DbSet<TblNavOrderrecord> TblNavOrderrecords { get; set; } = null!;
        public virtual DbSet<TblPackage> TblPackages { get; set; } = null!;
        public virtual DbSet<TblPackageSlider> TblPackageSliders { get; set; } = null!;
        public virtual DbSet<TblPassportValidateCriterion> TblPassportValidateCriteria { get; set; } = null!;
        public virtual DbSet<TblPasswordUpdate> TblPasswordUpdates { get; set; } = null!;
        public virtual DbSet<TblPaynimoReq> TblPaynimoReqs { get; set; } = null!;
        public virtual DbSet<TblPgCredential> TblPgCredentials { get; set; } = null!;
        public virtual DbSet<TblPgPaymentDetail> TblPgPaymentDetails { get; set; } = null!;
        public virtual DbSet<TblPgRadiolist> TblPgRadiolists { get; set; } = null!;
        public virtual DbSet<TblPgrefund> TblPgrefunds { get; set; } = null!;
        public virtual DbSet<TblPlbRef> TblPlbRefs { get; set; } = null!;
        public virtual DbSet<TblPnrMessage> TblPnrMessages { get; set; } = null!;
        public virtual DbSet<TblProfitComm> TblProfitComms { get; set; } = null!;
        public virtual DbSet<TblQcchecklist> TblQcchecklists { get; set; } = null!;
        public virtual DbSet<TblQuery> TblQueries { get; set; } = null!;
        public virtual DbSet<TblReferenceNo> TblReferenceNos { get; set; } = null!;
        public virtual DbSet<TblRegisteragentsIp> TblRegisteragentsIps { get; set; } = null!;
        public virtual DbSet<TblReportissue> TblReportissues { get; set; } = null!;
        public virtual DbSet<TblRoutelist> TblRoutelists { get; set; } = null!;
        public virtual DbSet<TblRoutelistAv> TblRoutelistAvs { get; set; } = null!;
        public virtual DbSet<TblScrapBookingLog> TblScrapBookingLogs { get; set; } = null!;
        public virtual DbSet<TblSearchResultBlock> TblSearchResultBlocks { get; set; } = null!;
        public virtual DbSet<TblServiceSwitch> TblServiceSwitches { get; set; } = null!;
        public virtual DbSet<TblServiceproviderEnable> TblServiceproviderEnables { get; set; } = null!;
        public virtual DbSet<TblSoapaction> TblSoapactions { get; set; } = null!;
        public virtual DbSet<TblSplfareLog> TblSplfareLogs { get; set; } = null!;
        public virtual DbSet<TblState> TblStates { get; set; } = null!;
        public virtual DbSet<TblTaxiBookingMarkupDetail> TblTaxiBookingMarkupDetails { get; set; } = null!;
        public virtual DbSet<TblTaxiForSure> TblTaxiForSures { get; set; } = null!;
        public virtual DbSet<TblTbobookingLog> TblTbobookingLogs { get; set; } = null!;
        public virtual DbSet<TblTbocancelLog> TblTbocancelLogs { get; set; } = null!;
        public virtual DbSet<TblTboticketLog> TblTboticketLogs { get; set; } = null!;
        public virtual DbSet<TblTransactionOtp> TblTransactionOtps { get; set; } = null!;
        public virtual DbSet<TblUploaderrorLog> TblUploaderrorLogs { get; set; } = null!;
        public virtual DbSet<TblUrlsToMap> TblUrlsToMaps { get; set; } = null!;
        public virtual DbSet<TblUserLoginTime> TblUserLoginTimes { get; set; } = null!;
        public virtual DbSet<TblViewedHotel> TblViewedHotels { get; set; } = null!;
        public virtual DbSet<TblVisitorInfo> TblVisitorInfos { get; set; } = null!;
        public virtual DbSet<TblWait> TblWaits { get; set; } = null!;
        public virtual DbSet<TblYaPricingLog> TblYaPricingLogs { get; set; } = null!;
        public virtual DbSet<TblYabookingLog> TblYabookingLogs { get; set; } = null!;
        public virtual DbSet<TempCreditAgent> TempCreditAgents { get; set; } = null!;
        public virtual DbSet<Testcomm> Testcomms { get; set; } = null!;
        public virtual DbSet<Testplb> Testplbs { get; set; } = null!;
        public virtual DbSet<TextPaxYt> TextPaxYts { get; set; } = null!;
        public virtual DbSet<TicketingLogGal> TicketingLogGals { get; set; } = null!;
        public virtual DbSet<TktByAgency> TktByAgencies { get; set; } = null!;
        public virtual DbSet<TktByAgencyGal> TktByAgencyGals { get; set; } = null!;
        public virtual DbSet<TktByAgencyGalTest> TktByAgencyGalTests { get; set; } = null!;
        public virtual DbSet<TotalSearchHit> TotalSearchHits { get; set; } = null!;
        public virtual DbSet<TransReport> TransReports { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<TransactionSequence> TransactionSequences { get; set; } = null!;
        public virtual DbSet<Ttt> Ttts { get; set; } = null!;
        public virtual DbSet<Unregagent> Unregagents { get; set; } = null!;
        public virtual DbSet<UploadAgentType> UploadAgentTypes { get; set; } = null!;
        public virtual DbSet<UploadAgentTypeBak> UploadAgentTypeBaks { get; set; } = null!;
        public virtual DbSet<UploadDetail> UploadDetails { get; set; } = null!;
        public virtual DbSet<UserIdmapping> UserIdmappings { get; set; } = null!;
        public virtual DbSet<UserTab> UserTabs { get; set; } = null!;
        public virtual DbSet<VisaDetail> VisaDetails { get; set; } = null!;
        public virtual DbSet<WorldAirportInfo> WorldAirportInfos { get; set; } = null!;
        public virtual DbSet<WorldAirportInfoOld1> WorldAirportInfoOld1s { get; set; } = null!;
        public virtual DbSet<YatraBillingLog> YatraBillingLogs { get; set; } = null!;
        public virtual DbSet<YatraVendor> YatraVendors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Flyraja;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountIntegration>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Account_Integration");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceProvider)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActionHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActionHistory");

                entity.Property(e => e.ActionOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActiveAirline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActiveAirline");

                entity.Property(e => e.Airlines).IsUnicode(false);

                entity.Property(e => e.OfficeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OfficeID");
            });

            modelBuilder.Entity<AdminB2b>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("admin_b2b");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AdultMarkup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adult_markup");

                entity.Property(e => e.AdultMarkupType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adult_markup_type");

                entity.Property(e => e.ChildMarkup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("child_markup");

                entity.Property(e => e.ChildMarkupType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("child_markup_type");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Contactno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactno");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_pwd");

                entity.Property(e => e.UserType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("user_type");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Work_phone");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<AdminMarkup>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("AdminMarkup");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Two Letter Airline code");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Distributor Id");

                entity.Property(e => e.MarkupType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Markup Type  : Fixed (F) or Percentage (P)");

                entity.Property(e => e.MarkupValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("fixed type value or percentage type value");

                entity.Property(e => e.Show)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Mark up display in Transaction fee (TRN) or Taxes (TAX)");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Domestic (D) or International ( I )");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Type of User(AGENT OR DISTR)");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Agent User ID  or Distr User ID");
            });

            modelBuilder.Entity<Adult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Adult");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasColumnName("AgentID");

                entity.Property(e => e.EmpId).ValueGeneratedOnAdd();

                entity.Property(e => e.Ffno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FFno");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppexp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PPexp");

                entity.Property(e => e.ProxyId)
                    .HasMaxLength(50)
                    .HasColumnName("ProxyID");

                entity.Property(e => e.SirName).HasMaxLength(20);

                entity.Property(e => e.VisaDet)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdvAvailability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Adv_Availability");

                entity.Property(e => e.ArrivalDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("arrivalDate");

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("arrivalTime");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Time");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departureDate");

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departureTime");

                entity.Property(e => e.DestFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("destFrom");

                entity.Property(e => e.DestTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("destTo");

                entity.Property(e => e.FlightIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flightIdentification");

                entity.Property(e => e.LineItemNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lineItemNumber");

                entity.Property(e => e.MarketingCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marketingCompany");

                entity.Property(e => e.Searchvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceClass)
                    .HasColumnType("text")
                    .HasColumnName("serviceClass");
            });

            modelBuilder.Entity<AgentCd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Agent_CD");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CB");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisBYq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dis_B_YQ");

                entity.Property(e => e.DisYq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dis_YQ");

                entity.Property(e => e.Grade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlbBasic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlbByq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PlbBYQ");

                entity.Property(e => e.PlbYq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PlbYQ");

                entity.Property(e => e.Rbd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RBD");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgentMarkup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AgentMarkup");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Two Letter Airline code");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Distributor Id");

                entity.Property(e => e.MarkupType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Markup Type  : Fixed (F) or Percentage (P)");

                entity.Property(e => e.MarkupValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("fixed type value or percentage type value");

                entity.Property(e => e.Show)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Mark up display in Transaction fee (TRN) or Taxes (TAX)");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Domestic (D) or International ( I )");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Agent User ID ");
            });

            modelBuilder.Entity<AgentRegister>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("agent_register");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ag_logo");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgentLimitTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.AgentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_Type");

                entity.Property(e => e.AltEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Alt_Email");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("Crd_Limit");

                entity.Property(e => e.CrdTrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Crd_Trns_Date");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.DecodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Decode_ITZ");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DueAmtTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExmptTds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ExmptTDS");

                entity.Property(e => e.ExmptTdsLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_no");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GstCity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_City");

                entity.Property(e => e.GstCompanyAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Address");

                entity.Property(e => e.GstCompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Name");

                entity.Property(e => e.GstEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GST_Email");

                entity.Property(e => e.GstPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_PhoneNo");

                entity.Property(e => e.GstPincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_Pincode");

                entity.Property(e => e.GstState)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_State");

                entity.Property(e => e.GstStateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GST_State_Code");

                entity.Property(e => e.GstUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GST_UpdateDate");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSTNO");

                entity.Property(e => e.Gstremark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GSTRemark");

                entity.Property(e => e.IsGstApply)
                    .HasColumnName("Is_GST_Apply")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPwd).HasColumnName("IsPWD");

                entity.Property(e => e.IsSupplier).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSupplierAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsWhiteLabel).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastLoginItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LastLogin_ITZ");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantKeyItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantKey_ITZ");

                entity.Property(e => e.Mname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModeType_ITZ");

                entity.Property(e => e.NamePanCard).HasMaxLength(100);

                entity.Property(e => e.NavId).HasColumnName("NAV_ID");

                entity.Property(e => e.OnlineTkt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Online_Tkt");

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .HasColumnName("OTP");

                entity.Property(e => e.OtpcreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPCreatedDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OtploginStatus)
                    .HasColumnName("OTPLoginStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otpstatus)
                    .HasColumnName("OTPStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordChangeDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate()+(30))");

                entity.Property(e => e.PasswordExpMsg).HasDefaultValueSql("((0))");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.PwdItz)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Pwd_ITZ");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesExecID");

                entity.Property(e => e.SecAns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Ans");

                entity.Property(e => e.SecQes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Qes");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Stax_no");

                entity.Property(e => e.StockistCrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("StockistCrd_limit");

                entity.Property(e => e.SvcTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SvcType_ITZ");

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.TimestampCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");

                entity.Property(e => e.VirtualCreditLimit).HasColumnType("money");

                entity.Property(e => e.VirtualCreditTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualFromDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualToDate).HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhatsAppNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YId)
                    .HasMaxLength(50)
                    .HasColumnName("Y_ID");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<AgentRegister05082019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agent_register_05_08_2019");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.AgLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ag_logo");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentLimit).HasColumnType("money");

                entity.Property(e => e.AgentLimitTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.AgentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_Type");

                entity.Property(e => e.AltEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Alt_Email");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("Crd_Limit");

                entity.Property(e => e.CrdTrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Crd_Trns_Date");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.DecodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Decode_ITZ");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueAmount).HasColumnType("money");

                entity.Property(e => e.DueAmtTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExmptTds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ExmptTDS");

                entity.Property(e => e.ExmptTdsLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_no");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GstCity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_City");

                entity.Property(e => e.GstCompanyAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Address");

                entity.Property(e => e.GstCompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Name");

                entity.Property(e => e.GstEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GST_Email");

                entity.Property(e => e.GstPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_PhoneNo");

                entity.Property(e => e.GstPincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_Pincode");

                entity.Property(e => e.GstState)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_State");

                entity.Property(e => e.GstStateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GST_State_Code");

                entity.Property(e => e.GstUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GST_UpdateDate");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSTNO");

                entity.Property(e => e.Gstremark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GSTRemark");

                entity.Property(e => e.IsGstApply).HasColumnName("Is_GST_Apply");

                entity.Property(e => e.IsPwd).HasColumnName("IsPWD");

                entity.Property(e => e.LastLoginItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LastLogin_ITZ");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantKeyItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantKey_ITZ");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModeType_ITZ");

                entity.Property(e => e.NamePanCard).HasMaxLength(100);

                entity.Property(e => e.NavId).HasColumnName("NAV_ID");

                entity.Property(e => e.OnlineTkt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Online_Tkt");

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .HasColumnName("OTP");

                entity.Property(e => e.OtpcreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPCreatedDate");

                entity.Property(e => e.OtploginStatus).HasColumnName("OTPLoginStatus");

                entity.Property(e => e.Otpstatus).HasColumnName("OTPStatus");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.PwdItz)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Pwd_ITZ");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesExecID");

                entity.Property(e => e.SecAns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Ans");

                entity.Property(e => e.SecQes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Qes");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Stax_no");

                entity.Property(e => e.StockistCrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("StockistCrd_limit");

                entity.Property(e => e.SvcTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SvcType_ITZ");

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.TimestampCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp_create");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");

                entity.Property(e => e.VirtualCreditLimit).HasColumnType("money");

                entity.Property(e => e.VirtualCreditTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualFromDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualToDate).HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YId)
                    .HasMaxLength(50)
                    .HasColumnName("Y_ID");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<AgentRegister06082019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agent_register_06_08_2019");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.AgLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ag_logo");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentLimit).HasColumnType("money");

                entity.Property(e => e.AgentLimitTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.AgentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_Type");

                entity.Property(e => e.AltEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Alt_Email");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("Crd_Limit");

                entity.Property(e => e.CrdTrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Crd_Trns_Date");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.DecodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Decode_ITZ");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueAmount).HasColumnType("money");

                entity.Property(e => e.DueAmtTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExmptTds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ExmptTDS");

                entity.Property(e => e.ExmptTdsLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_no");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GstCity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_City");

                entity.Property(e => e.GstCompanyAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Address");

                entity.Property(e => e.GstCompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Name");

                entity.Property(e => e.GstEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GST_Email");

                entity.Property(e => e.GstPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_PhoneNo");

                entity.Property(e => e.GstPincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_Pincode");

                entity.Property(e => e.GstState)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_State");

                entity.Property(e => e.GstStateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GST_State_Code");

                entity.Property(e => e.GstUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GST_UpdateDate");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSTNO");

                entity.Property(e => e.Gstremark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GSTRemark");

                entity.Property(e => e.IsGstApply).HasColumnName("Is_GST_Apply");

                entity.Property(e => e.IsPwd).HasColumnName("IsPWD");

                entity.Property(e => e.LastLoginItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LastLogin_ITZ");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantKeyItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantKey_ITZ");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModeType_ITZ");

                entity.Property(e => e.NamePanCard).HasMaxLength(100);

                entity.Property(e => e.NavId).HasColumnName("NAV_ID");

                entity.Property(e => e.OnlineTkt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Online_Tkt");

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .HasColumnName("OTP");

                entity.Property(e => e.OtpcreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPCreatedDate");

                entity.Property(e => e.OtploginStatus).HasColumnName("OTPLoginStatus");

                entity.Property(e => e.Otpstatus).HasColumnName("OTPStatus");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.PwdItz)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Pwd_ITZ");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesExecID");

                entity.Property(e => e.SecAns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Ans");

                entity.Property(e => e.SecQes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Qes");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Stax_no");

                entity.Property(e => e.StockistCrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("StockistCrd_limit");

                entity.Property(e => e.SvcTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SvcType_ITZ");

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.TimestampCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp_create");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");

                entity.Property(e => e.VirtualCreditLimit).HasColumnType("money");

                entity.Property(e => e.VirtualCreditTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualFromDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualToDate).HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YId)
                    .HasMaxLength(50)
                    .HasColumnName("Y_ID");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<AgentRegister1406>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agent_register_1406");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.AgLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ag_logo");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentLimit).HasColumnType("money");

                entity.Property(e => e.AgentLimitTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.AgentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_Type");

                entity.Property(e => e.AltEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Alt_Email");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("Crd_Limit");

                entity.Property(e => e.CrdTrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Crd_Trns_Date");

                entity.Property(e => e.DecodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Decode_ITZ");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueAmount).HasColumnType("money");

                entity.Property(e => e.DueAmtTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExmptTds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ExmptTDS");

                entity.Property(e => e.ExmptTdsLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_no");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GstCity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_City");

                entity.Property(e => e.GstCompanyAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Address");

                entity.Property(e => e.GstCompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Name");

                entity.Property(e => e.GstEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GST_Email");

                entity.Property(e => e.GstPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_PhoneNo");

                entity.Property(e => e.GstPincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_Pincode");

                entity.Property(e => e.GstState)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_State");

                entity.Property(e => e.GstStateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GST_State_Code");

                entity.Property(e => e.GstUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GST_UpdateDate");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSTNO");

                entity.Property(e => e.Gstremark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GSTRemark");

                entity.Property(e => e.IsGstApply).HasColumnName("Is_GST_Apply");

                entity.Property(e => e.IsPwd).HasColumnName("IsPWD");

                entity.Property(e => e.LastLoginItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LastLogin_ITZ");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantKeyItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantKey_ITZ");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModeType_ITZ");

                entity.Property(e => e.NamePanCard).HasMaxLength(100);

                entity.Property(e => e.NavId).HasColumnName("NAV_ID");

                entity.Property(e => e.OnlineTkt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Online_Tkt");

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .HasColumnName("OTP");

                entity.Property(e => e.OtpcreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPCreatedDate");

                entity.Property(e => e.OtploginStatus).HasColumnName("OTPLoginStatus");

                entity.Property(e => e.Otpstatus).HasColumnName("OTPStatus");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.PwdItz)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Pwd_ITZ");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesExecID");

                entity.Property(e => e.SecAns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Ans");

                entity.Property(e => e.SecQes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Qes");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Stax_no");

                entity.Property(e => e.StockistCrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("StockistCrd_limit");

                entity.Property(e => e.SvcTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SvcType_ITZ");

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.TimestampCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp_create");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");

                entity.Property(e => e.VirtualCreditLimit).HasColumnType("money");

                entity.Property(e => e.VirtualCreditTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualFromDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualToDate).HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YId)
                    .HasMaxLength(50)
                    .HasColumnName("Y_ID");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<AgentRegisterLog>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("agent_register_log");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.AgLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ag_logo");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgentLimitTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.AgentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_Type");

                entity.Property(e => e.AltEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Alt_Email");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("Crd_Limit");

                entity.Property(e => e.CrdTrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Crd_Trns_Date");

                entity.Property(e => e.DecodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Decode_ITZ");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DueAmtTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExmptTds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ExmptTDS");

                entity.Property(e => e.ExmptTdsLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_no");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GstCity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_City");

                entity.Property(e => e.GstCompanyAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Address");

                entity.Property(e => e.GstCompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Name");

                entity.Property(e => e.GstEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GST_Email");

                entity.Property(e => e.GstPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_PhoneNo");

                entity.Property(e => e.GstPincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_Pincode");

                entity.Property(e => e.GstState)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_State");

                entity.Property(e => e.GstStateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GST_State_Code");

                entity.Property(e => e.GstUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GST_UpdateDate");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSTNO");

                entity.Property(e => e.Gstremark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GSTRemark");

                entity.Property(e => e.IsGstApply)
                    .HasColumnName("Is_GST_Apply")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPwd).HasColumnName("IsPWD");

                entity.Property(e => e.IsWhiteLabel).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastLoginItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LastLogin_ITZ");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantKeyItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantKey_ITZ");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModeType_ITZ");

                entity.Property(e => e.NavId).HasColumnName("NAV_ID");

                entity.Property(e => e.OnlineTkt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Online_Tkt");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.PwdItz)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Pwd_ITZ");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesExecID");

                entity.Property(e => e.SecAns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Ans");

                entity.Property(e => e.SecQes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Qes");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Stax_no");

                entity.Property(e => e.StockistCrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("StockistCrd_limit");

                entity.Property(e => e.SvcTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SvcType_ITZ");

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.TimestampCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");

                entity.Property(e => e.VirtualCreditLimit).HasColumnType("money");

                entity.Property(e => e.VirtualCreditTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualFromDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualToDate).HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YId)
                    .HasMaxLength(50)
                    .HasColumnName("Y_ID");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<AgentService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AgentService");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgentStaffRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AgentStaffRegister");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.Bus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Cab).HasDefaultValueSql("((1))");

                entity.Property(e => e.CheckBalance).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditLimitTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.DelStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasMaxLength(100);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Flight).HasDefaultValueSql("((1))");

                entity.Property(e => e.GiftCard).HasDefaultValueSql("((1))");

                entity.Property(e => e.Holidays).HasDefaultValueSql("((1))");

                entity.Property(e => e.HomeStay).HasDefaultValueSql("((1))");

                entity.Property(e => e.Hotel).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Rail).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId).HasMaxLength(100);

                entity.Property(e => e.StaffLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StaffLimitTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(100);

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgentVisaQuery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Agent_Visa_Query");

                entity.Property(e => e.AgencyName).HasMaxLength(50);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(10)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ExcutiveId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Excutive_ID");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Query).HasMaxLength(200);

                entity.Property(e => e.QueryId)
                    .HasMaxLength(50)
                    .HasColumnName("QueryID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Agentreg1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agentreg1");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.AgLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ag_logo");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentLimit).HasColumnType("money");

                entity.Property(e => e.AgentLimitTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.AgentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_Type");

                entity.Property(e => e.AltEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Alt_Email");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("Crd_Limit");

                entity.Property(e => e.CrdTrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Crd_Trns_Date");

                entity.Property(e => e.DecodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Decode_ITZ");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueAmount).HasColumnType("money");

                entity.Property(e => e.DueAmtTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExmptTds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ExmptTDS");

                entity.Property(e => e.ExmptTdsLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_no");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GstCity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_City");

                entity.Property(e => e.GstCompanyAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Address");

                entity.Property(e => e.GstCompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Name");

                entity.Property(e => e.GstEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GST_Email");

                entity.Property(e => e.GstPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_PhoneNo");

                entity.Property(e => e.GstPincode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_Pincode");

                entity.Property(e => e.GstState)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GST_State");

                entity.Property(e => e.GstStateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GST_State_Code");

                entity.Property(e => e.GstUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GST_UpdateDate");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSTNO");

                entity.Property(e => e.Gstremark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GSTRemark");

                entity.Property(e => e.IsGstApply).HasColumnName("Is_GST_Apply");

                entity.Property(e => e.IsPwd).HasColumnName("IsPWD");

                entity.Property(e => e.LastLoginItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LastLogin_ITZ");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantKeyItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantKey_ITZ");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModeType_ITZ");

                entity.Property(e => e.NamePanCard).HasMaxLength(100);

                entity.Property(e => e.NavId).HasColumnName("NAV_ID");

                entity.Property(e => e.OnlineTkt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Online_Tkt");

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .HasColumnName("OTP");

                entity.Property(e => e.OtpcreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPCreatedDate");

                entity.Property(e => e.OtploginStatus).HasColumnName("OTPLoginStatus");

                entity.Property(e => e.Otpstatus).HasColumnName("OTPStatus");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.PwdItz)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Pwd_ITZ");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesExecID");

                entity.Property(e => e.SecAns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Ans");

                entity.Property(e => e.SecQes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Qes");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Stax_no");

                entity.Property(e => e.StockistCrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("StockistCrd_limit");

                entity.Property(e => e.SvcTypeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SvcType_ITZ");

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.TimestampCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp_create");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");

                entity.Property(e => e.VirtualCreditLimit).HasColumnType("money");

                entity.Property(e => e.VirtualCreditTrnsDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualFromDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualToDate).HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YId)
                    .HasMaxLength(50)
                    .HasColumnName("Y_ID");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<AirLineName>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.Property(e => e.AlCode)
                    .HasMaxLength(255)
                    .HasColumnName("AL_Code");

                entity.Property(e => e.AlName)
                    .HasMaxLength(255)
                    .HasColumnName("AL_Name");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AirLinesName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AirLinesName");

                entity.Property(e => e.AlCode)
                    .HasMaxLength(255)
                    .HasColumnName("AL_Code");

                entity.Property(e => e.AlName)
                    .HasMaxLength(255)
                    .HasColumnName("AL_Name");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Aircode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AIRCODE");

                entity.Property(e => e.AirLineCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AirNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirlineMarkup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("airline_markup");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("airline");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Markup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarkupType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("markup_type");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<AirlinePa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Airline_Pa");

                entity.Property(e => e.AirLine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Basic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BasicYq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Basic_YQ");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Ftf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTF");

                entity.Property(e => e.FuelS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FuelSur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STax");

                entity.Property(e => e.Tf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TF");
            });

            modelBuilder.Entity<AirlineTicketNumberLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AirlineTicketNumber_Log");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pnr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PNR");

                entity.Property(e => e.TicketNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirportDetailsByFlightStat>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.CityCode)
                    .HasMaxLength(255)
                    .HasColumnName("cityCode");

                entity.Property(e => e.Classification).HasColumnName("classification");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(255)
                    .HasColumnName("countryCode");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(255)
                    .HasColumnName("countryName");

                entity.Property(e => e.DelayIndexUrl)
                    .HasMaxLength(255)
                    .HasColumnName("delayIndexUrl");

                entity.Property(e => e.ElevationFeet).HasColumnName("elevationFeet");

                entity.Property(e => e.Faa)
                    .HasMaxLength(255)
                    .HasColumnName("faa");

                entity.Property(e => e.Fs)
                    .HasMaxLength(255)
                    .HasColumnName("fs");

                entity.Property(e => e.Iata)
                    .HasMaxLength(255)
                    .HasColumnName("iata");

                entity.Property(e => e.Icao)
                    .HasMaxLength(255)
                    .HasColumnName("icao");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.LocalTime)
                    .HasMaxLength(255)
                    .HasColumnName("localTime");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .HasColumnName("postalCode");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(255)
                    .HasColumnName("regionName");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(255)
                    .HasColumnName("stateCode");

                entity.Property(e => e.Street1)
                    .HasMaxLength(255)
                    .HasColumnName("street1");

                entity.Property(e => e.Street2)
                    .HasMaxLength(255)
                    .HasColumnName("street2");

                entity.Property(e => e.TimeZoneRegionName)
                    .HasMaxLength(255)
                    .HasColumnName("timeZoneRegionName");

                entity.Property(e => e.UtcOffsetHours).HasColumnName("utcOffsetHours");

                entity.Property(e => e.WeatherUrl)
                    .HasMaxLength(255)
                    .HasColumnName("weatherUrl");

                entity.Property(e => e.WeatherZone)
                    .HasMaxLength(255)
                    .HasColumnName("weatherZone");
            });

            modelBuilder.Entity<AirportInfo>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("airport_info");

                entity.Property(e => e.Airportid)
                    .HasMaxLength(255)
                    .HasColumnName("airportid");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dst).HasColumnName("dst");

                entity.Property(e => e.Latitudedeg).HasColumnName("latitudedeg");

                entity.Property(e => e.Latitudemin).HasColumnName("latitudemin");

                entity.Property(e => e.Longitudedeg).HasColumnName("longitudedeg");

                entity.Property(e => e.Major).HasColumnName("major");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Runway).HasColumnName("runway");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.Zone).HasColumnName("zone");
            });

            modelBuilder.Entity<AirportName>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("airport_Name");

                entity.Property(e => e.AirportCode).HasMaxLength(255);

                entity.Property(e => e.AirportName1)
                    .HasMaxLength(255)
                    .HasColumnName("AirportName");

                entity.Property(e => e.CityCode).HasMaxLength(255);

                entity.Property(e => e.CityName)
                    .HasMaxLength(255)
                    .HasColumnName("cityName");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regioun).HasMaxLength(255);
            });

            modelBuilder.Entity<AmountVerification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AmountVerification");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.LastModification).HasColumnType("datetime");

                entity.Property(e => e.VerficationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmsAvailability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ams_Availability");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.DateArr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date_arr");

                entity.Property(e => e.DateDeparture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date_departure");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.ETick)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_tick");

                entity.Property(e => e.EqType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eq_Type");

                entity.Property(e => e.FlightNo).HasColumnName("Flight_no");

                entity.Property(e => e.Location1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpretC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PDQua)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("P_D_Qua");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Ref2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ref2");

                entity.Property(e => e.Ref3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ref3");

                entity.Property(e => e.Searchvalue).HasColumnType("text");

                entity.Property(e => e.SegmentRef).HasColumnName("Segment_ref");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Terminal1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("terminal1");

                entity.Property(e => e.Terminal2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("terminal2");

                entity.Property(e => e.TimeArr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("time_arr");

                entity.Property(e => e.TimeDeparture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("time_departure");

                entity.Property(e => e.Unitqualifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unitqualifier");

                entity.Property(e => e.Unitqualifier2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unitqualifier2");
            });

            modelBuilder.Entity<AmsAvailabilityNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ams_Availability_new");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.DateArr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date_arr");

                entity.Property(e => e.DateDeparture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date_departure");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.ETick)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_tick");

                entity.Property(e => e.EqType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eq_Type");

                entity.Property(e => e.FlightNo).HasColumnName("Flight_no");

                entity.Property(e => e.Location1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpretC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PDQua)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("P_D_Qua");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Ref2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ref2");

                entity.Property(e => e.Ref3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ref3");

                entity.Property(e => e.Searchvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentRef).HasColumnName("Segment_ref");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Terminal1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("terminal1");

                entity.Property(e => e.Terminal2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("terminal2");

                entity.Property(e => e.TimeArr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("time_arr");

                entity.Property(e => e.TimeDeparture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("time_departure");

                entity.Property(e => e.Unitqualifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unitqualifier");

                entity.Property(e => e.Unitqualifier2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unitqualifier2");
            });

            modelBuilder.Entity<AmsRecommdation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ams_recommdation");

                entity.Property(e => e.Amount)
                    .HasColumnType("smallmoney")
                    .HasColumnName("amount");

                entity.Property(e => e.Avlstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avlstatus");

                entity.Property(e => e.Childamounttax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("childamounttax");

                entity.Property(e => e.Childfareamount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("childfareamount");

                entity.Property(e => e.Cls)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cls");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.Depno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("depno");

                entity.Property(e => e.Infantamounttax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infantamounttax");

                entity.Property(e => e.Infantfareamount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infantfareamount");

                entity.Property(e => e.ItemNo).HasColumnName("item_no");

                entity.Property(e => e.PaxFareNumDep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paxFareNum_Dep");

                entity.Property(e => e.Retno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("retno");

                entity.Property(e => e.Searchvalue).HasColumnType("text");

                entity.Property(e => e.Segment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segment");

                entity.Property(e => e.Tax)
                    .HasColumnType("smallmoney")
                    .HasColumnName("tax");

                entity.Property(e => e.TotalFareAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalFareAmount");

                entity.Property(e => e.TotalTaxAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalTaxAmount");
            });

            modelBuilder.Entity<AmsRecommdationNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ams_recommdation_new");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Avlstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avlstatus");

                entity.Property(e => e.Childamounttax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("childamounttax");

                entity.Property(e => e.Childfareamount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("childfareamount");

                entity.Property(e => e.Cls)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cls");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.Depno1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("depno1");

                entity.Property(e => e.Depno2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("depno2");

                entity.Property(e => e.Depno3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("depno3");

                entity.Property(e => e.FareBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fareBasis");

                entity.Property(e => e.Fbpaxtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fbpaxtype");

                entity.Property(e => e.Infantamounttax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infantamounttax");

                entity.Property(e => e.Infantfareamount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infantfareamount");

                entity.Property(e => e.ItemNo).HasColumnName("item_no");

                entity.Property(e => e.PaxFareNumDep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paxFareNum_Dep");

                entity.Property(e => e.Searchvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Segment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segment");

                entity.Property(e => e.Tax)
                    .HasColumnType("money")
                    .HasColumnName("tax");

                entity.Property(e => e.TotalFareAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalFareAmount");

                entity.Property(e => e.TotalTaxAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalTaxAmount");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CallBackUrl).HasColumnName("CallBackURL");

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Gstnnumber).HasColumnName("GSTNNumber");

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.RegisteredOn).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Zipcode).HasColumnName("ZIPCode");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");

                            j.ToTable("AspNetUserRoles");

                            j.IndexerProperty<string>("UserId").HasMaxLength(128);

                            j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AuthenticateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AuthenticateUser");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthenticatedIp)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AuthenticatedIP");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<AvailabilityResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Availability_Result");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<B2bemailAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("B2BEmailAddress");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<BalanceHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK_HistoryID");

                entity.ToTable("BalanceHistory");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AvailableBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TrackID");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.BankName).HasMaxLength(500);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.Neftcode)
                    .HasMaxLength(50)
                    .HasColumnName("NEFTCode");
            });

            modelBuilder.Entity<BillingCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillingCountry");

                entity.Property(e => e.Code)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlockBooking>(entity =>
            {
                entity.ToTable("blockBooking");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Airline_No");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dest)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FarePerPax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Src)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TravelDateEnd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TravelDateStart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidityEndDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validityEndDate");
            });

            modelBuilder.Entity<BookingLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Booking_log");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookReq).HasColumnName("book_req");

                entity.Property(e => e.BookRes).HasColumnName("book_res");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("booking_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BookingPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_PaymentID");

                entity.ToTable("BookingPayment");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BookingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TrackID");
            });

            modelBuilder.Entity<BookingSequence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BookingSequence");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Operation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PnrSequenceId).ValueGeneratedOnAdd();

                entity.Property(e => e.Sequence)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bookinglog1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bookinglogs");

                entity.Property(e => e.AddmultiReq)
                    .IsUnicode(false)
                    .HasColumnName("Addmulti_Req");

                entity.Property(e => e.AddmultiRes)
                    .IsUnicode(false)
                    .HasColumnName("Addmulti_Res");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PnrReq)
                    .IsUnicode(false)
                    .HasColumnName("Pnr_Req");

                entity.Property(e => e.PnrRes)
                    .IsUnicode(false)
                    .HasColumnName("Pnr_Res");

                entity.Property(e => e.PriceReq)
                    .IsUnicode(false)
                    .HasColumnName("Price_Req");

                entity.Property(e => e.PriceRes)
                    .IsUnicode(false)
                    .HasColumnName("Price_Res");

                entity.Property(e => e.SearchValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SellReq)
                    .IsUnicode(false)
                    .HasColumnName("Sell_Req");

                entity.Property(e => e.SellRes)
                    .IsUnicode(false)
                    .HasColumnName("Sell_Res");

                entity.Property(e => e.TstReq)
                    .IsUnicode(false)
                    .HasColumnName("Tst_Req");

                entity.Property(e => e.TstRes)
                    .IsUnicode(false)
                    .HasColumnName("Tst_Res");
            });

            modelBuilder.Entity<CanReq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("can_req");

                entity.Property(e => e.AgName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.CanDate)
                    .HasColumnType("datetime")
                    .HasColumnName("can_date");

                entity.Property(e => e.Pnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNR");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_id");
            });

            modelBuilder.Entity<Cancellation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cancellation");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.BaseFare)
                    .HasMaxLength(50)
                    .HasColumnName("Base_Fare");

                entity.Property(e => e.BlockCancel).HasColumnName("Block_Cancel");

                entity.Property(e => e.BookingDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Booking_date");

                entity.Property(e => e.Cb)
                    .HasMaxLength(50)
                    .HasColumnName("CB");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Departure)
                    .HasMaxLength(50)
                    .HasColumnName("departure");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .HasColumnName("departure_date");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .HasColumnName("destination");

                entity.Property(e => e.Discount).HasMaxLength(50);

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.PaxFname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_fname");

                entity.Property(e => e.PaxLname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_lname");

                entity.Property(e => e.PaxType)
                    .HasMaxLength(30)
                    .HasColumnName("pax_type");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTax)
                    .HasMaxLength(50)
                    .HasColumnName("Service_Tax");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .HasColumnName("TDS");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TktNo)
                    .HasMaxLength(50)
                    .HasColumnName("Tkt_No");

                entity.Property(e => e.TotalFare).HasMaxLength(50);

                entity.Property(e => e.TotalFareAfterDiscount).HasMaxLength(50);

                entity.Property(e => e.TranFees)
                    .HasMaxLength(50)
                    .HasColumnName("Tran_Fees");

                entity.Property(e => e.UpdateRemark).IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC");

                entity.Property(e => e.Yq)
                    .HasMaxLength(50)
                    .HasColumnName("YQ");
            });

            modelBuilder.Entity<CancellationIntl>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("CancellationIntl");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AirLinePnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AirLinePNR");

                entity.Property(e => e.ArrTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFare)
                    .HasMaxLength(50)
                    .HasColumnName("Base_Fare");

                entity.Property(e => e.BillNoAir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNoCorp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BlockCancel).HasColumnName("Block_Cancel");

                entity.Property(e => e.BookingDate)
                    .HasMaxLength(50)
                    .HasColumnName("Booking_date");

                entity.Property(e => e.CancelStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cb)
                    .HasMaxLength(50)
                    .HasColumnName("CB");

                entity.Property(e => e.DepTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departure)
                    .HasMaxLength(50)
                    .HasColumnName("departure");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .HasColumnName("departure_date");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .HasColumnName("destination");

                entity.Property(e => e.Discount).HasMaxLength(50);

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MassId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MassID");

                entity.Property(e => e.MgtFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OnlineRefAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PaxFname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_fname");

                entity.Property(e => e.PaxId).HasColumnName("PaxID");

                entity.Property(e => e.PaxLname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_lname");

                entity.Property(e => e.PaxType)
                    .HasMaxLength(30)
                    .HasColumnName("pax_type");

                entity.Property(e => e.PgCharges).HasColumnType("money");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.PrevReissueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PrevReissueID");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.RefundFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RefundID");

                entity.Property(e => e.Scsrvtax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SCSRVTAX");

                entity.Property(e => e.Sector).HasMaxLength(50);

                entity.Property(e => e.ServiceTax)
                    .HasMaxLength(50)
                    .HasColumnName("Service_Tax");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .HasColumnName("TDS");

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TktNo)
                    .HasMaxLength(50)
                    .HasColumnName("Tkt_No");

                entity.Property(e => e.TotalFare).HasMaxLength(50);

                entity.Property(e => e.TotalFareAfterDiscount).HasMaxLength(50);

                entity.Property(e => e.TranFees)
                    .HasMaxLength(50)
                    .HasColumnName("Tran_Fees");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC")
                    .IsFixedLength();

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");

                entity.Property(e => e.Yq)
                    .HasMaxLength(50)
                    .HasColumnName("YQ");
            });

            modelBuilder.Entity<CancellationIntlMass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CancellationIntlMass");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AirLinePnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AirLinePNR");

                entity.Property(e => e.ArrTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFare)
                    .HasMaxLength(50)
                    .HasColumnName("Base_Fare");

                entity.Property(e => e.BillNoAir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNoCorp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BlockCancel).HasColumnName("Block_Cancel");

                entity.Property(e => e.BookingDate)
                    .HasMaxLength(50)
                    .HasColumnName("Booking_date");

                entity.Property(e => e.CancelStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cb)
                    .HasMaxLength(50)
                    .HasColumnName("CB");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.DepTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departure)
                    .HasMaxLength(50)
                    .HasColumnName("departure");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .HasColumnName("departure_date");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .HasColumnName("destination");

                entity.Property(e => e.Discount).HasMaxLength(50);

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MassCounterId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MassCounterID");

                entity.Property(e => e.MassId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MassID");

                entity.Property(e => e.MassPaxId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("massPaxID");

                entity.Property(e => e.MassPaxName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("massPaxName");

                entity.Property(e => e.MgtFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PaxFname)
                    .HasMaxLength(300)
                    .HasColumnName("pax_fname");

                entity.Property(e => e.PaxId).HasColumnName("PaxID");

                entity.Property(e => e.PaxLname)
                    .HasMaxLength(300)
                    .HasColumnName("pax_lname");

                entity.Property(e => e.PaxType)
                    .HasMaxLength(200)
                    .HasColumnName("pax_type");

                entity.Property(e => e.PgCharges).HasColumnType("money");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.PrevReissueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PrevReissueID");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.RefundFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RefundID");

                entity.Property(e => e.Scsrvtax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SCSRVTAX");

                entity.Property(e => e.Sector).HasMaxLength(50);

                entity.Property(e => e.ServiceTax)
                    .HasMaxLength(50)
                    .HasColumnName("Service_Tax");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .HasColumnName("TDS");

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TktNo)
                    .HasMaxLength(50)
                    .HasColumnName("Tkt_No");

                entity.Property(e => e.TotalFare).HasMaxLength(50);

                entity.Property(e => e.TotalFareAfterDiscount).HasMaxLength(50);

                entity.Property(e => e.TranFees)
                    .HasMaxLength(50)
                    .HasColumnName("Tran_Fees");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC")
                    .IsFixedLength();

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");

                entity.Property(e => e.Yq)
                    .HasMaxLength(50)
                    .HasColumnName("YQ");
            });

            modelBuilder.Entity<CcTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CC_Trans");

                entity.Property(e => e.AccUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acc_user");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Payment_ID");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysIden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sys_iden");

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Track_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_date");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction_ID");
            });

            modelBuilder.Entity<Check>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Check");

                entity.Property(e => e.Aircode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BkgChannel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CabinClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cabinClass");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Farebasis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FltNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gptype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GPType");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MktC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPC");

                entity.Property(e => e.OrgCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rbd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RBD");

                entity.Property(e => e.ReturnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Yq)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("YQ");
            });

            modelBuilder.Entity<CheckRecord>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Gdspnr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GDSPNR");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pnr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNR");
            });

            modelBuilder.Entity<Child>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Child");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasColumnName("AgentID");

                entity.Property(e => e.EmpId).ValueGeneratedOnAdd();

                entity.Property(e => e.Ffno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FFno");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppexp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PPexp");

                entity.Property(e => e.ProxyId)
                    .HasMaxLength(50)
                    .HasColumnName("ProxyID");

                entity.Property(e => e.SirName).HasMaxLength(20);

                entity.Property(e => e.VisaDet)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Chkled>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("chkled");

                entity.Property(e => e.AvailBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("avail_balance");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Stat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stat");
            });

            modelBuilder.Entity<CityList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CityList");

                entity.Property(e => e.AirportCode).HasMaxLength(255);

                entity.Property(e => e.AirportName).HasMaxLength(255);

                entity.Property(e => e.CityName).HasMaxLength(255);

                entity.Property(e => e.CountryCode).HasMaxLength(255);

                entity.Property(e => e.CountryName).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Orderseq)
                    .HasMaxLength(255)
                    .HasColumnName("orderseq");
            });

            modelBuilder.Entity<CityListYatra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("city_list_yatra");

                entity.Property(e => e.AirportCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("airport_code");

                entity.Property(e => e.AirportName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("airport_name");

                entity.Property(e => e.CityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_code");

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city_name");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country_code");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("country_name");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Commission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Commission");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommisionOnBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Commission on Basic fare");

                entity.Property(e => e.CommisionOnBasicYq)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Coimmission on Basic + YQ");

                entity.Property(e => e.CommissionOnYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.GroupType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Agent Type or Distr. Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommissionNew>(entity =>
            {
                entity.ToTable("CommissionNew");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BookingChannel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingClassExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingClassInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BookingToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CabinClassExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CabinClassInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashBackAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommisionOnBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Commission on Basic fare");

                entity.Property(e => e.CommisionOnBasicYq)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Coimmission on Basic + YQ");

                entity.Property(e => e.CommissionOnYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DestCountryExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestCountryInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAirportExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAirportInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Distr).HasMaxLength(50);

                entity.Property(e => e.FareBasisExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareBasisInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNoExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNoInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Agent Type or Distr. Id");

                entity.Property(e => e.Idbk).HasColumnName("IDBK");

                entity.Property(e => e.MarketingCarrierExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCarrierInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnwardTravelFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OnwardTravelToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingCarrierExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingCarrierInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrginAirportExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrginAirportInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCountryExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCountryInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlbOnBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Plb % on basic Fare");

                entity.Property(e => e.PlbOnBasicYq)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Plb % on Basic + YQ");

                entity.Property(e => e.Ppptype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PPPType");

                entity.Property(e => e.RestrictionOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTravelFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTravelToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TripType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommissionNewBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CommissionNew_BAK");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BookingChannel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingClassExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingClassInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BookingToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CabinClassExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CabinClassInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashBackAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommisionOnBasic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommisionOnBasicYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommissionOnYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DestCountryExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestCountryInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAirportExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAirportInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Distr).HasMaxLength(50);

                entity.Property(e => e.FareBasisExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareBasisInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNoExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNoInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Idbk).HasColumnName("IDBK");

                entity.Property(e => e.MarketingCarrierExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCarrierInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnwardTravelFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OnwardTravelToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingCarrierExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingCarrierInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrginAirportExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrginAirportInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCountryExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCountryInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlbOnBasic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PlbOnBasicYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ppptype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PPPType");

                entity.Property(e => e.RestrictionOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTravelFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTravelToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TripType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommissionnewBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("commissionnewBACKUP");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BookingChannel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingClassExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingClassInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BookingToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CabinClassExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CabinClassInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashBackAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommisionOnBasic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommisionOnBasicYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommissionOnYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DestCountryExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestCountryInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAirportExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAirportInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Distr).HasMaxLength(50);

                entity.Property(e => e.FareBasisExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareBasisInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNoExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNoInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Idbk).HasColumnName("IDBK");

                entity.Property(e => e.MarketingCarrierExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCarrierInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnwardTravelFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OnwardTravelToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingCarrierExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingCarrierInclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrginAirportExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrginAirportInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCountryExclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCountryInclude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlbOnBasic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PlbOnBasicYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ppptype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PPPType");

                entity.Property(e => e.RestrictionOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTravelFromDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTravelToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TripType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CouponRequestResponse>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("CouponRequestResponse");

                entity.Property(e => e.RequestId).HasColumnName("requestID");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.RequestString)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("requestString");

                entity.Property(e => e.Responsedata)
                    .IsUnicode(false)
                    .HasColumnName("responsedata");
            });

            modelBuilder.Entity<CreditLimitTransaction>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("CreditLimitTransaction");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.AgencyName).HasMaxLength(200);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasColumnName("AgentID");

                entity.Property(e => e.AvalBalCredit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AvalBalDebit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AvalBalance)
                    .HasColumnType("money")
                    .HasColumnName("Aval_Balance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BookedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingType).HasMaxLength(50);

                entity.Property(e => e.CrdLimitCredit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CrdLimitDebit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentCrdLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DistrId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('FWU')");

                entity.Property(e => e.DueAmountCredit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DueAmountDebit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(25)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LimitExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetCreditLimit).HasColumnType("money");

                entity.Property(e => e.TotalDueAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CreditLimitTransactionDistrAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CreditLimitTransactionDistrAgent");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.AgencyName).HasMaxLength(200);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasColumnName("AgentID");

                entity.Property(e => e.AvalBalCredit).HasColumnType("money");

                entity.Property(e => e.AvalBalDebit).HasColumnType("money");

                entity.Property(e => e.AvalBalance)
                    .HasColumnType("money")
                    .HasColumnName("Aval_Balance");

                entity.Property(e => e.BookedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingType).HasMaxLength(50);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CrdLimitCredit).HasColumnType("money");

                entity.Property(e => e.CrdLimitDebit).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentCrdLimit).HasColumnType("money");

                entity.Property(e => e.DistrId).HasMaxLength(50);

                entity.Property(e => e.DueAmountCredit).HasColumnType("money");

                entity.Property(e => e.DueAmountDebit).HasColumnType("money");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.FixedLimit).HasColumnType("money");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(25)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LimitExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.LimitType).HasMaxLength(50);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetCreditLimit).HasColumnType("money");

                entity.Property(e => e.TempLimit).HasColumnType("money");

                entity.Property(e => e.TotalDueAmount).HasColumnType("money");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Addess2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.Mname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepositDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.Property(e => e.AcceptedDateTime).HasColumnType("datetime");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(50)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.AgencyName).HasMaxLength(50);

                entity.Property(e => e.AgentBankName).HasMaxLength(200);

                entity.Property(e => e.AgentType).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankAreaCode).HasMaxLength(30);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BranchCode).HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(200);

                entity.Property(e => e.ChequeDate).HasMaxLength(50);

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.ConcernPerson).HasMaxLength(200);

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepositCity).HasMaxLength(50);

                entity.Property(e => e.DepositeDate).HasMaxLength(50);

                entity.Property(e => e.DepositeOffice).HasMaxLength(500);

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID")
                    .HasDefaultValueSql("('ITZ')");

                entity.Property(e => e.FileUpload)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("File_Upload");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfPayment).HasMaxLength(30);

                entity.Property(e => e.OtprefNo)
                    .HasMaxLength(100)
                    .HasColumnName("OTPRefNo");

                entity.Property(e => e.RecieptNo).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.RemarkByAccounts).HasMaxLength(500);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(30)
                    .HasColumnName("SalesExecID");

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(30)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.UploadType).HasMaxLength(25);
            });

            modelBuilder.Entity<DiscountDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Agent)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.DisId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DisID");

                entity.Property(e => e.Star).HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Trip)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Distributor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Distributor");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DistributorId).HasMaxLength(50);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Url).HasMaxLength(555);
            });

            modelBuilder.Entity<DuplicateRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Duplicate_Role");

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SNo");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<EmailBody>(entity =>
            {
                entity.ToTable("EmailBody");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmailBody1).HasColumnName("Email_Body");

                entity.Property(e => e.EmailHead)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email_head");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Enquiry", "Hotel");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.BookingStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckInDate).HasColumnType("datetime");

                entity.Property(e => e.CheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.CityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactRemarks)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Hindex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HIndex");

                entity.Property(e => e.HotelId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HotelName).HasMaxLength(200);

                entity.Property(e => e.MealPlan)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomCategory).HasMaxLength(500);

                entity.Property(e => e.RoomId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("RoomID");

                entity.Property(e => e.StarRating)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tariff)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExceptionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExceptionLog");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MethodName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExecIpaddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXEC_IPAddress");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Iplocation)
                    .HasMaxLength(100)
                    .HasColumnName("IPLocation");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<Execu>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Execu");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Owner_ITZ");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_pwd");

                entity.Property(e => e.UserType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<ExecuRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExecuRegister");

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("email_id");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile_no");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleType)
                    .HasMaxLength(50)
                    .HasColumnName("role_type");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("trip");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ExecuRegister1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExecuRegister1");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("email_id");

                entity.Property(e => e.LastChangeDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile_no");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleType)
                    .HasMaxLength(50)
                    .HasColumnName("role_type");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ExpiryCreditLimitHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExpiryCreditLimitHistory");

                entity.Property(e => e.AgencyId).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DueAmount).HasColumnType("money");

                entity.Property(e => e.ExpireLimit).HasColumnType("money");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LimitExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.NewAgentLimit).HasColumnType("money");

                entity.Property(e => e.NewCrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("NewCrd_Limit");

                entity.Property(e => e.OldAgentLimit).HasColumnType("money");

                entity.Property(e => e.OldCrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("OldCrd_Limit");

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<FareDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fare_Details");

                entity.Property(e => e.AdtFareAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdtFareTax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Avlstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avlstatus");

                entity.Property(e => e.Childamounttax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("childamounttax");

                entity.Property(e => e.Childfareamount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("childfareamount");

                entity.Property(e => e.Cls)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cls");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.Depno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("depno");

                entity.Property(e => e.FareBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fareBasis");

                entity.Property(e => e.Fbpaxtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fbpaxtype");

                entity.Property(e => e.Infantamounttax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infantamounttax");

                entity.Property(e => e.Infantfareamount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infantfareamount");

                entity.Property(e => e.ItemNo).HasColumnName("item_no");

                entity.Property(e => e.PaxFareNumDep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paxFareNum_Dep");

                entity.Property(e => e.Searchvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Segment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segment");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("smallmoney")
                    .HasColumnName("Total_Amount");

                entity.Property(e => e.TotalTax)
                    .HasColumnType("smallmoney")
                    .HasColumnName("Total_Tax");
            });

            modelBuilder.Entity<FareRule>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("FareRules_PK_Login");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirlineCode).HasMaxLength(10);

                entity.Property(e => e.Cancelationamount)
                    .HasMaxLength(40)
                    .HasColumnName("cancelationamount");

                entity.Property(e => e.CancellationPolicy).HasMaxLength(1000);

                entity.Property(e => e.FareBasis).HasMaxLength(50);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.PenaltyCode).HasMaxLength(5);

                entity.Property(e => e.ReissuancePolicy).HasMaxLength(1000);

                entity.Property(e => e.ServiceFee).HasMaxLength(500);

                entity.Property(e => e.SpecialOffer).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Typeofcancelation)
                    .HasMaxLength(20)
                    .HasColumnName("typeofcancelation");
            });

            modelBuilder.Entity<FareTypeMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FareTypeMaster");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlightBooking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("flight_booking");

                entity.Property(e => e.AdultTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adult_tax");

                entity.Property(e => e.AgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.AgentMrk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_MRK");

                entity.Property(e => e.AirPnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Air_PNR");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("airline");

                entity.Property(e => e.ArrivalDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("arrival_date");

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("arrival_time");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("booking_date");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("card_number");

                entity.Property(e => e.CardType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("card_type");

                entity.Property(e => e.ChildTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("child_tax");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Cvv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cvv");

                entity.Property(e => e.Departure)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departure");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departure_date");

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departure_time");

                entity.Property(e => e.DeptDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dept_date");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("destination");

                entity.Property(e => e.Distributor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expression)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("expression");

                entity.Property(e => e.FareDiff).HasMaxLength(50);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flight_no");

                entity.Property(e => e.InfantTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infant_tax");

                entity.Property(e => e.PaxAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_address");

                entity.Property(e => e.PaxCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_city");

                entity.Property(e => e.PaxCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_country");

                entity.Property(e => e.PaxEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_email");

                entity.Property(e => e.PaxFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_fname");

                entity.Property(e => e.PaxLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_lname");

                entity.Property(e => e.PaxMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_mobile");

                entity.Property(e => e.PaxPin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_pin");

                entity.Property(e => e.PaxState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_state");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Type");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.PnrStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pnr_status");

                entity.Property(e => e.ReIssueCharge).HasMaxLength(50);

                entity.Property(e => e.RetDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ret_date");

                entity.Property(e => e.STax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_Tax");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sector");

                entity.Property(e => e.ServiceCharge).HasMaxLength(50);

                entity.Property(e => e.TFee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("T_Fee");

                entity.Property(e => e.TktExe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tkt_Exe");

                entity.Property(e => e.TotalAdult)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total_adult");

                entity.Property(e => e.TotalBookingCost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total_booking_cost");

                entity.Property(e => e.TotalChild)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total_child");

                entity.Property(e => e.TotalInfant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total_infant");

                entity.Property(e => e.TotalNoAdult)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total_no_adult");

                entity.Property(e => e.TotalNoChild)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total_no_child");

                entity.Property(e => e.TotalNoInfant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total_no_infant");

                entity.Property(e => e.TourCode)
                    .HasMaxLength(50)
                    .HasColumnName("tour_code");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");

                entity.Property(e => e.Vc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VC");
            });

            modelBuilder.Entity<FlightDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Flight_Details");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.DateOfArrival)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfDeparture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.EftRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Eft_Ref");

                entity.Property(e => e.ElectronicTicketing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FltRef).HasColumnName("Flt_ref");

                entity.Property(e => e.LocationId1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCarrier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.McxRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mcx_Ref");

                entity.Property(e => e.OperatingCarrier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDetailQualifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Searchvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentRef).HasColumnName("Segment_ref");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOfArrival)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOfDeparture)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlightSearchResult>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdminMarkup).HasColumnName("Admin_Markup");

                entity.Property(e => e.AdtAvlStatus).HasMaxLength(200);

                entity.Property(e => e.AdtBreakPoint).HasMaxLength(200);

                entity.Property(e => e.AdtCabin).HasMaxLength(200);

                entity.Property(e => e.AdtFar).HasMaxLength(200);

                entity.Property(e => e.AdtFareType).HasMaxLength(200);

                entity.Property(e => e.AdtFarebasis).HasMaxLength(200);

                entity.Property(e => e.AdtRbd).HasMaxLength(200);

                entity.Property(e => e.AirLineName).HasMaxLength(200);

                entity.Property(e => e.ArrAirportCode).HasMaxLength(200);

                entity.Property(e => e.ArrAirportCodeRef).HasMaxLength(200);

                entity.Property(e => e.ArrivalAirportName).HasMaxLength(200);

                entity.Property(e => e.ArrivalCityName).HasMaxLength(200);

                entity.Property(e => e.ArrivalCityNameRef).HasMaxLength(200);

                entity.Property(e => e.ArrivalDate)
                    .HasMaxLength(200)
                    .HasColumnName("Arrival_Date");

                entity.Property(e => e.ArrivalDate1)
                    .HasColumnType("date")
                    .HasColumnName("ArrivalDate");

                entity.Property(e => e.ArrivalLocation).HasMaxLength(200);

                entity.Property(e => e.ArrivalTerminal).HasMaxLength(200);

                entity.Property(e => e.ArrivalTime).HasMaxLength(200);

                entity.Property(e => e.AvlSeat)
                    .HasMaxLength(100)
                    .HasColumnName("Avl_Seat");

                entity.Property(e => e.BagInfo).HasMaxLength(200);

                entity.Property(e => e.ChdAvlStatus).HasMaxLength(200);

                entity.Property(e => e.ChdBreakPoint).HasMaxLength(200);

                entity.Property(e => e.ChdCabin).HasMaxLength(200);

                entity.Property(e => e.ChdFar).HasMaxLength(200);

                entity.Property(e => e.ChdFarebasis).HasMaxLength(200);

                entity.Property(e => e.ChdRbd).HasMaxLength(200);

                entity.Property(e => e.ChdfareType).HasMaxLength(200);

                entity.Property(e => e.ClassType).HasMaxLength(100);

                entity.Property(e => e.CreatedByName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUserid)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DepAirportCode).HasMaxLength(200);

                entity.Property(e => e.DepAirportCodeRef).HasMaxLength(200);

                entity.Property(e => e.DepartureAirportName).HasMaxLength(200);

                entity.Property(e => e.DepartureCityName).HasMaxLength(200);

                entity.Property(e => e.DepartureCityNameRef).HasMaxLength(200);

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(200)
                    .HasColumnName("Departure_Date");

                entity.Property(e => e.DepartureDate1)
                    .HasColumnType("date")
                    .HasColumnName("DepartureDate");

                entity.Property(e => e.DepartureLocation).HasMaxLength(200);

                entity.Property(e => e.DepartureTerminal).HasMaxLength(200);

                entity.Property(e => e.DepartureTime).HasMaxLength(200);

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicTicketing).HasMaxLength(200);

                entity.Property(e => e.FareBasis)
                    .HasMaxLength(200)
                    .HasColumnName("fareBasis");

                entity.Property(e => e.FareDet).HasMaxLength(200);

                entity.Property(e => e.FareRule).HasMaxLength(200);

                entity.Property(e => e.FbpaxType)
                    .HasMaxLength(200)
                    .HasColumnName("FBPaxType");

                entity.Property(e => e.FixedDepStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.FlightIdentification).HasMaxLength(200);

                entity.Property(e => e.FlightNo).HasMaxLength(100);

                entity.Property(e => e.GetVia)
                    .HasMaxLength(200)
                    .HasColumnName("getVia");

                entity.Property(e => e.GrandTotal).HasColumnName("Grand_Total");

                entity.Property(e => e.GrossTotal).HasColumnName("GROSS_Total");

                entity.Property(e => e.InfAvlStatus).HasMaxLength(200);

                entity.Property(e => e.InfBfare).HasColumnName("infBfare");

                entity.Property(e => e.InfBreakPoint).HasMaxLength(200);

                entity.Property(e => e.InfCabin).HasMaxLength(200);

                entity.Property(e => e.InfFar).HasMaxLength(200);

                entity.Property(e => e.InfFareType).HasMaxLength(200);

                entity.Property(e => e.InfFarebasis).HasMaxLength(200);

                entity.Property(e => e.InfRbd).HasMaxLength(200);

                entity.Property(e => e.IsPrimary).HasDefaultValueSql("((1))");

                entity.Property(e => e.MarketingCarrier).HasMaxLength(200);

                entity.Property(e => e.MarkupType)
                    .HasMaxLength(100)
                    .HasColumnName("Markup_Type");

                entity.Property(e => e.MarkupWithGst)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingCarrier).HasMaxLength(200);

                entity.Property(e => e.OrgDestFrom).HasMaxLength(200);

                entity.Property(e => e.OrgDestTo).HasMaxLength(200);

                entity.Property(e => e.Ot).HasColumnName("OT");

                entity.Property(e => e.ProductDetailQualifier).HasMaxLength(200);

                entity.Property(e => e.ProviderUserId)
                    .HasMaxLength(200)
                    .HasColumnName("ProviderUserID");

                entity.Property(e => e.Rbd)
                    .HasMaxLength(200)
                    .HasColumnName("RBD");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RtAirLineName)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_AirLineName");

                entity.Property(e => e.RtArrivalDate)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_Arrival_Date");

                entity.Property(e => e.RtArrivalTerminal)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_ArrivalTerminal");

                entity.Property(e => e.RtArrivalTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Rt_ArrivalTime");

                entity.Property(e => e.RtClassType)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_ClassType");

                entity.Property(e => e.RtDepartureDate)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_Departure_Date");

                entity.Property(e => e.RtDepartureTerminal)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_DepartureTerminal");

                entity.Property(e => e.RtDepartureTime)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_DepartureTime");

                entity.Property(e => e.RtFareBasis)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_fareBasis");

                entity.Property(e => e.RtFlightNo)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_FlightNo");

                entity.Property(e => e.RtRbd)
                    .HasMaxLength(100)
                    .HasColumnName("Rt_RBD");

                entity.Property(e => e.SupMarkup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalSeats)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Total_Seats");

                entity.Property(e => e.Triptype).HasMaxLength(100);

                entity.Property(e => e.UsedSeat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Used_Seat");

                entity.Property(e => e.ValiDatingCarrier).HasMaxLength(200);

                entity.Property(e => e.ValidTill)
                    .HasColumnType("date")
                    .HasColumnName("valid_Till");

                entity.Property(e => e.Wo).HasColumnName("WO");

                entity.Property(e => e.Yq).HasColumnName("YQ");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<FltDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdtFareBasis)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdtRbd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirCraft)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("2 Letter airline code");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrCityOrAirportCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("3 Letter city OrAirport code");

                entity.Property(e => e.ArrCityOrAirportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Arrival date (ddmmyy)");

                entity.Property(e => e.ArrTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Arrival time (hhmm)");

                entity.Property(e => e.ChdFareBasis)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChdRbd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepCityOrAirportCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("3 letter city or airport code");

                entity.Property(e => e.DepCityOrAirportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Departure date (ddmmyy)");

                entity.Property(e => e.DepTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Departure time (hhmm)");

                entity.Property(e => e.FltId).ValueGeneratedOnAdd();

                entity.Property(e => e.FltNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InfFareBasis)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InfRbd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Ycrn).HasColumnName("YCRN");

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");
            });

            modelBuilder.Entity<FltFareDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdminMrk).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AdnetFare)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ADNetFare");

                entity.Property(e => e.AgentMrk).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AgnetFare)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("AGNetFare");

                entity.Property(e => e.AvlBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BaseFare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CashBack).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cgst)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Discount1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DistrMrk).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F2)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FareId).ValueGeneratedOnAdd();

                entity.Property(e => e.FareType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.G1)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GstUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Gstdiff)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GSTDIFF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Iatacommission)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("IATACommission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Igst)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("IGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.In)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("IN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("JN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.K3)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MgtFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Oc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("OC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ot)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("OT");

                entity.Property(e => e.PaxType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Plb)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PLb");

                entity.Property(e => e.Qtax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ServiceTax1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sgst)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StcashBack)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STCashBack");

                entity.Property(e => e.Stdiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STDiscount");

                entity.Property(e => e.Stdiscount1)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STDiscount1");

                entity.Property(e => e.StnetFare)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STNetFare");

                entity.Property(e => e.Sttds)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STTds");

                entity.Property(e => e.SttdsOn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STTdsOn");

                entity.Property(e => e.SttotalDiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STTotalDiscount");

                entity.Property(e => e.Tds).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TdsOn).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TicketcopymarkupforTax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ticketcopymarkupforTAX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TicketcopymarkupforTc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ticketcopymarkupforTC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAfterDis).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalFare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TranFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Utgst)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("UTGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("WO");

                entity.Property(e => e.YCanFare).HasColumnName("Y_CAN_FARE");

                entity.Property(e => e.Ycrn).HasColumnName("YCRN");

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");

                entity.Property(e => e.Ym)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("YM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Yq)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("YQ");

                entity.Property(e => e.Yr)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("YR");
            });

            modelBuilder.Entity<FltHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FltHeader");

                entity.Property(e => e.AdditionalMarkup)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("Markup amount after pnr creation");

                entity.Property(e => e.Adult).HasComment("Number of Adult");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlinePnr)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Apiid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APIID");

                entity.Property(e => e.BillNoCorp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Child).HasComment("Number of child");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditNode)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DebitNode)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DistrId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Total Travel Duration");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GdsPnr)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GstCompanyAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Address");

                entity.Property(e => e.GstCompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GST_Company_Name");

                entity.Property(e => e.GstEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GST_Email");

                entity.Property(e => e.GstPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GST_PhoneNo");

                entity.Property(e => e.GstUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Gstdiff)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GSTDIFF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSTNO");

                entity.Property(e => e.Gstremark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GSTRemark");

                entity.Property(e => e.HeaderId).ValueGeneratedOnAdd();

                entity.Property(e => e.HoldCharge)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HoldDateTime).HasColumnType("datetime");

                entity.Property(e => e.ImportCharge).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Infant).HasComment("Number of infant");

                entity.Property(e => e.IsHoldByAgent).HasDefaultValueSql("((0))");

                entity.Property(e => e.MordifyStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Pending,Processed,Ticketed");

                entity.Property(e => e.Msent)
                    .HasColumnName("MSent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Unique referance number(8 digit)");

                entity.Property(e => e.PartnerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Credit limt (CL) or Credit card (CC)");

                entity.Property(e => e.PgCharges).HasColumnType("money");

                entity.Property(e => e.PgEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PgFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PgFName");

                entity.Property(e => e.PgLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PgLName");

                entity.Property(e => e.PgMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PgTid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PgTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pnrid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNRId");

                entity.Property(e => e.PreHoldRemark)
                    .IsUnicode(false)
                    .HasColumnName("PreHoldREmark");

                entity.Property(e => e.PreHoldUpdatedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PreholdUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RejectedRemark).IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.ResuCharge).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ResuFareDiff).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ResuId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ResuID");

                entity.Property(e => e.ResuServiseCharge).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SearchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sector")
                    .HasComment("Eg: DEL-LHR in case of Oneway and DEL-LHR-DEL in case of round trip");

                entity.Property(e => e.Sfdis)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SFDis");

                entity.Property(e => e.StaffId).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Request,Hold,Confirm,Ticketed");

                entity.Property(e => e.TicketId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAfterDis).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalBookingCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TourCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Domestic (D), International (I)");

                entity.Property(e => e.TripType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Oneway(O), RoundTrip(R), Multicity(M)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC")
                    .IsFixedLength();

                entity.Property(e => e.YCanFare).HasColumnName("Y_CAN_FARE");

                entity.Property(e => e.Ycrn).HasColumnName("YCRN");

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");
            });

            modelBuilder.Entity<FltHoldCharge>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasMaxLength(50);

                entity.Property(e => e.AirCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Charges).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.TripType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FltImportPnrSetting>(entity =>
            {
                entity.ToTable("FltImportPnrSetting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasMaxLength(50);

                entity.Property(e => e.AirCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Charges).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.TripType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FltPaxDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Ffairline)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FFAirline")
                    .IsFixedLength();

                entity.Property(e => e.Ffnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FFNumber");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfAssociatePaxName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.MealType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MName");

                entity.Property(e => e.MordifyStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PassportExpireDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaxId).ValueGeneratedOnAdd();

                entity.Property(e => e.PaxType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeatType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TicketNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VisaDet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ycrn).HasColumnName("YCRN");

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");
            });

            modelBuilder.Entity<GdsbookingLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GDSBookingLogs");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pnbfreq1).HasColumnName("PNBFReq1");

                entity.Property(e => e.Pnbfreq2).HasColumnName("PNBFReq2");

                entity.Property(e => e.Pnbfreq3).HasColumnName("PNBFReq3");

                entity.Property(e => e.Pnbfres1).HasColumnName("PNBFRes1");

                entity.Property(e => e.Pnbfres2).HasColumnName("PNBFRes2");

                entity.Property(e => e.Pnbfres3).HasColumnName("PNBFRes3");

                entity.Property(e => e.Pnr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sereq).HasColumnName("SEReq");

                entity.Property(e => e.Seres).HasColumnName("SERes");

                entity.Property(e => e.Ssreq).HasColumnName("SSReq");

                entity.Property(e => e.Ssres).HasColumnName("SSRes");
            });

            modelBuilder.Entity<GrpBookingDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Grp_Booking_Details");

                entity.Property(e => e.AcceptBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.AirlineInbond)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINE_INBOND");

                entity.Property(e => e.Airlinepnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINEPNR");

                entity.Property(e => e.BalancePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BkgPartnerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BKG_PartnerName");

                entity.Property(e => e.BookedPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BookingName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationRemarks).IsUnicode(false);

                entity.Property(e => e.CancelledBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.ExpactedPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FreezedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FreezedDate).HasColumnType("datetime");

                entity.Property(e => e.Gdspnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GDSPNR");

                entity.Property(e => e.GdspnrInbond)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GDSPNR_INBOND");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPaxDeatils).HasDefaultValueSql("((0))");

                entity.Property(e => e.ObookSelectedPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OBookSelectedPrice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORequestID");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayementBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayementDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentLink).IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PgCharges).HasColumnType("money");

                entity.Property(e => e.PgTid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProbableDays)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuotedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuotedDate).HasColumnType("datetime");

                entity.Property(e => e.RbookSelectedPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RBookSelectedPrice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefundedBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundedId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefundedID");

                entity.Property(e => e.RejectBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RejectDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RrequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RRequestID");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("SNO");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TicketedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TicketedDate).HasColumnType("datetime");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TripType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrpFlightDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Grp_Flight_Details");

                entity.Property(e => e.Aircode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalAirportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Arrival_AirportCode");

                entity.Property(e => e.ArrivalDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Arrival_Date");

                entity.Property(e => e.ArrivalLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Arrival_Location");

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Arrival_Time");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartureAirportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Departure_AirportCode");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Departure_Date");

                entity.Property(e => e.DepartureLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Departure_Location");

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Departure_Time");

                entity.Property(e => e.Flight)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RefRequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefRequestID");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("SNO");

                entity.Property(e => e.Stops)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TripType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Vc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VC");
            });

            modelBuilder.Entity<GrpPaxDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Grp_Pax_Details");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Ffairline)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FFAirline")
                    .IsFixedLength();

                entity.Property(e => e.Ffnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FFNumber");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfAssociatePaxName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.MealType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MName");

                entity.Property(e => e.MordifyStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PassportExpireDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaxType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PEmail");

                entity.Property(e => e.PfirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFirstName");

                entity.Property(e => e.PlastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLastName");

                entity.Property(e => e.Pmobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PMobile");

                entity.Property(e => e.Ptitle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PTitle");

                entity.Property(e => e.RefRequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefRequestID");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RequestID");

                entity.Property(e => e.SeatType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sno).HasColumnName("SNO");

                entity.Property(e => e.TicketNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TicketNumberInbond)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TicketNumber_INBOND");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ycrn).HasColumnName("YCRN");

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");
            });

            modelBuilder.Entity<GrpPriceQuotation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Grp_Price_Quotation");

                entity.Property(e => e.BkgPartnerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BKG_PartnerName");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.QuotePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefRequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefRequestID");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("SNO");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.ValidOffer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrpRefundAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GRP_RefundAmount");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Arrival)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BookingFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BookingName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRemarks).IsUnicode(false);

                entity.Property(e => e.CancelStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledDate).HasColumnType("datetime");

                entity.Property(e => e.CancellationCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Departure)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.JouneryDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Journey)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PgCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pgcharges)
                    .HasColumnType("money")
                    .HasColumnName("PGCharges");

                entity.Property(e => e.PrevReissueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PrevReissueID");

                entity.Property(e => e.RefRequestedId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefRequestedID");

                entity.Property(e => e.RefundRequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefundRequestID");

                entity.Property(e => e.RefundedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RefundedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RejectedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RequestedId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RequestedID");

                entity.Property(e => e.ServiceCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sno).HasColumnName("SNO");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRefund).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Trip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TripType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Gstdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GSTDetails");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gindex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("GIndex");

                entity.Property(e => e.Gstnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GSTNumber");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<GtaCountryList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GTA_Country_List");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .HasColumnName("Country_Code")
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Country_Name");
            });

            modelBuilder.Entity<HoldByAgentStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HoldByAgentStatus");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(100)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.ServiceType).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<HomeNotification>(entity =>
            {
                entity.ToTable("HomeNotification");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HotelCancellation>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Hotel_Cancellation");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.HotelCancellationDes)
                    .HasMaxLength(800)
                    .HasColumnName("Hotel_Cancellation_Des");

                entity.Property(e => e.HotelCancellationId).HasColumnName("Hotel_Cancellation_id");

                entity.Property(e => e.HotelId).HasColumnName("Hotel_id");
            });

            modelBuilder.Entity<HotelDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Hotel_Details");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.CountryName).HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.HotelAccommodation)
                    .HasMaxLength(500)
                    .HasColumnName("Hotel_accommodation");

                entity.Property(e => e.HotelCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Hotel_Category");

                entity.Property(e => e.HotelCheckingPolicy)
                    .HasMaxLength(500)
                    .HasColumnName("Hotel_Checking_Policy");

                entity.Property(e => e.HotelCheckoutPolicy)
                    .HasMaxLength(500)
                    .HasColumnName("Hotel_Checkout_Policy");

                entity.Property(e => e.HotelCode).HasColumnName("Hotel_Code");

                entity.Property(e => e.HotelDes)
                    .HasMaxLength(1000)
                    .HasColumnName("Hotel_Des");

                entity.Property(e => e.HotelId).HasColumnName("Hotel_id");

                entity.Property(e => e.HotelName)
                    .HasMaxLength(200)
                    .HasColumnName("Hotel_Name");

                entity.Property(e => e.HotelPrice).HasColumnName("Hotel_Price");

                entity.Property(e => e.RoomType)
                    .HasMaxLength(200)
                    .HasColumnName("Room_Type");

                entity.Property(e => e.StateName).HasMaxLength(100);
            });

            modelBuilder.Entity<HotelExlusion>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Hotel_Exlusion");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.HotelExclusionId).HasColumnName("Hotel_Exclusion_id");

                entity.Property(e => e.HotelExlusionDes)
                    .HasMaxLength(800)
                    .HasColumnName("Hotel_Exlusion_Des");

                entity.Property(e => e.HotelId).HasColumnName("Hotel_id");
            });

            modelBuilder.Entity<HotelImage>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Hotel_Image");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.HotelAmenetiesImage)
                    .HasMaxLength(200)
                    .HasColumnName("Hotel_ameneties_image");

                entity.Property(e => e.HotelAmentiesDes).HasColumnName("Hotel_amenties_des");

                entity.Property(e => e.HotelDiningDes).HasColumnName("Hotel_dining_des");

                entity.Property(e => e.HotelDiningImage)
                    .HasMaxLength(200)
                    .HasColumnName("Hotel_dining_image");

                entity.Property(e => e.HotelId).HasColumnName("Hotel_id");

                entity.Property(e => e.HotelImage1)
                    .HasMaxLength(200)
                    .HasColumnName("Hotel_Image");

                entity.Property(e => e.HotelImageDes)
                    .HasMaxLength(800)
                    .HasColumnName("Hotel_Image_Des");

                entity.Property(e => e.HotelImgaeId).HasColumnName("Hotel_Imgae_id");

                entity.Property(e => e.HotelName)
                    .HasMaxLength(200)
                    .HasColumnName("Hotel_Name");

                entity.Property(e => e.HotelRoomDes).HasColumnName("Hotel_room_des");

                entity.Property(e => e.HotelRoomImage)
                    .HasMaxLength(200)
                    .HasColumnName("Hotel_room_image");
            });

            modelBuilder.Entity<HotelIncluExeclu>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Hotel_Inclu_Execlu");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.HotelExeclusion).HasColumnName("Hotel_Execlusion");

                entity.Property(e => e.HotelId).HasColumnName("Hotel_id");

                entity.Property(e => e.HotelInclusion).HasColumnName("Hotel_Inclusion");

                entity.Property(e => e.HotelName)
                    .HasMaxLength(150)
                    .HasColumnName("Hotel_Name");
            });

            modelBuilder.Entity<HotelInclusion>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Hotel_Inclusion");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.HotelId).HasColumnName("Hotel_id");

                entity.Property(e => e.HotelInclusionDes)
                    .HasMaxLength(800)
                    .HasColumnName("Hotel_Inclusion_Des");

                entity.Property(e => e.HotelInclusionId).HasColumnName("Hotel_Inclusion_id");
            });

            modelBuilder.Entity<HotelItinerary>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Hotel_Itinerary");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.HotelId).HasColumnName("Hotel_id");

                entity.Property(e => e.HotelItinerary1).HasColumnName("Hotel_Itinerary_");

                entity.Property(e => e.HotelItineraryId).HasColumnName("Hotel_Itinerary_id");

                entity.Property(e => e.HotelNoOfDays).HasColumnName("Hotel_NoOfDays");
            });

            modelBuilder.Entity<ImportFltFareDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Import_FltFareDetails");

                entity.Property(e => e.AdminMrk).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AgentMrk).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AvlBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BaseFare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CashBack).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Discount1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DistrMrk).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FareId).ValueGeneratedOnAdd();

                entity.Property(e => e.FareType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gst)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GST");

                entity.Property(e => e.MgtFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ot)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("OT");

                entity.Property(e => e.PaxType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Plb)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PLb");

                entity.Property(e => e.Qtax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ServiceTax1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tds).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TdsOn).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalAfterDis).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalFare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TranFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Wo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("WO");

                entity.Property(e => e.YCanFare).HasColumnName("Y_CAN_FARE");

                entity.Property(e => e.Ycrn).HasColumnName("YCRN");

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");

                entity.Property(e => e.Yq)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("YQ");

                entity.Property(e => e.Yr)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("YR");
            });

            modelBuilder.Entity<ImportPnr>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("ImportPNR");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.AgName)
                    .HasMaxLength(50)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(150)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Airline).HasMaxLength(50);

                entity.Property(e => e.ArrivalDate).HasMaxLength(50);

                entity.Property(e => e.ArrivalTime).HasMaxLength(50);

                entity.Property(e => e.BlockPnr).HasColumnName("BlockPNR");

                entity.Property(e => e.DepartTime).HasMaxLength(50);

                entity.Property(e => e.Departdate).HasMaxLength(50);

                entity.Property(e => e.Departure).HasMaxLength(50);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Escharge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESCharge");

                entity.Property(e => e.ExecId)
                    .HasMaxLength(150)
                    .HasColumnName("Exec_ID");

                entity.Property(e => e.FlightNo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Pnrno)
                    .HasMaxLength(50)
                    .HasColumnName("PNRNo");

                entity.Property(e => e.Rdb)
                    .HasMaxLength(50)
                    .HasColumnName("RDB");

                entity.Property(e => e.RequestDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdRemark).HasColumnName("updRemark");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ImportPnrintl>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("ImportPNRIntl");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.AdtFareBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasMaxLength(50)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(150)
                    .HasColumnName("AgentID");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Airline).HasMaxLength(50);

                entity.Property(e => e.ArrivalDate).HasMaxLength(50);

                entity.Property(e => e.ArrivalTime).HasMaxLength(50);

                entity.Property(e => e.BlockPnr).HasColumnName("BlockPNR");

                entity.Property(e => e.BookedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChdFareBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartTime).HasMaxLength(50);

                entity.Property(e => e.Departdate).HasMaxLength(50);

                entity.Property(e => e.Departure).HasMaxLength(50);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID")
                    .HasDefaultValueSql("('FWU')");

                entity.Property(e => e.Escharge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESCharge");

                entity.Property(e => e.ExecId)
                    .HasMaxLength(150)
                    .HasColumnName("Exec_ID");

                entity.Property(e => e.FlightNo).HasMaxLength(50);

                entity.Property(e => e.FltheadrColumn)
                    .IsUnicode(false)
                    .HasColumnName("Fltheadr_column");

                entity.Property(e => e.ImportCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InfFareBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pnrno)
                    .HasMaxLength(50)
                    .HasColumnName("PNRNo");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rdb)
                    .HasMaxLength(50)
                    .HasColumnName("RDB");

                entity.Property(e => e.RequestDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SrvTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TripType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Infrant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Infrant");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasColumnName("AgentID");

                entity.Property(e => e.EmpId).ValueGeneratedOnAdd();

                entity.Property(e => e.Ffno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FFno");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppexp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PPexp");

                entity.Property(e => e.ProxyId)
                    .HasMaxLength(50)
                    .HasColumnName("ProxyID");

                entity.Property(e => e.SirName).HasMaxLength(20);

                entity.Property(e => e.VisaDet)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntPlb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IntPLB");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.EndDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Agent Type or Distr. Id");

                entity.Property(e => e.PlbOnBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Plb % on basic Fare");

                entity.Property(e => e.PlbOnBasicYq)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Plb % on Basic + YQ");

                entity.Property(e => e.Rbd)
                    .HasColumnName("RBD")
                    .HasComment("Restricted RBD");

                entity.Property(e => e.Sector).HasComment("Restricted Origin");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Irctccharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IRCTCCharges");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.AgencyName).HasMaxLength(500);

                entity.Property(e => e.Charges).HasColumnType("money");

                entity.Property(e => e.ChargesType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .HasColumnName("IP");

                entity.Property(e => e.Pgmax)
                    .HasColumnType("money")
                    .HasColumnName("PGMax");

                entity.Property(e => e.Pgmin)
                    .HasColumnType("money")
                    .HasColumnName("PGMin");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(100);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<LccBookingLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Airline)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apbreq).HasColumnName("APBREQ");

                entity.Property(e => e.Apbres).HasColumnName("APBRES");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Others).HasColumnName("OTHERS");

                entity.Property(e => e.PnrNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sbreq).HasColumnName("SBREQ");

                entity.Property(e => e.Sbres).HasColumnName("SBRES");

                entity.Property(e => e.Sjkreq).HasColumnName("SJKREQ");

                entity.Property(e => e.Sjkres).HasColumnName("SJKRES");

                entity.Property(e => e.Statereq).HasColumnName("STATEREQ");

                entity.Property(e => e.Stateres).HasColumnName("STATERES");

                entity.Property(e => e.Ucconreq).HasColumnName("UCCONREQ");

                entity.Property(e => e.Ucconres).HasColumnName("UCCONRES");

                entity.Property(e => e.Uppaxreq).HasColumnName("UPPAXREQ");

                entity.Property(e => e.Uppaxres).HasColumnName("UPPAXRES");
            });

            modelBuilder.Entity<LccFlightAvailability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LCC_Flight_Availability");

                entity.Property(e => e.AdtBasic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adt_Basic");

                entity.Property(e => e.AdtSur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adt_Sur");

                entity.Property(e => e.AdtTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adt_Tax");

                entity.Property(e => e.AdtTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adt_total");

                entity.Property(e => e.ArrDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Arr_Date");

                entity.Property(e => e.ArrTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Arr_Time");

                entity.Property(e => e.ChdBasic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Chd_Basic");

                entity.Property(e => e.ChdSur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Chd_Sur");

                entity.Property(e => e.ChdTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Chd_Tax");

                entity.Property(e => e.ChdTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Chd_Total");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.DeptDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Date");

                entity.Property(e => e.DeptTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Time");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fare_Basis");

                entity.Property(e => e.FlightDuration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Flight_Duration");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Flight_No");

                entity.Property(e => e.FltCnt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flt_cnt");

                entity.Property(e => e.FltDetail)
                    .IsUnicode(false)
                    .HasColumnName("flt_detail");

                entity.Property(e => e.Fulsur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fulsur");

                entity.Property(e => e.Helpkey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfBasic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Inf_Basic");

                entity.Property(e => e.InfSur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Inf_Sur");

                entity.Property(e => e.InfTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Inf_Tax");

                entity.Property(e => e.InfTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Inf_Total");

                entity.Property(e => e.MktCarrier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mkt_Carrier")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Origin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Search_value");

                entity.Property(e => e.Sno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sno");

                entity.Property(e => e.Stops)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Total_Fare");

                entity.Property(e => e.TotalTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Total_Tax");
            });

            modelBuilder.Entity<LccTraceId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LCC_TraceID");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookReq).HasColumnName("Book_req");

                entity.Property(e => e.BookRes).HasColumnName("Book_res");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Booking_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.FlightInfo).IsUnicode(false);

                entity.Property(e => e.Pnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNR");

                entity.Property(e => e.TraceId)
                    .IsUnicode(false)
                    .HasColumnName("TraceID");
            });

            modelBuilder.Entity<LccairlineSector>(entity =>
            {
                entity.HasKey(e => new { e.AirLineCode, e.SecFrom, e.SecTo });

                entity.ToTable("LCCAirlineSector");

                entity.Property(e => e.AirLineCode).HasMaxLength(2);

                entity.Property(e => e.SecFrom).HasMaxLength(3);

                entity.Property(e => e.SecTo).HasMaxLength(3);

                entity.Property(e => e.AirlineName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<LccairlineSectorIntl>(entity =>
            {
                entity.HasKey(e => new { e.AirLineCode, e.SecFrom, e.SecTo });

                entity.ToTable("LCCAirlineSectorIntl");

                entity.Property(e => e.AirLineCode).HasMaxLength(2);

                entity.Property(e => e.SecFrom).HasMaxLength(3);

                entity.Property(e => e.SecTo).HasMaxLength(3);

                entity.Property(e => e.AirlineName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<LccauthenticationTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LCCAuthenticationTable");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ActualURL");

                entity.Property(e => e.AutoTicketing).HasMaxLength(3);

                entity.Property(e => e.BookLcc)
                    .HasMaxLength(20)
                    .HasColumnName("BookLCC");

                entity.Property(e => e.CorporateCredentials).HasMaxLength(500);

                entity.Property(e => e.CorporateFare).HasMaxLength(300);

                entity.Property(e => e.CorporateFlag).HasMaxLength(30);

                entity.Property(e => e.CouponFareCredentials).HasMaxLength(500);

                entity.Property(e => e.CreditCard).HasMaxLength(100);

                entity.Property(e => e.ExchangeRates).HasMaxLength(120);

                entity.Property(e => e.FareTolerance).HasMaxLength(100);

                entity.Property(e => e.FormofPayment).HasMaxLength(50);

                entity.Property(e => e.GalTktIntl).HasMaxLength(10);

                entity.Property(e => e.GoAirCodes).HasMaxLength(100);

                entity.Property(e => e.IntTicketingPcc).HasMaxLength(250);

                entity.Property(e => e.IntlLccairlines)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("IntlLCCAirlines");

                entity.Property(e => e.LccagencyContact)
                    .HasMaxLength(600)
                    .HasColumnName("LCCAgencyContact");

                entity.Property(e => e.Lccairlines)
                    .HasMaxLength(50)
                    .HasColumnName("LCCAirlines");

                entity.Property(e => e.LccbalanceCheck)
                    .HasMaxLength(5)
                    .HasColumnName("LCCBalanceCheck");

                entity.Property(e => e.Lcccredentials)
                    .HasMaxLength(400)
                    .HasColumnName("LCCCredentials");

                entity.Property(e => e.LeisureCredentials).HasMaxLength(120);

                entity.Property(e => e.MakeOfflineGds)
                    .HasMaxLength(50)
                    .HasColumnName("MakeOfflineGDS");

                entity.Property(e => e.MerchantId).HasMaxLength(100);

                entity.Property(e => e.MerchantLoginCredentials).HasMaxLength(200);

                entity.Property(e => e.Pgcharges)
                    .HasMaxLength(500)
                    .HasColumnName("PGCharges");

                entity.Property(e => e.Sid).ValueGeneratedOnAdd();

                entity.Property(e => e.SpecialCredentials).HasMaxLength(500);

                entity.Property(e => e.TicketingIds)
                    .HasMaxLength(250)
                    .HasColumnName("TicketingIDs");

                entity.Property(e => e.TourCode).HasMaxLength(50);

                entity.Property(e => e.UptoDateGds)
                    .HasMaxLength(100)
                    .HasColumnName("UptoDateGDS");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIpaddress)
                    .HasMaxLength(20)
                    .HasColumnName("UserIPAddress");

                entity.Property(e => e.UserPwd).HasMaxLength(20);
            });

            modelBuilder.Entity<LccbookRq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LCCBookRq");

                entity.Property(e => e.AgencyData).HasMaxLength(300);

                entity.Property(e => e.Keys)
                    .HasMaxLength(700)
                    .HasColumnName("keys");

                entity.Property(e => e.PayPassword).HasMaxLength(200);

                entity.Property(e => e.Pnr)
                    .HasMaxLength(20)
                    .HasColumnName("PNR");

                entity.Property(e => e.QueryData).HasMaxLength(300);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(20)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.Sid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sid");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserData).HasMaxLength(300);
            });

            modelBuilder.Entity<LedgerDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .HasColumnName("AccountID");

                entity.Property(e => e.AgencyName).HasMaxLength(200);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(30)
                    .HasColumnName("AgentID");

                entity.Property(e => e.AvalBalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Aval_Balance");

                entity.Property(e => e.BillNoCorp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingType).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditLimitFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID")
                    .HasDefaultValueSql("('FWU')");

                entity.Property(e => e.DueAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.InvoiceNo).HasMaxLength(25);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(25)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PnrNo).HasMaxLength(250);

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.Tds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDS");

                entity.Property(e => e.TicketNo).HasMaxLength(150);

                entity.Property(e => e.TicketingCarrier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransType).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.YatraAccountId)
                    .HasMaxLength(50)
                    .HasColumnName("YatraAccountID");
            });

            modelBuilder.Entity<MailNotificationCredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MailNotification_Credential");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Bcc)
                    .HasMaxLength(1000)
                    .HasColumnName("BCC");

                entity.Property(e => e.Bccstatus)
                    .HasColumnName("BCCStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cc)
                    .HasMaxLength(1000)
                    .HasColumnName("CC");

                entity.Property(e => e.Ccstatus)
                    .HasColumnName("CCStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mailfrom)
                    .HasMaxLength(100)
                    .HasColumnName("MAILFROM");

                entity.Property(e => e.Mailingdepartment)
                    .HasMaxLength(150)
                    .HasColumnName("MAILINGDEPARTMENT");

                entity.Property(e => e.Mailto)
                    .HasMaxLength(100)
                    .HasColumnName("MAILTO");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Regards)
                    .HasMaxLength(150)
                    .HasColumnName("REGARDS");

                entity.Property(e => e.Smtpclient)
                    .HasMaxLength(150)
                    .HasColumnName("SMTPCLIENT");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1000)
                    .HasColumnName("SUBJECT");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<MailerQuery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MailerQuery");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Days)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PackageName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPassenger)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarqueeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarqueeMsg>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("MarqueeMsg");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.MarqueeMsg1).HasColumnName("MarqueeMsg");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<MiscSrvCharge>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("MISC_SRV_CHARGE");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Airline)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CommisionOnBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Commission on Basic fare");

                entity.Property(e => e.CommisionOnBasicYq)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Coimmission on Basic + YQ");

                entity.Property(e => e.CommissionOnYq)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dest)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MarkupType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Org)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WithGst)
                    .HasColumnName("WithGST")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MobileSmsMaster>(entity =>
            {
                entity.ToTable("MobileSmsMaster");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.EmailActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.MsgText).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ServiceType).HasMaxLength(50);

                entity.Property(e => e.Smsactive)
                    .HasColumnName("SMSActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MrkAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mrk_admin");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.MarkUp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarkupType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");
            });

            modelBuilder.Entity<MstService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MstService");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).ValueGeneratedOnAdd();

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewReg>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("New_Regs");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.AgLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ag_logo");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_Type");

                entity.Property(e => e.AltEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Alt_Email");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrdLimit)
                    .HasColumnType("money")
                    .HasColumnName("Crd_Limit");

                entity.Property(e => e.CrdTrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Crd_Trns_Date");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExmptTds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ExmptTDS");

                entity.Property(e => e.ExmptTdsLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_no");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPwd).HasColumnName("IsPWD");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NavId).HasColumnName("NAV_ID");

                entity.Property(e => e.OnlineTkt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Online_Tkt");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesExecID");

                entity.Property(e => e.SecAns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Ans");

                entity.Property(e => e.SecQes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sec_Qes");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Stax_no");

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.TimestampCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp_create");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YId)
                    .HasMaxLength(50)
                    .HasColumnName("Y_ID");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Notification");

                entity.Property(e => e.Activity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckedOn).HasColumnType("datetime");

                entity.Property(e => e.Index).ValueGeneratedOnAdd();

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<OlOfflineSeriesRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OL_OfflineSeriesRequest");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_ID");

                entity.Property(e => e.AirlineCode)
                    .IsUnicode(false)
                    .HasColumnName("Airline_Code");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableSeat).HasColumnName("Available_Seat");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.DepartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Depart_Date");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExecRemark)
                    .IsUnicode(false)
                    .HasColumnName("Exec_Remark");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Executive_ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.OfflineConfirm).HasColumnName("Offline_Confirm");

                entity.Property(e => e.OfflineHold).HasColumnName("Offline_Hold");

                entity.Property(e => e.RejectedRemark)
                    .IsUnicode(false)
                    .HasColumnName("Rejected_remark");

                entity.Property(e => e.RetDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ret_Date");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<OlSeriesAccountingRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OL_SeriesAccountingRequest");

                entity.Property(e => e.AccId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acc_ID");

                entity.Property(e => e.AccountRejectRemark)
                    .IsUnicode(false)
                    .HasColumnName("AccountReject_Remark");

                entity.Property(e => e.AccountRemark)
                    .IsUnicode(false)
                    .HasColumnName("Account_Remark");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Executive_ID");

                entity.Property(e => e.ExecutiveRemark)
                    .IsUnicode(false)
                    .HasColumnName("Executive_Remark");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<OlSeriesDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("OL_SeriesDetails");

                entity.Property(e => e.AirlineCode)
                    .IsUnicode(false)
                    .HasColumnName("Airline_Code");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableSeat).HasColumnName("Available_Seat");

                entity.Property(e => e.ConfirmSeat).HasColumnName("Confirm_Seat");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Depart_Date");

                entity.Property(e => e.ExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoldSeat).HasColumnName("Hold_Seat");

                entity.Property(e => e.OfflineConfirm).HasColumnName("Offline_Confirm");

                entity.Property(e => e.OfflineHold).HasColumnName("Offline_Hold");

                entity.Property(e => e.RetDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ret_Date");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<OlSeriesRequest>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("OL_SeriesRequest");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_ID");

                entity.Property(e => e.AgentRemark)
                    .IsUnicode(false)
                    .HasColumnName("Agent_Remark");

                entity.Property(e => e.AirlineCode)
                    .IsUnicode(false)
                    .HasColumnName("Airline_Code");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableSeat).HasColumnName("Available_Seat");

                entity.Property(e => e.ContactEmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactEmail_id");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactPerson_Name");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Depart_Date");

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Executive_ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.RejectedRemark)
                    .IsUnicode(false)
                    .HasColumnName("Rejected_remark");

                entity.Property(e => e.RetDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ret_Date");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Otphistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OTPHistory");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.Mstatus)
                    .HasColumnName("MStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otp)
                    .HasMaxLength(30)
                    .HasColumnName("OTP");

                entity.Property(e => e.Otpid)
                    .HasMaxLength(100)
                    .HasColumnName("OTPId");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<Otptransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OTPTransaction");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DistrId).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Otp)
                    .HasMaxLength(30)
                    .HasColumnName("OTP");

                entity.Property(e => e.OtpcreatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("OTPCreatedBy");

                entity.Property(e => e.Otpemail).HasColumnName("OTPEmail");

                entity.Property(e => e.Otpid)
                    .HasMaxLength(100)
                    .HasColumnName("OTPId");

                entity.Property(e => e.Otpmobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OTPMobile");

                entity.Property(e => e.RefNo).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ServiceType).HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<PageAuthentication>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.ToTable("PageAuthentication");

                entity.Property(e => e.PageId).HasColumnName("Page_ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PageName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PageParentId).HasColumnName("PageParent_ID");

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Page_URL");

                entity.Property(e => e.Updatedate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PageAuthorized>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Page_Authorized");

                entity.Property(e => e.PageId).HasColumnName("Page_id");

                entity.Property(e => e.RoleId).HasColumnName("Role_id");
            });

            modelBuilder.Entity<PageDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Page_Details");

                entity.Property(e => e.IsParentPage)
                    .HasMaxLength(10)
                    .HasColumnName("Is_Parent_Page")
                    .IsFixedLength();

                entity.Property(e => e.PageId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Page_id");

                entity.Property(e => e.PageName)
                    .HasMaxLength(100)
                    .HasColumnName("Page_name");

                entity.Property(e => e.PageUrl).HasColumnName("Page_url");

                entity.Property(e => e.RootPageId).HasColumnName("Root_page_id");
            });

            modelBuilder.Entity<PageUserAuthorization>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PageUserAuthorization");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enable)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PageId).HasColumnName("Page_ID");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Type_ID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PaxInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pax_information");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Paxtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("paxtype");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TktNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tkt_no");
            });

            modelBuilder.Entity<PgRefundAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PgRefundAmount");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApiStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FailureReason).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PgCharges).HasColumnType("money");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount).HasColumnType("money");

                entity.Property(e => e.RefundFor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundRemark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RefundStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tds)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDS");
            });

            modelBuilder.Entity<Pgcharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PGCharges");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.AgencyName).HasMaxLength(500);

                entity.Property(e => e.Charges)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargesType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(100);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<PgchargesLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PGChargesLog");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Charges).HasColumnType("money");

                entity.Property(e => e.ChargesType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NewCharge).HasColumnType("money");

                entity.Property(e => e.OriginalAmount).HasColumnType("money");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.TrackId).HasMaxLength(50);
            });

            modelBuilder.Entity<Pglog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PGLog");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChcekStatusBy).HasMaxLength(100);

                entity.Property(e => e.CheckedIpaddress)
                    .HasMaxLength(50)
                    .HasColumnName("CheckedIPAddress");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TId");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PgwebServiceLog>(entity =>
            {
                entity.ToTable("PGWebServiceLog");

                entity.Property(e => e.ApiName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PkgBooking>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Pkg_Booking");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.AdditonalNotes)
                    .HasMaxLength(500)
                    .HasColumnName("additonal_notes");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .HasColumnName("address");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("booking_date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .HasColumnName("full_name");

                entity.Property(e => e.HotelId).HasColumnName("hotel_id");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .HasColumnName("mobile_no");

                entity.Property(e => e.PkgHotelLocation)
                    .HasMaxLength(200)
                    .HasColumnName("pkg_hotel_location");

                entity.Property(e => e.PkgHotelName)
                    .HasMaxLength(100)
                    .HasColumnName("pkg_hotel_name");

                entity.Property(e => e.PkgId).HasColumnName("pkg_id");

                entity.Property(e => e.PkgLocation)
                    .HasMaxLength(200)
                    .HasColumnName("pkg_location");

                entity.Property(e => e.PkgPrice)
                    .HasColumnType("money")
                    .HasColumnName("pkg_price");

                entity.Property(e => e.PkgTitle)
                    .HasMaxLength(150)
                    .HasColumnName("pkg_title");
            });

            modelBuilder.Entity<PkgDetail>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_pkg_Detail");

                entity.ToTable("pkg_Details");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.PkgCreatedby)
                    .HasMaxLength(150)
                    .HasColumnName("pkg_createdby");

                entity.Property(e => e.PkgCreateddate)
                    .HasColumnType("date")
                    .HasColumnName("pkg_createddate");

                entity.Property(e => e.PkgDescription).HasColumnName("pkg_description");

                entity.Property(e => e.PkgDestinetionCity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pkg_destinetion_city");

                entity.Property(e => e.PkgEnddate)
                    .HasColumnType("date")
                    .HasColumnName("pkg_enddate");

                entity.Property(e => e.PkgExeclusion).HasColumnName("pkg_execlusion");

                entity.Property(e => e.PkgHotelMark).HasColumnName("Pkg_Hotel_Mark");

                entity.Property(e => e.PkgId).HasColumnName("pkg_Id");

                entity.Property(e => e.PkgImage)
                    .HasMaxLength(100)
                    .HasColumnName("Pkg_Image");

                entity.Property(e => e.PkgInclusion).HasColumnName("pkg_inclusion");

                entity.Property(e => e.PkgItinerary).HasColumnName("Pkg_Itinerary");

                entity.Property(e => e.PkgLocation)
                    .HasMaxLength(400)
                    .HasColumnName("pkg_Location");

                entity.Property(e => e.PkgNoofday).HasColumnName("pkg_noofday");

                entity.Property(e => e.PkgNoofnight).HasColumnName("pkg_noofnight");

                entity.Property(e => e.PkgOffer)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Pkg_Offer");

                entity.Property(e => e.PkgOfferPrice).HasColumnName("pkg_offerPrice");

                entity.Property(e => e.PkgOfferPriceValue)
                    .HasColumnType("money")
                    .HasColumnName("pkg_Offer_price_value");

                entity.Property(e => e.PkgPolicy).HasColumnName("Pkg_Policy");

                entity.Property(e => e.PkgPrice)
                    .HasColumnType("money")
                    .HasColumnName("pkg_price");

                entity.Property(e => e.PkgStartdate)
                    .HasColumnType("date")
                    .HasColumnName("pkg_startdate");

                entity.Property(e => e.PkgStatus).HasColumnName("pkg_status");

                entity.Property(e => e.PkgTheme)
                    .HasMaxLength(150)
                    .HasColumnName("pkg_theme");

                entity.Property(e => e.PkgTitle)
                    .HasMaxLength(150)
                    .HasColumnName("pkg_Title");

                entity.Property(e => e.PkgType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pkg_type");

                entity.Property(e => e.PkgUpdateby)
                    .HasMaxLength(100)
                    .HasColumnName("pkg_updateby");

                entity.Property(e => e.PkgUpdatedate)
                    .HasColumnType("date")
                    .HasColumnName("pkg_updatedate");
            });

            modelBuilder.Entity<PkgExclusion>(entity =>
            {
                entity.HasKey(e => e.PkgId);

                entity.ToTable("Pkg_Exclusions");

                entity.Property(e => e.PkgId)
                    .ValueGeneratedNever()
                    .HasColumnName("pkg_id");

                entity.Property(e => e.PkgExclusionsDescription)
                    .HasMaxLength(800)
                    .HasColumnName("pkg_Exclusions_Description");

                entity.Property(e => e.PkgExclusionsId).HasColumnName("pkg_Exclusions_Id");
            });

            modelBuilder.Entity<PkgHotelAdd>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Pkg_Hotel_Add");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.HotelId).HasColumnName("hotel_id");

                entity.Property(e => e.PkgHotelName)
                    .HasMaxLength(200)
                    .HasColumnName("pkg_hotel_name");

                entity.Property(e => e.PkgId).HasColumnName("pkg_id");

                entity.Property(e => e.PkgTitle)
                    .HasMaxLength(200)
                    .HasColumnName("pkg_title");
            });

            modelBuilder.Entity<PkgImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pkg_Image");

                entity.Property(e => e.PkgId).HasColumnName("pkg_id");

                entity.Property(e => e.PkgImage1)
                    .HasMaxLength(100)
                    .HasColumnName("pkg_Image");

                entity.Property(e => e.PkgImageDescription)
                    .HasMaxLength(500)
                    .HasColumnName("pkg_Image_Description");

                entity.Property(e => e.PkgImageId).HasColumnName("pkg_Image_Id");

                entity.Property(e => e.PkgTitle)
                    .HasMaxLength(150)
                    .HasColumnName("pkg_title");
            });

            modelBuilder.Entity<PkgIncluExclu>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Pkg_Inclu_Exclu");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.PkgExeclu).HasColumnName("pkg_execlu");

                entity.Property(e => e.PkgInclu).HasColumnName("pkg_inclu");
            });

            modelBuilder.Entity<PkgInclusion>(entity =>
            {
                entity.HasKey(e => e.PkgId);

                entity.ToTable("pkg_Inclusion");

                entity.Property(e => e.PkgId)
                    .ValueGeneratedNever()
                    .HasColumnName("pkg_id");

                entity.Property(e => e.PkgInclusionDescription)
                    .HasMaxLength(500)
                    .HasColumnName("pkg_Inclusion_Description");

                entity.Property(e => e.PkgInclusionId).HasColumnName("pkg_Inclusion_Id");
            });

            modelBuilder.Entity<PkgItinerary>(entity =>
            {
                entity.HasKey(e => e.PkgId);

                entity.ToTable("Pkg_Itinerary");

                entity.Property(e => e.PkgId)
                    .ValueGeneratedNever()
                    .HasColumnName("pkg_id");

                entity.Property(e => e.PkgItineraryDescription).HasColumnName("pkg_Itinerary_Description");

                entity.Property(e => e.PkgItineraryId).HasColumnName("pkg_Itinerary_Id");

                entity.Property(e => e.PkgItineraryNoOfDays).HasColumnName("pkg_Itinerary_NoOf_Days");

                entity.Property(e => e.PkgTitle)
                    .HasMaxLength(150)
                    .HasColumnName("pkg_title");
            });

            modelBuilder.Entity<PkgOfferPrice>(entity =>
            {
                entity.HasKey(e => e.PkgId);

                entity.ToTable("Pkg_Offer_Price");

                entity.Property(e => e.PkgId)
                    .ValueGeneratedNever()
                    .HasColumnName("pkg_id");

                entity.Property(e => e.PkgOfferId).HasColumnName("pkg_offer_id");

                entity.Property(e => e.PkgOfferPrice1)
                    .HasColumnType("money")
                    .HasColumnName("pkg_offer_price");

                entity.Property(e => e.PkgPrice)
                    .HasColumnType("money")
                    .HasColumnName("pkg_price");

                entity.Property(e => e.PkgTitle)
                    .HasMaxLength(150)
                    .HasColumnName("pkg_title");
            });

            modelBuilder.Entity<PkgPolicy>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Pkg_Policy");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.PkgPolicyDis).HasColumnName("Pkg_Policy_Dis");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCTS");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ManufacturingDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProviderInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProviderInfo");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProxyIpdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProxyIPDetails");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProxyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProxyID");

                entity.Property(e => e.ProxyIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ProxyIP");

                entity.Property(e => e.ProxyPort)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProxyTicket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProxyTicket");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.AgName)
                    .HasMaxLength(50)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(150)
                    .HasColumnName("AgentID");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlinePnr)
                    .HasMaxLength(50)
                    .HasColumnName("AirlinePNR");

                entity.Property(e => e.Airlines).HasMaxLength(50);

                entity.Property(e => e.BookedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingType).HasMaxLength(10);

                entity.Property(e => e.Class).HasMaxLength(50);

                entity.Property(e => e.Classes).HasMaxLength(3);

                entity.Property(e => e.DepartDate).HasMaxLength(50);

                entity.Property(e => e.DepartTime).HasMaxLength(50);

                entity.Property(e => e.DepartureTerminal).HasMaxLength(50);

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID")
                    .HasDefaultValueSql("('FWU')");

                entity.Property(e => e.ExecId)
                    .HasMaxLength(50)
                    .HasColumnName("Exec_ID");

                entity.Property(e => e.ExpectedAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNo).HasMaxLength(50);

                entity.Property(e => e.OrderIdOneWay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderIdTwoWay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode).HasMaxLength(20);

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.ProxyChargeOw)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ProxyChargeOW");

                entity.Property(e => e.ProxyChargeRt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ProxyChargeRT");

                entity.Property(e => e.ProxyFrom).HasMaxLength(50);

                entity.Property(e => e.ProxyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProxyID");

                entity.Property(e => e.ProxyTo).HasMaxLength(50);

                entity.Property(e => e.ProxyType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RbdoneWay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RBDOneWay");

                entity.Property(e => e.RbdtwoWay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RBDTwoWay");

                entity.Property(e => e.RejectComment).HasMaxLength(500);

                entity.Property(e => e.RequestDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("requestDateTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnDate).HasMaxLength(50);

                entity.Property(e => e.ReturnTime).HasMaxLength(50);

                entity.Property(e => e.SalesExecId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SrvChargeOneWay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SrvChargeTwoWay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TravelType).HasMaxLength(10);

                entity.Property(e => e.UpdateRemark).HasColumnName("updateRemark");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuickContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("quick_contact");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Query)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("query");
            });

            modelBuilder.Entity<RailAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rail_agent");

                entity.Property(e => e.SubUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sub_User_ID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<RailBookingHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RailBookingHistory");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCharge).HasColumnType("money");

                entity.Property(e => e.BankTxnId).HasMaxLength(50);

                entity.Property(e => e.Charges).HasColumnType("money");

                entity.Property(e => e.ChargesType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DistrId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GstOnAgentCharge).HasColumnType("money");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Pgcharge)
                    .HasColumnType("money")
                    .HasColumnName("PGCharge");

                entity.Property(e => e.Pgmax)
                    .HasColumnType("money")
                    .HasColumnName("PGMax");

                entity.Property(e => e.Pgmin)
                    .HasColumnType("money")
                    .HasColumnName("PGMin");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReservationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("money");

                entity.Property(e => e.TxnAmt).HasColumnType("money");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RailRefundFw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RailRefundFWS");

                entity.Property(e => e.ActualRefundDate)
                    .HasColumnType("date")
                    .HasColumnName("ACTUAL_REFUND_DATE");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasColumnName("Agent Id");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RefundAmount)
                    .HasColumnType("money")
                    .HasColumnName("REFUND_AMOUNT");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SlNo).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTION_ID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Rdslog>(entity =>
            {
                entity.ToTable("RDSLog");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MerchantCode).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ReservationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Rdspayment>(entity =>
            {
                entity.ToTable("RDSPayment");

                entity.Property(e => e.AgencyId).HasMaxLength(50);

                entity.Property(e => e.AgencyName).HasMaxLength(100);

                entity.Property(e => e.AppCode).HasMaxLength(50);

                entity.Property(e => e.BankTxnId).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistrId).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MerchantCode).HasMaxLength(50);

                entity.Property(e => e.PymtMode).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReservationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnAmount).HasColumnType("money");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<RdspaymentResponse>(entity =>
            {
                entity.ToTable("RDSPaymentResponse");

                entity.Property(e => e.BankTxnId).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Rdsrequest>(entity =>
            {
                entity.ToTable("RDSRequest");

                entity.Property(e => e.AppCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MerchantCode).HasMaxLength(50);

                entity.Property(e => e.PymtMode).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReservationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ru).HasColumnName("RU");

                entity.Property(e => e.SecurityId).HasMaxLength(30);

                entity.Property(e => e.TxnAmount).HasColumnType("money");

                entity.Property(e => e.TxnDate).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RdsverificationResponse>(entity =>
            {
                entity.ToTable("RDSVerificationResponse");

                entity.Property(e => e.AgencyId).HasMaxLength(50);

                entity.Property(e => e.AgencyName).HasMaxLength(100);

                entity.Property(e => e.BankTxnId).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DistrId).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MerchantCode).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ReservationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusDesc).HasMaxLength(100);

                entity.Property(e => e.TxnAmount).HasColumnType("money");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<ReIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReIssue");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AirPnr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Base_Fare");

                entity.Property(e => e.BlockIssue).HasColumnName("Block_Issue");

                entity.Property(e => e.BookingDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Booking_date");

                entity.Property(e => e.Cb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CB");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Departure)
                    .HasMaxLength(50)
                    .HasColumnName("departure");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departure_date");

                entity.Property(e => e.Deptime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .HasColumnName("destination");

                entity.Property(e => e.Discount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.FareDiff).HasMaxLength(50);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaxFname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_fname");

                entity.Property(e => e.PaxLname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_lname");

                entity.Property(e => e.PaxType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pax_type");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.ReIssueCharge).HasMaxLength(50);

                entity.Property(e => e.RegardingIssue).IsUnicode(false);

                entity.Property(e => e.RejectionComment).IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCharge).HasMaxLength(50);

                entity.Property(e => e.ServiceTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Service_Tax");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TktNo)
                    .HasMaxLength(50)
                    .HasColumnName("Tkt_No");

                entity.Property(e => e.TotalFare).HasMaxLength(50);

                entity.Property(e => e.TotalFareAfterDiscount).HasMaxLength(50);

                entity.Property(e => e.TranFees)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tran_Fees");

                entity.Property(e => e.UpdateRemark).HasColumnName("updateRemark");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC");

                entity.Property(e => e.Yq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YQ");
            });

            modelBuilder.Entity<ReIssueIntl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReIssueIntl");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .HasColumnName("Agency_Name");

                entity.Property(e => e.AirPnr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Base_Fare");

                entity.Property(e => e.BlockIssue).HasColumnName("Block_Issue");

                entity.Property(e => e.BookingDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Booking_date");

                entity.Property(e => e.Cb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CB");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Departure)
                    .HasMaxLength(50)
                    .HasColumnName("departure");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departure_date");

                entity.Property(e => e.Deptime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .HasColumnName("destination");

                entity.Property(e => e.Discount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.FareDiff).HasMaxLength(50);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.PaxFname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_fname");

                entity.Property(e => e.PaxId).HasColumnName("PaxID");

                entity.Property(e => e.PaxLname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_lname");

                entity.Property(e => e.PaxType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pax_type");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.ReIssueCharge).HasMaxLength(50);

                entity.Property(e => e.ReIssueId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ReIssueID");

                entity.Property(e => e.RegardingIssue).IsUnicode(false);

                entity.Property(e => e.RejectionComment).IsUnicode(false);

                entity.Property(e => e.Scsrvtax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SCSRVTAX");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCharge).HasMaxLength(50);

                entity.Property(e => e.ServiceTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Service_Tax");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TktNo)
                    .HasMaxLength(50)
                    .HasColumnName("Tkt_No");

                entity.Property(e => e.TotalFare).HasMaxLength(50);

                entity.Property(e => e.TotalFareAfterDiscount).HasMaxLength(50);

                entity.Property(e => e.TranFees)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tran_Fees");

                entity.Property(e => e.Trip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC");

                entity.Property(e => e.Yq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YQ");
            });

            modelBuilder.Entity<ResultSessionDetail>(entity =>
            {
                entity.HasKey(e => e.Rsindex)
                    .HasName("PK_ResultSession");

                entity.Property(e => e.Rsindex).HasColumnName("RSIndex");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.ResultSessionKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleTab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Role_tab");

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.RoleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Role_id");

                entity.Property(e => e.RoleType)
                    .HasMaxLength(50)
                    .HasColumnName("Role_Type");
            });

            modelBuilder.Entity<SalesExecReg>(entity =>
            {
                entity.ToTable("SalesExecReg");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<SearchLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("searchLog");

                entity.Property(e => e.DestFrmDestTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestXml).HasColumnType("text");

                entity.Property(e => e.ResponseXml).HasColumnType("text");

                entity.Property(e => e.SearchValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SelectedFlightDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdtBfare)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdtCb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AdtCB");

                entity.Property(e => e.AdtComm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdtFare)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdtFsur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AdtFSur");

                entity.Property(e => e.AdtMgtFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdtTax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdtTax1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Adt_Tax");

                entity.Property(e => e.AdtTds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdtadminMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADTAdminMrk");

                entity.Property(e => e.AdtagentMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADTAgentMrk");

                entity.Property(e => e.Adult)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirLineName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Arrdatelcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("arrdatelcc");

                entity.Property(e => e.ArrivalCityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Arrival_Date");

                entity.Property(e => e.ArrivalLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableSeats)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdBfare)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChdCb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ChdCB");

                entity.Property(e => e.ChdComm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChdFare)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChdFsur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ChdFSur");

                entity.Property(e => e.ChdMgtFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChdTax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChdTax1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Chd_Tax");

                entity.Property(e => e.ChdTds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChdadminMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CHDAdminMrk");

                entity.Property(e => e.ChdagentMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CHDAgentMrk");

                entity.Property(e => e.Child)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureCityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureDate1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Departure_Date");

                entity.Property(e => e.DepartureLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Depdatelcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("depdatelcc");

                entity.Property(e => e.DisCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eq)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EQ");

                entity.Property(e => e.FareBasis)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fareBasis");

                entity.Property(e => e.FbpaxType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FBPaxType");

                entity.Property(e => e.Flight)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlightIdentification)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlightStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Iatacomm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IATAComm");

                entity.Property(e => e.InfBfare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infBfare");

                entity.Property(e => e.InfFare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfFsur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InfFSur");

                entity.Property(e => e.InfMgtFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InfTax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfTax1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Inf_Tax");

                entity.Property(e => e.Infant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCorp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Leg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCarrier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NetFare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netFare");

                entity.Property(e => e.OrgDestFrom)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDestTo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalTf)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OriginalTF");

                entity.Property(e => e.OriginalTt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OriginalTT");

                entity.Property(e => e.Rbd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RBD");

                entity.Property(e => e.Searchvalue).IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sno)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sno");

                entity.Property(e => e.SrvTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Stax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STax");

                entity.Property(e => e.Stops)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TC");

                entity.Property(e => e.Tf)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TF");

                entity.Property(e => e.Tfee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TFee");

                entity.Property(e => e.TotDur)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tot_Dur");

                entity.Property(e => e.TotFare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totFare");

                entity.Property(e => e.TotMgtFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotPax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBfare)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFare)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFuelSur).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Track_id");

                entity.Property(e => e.Trip)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TripCnt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TripType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_id");

                entity.Property(e => e.ValiDatingCarrier)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SelectedFlightDetailsGal>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("SelectedFlightDetails_Gal");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.AdtBfare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtCabin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtCb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AdtCB");

                entity.Property(e => e.AdtComm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdtComm1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdtFare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtFareType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtFarebasis)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtFsur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AdtFSur");

                entity.Property(e => e.AdtMgtFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdtOt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AdtOT");

                entity.Property(e => e.AdtRbd)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtSrvTax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtSrvTax1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtTax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdtTax1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Adt_Tax");

                entity.Property(e => e.AdtTds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdtadminMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADTAdminMrk");

                entity.Property(e => e.AdtagentMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADTAgentMrk");

                entity.Property(e => e.Adtstockistmrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADTSTOCKISTMRK");

                entity.Property(e => e.AirLineName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineRemark).IsUnicode(false);

                entity.Property(e => e.ArrAirportCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Arrdatelcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("arrdatelcc");

                entity.Property(e => e.ArrivalCityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Arrival_Date");

                entity.Property(e => e.ArrivalLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalTerminal)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableSeats)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdBfare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdCabin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdCb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ChdCB");

                entity.Property(e => e.ChdComm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChdComm1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChdFare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdFareType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdFarebasis)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdFsur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ChdFSur");

                entity.Property(e => e.ChdMgtFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChdOt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ChdOT");

                entity.Property(e => e.ChdRbd)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdSrvTax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdSrvTax1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdTax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChdTax1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Chd_Tax");

                entity.Property(e => e.ChdTds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChdadminMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CHDAdminMrk");

                entity.Property(e => e.ChdagentMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CHDAgentMrk");

                entity.Property(e => e.Chdstockistmrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CHDSTOCKISTMRK");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepAirportCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureCityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureDate1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Departure_Date");

                entity.Property(e => e.DepartureLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureTerminal)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Depdatelcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("depdatelcc");

                entity.Property(e => e.DisCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicTicketing)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Eq)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EQ");

                entity.Property(e => e.FamilyFare).HasMaxLength(100);

                entity.Property(e => e.FareBasis)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FbpaxType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FBPaxType");

                entity.Property(e => e.Flight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightIdentification)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlightStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Iatacomm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IATAComm");

                entity.Property(e => e.InfAdminMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfAgentMrk)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfBfare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfCabin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfCb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InfCB");

                entity.Property(e => e.InfComm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InfFare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfFareType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfFarebasis)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfFsur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InfFSur");

                entity.Property(e => e.InfMgtFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InfOt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("InfOT");

                entity.Property(e => e.InfRbd)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfSrvTax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfTax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InfTax1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Inf_Tax");

                entity.Property(e => e.InfTds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Inftockistmrk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("INFTOCKISTMRK");

                entity.Property(e => e.IsSmefare).HasColumnName("IsSMEFare");

                entity.Property(e => e.Leg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCarrier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NetFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OldTrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OldTrack_Id");

                entity.Property(e => e.OperatingCarrier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDestFrom)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDestTo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalTf)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("OriginalTF");

                entity.Property(e => e.OriginalTt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("OriginalTT");

                entity.Property(e => e.Pnrid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNRId");

                entity.Property(e => e.Provider)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rbd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RBD");

                entity.Property(e => e.Resulttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RESULTTYPE");

                entity.Property(e => e.SearchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Searchvalue).IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sno)
                    .IsUnicode(false)
                    .HasColumnName("sno");

                entity.Property(e => e.SrvTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ssrcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSRCode");

                entity.Property(e => e.Stadtcb)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STADTCB");

                entity.Property(e => e.Stadtcomm)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STADTCOMM");

                entity.Property(e => e.Stadtcomm1)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STADTCOMM1");

                entity.Property(e => e.Stadttds)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STADTTDS");

                entity.Property(e => e.Stax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STax");

                entity.Property(e => e.StchdComm)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STChdComm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stchdcb)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STCHDCB");

                entity.Property(e => e.Stchdcomm1)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STCHDCOMM1");

                entity.Property(e => e.Stchdtds)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STCHDTDS");

                entity.Property(e => e.Stiatacomm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STIATACOMM");

                entity.Property(e => e.Stinfcb)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STINFCB");

                entity.Property(e => e.Stinfcomm)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STINFCOMM");

                entity.Property(e => e.Stinftds)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("STINFTDS");

                entity.Property(e => e.Stops)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TC");

                entity.Property(e => e.Tf)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TF");

                entity.Property(e => e.Tfee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TFee");

                entity.Property(e => e.TicketId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotDur)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tot_Dur");

                entity.Property(e => e.TotFare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotMgtFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalBfare)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFuelSur).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Track_id");

                entity.Property(e => e.Trip)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TripCnt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TripType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_id");

                entity.Property(e => e.ValiDatingCarrier)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceCredential>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Apisource).HasColumnName("APISource");

                entity.Property(e => e.BkgServerUrlOrIp).HasColumnName("BkgServerUrlOrIP");

                entity.Property(e => e.Cache).HasDefaultValueSql("((0))");

                entity.Property(e => e.CarrierAcc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CorporateId)
                    .HasMaxLength(50)
                    .HasColumnName("CorporateID");

                entity.Property(e => e.CrdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Iatanumber)
                    .HasMaxLength(100)
                    .HasColumnName("IATANumber");

                entity.Property(e => e.InfBasic).HasColumnType("money");

                entity.Property(e => e.InfTax).HasColumnType("money");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(500)
                    .HasColumnName("LoginID");

                entity.Property(e => e.LoginPwd).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceVersion).HasMaxLength(100);

                entity.Property(e => e.ResultFrom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SearchType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServerUrlOrIp).HasColumnName("ServerUrlOrIP");

                entity.Property(e => e.TripType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.Version).HasMaxLength(100);

                entity.Property(e => e.WebProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebResult).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ServiceCredentialsTemp>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("ServiceCredentials_TEMP");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Apisource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("APISource");

                entity.Property(e => e.BkgServerUrlOrIp).HasColumnName("BkgServerUrlOrIP");

                entity.Property(e => e.Cache).HasDefaultValueSql("((0))");

                entity.Property(e => e.CarrierAcc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorporateId)
                    .HasMaxLength(50)
                    .HasColumnName("CorporateID");

                entity.Property(e => e.CrdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InfBasic).HasColumnType("money");

                entity.Property(e => e.InfTax).HasColumnType("money");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(500)
                    .HasColumnName("LoginID");

                entity.Property(e => e.LoginPwd).HasMaxLength(500);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultFrom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SearchType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServerUrlOrIp).HasColumnName("ServerUrlOrIP");

                entity.Property(e => e.TripType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.WebProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebResult).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ServiceCredentialsTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceCredentials_TEST");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Apisource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("APISource");

                entity.Property(e => e.BkgServerUrlOrIp).HasColumnName("BkgServerUrlOrIP");

                entity.Property(e => e.CarrierAcc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CorporateId)
                    .HasMaxLength(50)
                    .HasColumnName("CorporateID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CrdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Iatanumber)
                    .HasMaxLength(100)
                    .HasColumnName("IATANumber");

                entity.Property(e => e.InfBasic).HasColumnType("money");

                entity.Property(e => e.InfTax).HasColumnType("money");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(500)
                    .HasColumnName("LoginID");

                entity.Property(e => e.LoginPwd).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceVersion).HasMaxLength(100);

                entity.Property(e => e.ResultFrom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SearchType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServerUrlOrIp).HasColumnName("ServerUrlOrIP");

                entity.Property(e => e.TripType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.Version).HasMaxLength(100);

                entity.Property(e => e.WebProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceErrorLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("ServiceErrorLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PageName).IsUnicode(false);
            });

            modelBuilder.Entity<ServiceSwitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceSwitch");

                entity.Property(e => e.AvailableOn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceProviderType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedDate");
            });

            modelBuilder.Entity<ServiceSwitchCache>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceSwitch_Cache");

                entity.Property(e => e.Airline)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableOn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceProviderType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedDate");
            });

            modelBuilder.Entity<ServiceTaxInt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceTaxInt");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Iatacomm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("IATAComm");

                entity.Property(e => e.SrvTax)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((1.24))");

                entity.Property(e => e.TranFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SmsDetail>(entity =>
            {
                entity.ToTable("Sms_Details");

                entity.Property(e => e.MobNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasMaxLength(100);

                entity.Property(e => e.Smsdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SMSDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatCd).HasColumnName("StatCD");
            });

            modelBuilder.Entity<SmsEmailMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SmsEmailMaster");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId).HasMaxLength(200);

                entity.Property(e => e.EmaliStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.SmsStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SmsserviceType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSServiceType");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ServiceType).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<StInt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("St_Int");

                entity.Property(e => e.SrTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sr_Tax");
            });

            modelBuilder.Entity<StaffTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StaffTransaction");

                entity.Property(e => e.AgencyId).HasMaxLength(100);

                entity.Property(e => e.AgentBal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgentLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgentMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvalBal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckBalance).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Credit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Debit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DistrId).HasMaxLength(100);

                entity.Property(e => e.DueAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasMaxLength(100);

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ServiceType).HasMaxLength(100);

                entity.Property(e => e.StaffId).HasMaxLength(100);

                entity.Property(e => e.StaffUserId).HasMaxLength(100);

                entity.Property(e => e.TransAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("status_table");

                entity.Property(e => e.Slno).HasColumnName("slno");

                entity.Property(e => e.Statusdesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("statusdesc");

                entity.Property(e => e.Statusname)
                    .HasMaxLength(10)
                    .HasColumnName("statusname")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TAirFareTypeSetting>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_T_Air_LCCFareRule");

                entity.ToTable("T_Air_FareTypeSettings");

                entity.Property(e => e.AirCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cabin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationPanelty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FareBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareClassReq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FareClass_Req");

                entity.Property(e => e.FareClassRes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FareClass_Res");

                entity.Property(e => e.FareType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fsk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FSK");

                entity.Property(e => e.IdType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IsSmefare)
                    .HasColumnName("IsSMEFare")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductClassReq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductClass_Req");

                entity.Property(e => e.ProductClassRes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductClass_Res");

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReIssuePanelty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ssrcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSRCode");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TCanLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_CAN_LOG");

                entity.Property(e => e.AddpayReq)
                    .IsUnicode(false)
                    .HasColumnName("ADDPAY_REQ");

                entity.Property(e => e.AddpayRes)
                    .IsUnicode(false)
                    .HasColumnName("ADDPAY_RES");

                entity.Property(e => e.BkgReq)
                    .IsUnicode(false)
                    .HasColumnName("BKG_REQ");

                entity.Property(e => e.BkgRes)
                    .IsUnicode(false)
                    .HasColumnName("BKG_RES");

                entity.Property(e => e.BkgcommitReq)
                    .IsUnicode(false)
                    .HasColumnName("BKGCOMMIT_REQ");

                entity.Property(e => e.BkgcommitRes)
                    .IsUnicode(false)
                    .HasColumnName("BKGCOMMIT_RES");

                entity.Property(e => e.CanReq)
                    .IsUnicode(false)
                    .HasColumnName("CAN_REQ");

                entity.Property(e => e.CanRes)
                    .IsUnicode(false)
                    .HasColumnName("CAN_RES");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Error)
                    .IsUnicode(false)
                    .HasColumnName("ERROR");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Refno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFNO");

                entity.Property(e => e.Refundamount)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REFUNDAMOUNT");

                entity.Property(e => e.Vc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VC");
            });

            modelBuilder.Entity<TCancImportPnr>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_CancellationIntlNew");

                entity.ToTable("T_Canc_ImportPNR");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.Adminmrk)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ADMINMRK");

                entity.Property(e => e.AirLinePnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AirLinePNR");

                entity.Property(e => e.ArrTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFare)
                    .HasMaxLength(50)
                    .HasColumnName("Base_Fare");

                entity.Property(e => e.BfCgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("BF_CGST");

                entity.Property(e => e.BfIgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("BF_IGST");

                entity.Property(e => e.BfSgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("BF_SGST");

                entity.Property(e => e.BillNoAir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNoCorp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BlockCancel).HasColumnName("Block_Cancel");

                entity.Property(e => e.BookingDate)
                    .HasMaxLength(50)
                    .HasColumnName("Booking_date");

                entity.Property(e => e.CancelledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cb)
                    .HasMaxLength(50)
                    .HasColumnName("CB");

                entity.Property(e => e.CorpId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CorpID");

                entity.Property(e => e.CorpName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorpType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditNoteNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departure)
                    .HasMaxLength(50)
                    .HasColumnName("departure");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .HasColumnName("departure_date");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .HasColumnName("destination");

                entity.Property(e => e.Discount).HasMaxLength(50);

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.EntityId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EntityID");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .HasColumnName("ExecutiveID");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.In)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("IN");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(25)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Jn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("JN");

                entity.Property(e => e.MgtFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MsCgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MS_CGST");

                entity.Property(e => e.MsIgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MS_IGST");

                entity.Property(e => e.MsSgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MS_SGST");

                entity.Property(e => e.Octax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OCTax");

                entity.Property(e => e.OnlineRefAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ot)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("OT");

                entity.Property(e => e.PaxFname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_fname");

                entity.Property(e => e.PaxId).HasColumnName("PaxID");

                entity.Property(e => e.PaxLname)
                    .HasMaxLength(50)
                    .HasColumnName("pax_lname");

                entity.Property(e => e.PaxType)
                    .HasMaxLength(30)
                    .HasColumnName("pax_type");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RefundID");

                entity.Property(e => e.RequestRemarks).IsUnicode(false);

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ScCgst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SC_CGST");

                entity.Property(e => e.ScIgst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SC_IGST");

                entity.Property(e => e.ScSgst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SC_SGST");

                entity.Property(e => e.Scsrvtax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SCSRVTAX");

                entity.Property(e => e.Sector).HasMaxLength(50);

                entity.Property(e => e.Segments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTax)
                    .HasMaxLength(50)
                    .HasColumnName("Service_Tax");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.Taid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TAID");

                entity.Property(e => e.Tauserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TAUSERID");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .HasColumnName("TDS");

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TktNo)
                    .HasMaxLength(50)
                    .HasColumnName("Tkt_No");

                entity.Property(e => e.TotalFare).HasMaxLength(50);

                entity.Property(e => e.TotalFareAfterDiscount).HasMaxLength(50);

                entity.Property(e => e.TranFees)
                    .HasMaxLength(50)
                    .HasColumnName("Tran_Fees");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC")
                    .IsFixedLength();

                entity.Property(e => e.Wo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("WO");

                entity.Property(e => e.Yflag).HasColumnName("YFLAG");

                entity.Property(e => e.Yq)
                    .HasMaxLength(50)
                    .HasColumnName("YQ");

                entity.Property(e => e.YqCgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("YQ_CGST");

                entity.Property(e => e.YqIgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("YQ_IGST");

                entity.Property(e => e.YqSgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("YQ_SGST");

                entity.Property(e => e.Yr)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("YR");

                entity.Property(e => e.YrCgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("YR_CGST");

                entity.Property(e => e.YrIgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("YR_IGST");

                entity.Property(e => e.YrSgst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("YR_SGST");
            });

            modelBuilder.Entity<TDealCodeMstr>(entity =>
            {
                entity.ToTable("T_DealCode_Mstr");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasMaxLength(50);

                entity.Property(e => e.AirCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppliedOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DTCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("D_T_Code");

                entity.Property(e => e.DestAirport).IsUnicode(false);

                entity.Property(e => e.DestCountry).IsUnicode(false);

                entity.Property(e => e.FltNo).IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Agent Type or Distr. Id");

                entity.Property(e => e.IdType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrginAirport).IsUnicode(false);

                entity.Property(e => e.OrginCountry).IsUnicode(false);

                entity.Property(e => e.TripType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TripTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TDmtmarkupCharge>(entity =>
            {
                entity.ToTable("T_DMTMarkupCharges");

                entity.Property(e => e.Amount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Charges)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChargesType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Charges_Type");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Group_Type");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Uploaded_Date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TFdSeatUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_fd_seat_update");

                entity.Property(e => e.AvlSeat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avl_seat");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Cseat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cseat");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orderid");

                entity.Property(e => e.PavlSeat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pavl_seat");

                entity.Property(e => e.Pnr)
                    .HasColumnType("datetime")
                    .HasColumnName("pnr");

                entity.Property(e => e.Pseat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pseat");

                entity.Property(e => e.PusedSeat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pused_seat");

                entity.Property(e => e.Sno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sno");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UsedSeat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("used_seat");
            });

            modelBuilder.Entity<TFlightDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_FLIGHT_DETAILS");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalLoc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("arrival_loc");

                entity.Property(e => e.Arrvldate)
                    .HasColumnType("datetime")
                    .HasColumnName("arrvldate");

                entity.Property(e => e.DepartLoc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("depart_loc");

                entity.Property(e => e.Departdate)
                    .HasColumnType("datetime")
                    .HasColumnName("departdate");

                entity.Property(e => e.Departtime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departtime");

                entity.Property(e => e.DomOrIntl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flight)
                    .HasMaxLength(10)
                    .HasColumnName("flight")
                    .IsFixedLength();

                entity.Property(e => e.FlightNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flight_num");

                entity.Property(e => e.NoOfPsgr).HasColumnName("no_of_psgr");

                entity.Property(e => e.ProbableDays).HasColumnName("probable_days");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Requestid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestid");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sno");

                entity.Property(e => e.TripType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trip_type");
            });

            modelBuilder.Entity<TFltEbSsr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Flt_EB_SSR");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SNO");

                entity.Property(e => e.SsrCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSR_Code");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC");
            });

            modelBuilder.Entity<TFltMbSsrLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Flt_MB_SSR_Log");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HeaderTbc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Header_TBC");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssrxml)
                    .IsUnicode(false)
                    .HasColumnName("SSRXML");
            });

            modelBuilder.Entity<TFltMealAndBaggageRequest>(entity =>
            {
                entity.HasKey(e => e.Mbid)
                    .HasName("PK_T_Flt_MealRequest");

                entity.ToTable("T_Flt_Meal_And_Baggage_Request");

                entity.Property(e => e.Mbid).HasColumnName("MBID");

                entity.Property(e => e.AirLineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaggageCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BaggageCode).HasMaxLength(20);

                entity.Property(e => e.BaggageDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BaggagePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaggagePriceWithNoTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BookingRefNo).HasMaxLength(20);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FltHeaderId)
                    .HasMaxLength(12)
                    .HasColumnName("Flt_HeaderID");

                entity.Property(e => e.MealCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MealCode).HasMaxLength(20);

                entity.Property(e => e.MealDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MealPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MealPriceWithNoTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaxId).HasColumnName("PaxID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SeatCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SeatCode).HasMaxLength(20);

                entity.Property(e => e.SeatDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SeatPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeatPriceWithNoTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TripType)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFltMealSsr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Flt_MEAL_SSR");

                entity.Property(e => e.AircraftType)
                    .HasMaxLength(10)
                    .HasColumnName("Aircraft_Type");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DomesticPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Domestic_Price");

                entity.Property(e => e.Enable).HasColumnName("ENABLE");

                entity.Property(e => e.FltDuration)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FLT_Duration");

                entity.Property(e => e.InternationalPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("International_Price");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SNO");

                entity.Property(e => e.SsrCat2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSR_CAT2");

                entity.Property(e => e.SsrCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSR_Category");

                entity.Property(e => e.SsrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SSR_CODE");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC");
            });

            modelBuilder.Entity<TFltdetailsCancellation>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_T_FLTDETAILS_CANCELLATION_1");

                entity.ToTable("T_FLTDETAILS_CANCELLATION");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Adtfarebasis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADTFAREBASIS");

                entity.Property(e => e.Adtrbd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADTRBD");

                entity.Property(e => e.Aircraft)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIRCRAFT");

                entity.Property(e => e.Airlinecode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINECODE")
                    .IsFixedLength();

                entity.Property(e => e.Airlinename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINENAME");

                entity.Property(e => e.Arrcityorairportcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ARRCITYORAIRPORTCODE")
                    .IsFixedLength();

                entity.Property(e => e.Arrcityorairportname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARRCITYORAIRPORTNAME");

                entity.Property(e => e.Arrdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARRDATE");

                entity.Property(e => e.Arrterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARRTERMINAL");

                entity.Property(e => e.Arrtime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARRTIME");

                entity.Property(e => e.Avlseat).HasColumnName("AVLSEAT");

                entity.Property(e => e.Baggage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BAGGAGE");

                entity.Property(e => e.Chdfarebasis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHDFAREBASIS");

                entity.Property(e => e.Chdrbd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CHDRBD");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASS");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depcityorairportcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEPCITYORAIRPORTCODE")
                    .IsFixedLength();

                entity.Property(e => e.Depcityorairportname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPCITYORAIRPORTNAME");

                entity.Property(e => e.Depdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPDATE");

                entity.Property(e => e.Depterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPTERMINAL");

                entity.Property(e => e.Deptime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPTIME");

                entity.Property(e => e.Designator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESIGNATOR");

                entity.Property(e => e.Fltid).HasColumnName("FLTID");

                entity.Property(e => e.Fltnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FLTNUMBER");

                entity.Property(e => e.Inffarebasis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INFFAREBASIS");

                entity.Property(e => e.Infrbd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INFRBD");

                entity.Property(e => e.NotValidAfter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotValidBefore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Segment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");
            });

            modelBuilder.Entity<TGstState>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("T_GST_State");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gstcode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GSTCode")
                    .IsFixedLength();

                entity.Property(e => e.StateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TInstantPayBankDetail>(entity =>
            {
                entity.ToTable("T_InstantPayBankDetail");

                entity.Property(e => e.AepsEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aeps_enabled");

                entity.Property(e => e.BankId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_id");

                entity.Property(e => e.BankIin)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bank_iin");

                entity.Property(e => e.BankName)
                    .IsUnicode(false)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BankSortName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bank_sort_name");

                entity.Property(e => e.BranchIfsc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("branch_ifsc");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IfscAlias)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ifsc_alias");

                entity.Property(e => e.ImpsEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imps_enabled");

                entity.Property(e => e.IsDown)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("is_down");
            });

            modelBuilder.Entity<TInstantPayBeneficary>(entity =>
            {
                entity.ToTable("T_InstantPayBeneficary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bank).IsUnicode(false);

                entity.Property(e => e.BeneficiaryId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Environment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Imps)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("imps");

                entity.Property(e => e.IpayUuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Ipay_uuid");

                entity.Property(e => e.LastSuccessDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastSuccessDate");

                entity.Property(e => e.LastSuccessImps)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastSuccessImps");

                entity.Property(e => e.LastSuccessName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastSuccessName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqBank).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TInstantPayDmtdirectBeneficiary>(entity =>
            {
                entity.ToTable("T_InstantPayDMTDirectBeneficiary");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BenId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BenName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Expotp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EXPOTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ifsccode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IFSCCode");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TInstantPayDmtdirectRemitter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_InstantPayDMTDirectRemitter");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BackImg)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FrontImg)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Idproof)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDProof");

                entity.Property(e => e.IdproofNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDProofNumber");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsKyc)
                    .HasColumnName("IsKYC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVerified).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kycstatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KYCStatus")
                    .HasDefaultValueSql("('PENDING')");

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Otp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OTP");

                entity.Property(e => e.OtpexpTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OTPExpTime");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowKycform)
                    .HasColumnName("ShowKYCForm")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TransferOtp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TransferOTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransferOtpexpDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TransferOTPExpDate")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TInstantPayErrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK__T_Instan__35856A2A245EA738");

                entity.ToTable("T_InstantPayErrorLog");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorRemark).IsUnicode(false);

                entity.Property(e => e.PostUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestJson).IsUnicode(false);

                entity.Property(e => e.RequestRemark).IsUnicode(false);

                entity.Property(e => e.ResponseRemark).IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TInstantPayFundTransfer>(entity =>
            {
                entity.HasKey(e => e.FundTransId)
                    .HasName("PK__T_Instan__2A17325A7F9F3F64");

                entity.ToTable("T_InstantPayFundTransfer");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAlias)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bank_alias");

                entity.Property(e => e.BenificieryId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CcfBank)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ccf_bank");

                entity.Property(e => e.ChargedAmt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("charged_amt");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Environment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("environment");

                entity.Property(e => e.IpayId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ipay_id");

                entity.Property(e => e.IpayUuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ipay_uuid");

                entity.Property(e => e.LedgerAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LockedAmt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("locked_amt");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OpeningBal)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("opening_bal");

                entity.Property(e => e.OprId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("opr_id");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("orderid");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ref_no");

                entity.Property(e => e.Refund).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefundId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitterMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransTrackId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TxnMode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TInstantPayInitiatePayout>(entity =>
            {
                entity.HasKey(e => e.InitiatePayoutId)
                    .HasName("PK__T_Instan__C6281B18716F893E");

                entity.ToTable("T_InstantPayInitiatePayout");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlertEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("alert_email");

                entity.Property(e => e.AlertMobile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("alert_mobile");

                entity.Property(e => e.BankName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BeneName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bene_name");

                entity.Property(e => e.BenificieryId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ccf)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ccf");

                entity.Property(e => e.ChargedAmt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("charged_amt");

                entity.Property(e => e.CommercialValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("commercial_value");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("credit_amount");

                entity.Property(e => e.EndpointIp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("endpoint_ip");

                entity.Property(e => e.Environment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("environment");

                entity.Property(e => e.ExternalRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("external_ref");

                entity.Property(e => e.IpayId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ipay_id");

                entity.Property(e => e.IpayUuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ipay_uuid");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("latitude");

                entity.Property(e => e.LedgerAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("longitude");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("orderid");

                entity.Property(e => e.Otp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("otp");

                entity.Property(e => e.OtpAuth)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("otp_auth");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('payout')");

                entity.Property(e => e.PayoutAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("payout_account");

                entity.Property(e => e.PayoutCreditRefid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("payout_credit_refid");

                entity.Property(e => e.PayoutIfsc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("payout_ifsc");

                entity.Property(e => e.PayoutName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("payout_name");

                entity.Property(e => e.Refund).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefundId).HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemitterMobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemtRemark).IsUnicode(false);

                entity.Property(e => e.SpKey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sp_key");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");

                entity.Property(e => e.TrackId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransferValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("transfer_value");

                entity.Property(e => e.TypePricing)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type_pricing");

                entity.Property(e => e.ValueTds)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("value_tds");

                entity.Property(e => e.VendorCcf)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vendor_ccf");
            });

            modelBuilder.Entity<TInstantPayRemitterDetail>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("PK__T_Instan__2C6822F80BC4D9E8");

                entity.ToTable("T_InstantPayRemitterDetail");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Consumedlimit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("consumedlimit");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditLimit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAddress).IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsVerified)
                    .HasColumnName("is_verified")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kycdocs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("kycdocs");

                entity.Property(e => e.Kycstatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kycstatus");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PermTxnLimit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("perm_txn_limit");

                entity.Property(e => e.PinCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PincodeRes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pincode_res");

                entity.Property(e => e.RegMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remaininglimit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remaininglimit");

                entity.Property(e => e.State)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TInstantPayRemitterReg>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("PK__T_Instan__2C6822F8EC1924DF");

                entity.ToTable("T_InstantPayRemitterReg");

                entity.Property(e => e.AgentUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsKycstatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IsKYCStatus")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocalAddress).IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('registered')");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VerifiedStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TInstantPayRemitterRegResponse>(entity =>
            {
                entity.HasKey(e => e.RegRespoId)
                    .HasName("PK__T_Instan__F287CC2E93BA11F6");

                entity.ToTable("T_InstantPayRemitterRegResponse");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.AgentUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumedAmount).IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditLimit).IsUnicode(false);

                entity.Property(e => e.Impsmode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IMPSMode");

                entity.Property(e => e.IsVerified)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kycdoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KYCDoc");

                entity.Property(e => e.Kycstatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KYCStatus");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Neftmode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NEFTMode");

                entity.Property(e => e.PernTxnLimit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingLimit).IsUnicode(false);

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TInstantPayResponseLog>(entity =>
            {
                entity.HasKey(e => e.ResponseId)
                    .HasName("PK__T_Instan__1AAA646C96EF18A5");

                entity.ToTable("T_InstantPayResponseLog");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestJson).IsUnicode(false);

                entity.Property(e => e.RequestRemark).IsUnicode(false);

                entity.Property(e => e.ResponseJson).IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TIpdmtbeneficaryDetail>(entity =>
            {
                entity.ToTable("T_IPDMTBeneficaryDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Merchant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TIpdmterrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorLogId)
                    .HasName("PK__T_IPDMTE__D65247C21E02855E");

                entity.ToTable("T_IPDMTErrorLog");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.ErrorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostUrl).IsUnicode(false);

                entity.Property(e => e.RequestDel).IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TIpdmtfundTransferDetail>(entity =>
            {
                entity.HasKey(e => e.FundTransId)
                    .HasName("PK__T_IPDMTF__2A17325A86E3B1B1");

                entity.ToTable("T_IPDMTFundTransferDetails");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BenificieryId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FundTransStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IpayOprId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IpayRefNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IpayReferenceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Merchant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitterMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxnMode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TIpdmtremitterBenificiaryLog>(entity =>
            {
                entity.HasKey(e => e.RemtBenLogId)
                    .HasName("PK__T_IPDMTR__45C1828252F2A432");

                entity.ToTable("T_IPDMTRemitterBenificiaryLog");

                entity.Property(e => e.Account)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("account");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .IsUnicode(false)
                    .HasColumnName("bank");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Ifsc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ifsc");

                entity.Property(e => e.Imps)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imps");

                entity.Property(e => e.LastSuccessDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastSuccessDate");

                entity.Property(e => e.LastSuccessImps)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastSuccessImps");

                entity.Property(e => e.LastSuccessName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastSuccessName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Remitterid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remitterid");

                entity.Property(e => e.Remittermobile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remittermobile");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TIpdmtremitterDetail>(entity =>
            {
                entity.ToTable("T_IPDMTRemitterDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsKycstatus)
                    .HasColumnName("IsKYCStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemitterId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VerifiedStatus).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TIpdmtremitterRegLog>(entity =>
            {
                entity.HasKey(e => e.RemtRegLogId)
                    .HasName("PK__T_IPDMTR__200ED116B7EEB34B");

                entity.ToTable("T_IPDMTRemitterRegLog");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ConsumedLimit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("consumedLimit");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsVerified)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isVerified");

                entity.Property(e => e.KycDocs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("kycDocs");

                entity.Property(e => e.KycStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kycStatus");

                entity.Property(e => e.LimitconsumedAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("limitconsumedAmount");

                entity.Property(e => e.Limitimpsmode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("limitimpsmode");

                entity.Property(e => e.Limitneftmode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("limitneftmode");

                entity.Property(e => e.LimitremainningAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("limitremainningAmount");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PernTxnLimit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pernTxnLimit");

                entity.Property(e => e.PinCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pinCode");

                entity.Property(e => e.RemainingLimit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remainingLimit");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<TIpdmtrequestResponseLog>(entity =>
            {
                entity.HasKey(e => e.RrlogId)
                    .HasName("PK__T_IPDMTR__9B7E8D66D6A1D128");

                entity.ToTable("T_IPDMTRequestResponseLog");

                entity.Property(e => e.RrlogId).HasColumnName("RRLogId");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostUrl).IsUnicode(false);

                entity.Property(e => e.RequestDel).IsUnicode(false);

                entity.Property(e => e.ResponseDel).IsUnicode(false);

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TReissueFltdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_REISSUE_FLTDETAILS");

                entity.Property(e => e.Adtfarebasis)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADTFAREBASIS");

                entity.Property(e => e.Adtrbd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADTRBD");

                entity.Property(e => e.Aircraft)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIRCRAFT");

                entity.Property(e => e.Airlinecode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINECODE")
                    .IsFixedLength();

                entity.Property(e => e.Airlinename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINENAME");

                entity.Property(e => e.Arrcityorairportcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ARRCITYORAIRPORTCODE")
                    .IsFixedLength();

                entity.Property(e => e.Arrcityorairportname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARRCITYORAIRPORTNAME");

                entity.Property(e => e.Arrdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARRDATE");

                entity.Property(e => e.Arrterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARRTERMINAL");

                entity.Property(e => e.Arrtime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARRTIME");

                entity.Property(e => e.Avlseat).HasColumnName("AVLSEAT");

                entity.Property(e => e.Baggage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BAGGAGE");

                entity.Property(e => e.Chdfarebasis)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CHDFAREBASIS");

                entity.Property(e => e.Chdrbd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CHDRBD");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASS");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depcityorairportcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEPCITYORAIRPORTCODE")
                    .IsFixedLength();

                entity.Property(e => e.Depcityorairportname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPCITYORAIRPORTNAME");

                entity.Property(e => e.Depdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPDATE");

                entity.Property(e => e.Depterminal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPTERMINAL");

                entity.Property(e => e.Deptime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPTIME");

                entity.Property(e => e.Designator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESIGNATOR");

                entity.Property(e => e.ExecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExecID");

                entity.Property(e => e.Fltid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FLTID");

                entity.Property(e => e.Fltnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FLTNUMBER");

                entity.Property(e => e.Inffarebasis)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INFFAREBASIS");

                entity.Property(e => e.Infrbd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INFRBD");

                entity.Property(e => e.IsPnrRetreive).HasDefaultValueSql("((0))");

                entity.Property(e => e.NotValidAfter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotValidBefore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Refno)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("REFNO");

                entity.Property(e => e.ReissueRbd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Reissue_RBD");

                entity.Property(e => e.ReissueRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");
            });

            modelBuilder.Entity<TRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_REQUEST");

                entity.Property(e => e.Amountpaid)
                    .HasColumnType("money")
                    .HasColumnName("amountpaid");

                entity.Property(e => e.Bookingstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bookingstatus");

                entity.Property(e => e.ConfirmDate)
                    .HasColumnType("datetime")
                    .HasColumnName("confirm_date");

                entity.Property(e => e.Hod)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hod");

                entity.Property(e => e.Isofficial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isofficial");

                entity.Property(e => e.Opsexecutive)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("opsexecutive");

                entity.Property(e => e.Paymentstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentstatus");

                entity.Property(e => e.Pnr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pnr");

                entity.Property(e => e.Requestedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("requestedby");

                entity.Property(e => e.Requesteddate)
                    .HasColumnType("datetime")
                    .HasColumnName("requesteddate");

                entity.Property(e => e.Requestid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestid");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("servicetype");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sno");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.Usertype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usertype");
            });

            modelBuilder.Entity<TSaltValue>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("T_SaltValue");

                entity.Property(e => e.ClientType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaltValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSeat>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("T_Seat");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassOfService)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Destination)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Equipment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsMaxSeat)
                    .HasColumnName("isMaxSeat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxSeatSsrcode)
                    .HasMaxLength(200)
                    .HasColumnName("MaxSeatSSRCode");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.SeatAlignment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SeatDesignator)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SeatStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SsrrefNo)
                    .HasMaxLength(200)
                    .HasColumnName("SSRRefNo");

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TSeatMstr>(entity =>
            {
                entity.ToTable("T_Seat_Mstr");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeatTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SeatTypeName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TSeatRequestTraveller>(entity =>
            {
                entity.ToTable("T_SeatRequest_Traveller");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SeatType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tpcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TPCode");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TSmbpBbpsbillerLabelDatum>(entity =>
            {
                entity.HasKey(e => e.LabelDataId)
                    .HasName("PK__T_SMBP_B__05CE6DA2544A9B8F");

                entity.ToTable("T_SMBP_BBPSBillerLabelData");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillerId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FetchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FieldMaxLen)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FieldMinLen)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Index)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Labels).IsUnicode(false);
            });

            modelBuilder.Entity<TSmbpBbpsbillerList>(entity =>
            {
                entity.HasKey(e => e.BbpsbillerId)
                    .HasName("PK__T_SMBP_B__57EAE28262C0CCE9");

                entity.ToTable("T_SMBP_BBPSBillerList");

                entity.Property(e => e.BbpsbillerId).HasColumnName("BBPSBillerId");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillUpdation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillerId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FetchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsBillFetch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpKey)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSmbpBbpspayment>(entity =>
            {
                entity.HasKey(e => e.BbpspaymentId)
                    .HasName("PK__T_SMBP_B__8252D413F8179333");

                entity.ToTable("T_SMBP_BBPSPayment");

                entity.Property(e => e.BbpspaymentId).HasColumnName("BBPSPaymentId");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvlBalance)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CircleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CircleID");

                entity.Property(e => e.ClientRefId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Number)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OptTransactionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Refund).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefundId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Spkey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPKey");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TSmbpBbpspaymentOptional>(entity =>
            {
                entity.HasKey(e => e.OptionalId)
                    .HasName("PK__T_SMBP_B__7735FFCC6E08BF21");

                entity.ToTable("T_SMBP_BBPSPaymentOptional");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientRefId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Optional)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSmbpCircleDetail>(entity =>
            {
                entity.ToTable("T_SMBP_CircleDetails");

                entity.Property(e => e.CircleId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CircleName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TSmbperrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK__T_SMBPEr__35856A2A43A299DC");

                entity.ToTable("T_SMBPErrorLog");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientRefId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorRemark).IsUnicode(false);

                entity.Property(e => e.PostUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestJson).IsUnicode(false);

                entity.Property(e => e.RequestRemark).IsUnicode(false);

                entity.Property(e => e.ResponseRemark).IsUnicode(false);
            });

            modelBuilder.Entity<TSmbpresponseLog>(entity =>
            {
                entity.HasKey(e => e.ResponseId)
                    .HasName("PK__T_SMBPRe__1AAA646C80BEEA09");

                entity.ToTable("T_SMBPResponseLog");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientRefId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestJson).IsUnicode(false);

                entity.Property(e => e.RequestRemark).IsUnicode(false);

                entity.Property(e => e.ResponseJson).IsUnicode(false);
            });

            modelBuilder.Entity<TSmsCredential>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("T_SMS_Credential");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FeedId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TUserTypeId>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("T_User_TypeId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TWebNotification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_WebNotification");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EndHour)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endmin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.StartHour)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("startTime");

                entity.Property(e => e.Startmin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("startmin");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfmsg)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableWebhandeler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_webhandeler");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Imagename).HasMaxLength(100);

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .HasColumnName("IP");

                entity.Property(e => e.Orderid).HasMaxLength(100);
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tax");

                entity.Property(e => e.From).HasMaxLength(255);

                entity.Property(e => e.To).HasMaxLength(255);
            });

            modelBuilder.Entity<TaxiFareChart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TaxiFareChart");

                entity.Property(e => e.CarName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DayNight)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstKm).HasColumnName("FirstKM");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PackageType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAdjustmentdetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_ADJUSTMENTDETAILS");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Agencyname)
                    .HasMaxLength(100)
                    .HasColumnName("AGENCYNAME");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(50)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(50)
                    .HasColumnName("BANKCODE");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Cifcounter).HasColumnName("CIFCOUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Invoiceno)
                    .HasMaxLength(50)
                    .HasColumnName("INVOICENO");

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Remark)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Uploadtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADTYPE");
            });

            modelBuilder.Entity<TblAgencyDetailsUpdationLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Agency_Details_Updation_Log");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.LogId).ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedFieldLog).IsUnicode(false);
            });

            modelBuilder.Entity<TblAgencydetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_AGENCYDETAILS");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfVisit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QueryFor).IsUnicode(false);

                entity.Property(e => e.Timing)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAgentbookingInfo>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_AGENTBOOKING_INFO");

                entity.Property(e => e.BookingInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAirLinePromoCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_AirLinePromoCode");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Arrival).HasMaxLength(3);

                entity.Property(e => e.BookingPeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.BookingPeriodTo).HasColumnType("datetime");

                entity.Property(e => e.CounterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CounterID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Departure).HasMaxLength(3);

                entity.Property(e => e.PromoCode).HasMaxLength(20);

                entity.Property(e => e.Supplier).HasMaxLength(20);

                entity.Property(e => e.TravelPeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.TravelPeriodTo).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAirlineProvider>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_TBL_Providers");

                entity.ToTable("TBL_Airline_Providers");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gds).HasColumnName("GDS");

                entity.Property(e => e.Lcc).HasColumnName("LCC");

                entity.Property(e => e.ProviderCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAmdgdsbookinglog>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_AMDGDSBOOKINGLOGS");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.AddmultiReq).HasColumnName("ADDMULTI_REQ");

                entity.Property(e => e.AddmultiRes).HasColumnName("ADDMULTI_RES");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Other).HasColumnName("OTHER");

                entity.Property(e => e.Pnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNR");

                entity.Property(e => e.PnrReq).HasColumnName("PNR_REQ");

                entity.Property(e => e.PnrRes).HasColumnName("PNR_RES");

                entity.Property(e => e.PriceReq).HasColumnName("PRICE_REQ");

                entity.Property(e => e.PriceRes).HasColumnName("PRICE_RES");

                entity.Property(e => e.SellReq).HasColumnName("SELL_REQ");

                entity.Property(e => e.SellRes).HasColumnName("SELL_RES");

                entity.Property(e => e.TstReq).HasColumnName("TST_REQ");

                entity.Property(e => e.TstRes).HasColumnName("TST_RES");
            });

            modelBuilder.Entity<TblAmdgdsticketinglog>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_AMDGDSTICKETINGLOGS");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CripticReq).HasColumnName("CRIPTIC_REQ");

                entity.Property(e => e.CripticRes).HasColumnName("CRIPTIC_RES");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Other).HasColumnName("OTHER");

                entity.Property(e => e.RepnrretriveReq).HasColumnName("REPNRRETRIVE_REQ");

                entity.Property(e => e.RepnrretriveRes).HasColumnName("REPNRRETRIVE_RES");

                entity.Property(e => e.RepriceReq).HasColumnName("REPRICE_REQ");

                entity.Property(e => e.RepriceRes).HasColumnName("REPRICE_RES");

                entity.Property(e => e.RetrivepnrReq).HasColumnName("RETRIVEPNR_REQ");

                entity.Property(e => e.RetrivepnrRes).HasColumnName("RETRIVEPNR_RES");

                entity.Property(e => e.RetrivepnrtktReq).HasColumnName("RETRIVEPNRTKT_REQ");

                entity.Property(e => e.RetrivepnrtktRes).HasColumnName("RETRIVEPNRTKT_RES");

                entity.Property(e => e.RetstReq).HasColumnName("RETST_REQ");

                entity.Property(e => e.RetstRes).HasColumnName("RETST_RES");

                entity.Property(e => e.SigninReq)
                    .IsUnicode(false)
                    .HasColumnName("SIGNIN_REQ");

                entity.Property(e => e.SigninRes).HasColumnName("SIGNIN_RES");

                entity.Property(e => e.SignoutReq).HasColumnName("SIGNOUT_REQ");

                entity.Property(e => e.SignoutRes).HasColumnName("SIGNOUT_RES");
            });

            modelBuilder.Entity<TblAvbookinglog>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_AVBOOKINGLOGS");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Bookingencryptedres).HasColumnName("BOOKINGENCRYPTEDRES");

                entity.Property(e => e.Bookingreq).HasColumnName("BOOKINGREQ");

                entity.Property(e => e.Bookingres).HasColumnName("BOOKINGRES");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fareruleoneway).HasColumnName("FARERULEONEWAY");

                entity.Property(e => e.Fareruleroundtrip).HasColumnName("FARERULEROUNDTRIP");

                entity.Property(e => e.Holdencryptedres).HasColumnName("HOLDENCRYPTEDRES");

                entity.Property(e => e.Holdreq).HasColumnName("HOLDREQ");

                entity.Property(e => e.Holdres).HasColumnName("HOLDRES");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Other).HasColumnName("OTHER");

                entity.Property(e => e.Pnr)
                    .HasMaxLength(50)
                    .HasColumnName("PNR");

                entity.Property(e => e.Provider)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PROVIDER")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblBaggageinfo>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_BAGGAGEINFO");

                entity.Property(e => e.Airline)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaggageName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaggageinfo1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_BAGGAGEINFOS");

                entity.Property(e => e.Airline)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaggageName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CountryFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryFromCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Branch");

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Branch_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCabBookingEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_CAB_BOOKING_ENTRY");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BookingRequest).IsUnicode(false);

                entity.Property(e => e.BookingResponse).IsUnicode(false);

                entity.Property(e => e.CancelRemarks).IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.DropAdd)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DropLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Execid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXECID");

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MarkUpAmt).HasColumnType("money");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.PayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpAdd)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SNo");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxiBookingId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TaxiBookingID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCabinClassForOffineRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_CabinClassForOffineRecord");

                entity.Property(e => e.BookingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CabinClass)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FareType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.Rbd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RBD");
            });

            modelBuilder.Entity<TblCancellationCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CancellationCharge");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Gst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GST");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblChache>(entity =>
            {
                entity.ToTable("TBL_Chache");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sector");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<TblChacheSector>(entity =>
            {
                entity.ToTable("TBL_Chache_Sector");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Airline)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Daylimit).HasColumnName("daylimit");

                entity.Property(e => e.Expiretime).HasColumnName("expiretime");

                entity.Property(e => e.HitsCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.JourneyDate).HasColumnType("datetime");

                entity.Property(e => e.Response)
                    .IsUnicode(false)
                    .HasColumnName("response");

                entity.Property(e => e.ResultFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sector");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<TblChacheSectorBackup>(entity =>
            {
                entity.ToTable("TBL_Chache_Sector_backup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Airline)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Daylimit).HasColumnName("daylimit");

                entity.Property(e => e.Expiretime).HasColumnName("expiretime");

                entity.Property(e => e.HitsCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.JourneyDate).HasColumnType("datetime");

                entity.Property(e => e.Response)
                    .IsUnicode(false)
                    .HasColumnName("response");

                entity.Property(e => e.ResultFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sector");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<TblCharterFlightDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_CHARTER_FLIGHT_DETAILS");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalCityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepartureCityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FareType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InfBaseFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InfOt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InfOT");

                entity.Property(e => e.InfTotalFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InfYq)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InfYQ");

                entity.Property(e => e.MarketingCarrier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrgDestFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDestTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ot)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OT");

                entity.Property(e => e.Rbd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RBD");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrvCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Stops)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValidatingCarrier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Yq)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("YQ");
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_CITY");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.City)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stateid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATEID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblClearCacheRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_ClearCacheRecord");

                entity.Property(e => e.Aircode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIRCODE");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Searchkey)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SEARCHKEY");
            });

            modelBuilder.Entity<TblCommon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Common");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.RequestType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Service)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCompanyaddress>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_COMPANYADDRESS");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Addtype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDTYPE");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Companyaddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMPANYADDRESS");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COMPANYNAME");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FAX");

                entity.Property(e => e.Gst)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GST");

                entity.Property(e => e.Iatanumber)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("IATANUMBER");

                entity.Property(e => e.Logo).HasMaxLength(150);

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOBILENO");

                entity.Property(e => e.Panno)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PANNO");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONENO");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.Websitelink)
                    .HasMaxLength(100)
                    .HasColumnName("WEBSITELINK");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ZIPCODE");
            });

            modelBuilder.Entity<TblConfiguredMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ConfiguredMails");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_Control");

                entity.Property(e => e.ControlId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ControlID");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblControlItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_ControlItems");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ItemID");

                entity.Property(e => e.ItemSubTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedUrl)
                    .IsUnicode(false)
                    .HasColumnName("LinkedURL");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCorpBookedby>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_CORP_BOOKEDBY");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Bookedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BOOKEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<TblCorpManagementfee>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_TBL_MANAGEMENTFEE");

                entity.ToTable("TBL_CORP_MANAGEMENTFEE");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Airlinecode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINECODE")
                    .IsFixedLength();

                entity.Property(e => e.Airlinename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINENAME");

                entity.Property(e => e.Cretaeddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CRETAEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mgtonbasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MGTONBASIC");

                entity.Property(e => e.Mgtonbasicyq)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MGTONBASICYQ");

                entity.Property(e => e.Mgtontotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MGTONTOTAL");

                entity.Property(e => e.Mgtonyq)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MGTONYQ");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRIP")
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDDATE");
            });

            modelBuilder.Entity<TblCorpProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_CORP_PROJECTS");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCouCouponFareDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_COU_CouponFareDetails");

                entity.Property(e => e.AdultFare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adult_Fare");

                entity.Property(e => e.ChildFare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Child_fare");

                entity.Property(e => e.CouPnr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cou_PNR");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Departure_Date");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Flight_No");

                entity.Property(e => e.FltArr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Flt_Arr");

                entity.Property(e => e.FltDepart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Flt_Depart");

                entity.Property(e => e.InfantFare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Infant_fare");

                entity.Property(e => e.PortalFare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Portal_Fare");

                entity.Property(e => e.RowId).HasColumnName("row_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Total_Fare");

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Track_ID");

                entity.Property(e => e.Via)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCoupon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Coupon");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Airline)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponOnPaxWise)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.Dest)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Ex1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EX1");

                entity.Property(e => e.Ex2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EX2");

                entity.Property(e => e.MarkupType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Org)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TravelType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCouponCrd>(entity =>
            {
                entity.ToTable("TBL_Coupon_Crd");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Airline)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CorporateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CorporateID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblCouponHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CouponHistory");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.AppliedAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CouponOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CouponOrderID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TripType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCredentialPnrcreation>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_CREDENTIAL_PNRCREATION");

                entity.Property(e => e.Apisource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("APISource");

                entity.Property(e => e.BkgServerUrlOrIp).HasColumnName("BkgServerUrlOrIP");

                entity.Property(e => e.CarrierAcc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorporateId)
                    .HasMaxLength(50)
                    .HasColumnName("CorporateID");

                entity.Property(e => e.CrdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InfBasic).HasColumnType("money");

                entity.Property(e => e.InfTax).HasColumnType("money");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .HasColumnName("LoginID");

                entity.Property(e => e.LoginPwd).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServerUrlOrIp).HasColumnName("ServerUrlOrIP");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VC");

                entity.Property(e => e.WebProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCredentialPnrcreationTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_CREDENTIAL_PNRCREATION_TEST");

                entity.Property(e => e.Apisource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("APISource");

                entity.Property(e => e.BkgServerUrlOrIp).HasColumnName("BkgServerUrlOrIP");

                entity.Property(e => e.CarrierAcc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorporateId)
                    .HasMaxLength(50)
                    .HasColumnName("CorporateID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CrdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InfBasic).HasColumnType("money");

                entity.Property(e => e.InfTax).HasColumnType("money");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .HasColumnName("LoginID");

                entity.Property(e => e.LoginPwd).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServerUrlOrIp).HasColumnName("ServerUrlOrIP");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VC");

                entity.Property(e => e.WebProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditDebitNode>(entity =>
            {
                entity.ToTable("TBL_CreditDebitNode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.DistributerId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pnr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PNR");

                entity.Property(e => e.ReferenceId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditcardPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_CREDITCARD_PAYMENT");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ApiStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankRefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber).HasMaxLength(50);

                entity.Property(e => e.CardType).HasMaxLength(50);

                entity.Property(e => e.ChargesType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditLimitUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.CreditUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountValue).HasColumnType("money");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IbtrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBTrackId");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssuingBank).HasMaxLength(50);

                entity.Property(e => e.MerAamount).HasColumnType("money");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAmount).HasColumnType("money");

                entity.Property(e => e.PaymentGateway)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PgAmount).HasColumnType("money");

                entity.Property(e => e.Pgmode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PGMode");

                entity.Property(e => e.ResponseCode).IsUnicode(false);

                entity.Property(e => e.ResponseMessage).IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TId");

                entity.Property(e => e.TotalCharges).HasColumnType("money");

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransCharges).HasColumnType("money");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.Trip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnmappedStatus).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCurrencyDetail>(entity =>
            {
                entity.ToTable("TBL_CurrencyDetails");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryCode).HasMaxLength(2);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrancyCode).HasMaxLength(3);

                entity.Property(e => e.CurrencyName).HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Symbol).HasMaxLength(50);

                entity.Property(e => e.Tccode)
                    .HasMaxLength(50)
                    .HasColumnName("TCCode");

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblDailyRailcanceldatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_dailyRailcanceldata");

                entity.Property(e => e.ActualRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTUAL_REFUND_DATE");

                entity.Property(e => e.CancellationId).HasColumnName("CANCELLATION_ID");

                entity.Property(e => e.Class)
                    .HasMaxLength(255)
                    .HasColumnName("CLASS");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Ledgerentry).HasColumnName("LEDGERENTRY");

                entity.Property(e => e.OperatorId).HasColumnName("OPERATOR_ID");

                entity.Property(e => e.PgName)
                    .HasMaxLength(255)
                    .HasColumnName("PG NAME");

                entity.Property(e => e.PnrNo).HasColumnName("PNR_NO");

                entity.Property(e => e.PrincipalUserId)
                    .HasMaxLength(255)
                    .HasColumnName("PRINCIPAL_USER_ID");

                entity.Property(e => e.RefundAmount).HasColumnName("REFUND_AMOUNT");

                entity.Property(e => e.TdrCan)
                    .HasMaxLength(255)
                    .HasColumnName("TDR_CAN");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSACTION_DATE");

                entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.WaitingAutoCancelled)
                    .HasMaxLength(255)
                    .HasColumnName("WAITING_AUTO_CANCELLED");
            });

            modelBuilder.Entity<TblDailySalesRpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DailySalesRpt");

                entity.Property(e => e.AgenctName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Agenct_Name");

                entity.Property(e => e.AgencyCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agency_City");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.CtcPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ctc_Person");

                entity.Property(e => e.CtcPersonNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ctc_PersonNo");

                entity.Property(e => e.Inputdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");
            });

            modelBuilder.Entity<TblDeleteCacheSector>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DeleteCacheSector");

                entity.Property(e => e.Airline)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.JourneyDate).HasColumnType("datetime");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sector");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<TblDepositeoffice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_DEPOSITEOFFICE");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Cretaeddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CRETAEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.Office)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("OFFICE");
            });

            modelBuilder.Entity<TblDistrcashback>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_DISTRCASHBACK");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Aircb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AIRCB");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.Railcb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RAILCB");
            });

            modelBuilder.Entity<TblDistrcashbackDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_DISTRCASHBACK_DETAILS");

                entity.Property(e => e.Aircb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AIRCB");

                entity.Property(e => e.Aircbdistr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AIRCBDISTR");

                entity.Property(e => e.Airsale)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AIRSALE");

                entity.Property(e => e.Airticket)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("AIRTICKET");

                entity.Property(e => e.Cbdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CBDATE");

                entity.Property(e => e.Cborderno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBORDERNO");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.Railcb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RAILCB");

                entity.Property(e => e.Railcbdistr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RAILCBDISTR");

                entity.Property(e => e.Railsale)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RAILSALE");

                entity.Property(e => e.Railticket)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RAILTICKET");
            });

            modelBuilder.Entity<TblExportPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ExportPermission");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PageId).HasColumnName("pageID");

                entity.Property(e => e.PageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFareRule>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Tbl_FareRule");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FareRule).IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");
            });

            modelBuilder.Entity<TblFltAbacusTransaction>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_FLT_AbacusTransaction");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.AirTicketCommision).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CompanyType).HasMaxLength(50);

                entity.Property(e => e.ConversationId).HasMaxLength(50);

                entity.Property(e => e.Cpaid)
                    .HasMaxLength(10)
                    .HasColumnName("CPAID")
                    .IsFixedLength();

                entity.Property(e => e.LineAddressHardCopy).HasMaxLength(50);

                entity.Property(e => e.LineAddressPrinters).HasMaxLength(50);

                entity.Property(e => e.MaxResponses).HasMaxLength(20);

                entity.Property(e => e.MdrsubsetCode)
                    .HasMaxLength(20)
                    .HasColumnName("MDRSubsetCode");

                entity.Property(e => e.MessageHeaderId)
                    .HasMaxLength(50)
                    .HasColumnName("MessageHeaderID");

                entity.Property(e => e.PartyIdFromValue).HasMaxLength(50);

                entity.Property(e => e.PartyIdToValue).HasMaxLength(50);

                entity.Property(e => e.PartyIdType).HasMaxLength(50);

                entity.Property(e => e.PseudoCityCode).HasMaxLength(50);

                entity.Property(e => e.QueueNumber).HasMaxLength(20);

                entity.Property(e => e.RequestedId)
                    .HasMaxLength(50)
                    .HasColumnName("RequestedID");

                entity.Property(e => e.RequestedType).HasMaxLength(50);

                entity.Property(e => e.ServiceType).HasMaxLength(50);

                entity.Property(e => e.ServiceValue).HasMaxLength(50);

                entity.Property(e => e.ShortText).HasMaxLength(20);

                entity.Property(e => e.TicketTimeLimit).HasMaxLength(50);

                entity.Property(e => e.TicketType).HasMaxLength(20);

                entity.Property(e => e.TicketingPseudoCode).HasMaxLength(50);

                entity.Property(e => e.TransactionName).HasMaxLength(50);

                entity.Property(e => e.Version).HasMaxLength(100);
            });

            modelBuilder.Entity<TblFopPnrcreation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_FOP_PNRCREATION");

                entity.Property(e => e.AddressName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyBillingIdentifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyBillingPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Airline)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BankCountryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardExpDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cvv).HasColumnName("CVV");

                entity.Property(e => e.Fop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FOP");

                entity.Property(e => e.Pcc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PCC");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Vendor)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFqc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_FQCS");

                entity.Property(e => e.Airline)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rbd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RBD");
            });

            modelBuilder.Entity<TblGdsCancelLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_GDS_CancelLogs");

                entity.Property(e => e.CancelDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.EndTransactionReq34).HasColumnName("EndTransactionReq3_4");

                entity.Property(e => e.EndTransactionReq56).HasColumnName("EndTransactionReq5_6");

                entity.Property(e => e.EndTransactionResp34).HasColumnName("EndTransactionResp3_4");

                entity.Property(e => e.EndTransactionResp56).HasColumnName("EndTransactionResp5_6");

                entity.Property(e => e.NewPnr)
                    .HasMaxLength(20)
                    .HasColumnName("NewPNR");

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.Pnr)
                    .HasMaxLength(20)
                    .HasColumnName("PNR");

                entity.Property(e => e.TicketNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblGstDiffLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_GstDiffLog");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.GstUpdateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gstdiff)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GSTDIFF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalGstdiff)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOTAL_GSTDIFF")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblHotelNotification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Hotel_Notification");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.NotiActiveStatus)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.NotiUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SNo");
            });

            modelBuilder.Entity<TblInsertCrossfarexml>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_insertCrossfarexml");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.Url).HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblItemPageLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_ItemPageLine");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PageUrl)
                    .IsUnicode(false)
                    .HasColumnName("PageURL");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblItzTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_ITZ_TRANSACTIONS");

                entity.Property(e => e.AccTypeNameItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACC_TYPE_NAME_ITZ");

                entity.Property(e => e.AmtToCre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMT_TO_CRE");

                entity.Property(e => e.AmtToDed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMT_TO_DED");

                entity.Property(e => e.AvailableBalItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_BAL_ITZ");

                entity.Property(e => e.B2cMblNoItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B2C_MBL_NO_ITZ");

                entity.Property(e => e.CommissionItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMMISSION_ITZ");

                entity.Property(e => e.ConveniencefeeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONVENIENCEFEE_ITZ");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DecodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DECODE_ITZ");

                entity.Property(e => e.EasyOrderidItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EASY_ORDERID_ITZ");

                entity.Property(e => e.EasyTranCodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EASY_TRAN_CODE_ITZ");

                entity.Property(e => e.ErrorCodeItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_CODE_ITZ");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MerchantKeyItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MERCHANT_KEY_ITZ");

                entity.Property(e => e.MessageItz)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE_ITZ");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.RateGroupItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RATE_GROUP_ITZ");

                entity.Property(e => e.RefundTypeItz)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REFUND_TYPE_ITZ")
                    .IsFixedLength();

                entity.Property(e => e.SerialNoFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NO_FROM");

                entity.Property(e => e.SerialNoTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NO_TO");

                entity.Property(e => e.ServiceTaxItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_TAX_ITZ");

                entity.Property(e => e.TdsItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS_ITZ");

                entity.Property(e => e.TotalAmtDedItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOTAL_AMT_DED_ITZ");

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_TYPE");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DATE");

                entity.Property(e => e.UserNameItz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME_ITZ");
            });

            modelBuilder.Entity<TblLccLccCredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_LCC_LccCredentials");

                entity.Property(e => e.Airlinecode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINECODE");

                entity.Property(e => e.Bookenable)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BOOKENABLE");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Promotionalcreditpassword)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PROMOTIONALCREDITPASSWORD");

                entity.Property(e => e.Promotionalpassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROMOTIONALPASSWORD");

                entity.Property(e => e.Promotionaluserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROMOTIONALUSERID");

                entity.Property(e => e.Searchenable)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SEARCHENABLE");

                entity.Property(e => e.Searchviewstate)
                    .IsUnicode(false)
                    .HasColumnName("SEARCHVIEWSTATE");

                entity.Property(e => e.Starcreditpassword)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STARCREDITPASSWORD");

                entity.Property(e => e.Starpassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STARPASSWORD");

                entity.Property(e => e.Staruserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STARUSERID");
            });

            modelBuilder.Entity<TblLcccouponbookinglog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_LCCCOUPONBOOKINGLOG");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKING_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BookingRequest)
                    .IsUnicode(false)
                    .HasColumnName("BOOKING_REQUEST");

                entity.Property(e => e.BookingResponse)
                    .IsUnicode(false)
                    .HasColumnName("BOOKING_RESPONSE");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Trackid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRACKID");
            });

            modelBuilder.Entity<TblLccresult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_LCCRESULT");

                entity.Property(e => e.Adultfare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADULTFARE");

                entity.Property(e => e.Arrivaltime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARRIVALTIME");

                entity.Property(e => e.Childfare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHILDFARE");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Departuretime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTURETIME");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESTINATION");

                entity.Property(e => e.Flight)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FLIGHT");

                entity.Property(e => e.Flightcount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FLIGHTCOUNT");

                entity.Property(e => e.Hiddenvalue)
                    .IsUnicode(false)
                    .HasColumnName("HIDDENVALUE");

                entity.Property(e => e.Infantfare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INFANTFARE");

                entity.Property(e => e.Radioselector)
                    .IsUnicode(false)
                    .HasColumnName("RADIOSELECTOR");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Totalpackagecost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOTALPACKAGECOST");
            });

            modelBuilder.Entity<TblLogAirlineStatus>(entity =>
            {
                entity.ToTable("Tbl_LogAirlineStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Airline)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<TblLogChangeType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_LogChangeType");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Newagenttype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NEWAGENTTYPE");

                entity.Property(e => e.Oldagnettype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OLDAGNETTYPE");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<TblLogImportPnr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_logImportPnr");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.Request).IsUnicode(false);

                entity.Property(e => e.Response).IsUnicode(false);
            });

            modelBuilder.Entity<TblMailContainer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_MAIL_CONTAINER");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileType).HasMaxLength(20);

                entity.Property(e => e.MailBcc)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_BCC");

                entity.Property(e => e.MailCc)
                    .IsUnicode(false)
                    .HasColumnName("MAIL_CC");

                entity.Property(e => e.MailContent).HasColumnName("MAIL_CONTENT");

                entity.Property(e => e.MailCredencialId)
                    .HasMaxLength(50)
                    .HasColumnName("mail_Credencial_id");

                entity.Property(e => e.MailCredencialPwd)
                    .HasMaxLength(50)
                    .HasColumnName("mail_Credencial_Pwd");

                entity.Property(e => e.MailFrom)
                    .HasMaxLength(50)
                    .HasColumnName("Mail_From");

                entity.Property(e => e.MailHostPwd)
                    .HasMaxLength(50)
                    .HasColumnName("Mail_HostPwd");

                entity.Property(e => e.MailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MAIL_ID");

                entity.Property(e => e.MailModule)
                    .HasMaxLength(20)
                    .HasColumnName("MAIL_Module");

                entity.Property(e => e.MailSubject)
                    .HasMaxLength(500)
                    .HasColumnName("mail_Subject");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DATE");
            });

            modelBuilder.Entity<TblMailingCredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_MAILING_CREDENTIAL");

                entity.Property(e => e.Bcc)
                    .HasMaxLength(100)
                    .HasColumnName("BCC");

                entity.Property(e => e.Cc)
                    .HasMaxLength(100)
                    .HasColumnName("CC");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID");

                entity.Property(e => e.Mailfrom)
                    .HasMaxLength(100)
                    .HasColumnName("MAILFROM");

                entity.Property(e => e.Mailingdepartment)
                    .HasMaxLength(150)
                    .HasColumnName("MAILINGDEPARTMENT");

                entity.Property(e => e.Mailtext)
                    .HasMaxLength(1000)
                    .HasColumnName("MAILTEXT");

                entity.Property(e => e.Mailto)
                    .HasMaxLength(100)
                    .HasColumnName("MAILTO");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Regards)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Smtpclient)
                    .HasMaxLength(150)
                    .HasColumnName("SMTPCLIENT");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblMailingCredentialItz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_MAILING_CREDENTIAL_ITZ");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Bcc)
                    .HasMaxLength(1000)
                    .HasColumnName("BCC");

                entity.Property(e => e.Cc)
                    .HasMaxLength(1000)
                    .HasColumnName("CC");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mailfrom)
                    .HasMaxLength(100)
                    .HasColumnName("MAILFROM");

                entity.Property(e => e.Mailingdepartment)
                    .HasMaxLength(150)
                    .HasColumnName("MAILINGDEPARTMENT");

                entity.Property(e => e.Mailto)
                    .HasMaxLength(100)
                    .HasColumnName("MAILTO");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Regards)
                    .HasMaxLength(150)
                    .HasColumnName("REGARDS");

                entity.Property(e => e.Smtpclient)
                    .HasMaxLength(150)
                    .HasColumnName("SMTPCLIENT");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1000)
                    .HasColumnName("SUBJECT");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblMailingCredentialItzB2c>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_MAILING_CREDENTIAL_ITZ_B2C");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Bcc)
                    .HasMaxLength(1000)
                    .HasColumnName("BCC");

                entity.Property(e => e.Cc)
                    .HasMaxLength(1000)
                    .HasColumnName("CC");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Mailfrom)
                    .HasMaxLength(100)
                    .HasColumnName("MAILFROM");

                entity.Property(e => e.Mailingdepartment)
                    .HasMaxLength(150)
                    .HasColumnName("MAILINGDEPARTMENT");

                entity.Property(e => e.Mailto)
                    .HasMaxLength(100)
                    .HasColumnName("MAILTO");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Regards)
                    .HasMaxLength(150)
                    .HasColumnName("REGARDS");

                entity.Property(e => e.Smtpclient)
                    .HasMaxLength(150)
                    .HasColumnName("SMTPCLIENT");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1000)
                    .HasColumnName("SUBJECT");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblMailingCredentialItzBookmyfly>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_MAILING_CREDENTIAL_ITZ_BOOKMYFLYS");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Bcc)
                    .HasMaxLength(1000)
                    .HasColumnName("BCC");

                entity.Property(e => e.Cc)
                    .HasMaxLength(1000)
                    .HasColumnName("CC");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Mailfrom)
                    .HasMaxLength(100)
                    .HasColumnName("MAILFROM");

                entity.Property(e => e.Mailingdepartment)
                    .HasMaxLength(150)
                    .HasColumnName("MAILINGDEPARTMENT");

                entity.Property(e => e.Mailto)
                    .HasMaxLength(100)
                    .HasColumnName("MAILTO");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Regards)
                    .HasMaxLength(150)
                    .HasColumnName("REGARDS");

                entity.Property(e => e.Smtpclient)
                    .HasMaxLength(150)
                    .HasColumnName("SMTPCLIENT");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1000)
                    .HasColumnName("SUBJECT");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblMidServiceCall>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_MidServiceCall");

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Child).HasColumnName("child");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.From)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.To)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblModuleAccess>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_MODULE_ACCESS");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Module)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MODULE");

                entity.Property(e => e.Moduletype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULETYPE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<TblNavCredential>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_NAV_CREDENTIAL");

                entity.Property(e => e.CeartedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DomainName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.ServiceUrl).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNavFailtransaction>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_NAV_FAILTRANSACTION");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Failcounter).HasColumnName("FAILCOUNTER");

                entity.Property(e => e.Operation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Other).HasColumnName("OTHER");

                entity.Property(e => e.Xmldocument).HasColumnName("XMLDOCUMENT");
            });

            modelBuilder.Entity<TblNavOrderrecord>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_NAV_ORDERRECORD");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag)
                    .HasColumnName("FLAG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oldorderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OLDORDERID");

                entity.Property(e => e.Oldticketno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OLDTICKETNO");

                entity.Property(e => e.Operation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Ticketno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TICKETNO");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDDATE");

                entity.Property(e => e.Xmldocument)
                    .IsUnicode(false)
                    .HasColumnName("XMLDOCUMENT");
            });

            modelBuilder.Entity<TblPackage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Package");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PackageTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PackageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PkgId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PkgID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblPackageSlider>(entity =>
            {
                entity.HasKey(e => e.PackageId);

                entity.ToTable("Tbl_Package_Slider");

                entity.Property(e => e.Destination)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MinCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PackageTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPassportValidateCriterion>(entity =>
            {
                entity.ToTable("Tbl_Passport_Validate_Criteria");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Country)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPasswordUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PasswordUpdate");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Newpwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEWPWD");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblPaynimoReq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PaynimoReq");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsIv)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsKey)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Itc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ITC");

                entity.Property(e => e.MerchantCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantTxnRefNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnUrl)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("ReturnURL");

                entity.Property(e => e.S2sreturnUrl)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("S2SReturnURL");

                entity.Property(e => e.ShoppingCartDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TpsltxnId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TPSLTxnID");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueCustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPgCredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_PG_CREDENTIALS");

                entity.Property(e => e.AesreqKey)
                    .HasMaxLength(100)
                    .HasColumnName("AESReqKey");

                entity.Property(e => e.AesreqSaltIvkey)
                    .HasMaxLength(100)
                    .HasColumnName("AESReqSaltIVKey");

                entity.Property(e => e.AesresKey)
                    .HasMaxLength(100)
                    .HasColumnName("AESResKey");

                entity.Property(e => e.AesresSaltIvkey)
                    .HasMaxLength(100)
                    .HasColumnName("AESResSaltIVKey");

                entity.Property(e => e.CancelUrl).HasMaxLength(200);

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CHANNEL_ID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.FailureUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HashReqKey).HasMaxLength(100);

                entity.Property(e => e.HashResKey).HasMaxLength(100);

                entity.Property(e => e.IndustryTypeId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INDUSTRY_TYPE_ID");

                entity.Property(e => e.MercUnqRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MERC_UNQ_REF");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantKey)
                    .HasMaxLength(100)
                    .HasColumnName("MERCHANT_KEY");

                entity.Property(e => e.MerchantPswd)
                    .HasMaxLength(100)
                    .HasColumnName("MERCHANT_PSWD");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(100)
                    .HasColumnName("ProductID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuccessUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Txntype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebServiceUrl).HasMaxLength(200);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WEBSITE");

                entity.Property(e => e.Zppayoption)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPgPaymentDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_PG_PAYMENT_DETAILS");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ApiStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankRefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber).HasMaxLength(50);

                entity.Property(e => e.CardType).HasMaxLength(50);

                entity.Property(e => e.ChargesType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditLimitUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.CreditUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountValue).HasColumnType("money");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IbtrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBTrackId");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssuingBank).HasMaxLength(50);

                entity.Property(e => e.MerAamount).HasColumnType("money");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAmount).HasColumnType("money");

                entity.Property(e => e.PaymentGateway)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PgAmount).HasColumnType("money");

                entity.Property(e => e.Pgmode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PGMode");

                entity.Property(e => e.ResponseCode).IsUnicode(false);

                entity.Property(e => e.ResponseMessage).IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TId");

                entity.Property(e => e.TotalCharges).HasColumnType("money");

                entity.Property(e => e.TrackId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransCharges).HasColumnType("money");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.Trip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnmappedStatus).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPgRadiolist>(entity =>
            {
                entity.ToTable("TBL_PG_RADIOLIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bus).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Flight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hotel).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Provider).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Text)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPgrefund>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_PGRefund");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InitiatedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.RefundAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RefundDate).HasColumnType("datetime");

                entity.Property(e => e.RefundFor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPlbRef>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_PLB_REF");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Airportcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AIRPORTCODE");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRIP")
                    .IsFixedLength();

                entity.Property(e => e.Triptype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRIPTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Vc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VC")
                    .IsFixedLength();

                entity.Property(e => e.Yq)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("YQ");

                entity.Property(e => e.Yr)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("YR");
            });

            modelBuilder.Entity<TblPnrMessage>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_PNR_Message");

                entity.Property(e => e.AgentMsg).IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OtherMsg).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProfitComm>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_PROFIT_COMM");

                entity.Property(e => e.Basic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BasicYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VC");
            });

            modelBuilder.Entity<TblQcchecklist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Qcchecklist");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExecutiveId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblQuery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Query");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TblReferenceNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ReferenceNo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRegisteragentsIp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_REGISTERAGENTS_IP");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.StrText).HasColumnName("strText");
            });

            modelBuilder.Entity<TblReportissue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_Reportissues");

                entity.Property(e => e.AgencyName).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(200);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department).HasMaxLength(200);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(200)
                    .HasColumnName("EmailID");

                entity.Property(e => e.Issues)
                    .HasMaxLength(500)
                    .HasColumnName("ISSUES");

                entity.Property(e => e.Mtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MType");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Trip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblRoutelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_ROUTELIST");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dest)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEST")
                    .IsFixedLength();

                entity.Property(e => e.Destname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESTNAME");

                entity.Property(e => e.Origin)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ORIGIN")
                    .IsFixedLength();

                entity.Property(e => e.Originname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINNAME");

                entity.Property(e => e.Provider)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PROVIDER")
                    .IsFixedLength();

                entity.Property(e => e.Trip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRIP");
            });

            modelBuilder.Entity<TblRoutelistAv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_ROUTELIST_AV");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dest)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEST")
                    .IsFixedLength();

                entity.Property(e => e.Destname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESTNAME");

                entity.Property(e => e.Origin)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ORIGIN")
                    .IsFixedLength();

                entity.Property(e => e.Originname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINNAME");

                entity.Property(e => e.Provider)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PROVIDER")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblScrapBookingLog>(entity =>
            {
                entity.ToTable("Tbl_Scrap_Booking_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.Pnr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PNR");

                entity.Property(e => e.Vc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VC");
            });

            modelBuilder.Entity<TblSearchResultBlock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_SearchResultBlock");

                entity.Property(e => e.AgentId).HasMaxLength(50);

                entity.Property(e => e.AgentIdExclude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Airline)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FareType).HasMaxLength(50);

                entity.Property(e => e.FareTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rtf)
                    .HasColumnName("RTF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblServiceSwitch>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_ServiceSwitch");

                entity.Property(e => e.Airline)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Provider)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rtf).HasColumnName("RTF");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblServiceproviderEnable>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_SERVICEPROVIDER_ENABLE");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VC");
            });

            modelBuilder.Entity<TblSoapaction>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_SOAPACTION");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Provider)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PROVIDER");

                entity.Property(e => e.Soapactionmethod)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SOAPACTIONMETHOD");

                entity.Property(e => e.Soapactionurl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SOAPACTIONURL");
            });

            modelBuilder.Entity<TblSplfareLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_SPLFARE_LOG");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Airline)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogData).HasColumnName("logData");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sts)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblState>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_STATE");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.Stateid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATEID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTaxiBookingMarkupDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_TAXI_BOOKING_MARKUP_DETAILS");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicableOn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.DiscountMarkupType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarkingAmountOnId)
                    .HasColumnType("money")
                    .HasColumnName("MarkingAmountOnID");

                entity.Property(e => e.MarkingAmountOnType).HasColumnType("money");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTaxiForSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_TAXI_FOR_SURE");

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoactionName).IsUnicode(false);

                entity.Property(e => e.LocLattitude)
                    .IsUnicode(false)
                    .HasColumnName("Loc_Lattitude");

                entity.Property(e => e.LocLongitude)
                    .IsUnicode(false)
                    .HasColumnName("Loc_Longitude");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SNo");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTbobookingLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_TBOBookingLogs");

                entity.Property(e => e.Airline)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Others).HasColumnName("OTHERS");

                entity.Property(e => e.PnrNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTbocancelLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_TBOCancelLogs");

                entity.Property(e => e.CancelDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.TicketNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTboticketLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_TBOTicketLogs");

                entity.Property(e => e.Airline)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Others).HasColumnName("OTHERS");

                entity.Property(e => e.PnrNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TicketDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblTransactionOtp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_transactionOTP");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updateddate).HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUploaderrorLog>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("TBL_UPLOADERROR_LOG");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Agencyname)
                    .HasMaxLength(150)
                    .HasColumnName("AGENCYNAME");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.AvlBalance).HasColumnName("AVL_BALANCE");

                entity.Property(e => e.Bookingtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOOKINGTYPE");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Debit).HasColumnName("DEBIT");

                entity.Property(e => e.Error)
                    .IsUnicode(false)
                    .HasColumnName("ERROR");

                entity.Property(e => e.Invoiceno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INVOICENO");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Remark)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Uploadtype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UPLOADTYPE");
            });

            modelBuilder.Entity<TblUrlsToMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Urls_To_Map");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MapUrl).IsUnicode(false);

                entity.Property(e => e.PageName).IsUnicode(false);

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUserLoginTime>(entity =>
            {
                entity.ToTable("Tbl_UserLoginTime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ipadress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAdress");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblViewedHotel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Viewed_Hotels");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SNo");

                entity.Property(e => e.ViewDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblVisitorInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_VisitorInfo");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsgalileoCustomer).HasColumnName("ISGalileoCustomer");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Organisation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OtherProduct)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<TblWait>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Wait");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Airline)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SearchDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SearchId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SearchID");

                entity.Property(e => e.Sector)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WaitInSec)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("waitInSec");
            });

            modelBuilder.Entity<TblYaPricingLog>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Tbl_YA_Pricing_Log");

                entity.Property(e => e.CreatedDare)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.PriceReq).HasColumnName("Price_Req");

                entity.Property(e => e.PriceRes).HasColumnName("Price_Res");
            });

            modelBuilder.Entity<TblYabookingLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_YABookingLogs");

                entity.Property(e => e.Airline)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Others).HasColumnName("OTHERS");

                entity.Property(e => e.PnrNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempCreditAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_credit_agent");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("agentid");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Testcomm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testcomm");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommisionOnBasic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommisionOnBasicYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommissionOnYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.GroupType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Testplb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testplb");

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.EndDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlbOnBasic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PlbOnBasicYq).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rbd)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RBD");

                entity.Property(e => e.Sector)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TextPaxYt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TextPaxYT");

                entity.Property(e => e.Pnrno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tkt)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketingLogGal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TicketingLog_GAL");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Docprdreq).HasColumnName("DOCPRDReq");

                entity.Property(e => e.Docprdres).HasColumnName("DOCPRDRes");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pnrbf1req).HasColumnName("PNRBF1Req");

                entity.Property(e => e.Pnrbf1res).HasColumnName("PNRBF1Res");

                entity.Property(e => e.Pnrbf2req).HasColumnName("PNRBF2Req");

                entity.Property(e => e.Pnrbf2res).HasColumnName("PNRBF2Res");

                entity.Property(e => e.Pnrbf3req).HasColumnName("PNRBF3Req");

                entity.Property(e => e.Pnrbf3res).HasColumnName("PNRBF3Res");

                entity.Property(e => e.Pnrbf4req).HasColumnName("PNRBF4Req");

                entity.Property(e => e.Pnrbf4res).HasColumnName("PNRBF4Res");

                entity.Property(e => e.Pnrrt2req).HasColumnName("PNRRT2Req");

                entity.Property(e => e.Pnrrt2res).HasColumnName("PNRRT2Res");

                entity.Property(e => e.Pnrrtreq).HasColumnName("PNRRTReq");

                entity.Property(e => e.Pnrrtres).HasColumnName("PNRRTRes");

                entity.Property(e => e.Sereq).HasColumnName("SEReq");

                entity.Property(e => e.Seres).HasColumnName("SERes");

                entity.Property(e => e.Ssreq).HasColumnName("SSReq");

                entity.Property(e => e.Ssres).HasColumnName("SSRes");
            });

            modelBuilder.Entity<TktByAgency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tkt_by_Agency");

                entity.Property(e => e.AgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.CorporateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Corporate_ID");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.OfficeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Office_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SigninXml).HasColumnName("SigninXML");

                entity.Property(e => e.ValCar)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Val_Car")
                    .IsFixedLength();

                entity.Property(e => e.WebProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TktByAgencyGal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tkt_by_Agency_GAL");

                entity.Property(e => e.AgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.Airline)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINE")
                    .IsFixedLength();

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CrdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Hap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HAP");

                entity.Property(e => e.Pcc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PCC");

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.Qno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QNO");

                entity.Property(e => e.QnoforApi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QNOForAPI");

                entity.Property(e => e.QueuePcc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QueuePCC");

                entity.Property(e => e.StrCode).HasColumnName("strCode");

                entity.Property(e => e.TicketThrough)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.WebProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TktByAgencyGalTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tkt_by_Agency_GAL_TEST");

                entity.Property(e => e.AgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.Airline)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AIRLINE")
                    .IsFixedLength();

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CrdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Hap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HAP");

                entity.Property(e => e.Pcc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PCC");

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.Qno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QNO");

                entity.Property(e => e.QnoforApi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QNOForAPI");

                entity.Property(e => e.QueuePcc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QueuePCC");

                entity.Property(e => e.StrCode).HasColumnName("strCode");

                entity.Property(e => e.TicketThrough)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.WebProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TotalSearchHit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Airline)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Daylimit).HasColumnName("daylimit");

                entity.Property(e => e.Expiretime).HasColumnName("expiretime");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.JourneyDate).HasColumnType("datetime");

                entity.Property(e => e.Response)
                    .IsUnicode(false)
                    .HasColumnName("response");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sector");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<TransReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Trans_Report");

                entity.Property(e => e.AgName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Ag_Name");

                entity.Property(e => e.AgentMrk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Agent_MRK");

                entity.Property(e => e.AvalBal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Aval_Bal");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("booking_date");

                entity.Property(e => e.BookingType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Booking_Type");

                entity.Property(e => e.CashBack)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cash_Back");

                entity.Property(e => e.Counter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counter");

                entity.Property(e => e.Credit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Debit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Distr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FareAftdis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fare_AFTDIS");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flight_no");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaxEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_email");

                entity.Property(e => e.PaxFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pax_fname");

                entity.Property(e => e.PaxMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pax_Mobile");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Type");

                entity.Property(e => e.PnrLocator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pnr_locator");

                entity.Property(e => e.PnrStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pnr_status");

                entity.Property(e => e.Rm).IsUnicode(false);

                entity.Property(e => e.STax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_Tax");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sfdis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFDis");

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDS");

                entity.Property(e => e.Tf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TF");

                entity.Property(e => e.TotBf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tot_BF");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");

                entity.Property(e => e.Yq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YQ");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transaction");

                entity.Property(e => e.InsertedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentTransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ParentTransactionID");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.TransactionIndex).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransactionSequence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransactionSequence");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Index).ValueGeneratedOnAdd();

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ttt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ttt");

                entity.Property(e => e.AmcChargeIncludingGst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMC_Charge(Including GST)");

                entity.Property(e => e.BookingAmount)
                    .HasColumnType("money")
                    .HasColumnName("BOOKING_AMOUNT");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASS");

                entity.Property(e => e.ClientTransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT TRANSACTION ID");

                entity.Property(e => e.PgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PG NAME");

                entity.Property(e => e.PnrNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNR_NO");

                entity.Property(e => e.PrincipalUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINCIPAL_USER_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSACTION_DATE");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTION_ID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Unregagent>(entity =>
            {
                entity.ToTable("UNREGAGENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOBILENO");

                entity.Property(e => e.Regesterd).HasColumnName("regesterd");
            });

            modelBuilder.Entity<UploadAgentType>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("UploadAgentType");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Distr).HasMaxLength(50);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UploadCategory)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UploadCategoryText)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UploadAgentTypeBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UploadAgentType_BAK");

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Distr).HasMaxLength(50);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UploadCategory)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UploadCategoryText)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UploadDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccId)
                    .HasMaxLength(50)
                    .HasColumnName("AccID");

                entity.Property(e => e.AgencyName).HasMaxLength(100);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasColumnName("AgentID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditLimit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrAvlBal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Curr_Avl_Bal");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepositeBankName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Distrid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRID")
                    .HasDefaultValueSql("('FWU')");

                entity.Property(e => e.DueAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LastAvlBal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleType)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkSales).IsUnicode(false);

                entity.Property(e => e.TransactionIdorChequeNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TransactionIDOrChequeNo");

                entity.Property(e => e.UpdatedAccId)
                    .HasMaxLength(50)
                    .HasColumnName("UpdatedAccID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateSales).HasColumnType("datetime");

                entity.Property(e => e.UploadType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.YtrRcptNo).HasMaxLength(50);
            });

            modelBuilder.Entity<UserIdmapping>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("UserIDMapping");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Distr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Table_Ref");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_ID");
            });

            modelBuilder.Entity<UserTab>(entity =>
            {
                entity.HasKey(e => e.UserType);

                entity.ToTable("User_tab");

                entity.HasIndex(e => e.UserName, "IX_User_tab")
                    .IsUnique();

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .HasColumnName("User_Type");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("User_id");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("User_name");
            });

            modelBuilder.Entity<VisaDetail>(entity =>
            {
                entity.HasKey(e => e.Counter);

                entity.ToTable("Visa_Details");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WorldAirportInfo>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WorldAirportInfo_old");

                entity.ToTable("WorldAirportInfo");

                entity.Property(e => e.AirportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirportName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isorder).HasColumnName("isorder");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorldAreaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorldAirportInfoOld1>(entity =>
            {
                entity.HasKey(e => e.Counter)
                    .HasName("PK_WorldAirportInfo");

                entity.ToTable("WorldAirportInfo_old1");

                entity.Property(e => e.AirportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirportName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderseq).HasColumnName("orderseq");

                entity.Property(e => e.WorldAreaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YatraBillingLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YatraBillingLog");

                entity.Property(e => e.BillNo).IsUnicode(false);

                entity.Property(e => e.BillType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Counter).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RetVal).HasComment("0-success,3-failure");
            });

            modelBuilder.Entity<YatraVendor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Yatra_Vendors");

                entity.Property(e => e.Counter)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PortalVc)
                    .HasMaxLength(10)
                    .HasColumnName("Portal_VC");

                entity.Property(e => e.PortalVendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Portal_Vendor Name");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Trip).HasMaxLength(10);

                entity.Property(e => e.YatraVc)
                    .HasMaxLength(10)
                    .HasColumnName("Yatra_VC");

                entity.Property(e => e.YatraVendorName)
                    .HasMaxLength(50)
                    .HasColumnName("Yatra_Vendor Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
