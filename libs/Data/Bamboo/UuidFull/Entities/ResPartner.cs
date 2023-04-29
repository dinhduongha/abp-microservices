﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_partner")]
[Index("CommercialPartnerId", Name = "res_partner_commercial_partner_id_index")]
[Index("CompanyId", Name = "res_partner_company_id_index")]
[Index("Date", Name = "res_partner_date_index")]
[Index("DisplayName", Name = "res_partner_display_name_index")]
[Index("IsPublished", Name = "res_partner_is_published_index")]
[Index("Name", Name = "res_partner_name_index")]
[Index("ParentId", Name = "res_partner_parent_id_index")]
[Index("Ref", Name = "res_partner_ref_index")]
[Index("Vat", Name = "res_partner_vat_index")]
[Index("WebsiteId", Name = "res_partner_website_id_index")]
public partial class ResPartner
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("title")]
    public long? Title { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("industry_id")]
    public long? IndustryId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("commercial_partner_id")]
    public Guid? CommercialPartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("display_name")]
    public string? DisplayName { get; set; }

    [Column("ref")]
    public string? Ref { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("tz")]
    public string? Tz { get; set; }

    [Column("vat")]
    public string? Vat { get; set; }

    [Column("company_registry")]
    public string? CompanyRegistry { get; set; }

    [Column("website")]
    public string? Website { get; set; }

    [Column("function")]
    public string? Function { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("street")]
    public string? Street { get; set; }

    [Column("street2")]
    public string? Street2 { get; set; }

    [Column("zip")]
    public string? Zip { get; set; }

    [Column("city")]
    public string? City { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("phone")]
    public string? Phone { get; set; }

    [Column("mobile")]
    public string? Mobile { get; set; }

    [Column("commercial_company_name")]
    public string? CommercialCompanyName { get; set; }

    [Column("company_name")]
    public string? CompanyName { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("comment")]
    public string? Comment { get; set; }

    [Column("partner_latitude")]
    public decimal? PartnerLatitude { get; set; }

    [Column("partner_longitude")]
    public decimal? PartnerLongitude { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("employee")]
    public bool? Employee { get; set; }

    [Column("is_company")]
    public bool? IsCompany { get; set; }

    [Column("partner_share")]
    public bool? PartnerShare { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("message_bounce")]
    public long? MessageBounce { get; set; }

    [Column("email_normalized")]
    public string? EmailNormalized { get; set; }

    [Column("signup_token")]
    public string? SignupToken { get; set; }

    [Column("signup_type")]
    public string? SignupType { get; set; }

    [Column("signup_expiration", TypeName = "timestamp without time zone")]
    public DateTime? SignupExpiration { get; set; }

    [Column("team_id")]
    public Guid? TeamId { get; set; }

    [Column("partner_gid")]
    public Guid? PartnerGid { get; set; }

    [Column("additional_info")]
    public string? AdditionalInfo { get; set; }

    [Column("phone_sanitized")]
    public string? PhoneSanitized { get; set; }

    [Column("supplier_rank")]
    public long? SupplierRank { get; set; }

    [Column("customer_rank")]
    public long? CustomerRank { get; set; }

    [Column("invoice_warn")]
    public string? InvoiceWarn { get; set; }

    [Column("invoice_warn_msg")]
    public string? InvoiceWarnMsg { get; set; }

    [Column("debit_limit")]
    public decimal? DebitLimit { get; set; }

    [Column("last_time_entries_checked", TypeName = "timestamp without time zone")]
    public DateTime? LastTimeEntriesChecked { get; set; }

    [Column("sale_warn")]
    public string? SaleWarn { get; set; }

    [Column("sale_warn_msg")]
    public string? SaleWarnMsg { get; set; }

    [Column("picking_warn")]
    public string? PickingWarn { get; set; }

    [Column("picking_warn_msg")]
    public string? PickingWarnMsg { get; set; }

    [Column("purchase_warn")]
    public string? PurchaseWarn { get; set; }

    [Column("purchase_warn_msg")]
    public string? PurchaseWarnMsg { get; set; }

    [Column("calendar_last_notif_ack", TypeName = "timestamp without time zone")]
    public DateTime? CalendarLastNotifAck { get; set; }

    [Column("payment_responsible_id")]
    public Guid? PaymentResponsibleId { get; set; }

    [Column("latest_followup_sequence")]
    public long? LatestFollowupSequence { get; set; }

    [Column("latest_followup_level_id_without_lit")]
    public Guid? LatestFollowupLevelIdWithoutLit { get; set; }

    [Column("payment_next_action_date")]
    public DateOnly? PaymentNextActionDate { get; set; }

    [Column("payment_note")]
    public string? PaymentNote { get; set; }

    [Column("payment_next_action")]
    public string? PaymentNextAction { get; set; }

    [Column("plan_to_change_car")]
    public bool? PlanToChangeCar { get; set; }

    [Column("plan_to_change_bike")]
    public bool? PlanToChangeBike { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("is_published")]
    public bool? IsPublished { get; set; }

    [InverseProperty("Partner")]
    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; } = new List<AccountAnalyticAccount>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; } = new List<AccountBankStatementLine>();

    [InverseProperty("CommercialPartner")]
    public virtual ICollection<AccountMove> AccountMoveCommercialPartners { get; } = new List<AccountMove>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("PartnerShipping")]
    public virtual ICollection<AccountMove> AccountMovePartnerShippings { get; } = new List<AccountMove>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountMove> AccountMovePartners { get; } = new List<AccountMove>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [InverseProperty("Partner")]
    public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappings { get; } = new List<AccountReconcileModelPartnerMapping>();

    [InverseProperty("Author")]
    public virtual ICollection<ApplicantSendMail> ApplicantSendMails { get; } = new List<ApplicantSendMail>();

    [InverseProperty("DstPartner")]
    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizards { get; } = new List<BasePartnerMergeAutomaticWizard>();

    [InverseProperty("Partner")]
    public virtual ICollection<CalendarAttendee> CalendarAttendees { get; } = new List<CalendarAttendee>();

    [InverseProperty("Partner")]
    public virtual ICollection<CalendarFilter> CalendarFilters { get; } = new List<CalendarFilter>();

    [ForeignKey("CommercialPartnerId")]
    [InverseProperty("InverseCommercialPartner")]
    public virtual ResPartner? CommercialPartner { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ResPartners")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResPartnerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Partner")]
    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; } = new List<CrmLead2opportunityPartnerMass>();

    [InverseProperty("Partner")]
    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartners { get; } = new List<CrmLead2opportunityPartner>();

    [InverseProperty("Partner")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [InverseProperty("Partner")]
    public virtual ICollection<CrmQuotationPartner> CrmQuotationPartners { get; } = new List<CrmQuotationPartner>();

    [InverseProperty("Driver")]
    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogs { get; } = new List<FleetVehicleAssignationLog>();

    [InverseProperty("Driver")]
    public virtual ICollection<FleetVehicle> FleetVehicleDrivers { get; } = new List<FleetVehicle>();

    [InverseProperty("FutureDriver")]
    public virtual ICollection<FleetVehicle> FleetVehicleFutureDrivers { get; } = new List<FleetVehicle>();

    [InverseProperty("Insurer")]
    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; } = new List<FleetVehicleLogContract>();

    [InverseProperty("Purchaser")]
    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServicePurchasers { get; } = new List<FleetVehicleLogService>();

    [InverseProperty("Vendor")]
    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceVendors { get; } = new List<FleetVehicleLogService>();

    [InverseProperty("Partner")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    [InverseProperty("AddressHome")]
    public virtual ICollection<HrEmployee> HrEmployeeAddressHomes { get; } = new List<HrEmployee>();

    [InverseProperty("Address")]
    public virtual ICollection<HrEmployee> HrEmployeeAddresses { get; } = new List<HrEmployee>();

    [InverseProperty("WorkContact")]
    public virtual ICollection<HrEmployee> HrEmployeeWorkContacts { get; } = new List<HrEmployee>();

    [InverseProperty("Address")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    [InverseProperty("Address")]
    public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    [InverseProperty("Address")]
    public virtual ICollection<HrWorkLocation> HrWorkLocations { get; } = new List<HrWorkLocation>();

    [InverseProperty("CommercialPartner")]
    public virtual ICollection<ResPartner> InverseCommercialPartner { get; } = new List<ResPartner>();

    [InverseProperty("Parent")]
    public virtual ICollection<ResPartner> InverseParent { get; } = new List<ResPartner>();

    [ForeignKey("LatestFollowupLevelIdWithoutLit")]
    [InverseProperty("ResPartners")]
    public virtual FollowupLine? LatestFollowupLevelIdWithoutLitNavigation { get; set; }

    [InverseProperty("Partner")]
    public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();

    [InverseProperty("RequestPartner")]
    public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    [InverseProperty("Partner")]
    public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    [InverseProperty("Author")]
    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    [InverseProperty("Partner")]
    public virtual ICollection<MailFollower> MailFollowers { get; } = new List<MailFollower>();

    [InverseProperty("Partner")]
    public virtual ICollection<MailMessageReaction> MailMessageReactions { get; } = new List<MailMessageReaction>();

    [InverseProperty("Author")]
    public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    [InverseProperty("Author")]
    public virtual ICollection<MailNotification> MailNotificationAuthors { get; } = new List<MailNotification>();

    [InverseProperty("ResPartner")]
    public virtual ICollection<MailNotification> MailNotificationResPartners { get; } = new List<MailNotification>();

    [InverseProperty("Partner")]
    public virtual ICollection<MailResendPartner> MailResendPartners { get; } = new List<MailResendPartner>();

    [InverseProperty("Partner")]
    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("ResPartners")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual ResPartner? Parent { get; set; }

    [InverseProperty("Partner")]
    public virtual ICollection<PaymentLinkWizard> PaymentLinkWizards { get; } = new List<PaymentLinkWizard>();

    [ForeignKey("PaymentResponsibleId")]
    [InverseProperty("ResPartnerPaymentResponsibles")]
    public virtual ResUser? PaymentResponsible { get; set; }

    [InverseProperty("Partner")]
    public virtual ICollection<PaymentToken> PaymentTokens { get; } = new List<PaymentToken>();

    [InverseProperty("Partner")]
    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    [InverseProperty("Partner")]
    public virtual ICollection<PortalWizardUser> PortalWizardUsers { get; } = new List<PortalWizardUser>();

    [InverseProperty("Partner")]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("Partner")]
    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; } = new List<ProcurementGroup>();

    [InverseProperty("Partner")]
    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    [InverseProperty("Partner")]
    public virtual ICollection<ProjectCollaborator> ProjectCollaborators { get; } = new List<ProjectCollaborator>();

    [InverseProperty("Partner")]
    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    [InverseProperty("Partner")]
    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    [InverseProperty("DestAddress")]
    public virtual ICollection<PurchaseOrder> PurchaseOrderDestAddresses { get; } = new List<PurchaseOrder>();

    [InverseProperty("Partner")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("Partner")]
    public virtual ICollection<PurchaseOrder> PurchaseOrderPartners { get; } = new List<PurchaseOrder>();

    [InverseProperty("Partner")]
    public virtual ICollection<RatingRating> RatingRatingPartners { get; } = new List<RatingRating>();

    [InverseProperty("Publisher")]
    public virtual ICollection<RatingRating> RatingRatingPublishers { get; } = new List<RatingRating>();

    [InverseProperty("RatedPartner")]
    public virtual ICollection<RatingRating> RatingRatingRatedPartners { get; } = new List<RatingRating>();

    [InverseProperty("Partner")]
    public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    [InverseProperty("Partner")]
    public virtual ICollection<RecurringPayment> RecurringPayments { get; } = new List<RecurringPayment>();

    [InverseProperty("Address")]
    public virtual ICollection<RepairOrder> RepairOrderAddresses { get; } = new List<RepairOrder>();

    [InverseProperty("PartnerInvoice")]
    public virtual ICollection<RepairOrder> RepairOrderPartnerInvoices { get; } = new List<RepairOrder>();

    [InverseProperty("Partner")]
    public virtual ICollection<RepairOrder> RepairOrderPartners { get; } = new List<RepairOrder>();

    [InverseProperty("Partner")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [InverseProperty("Partner")]
    public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncs { get; } = new List<ResPartnerAutocompleteSync>();

    [InverseProperty("Partner")]
    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    [InverseProperty("Partner")]
    public virtual ICollection<ResPartnerResPartnerCategoryRel> ResPartnerResPartnerCategoryRels { get; } = new List<ResPartnerResPartnerCategoryRel>();

    [InverseProperty("Partner")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    [InverseProperty("Guest")]
    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeGuests { get; } = new List<ResUsersSettingsVolume>();

    [InverseProperty("Partner")]
    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumePartners { get; } = new List<ResUsersSettingsVolume>();

    [InverseProperty("Author")]
    public virtual ICollection<SaleOrderCancel> SaleOrderCancels { get; } = new List<SaleOrderCancel>();

    [InverseProperty("OrderPartner")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [InverseProperty("PartnerInvoice")]
    public virtual ICollection<SaleOrder> SaleOrderPartnerInvoices { get; } = new List<SaleOrder>();

    [InverseProperty("PartnerShipping")]
    public virtual ICollection<SaleOrder> SaleOrderPartnerShippings { get; } = new List<SaleOrder>();

    [InverseProperty("Partner")]
    public virtual ICollection<SaleOrder> SaleOrderPartners { get; } = new List<SaleOrder>();

    [InverseProperty("Partner")]
    public virtual ICollection<SmsSm> SmsSms { get; } = new List<SmsSm>();

    [InverseProperty("Partner")]
    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; } = new List<SnailmailLetterMissingRequiredField>();

    [InverseProperty("Partner")]
    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    [InverseProperty("Owner")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("Partner")]
    public virtual ICollection<StockMove> StockMovePartners { get; } = new List<StockMove>();

    [InverseProperty("RestrictPartner")]
    public virtual ICollection<StockMove> StockMoveRestrictPartners { get; } = new List<StockMove>();

    [InverseProperty("Owner")]
    public virtual ICollection<StockPicking> StockPickingOwners { get; } = new List<StockPicking>();

    [InverseProperty("Partner")]
    public virtual ICollection<StockPicking> StockPickingPartners { get; } = new List<StockPicking>();

    [InverseProperty("Owner")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    [InverseProperty("PartnerAddress")]
    public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    [InverseProperty("Owner")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [InverseProperty("Vendor")]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    [InverseProperty("Partner")]
    public virtual ICollection<StockWarehouse> StockWarehouses { get; } = new List<StockWarehouse>();

    [ForeignKey("TeamId")]
    [InverseProperty("ResPartners")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ResPartnerUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("ResPartners")]
    public virtual Website? WebsiteNavigation { get; set; }

    [InverseProperty("Partner")]
    public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; } = new List<WebsiteVisitor>();

    [ForeignKey("WriteUid")]
    [InverseProperty("ResPartnerWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalances { get; } = new List<AccountAgedTrialBalance>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<AccountBalanceReport> AccountBalanceReports { get; } = new List<AccountBalanceReport>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReports { get; } = new List<AccountCommonPartnerReport>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; } = new List<AccountReconcileModelTemplate>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgers { get; } = new List<AccountReportGeneralLedger>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgers { get; } = new List<AccountReportPartnerLedger>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardsNavigation { get; } = new List<BasePartnerMergeAutomaticWizard>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<IrActServer> IrActServers { get; } = new List<IrActServer>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<MailMail> MailMails { get; } = new List<MailMail>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartnersNavigation")]
    public virtual ICollection<MailMessage> MailMessages1 { get; } = new List<MailMessage>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<MailMessage> MailMessagesNavigation { get; } = new List<MailMessage>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<MailWizardInvite> MailWizardInvites { get; } = new List<MailWizardInvite>();

    [ForeignKey("PartnerId")]
    [InverseProperty("Partners")]
    public virtual ICollection<FleetVehicleModel> Models { get; } = new List<FleetVehicleModel>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<PortalShare> PortalShares { get; } = new List<PortalShare>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<PortalWizard> PortalWizards { get; } = new List<PortalWizard>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    [ForeignKey("ResPartnerId")]
    [InverseProperty("ResPartners")]
    public virtual ICollection<ProjectShareWizard> ProjectShareWizards { get; } = new List<ProjectShareWizard>();

    [ForeignKey("PartnerId")]
    [InverseProperty("Partners")]
    public virtual ICollection<MailComposeMessage> Wizards { get; } = new List<MailComposeMessage>();
}
