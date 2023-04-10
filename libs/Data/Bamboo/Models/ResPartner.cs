using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResPartner
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public DateTime? CreationTime { get; set; }

    public string? Name { get; set; }

    public long? Title { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? UserId { get; set; }

    public long? StateId { get; set; }

    public long? CountryId { get; set; }

    public long? IndustryId { get; set; }

    public long? Color { get; set; }

    public Guid? CommercialPartnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? DisplayName { get; set; }

    public string? Ref { get; set; }

    public string? Lang { get; set; }

    public string? Tz { get; set; }

    public string? Vat { get; set; }

    public string? CompanyRegistry { get; set; }

    public string? Website { get; set; }

    public string? Function { get; set; }

    public string? Type { get; set; }

    public string? Street { get; set; }

    public string? Street2 { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? CommercialCompanyName { get; set; }

    public string? CompanyName { get; set; }

    public DateOnly? Date { get; set; }

    public string? Comment { get; set; }

    public decimal? PartnerLatitude { get; set; }

    public decimal? PartnerLongitude { get; set; }

    public bool? Active { get; set; }

    public bool? Employee { get; set; }

    public bool? IsCompany { get; set; }

    public bool? PartnerShare { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? MessageBounce { get; set; }

    public string? EmailNormalized { get; set; }

    public string? SignupToken { get; set; }

    public string? SignupType { get; set; }

    public DateTime? SignupExpiration { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? PartnerGid { get; set; }

    public string? AdditionalInfo { get; set; }

    public string? PhoneSanitized { get; set; }

    public long? SupplierRank { get; set; }

    public long? CustomerRank { get; set; }

    public string? InvoiceWarn { get; set; }

    public string? InvoiceWarnMsg { get; set; }

    public decimal? DebitLimit { get; set; }

    public DateTime? LastTimeEntriesChecked { get; set; }

    public string? SaleWarn { get; set; }

    public string? SaleWarnMsg { get; set; }

    public string? PickingWarn { get; set; }

    public string? PickingWarnMsg { get; set; }

    public string? PurchaseWarn { get; set; }

    public string? PurchaseWarnMsg { get; set; }

    public Guid? PaymentResponsibleId { get; set; }

    public long? LatestFollowupSequence { get; set; }

    public Guid? LatestFollowupLevelIdWithoutLit { get; set; }

    public DateOnly? PaymentNextActionDate { get; set; }

    public string? PaymentNote { get; set; }

    public string? PaymentNextAction { get; set; }

    public DateTime? CalendarLastNotifAck { get; set; }

    public Guid? WebsiteId { get; set; }

    public bool? IsPublished { get; set; }

    public bool? PlanToChangeCar { get; set; }

    public bool? PlanToChangeBike { get; set; }

    //public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; } = new List<AccountAnalyticAccount>();

    //public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    //public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; } = new List<AccountBankStatementLine>();

    //public virtual ICollection<AccountMove> AccountMoveCommercialPartners { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMove> AccountMovePartnerShippings { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountMove> AccountMovePartners { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    //public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappings { get; } = new List<AccountReconcileModelPartnerMapping>();

    //public virtual ICollection<ApplicantSendMail> ApplicantSendMails { get; } = new List<ApplicantSendMail>();

    //public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizards { get; } = new List<BasePartnerMergeAutomaticWizard>();

    //public virtual ICollection<CalendarAttendee> CalendarAttendees { get; } = new List<CalendarAttendee>();

    //public virtual ICollection<CalendarFilter> CalendarFilters { get; } = new List<CalendarFilter>();

    public virtual ResPartner? CommercialPartner { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; } = new List<CrmLead2opportunityPartnerMass>();

    //public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartners { get; } = new List<CrmLead2opportunityPartner>();

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    //public virtual ICollection<CrmQuotationPartner> CrmQuotationPartners { get; } = new List<CrmQuotationPartner>();

    //public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogs { get; } = new List<FleetVehicleAssignationLog>();

    //public virtual ICollection<FleetVehicle> FleetVehicleDrivers { get; } = new List<FleetVehicle>();

    //public virtual ICollection<FleetVehicle> FleetVehicleFutureDrivers { get; } = new List<FleetVehicle>();

    //public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; } = new List<FleetVehicleLogContract>();

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServicePurchasers { get; } = new List<FleetVehicleLogService>();

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceVendors { get; } = new List<FleetVehicleLogService>();

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrEmployee> HrEmployeeAddressHomes { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrEmployee> HrEmployeeAddresses { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrEmployee> HrEmployeeWorkContacts { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    //public virtual ICollection<HrWorkLocation> HrWorkLocations { get; } = new List<HrWorkLocation>();

    public virtual ResPartnerIndustry? Industry { get; set; }

    //public virtual ICollection<ResPartner> InverseCommercialPartner { get; } = new List<ResPartner>();

    //public virtual ICollection<ResPartner> InverseParent { get; } = new List<ResPartner>();

    public virtual FollowupLine? LatestFollowupLevelIdWithoutLitNavigation { get; set; }

    //public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();

    //public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    //public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    //public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    //public virtual ICollection<MailFollower> MailFollowers { get; } = new List<MailFollower>();

    //public virtual ICollection<MailMessageReaction> MailMessageReactions { get; } = new List<MailMessageReaction>();

    //public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    //public virtual ICollection<MailNotification> MailNotificationAuthors { get; } = new List<MailNotification>();

    //public virtual ICollection<MailNotification> MailNotificationResPartners { get; } = new List<MailNotification>();

    //public virtual ICollection<MailResendPartner> MailResendPartners { get; } = new List<MailResendPartner>();

    //public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Parent { get; set; }

    //public virtual ICollection<PaymentLinkWizard> PaymentLinkWizards { get; } = new List<PaymentLinkWizard>();

    public virtual ResUser? PaymentResponsible { get; set; }

    //public virtual ICollection<PaymentToken> PaymentTokens { get; } = new List<PaymentToken>();

    //public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    //public virtual ICollection<PortalWizardUser> PortalWizardUsers { get; } = new List<PortalWizardUser>();

    //public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    //public virtual ICollection<ProcurementGroup> ProcurementGroups { get; } = new List<ProcurementGroup>();

    //public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    //public virtual ICollection<ProjectCollaborator> ProjectCollaborators { get; } = new List<ProjectCollaborator>();

    //public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    //public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrderDestAddresses { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrderPartners { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<RatingRating> RatingRatingPartners { get; } = new List<RatingRating>();

    //public virtual ICollection<RatingRating> RatingRatingPublishers { get; } = new List<RatingRating>();

    //public virtual ICollection<RatingRating> RatingRatingRatedPartners { get; } = new List<RatingRating>();

    //public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    //public virtual ICollection<RecurringPayment> RecurringPayments { get; } = new List<RecurringPayment>();

    //public virtual ICollection<RepairOrder> RepairOrderAddresses { get; } = new List<RepairOrder>();

    //public virtual ICollection<RepairOrder> RepairOrderPartnerInvoices { get; } = new List<RepairOrder>();

    //public virtual ICollection<RepairOrder> RepairOrderPartners { get; } = new List<RepairOrder>();

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    //public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncs { get; } = new List<ResPartnerAutocompleteSync>();

    //public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    //public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    //public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeGuests { get; } = new List<ResUsersSettingsVolume>();

    //public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumePartners { get; } = new List<ResUsersSettingsVolume>();

    //public virtual ICollection<SaleOrderCancel> SaleOrderCancels { get; } = new List<SaleOrderCancel>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<SaleOrder> SaleOrderPartnerInvoices { get; } = new List<SaleOrder>();

    //public virtual ICollection<SaleOrder> SaleOrderPartnerShippings { get; } = new List<SaleOrder>();

    //public virtual ICollection<SaleOrder> SaleOrderPartners { get; } = new List<SaleOrder>();

    //public virtual ICollection<SmsSm> SmsSms { get; } = new List<SmsSm>();

    //public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; } = new List<SnailmailLetterMissingRequiredField>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    public virtual ResCountryState? State { get; set; }

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMove> StockMovePartners { get; } = new List<StockMove>();

    //public virtual ICollection<StockMove> StockMoveRestrictPartners { get; } = new List<StockMove>();

    //public virtual ICollection<StockPicking> StockPickingOwners { get; } = new List<StockPicking>();

    //public virtual ICollection<StockPicking> StockPickingPartners { get; } = new List<StockPicking>();

    //public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    //public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    //public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    //public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    //public virtual ICollection<StockWarehouse> StockWarehouses { get; } = new List<StockWarehouse>();

    public virtual CrmTeam? Team { get; set; }

    public virtual ResPartnerTitle? TitleNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual Website? WebsiteNavigation { get; set; }

    //public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; } = new List<WebsiteVisitor>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalances { get; } = new List<AccountAgedTrialBalance>();

    //public virtual ICollection<AccountBalanceReport> AccountBalanceReports { get; } = new List<AccountBalanceReport>();

    //public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    //public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReports { get; } = new List<AccountCommonPartnerReport>();

    //public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; } = new List<AccountReconcileModelTemplate>();

    //public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    //public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgers { get; } = new List<AccountReportGeneralLedger>();

    //public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgers { get; } = new List<AccountReportPartnerLedger>();

    //public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardsNavigation { get; } = new List<BasePartnerMergeAutomaticWizard>();

    //public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    //public virtual ICollection<ResPartnerCategory> Categories { get; } = new List<ResPartnerCategory>();

    //public virtual ICollection<IrActServer> IrActServers { get; } = new List<IrActServer>();

    //public virtual ICollection<MailMail> MailMails { get; } = new List<MailMail>();

    //public virtual ICollection<MailMessage> MailMessages1 { get; } = new List<MailMessage>();

    //public virtual ICollection<MailMessage> MailMessagesNavigation { get; } = new List<MailMessage>();

    //public virtual ICollection<MailWizardInvite> MailWizardInvites { get; } = new List<MailWizardInvite>();

    //public virtual ICollection<FleetVehicleModel> Models { get; } = new List<FleetVehicleModel>();

    //public virtual ICollection<PortalShare> PortalShares { get; } = new List<PortalShare>();

    //public virtual ICollection<PortalWizard> PortalWizards { get; } = new List<PortalWizard>();

    //public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProjectShareWizard> ProjectShareWizards { get; } = new List<ProjectShareWizard>();

    //public virtual ICollection<MailComposeMessage> Wizards { get; } = new List<MailComposeMessage>();
}
