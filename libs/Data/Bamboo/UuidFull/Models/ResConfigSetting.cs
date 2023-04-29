using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResConfigSetting
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? CompanyId { get; set; }

    public bool? UserDefaultRights { get; set; }

    public bool? ExternalEmailServerDefault { get; set; }

    public bool? ModuleBaseImport { get; set; }

    public bool? ModuleGoogleCalendar { get; set; }

    public bool? ModuleMicrosoftCalendar { get; set; }

    public bool? ModuleMailPlugin { get; set; }

    public bool? ModuleAuthOauth { get; set; }

    public bool? ModuleAuthLdap { get; set; }

    public bool? ModuleBaseGengo { get; set; }

    public bool? ModuleAccountInterCompanyRules { get; set; }

    public bool? ModuleVoip { get; set; }

    public bool? ModuleWebUnsplash { get; set; }

    public bool? ModulePartnerAutocomplete { get; set; }

    public bool? ModuleBaseGeolocalize { get; set; }

    public bool? ModuleGoogleRecaptcha { get; set; }

    public bool? GroupMultiCurrency { get; set; }

    public bool? ShowEffect { get; set; }

    public bool? ModuleProductImages { get; set; }

    public DateTime? ProfilingEnabledUntil { get; set; }

    public string? AliasDomain { get; set; }

    public string? TwilioAccountSid { get; set; }

    public string? TwilioAccountToken { get; set; }

    public bool? ModuleGoogleGmail { get; set; }

    public bool? ModuleMicrosoftOutlook { get; set; }

    public bool? RestrictTemplateRendering { get; set; }

    public bool? UseTwilioRtcServers { get; set; }

    public bool? GroupAnalyticAccounting { get; set; }

    public Guid? AuthSignupTemplateUserId { get; set; }

    public string? AuthSignupUninvited { get; set; }

    public bool? AuthSignupResetPassword { get; set; }

    public string? GoogleGmailClientIdentifier { get; set; }

    public string? GoogleGmailClientSecret { get; set; }

    public string? ProductPricelistSetting { get; set; }

    public string? ProductWeightInLbs { get; set; }

    public string? ProductVolumeVolumeInCubicFeet { get; set; }

    public bool? GroupDiscountPerSoLine { get; set; }

    public bool? GroupUom { get; set; }

    public bool? GroupProductVariant { get; set; }

    public bool? ModuleSaleProductMatrix { get; set; }

    public bool? ModuleLoyalty { get; set; }

    public bool? GroupStockPackaging { get; set; }

    public bool? GroupProductPricelist { get; set; }

    public bool? GroupSalePricelist { get; set; }

    public string? UnsplashAccessKey { get; set; }

    public string? UnsplashAppId { get; set; }

    public Guid? DigestId { get; set; }

    public bool? DigestEmails { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public string? ShowLineSubtotalsTaxSelection { get; set; }

    public bool? ModuleAccountAccountant { get; set; }

    public bool? GroupWarningAccount { get; set; }

    public bool? GroupCashRounding { get; set; }

    public bool? GroupShowLineSubtotalsTaxExcluded { get; set; }

    public bool? GroupShowLineSubtotalsTaxIncluded { get; set; }

    public bool? GroupShowSaleReceipts { get; set; }

    public bool? GroupShowPurchaseReceipts { get; set; }

    public bool? ModuleAccountBudget { get; set; }

    public bool? ModuleAccountPayment { get; set; }

    public bool? ModuleAccountReports { get; set; }

    public bool? ModuleAccountCheckPrinting { get; set; }

    public bool? ModuleAccountBatchPayment { get; set; }

    public bool? ModuleAccountSepa { get; set; }

    public bool? ModuleAccountSepaDirectDebit { get; set; }

    public bool? ModuleAccountBankStatementImportQif { get; set; }

    public bool? ModuleAccountBankStatementImportOfx { get; set; }

    public bool? ModuleAccountBankStatementImportCsv { get; set; }

    public bool? ModuleAccountBankStatementImportCamt { get; set; }

    public bool? ModuleCurrencyRateLive { get; set; }

    public bool? ModuleAccountIntrastat { get; set; }

    public bool? ModuleProductMargin { get; set; }

    public bool? ModuleL10nEuOss { get; set; }

    public bool? ModuleAccountTaxcloud { get; set; }

    public bool? ModuleAccountInvoiceExtract { get; set; }

    public bool? ModuleSnailmailAccount { get; set; }

    public bool? UseInvoiceTerms { get; set; }

    public bool? GroupSaleDeliveryAddress { get; set; }

    public Guid? DepositDefaultProductId { get; set; }

    public Guid? InvoiceMailTemplateId { get; set; }

    public string? DefaultInvoicePolicy { get; set; }

    public bool? GroupAutoDoneSetting { get; set; }

    public bool? GroupProformaSales { get; set; }

    public bool? GroupWarningSale { get; set; }

    public bool? AutomaticInvoice { get; set; }

    public bool? UseQuotationValidityDays { get; set; }

    public bool? ModuleDelivery { get; set; }

    public bool? ModuleDeliveryBpost { get; set; }

    public bool? ModuleDeliveryDhl { get; set; }

    public bool? ModuleDeliveryEasypost { get; set; }

    public bool? ModuleDeliverySendcloud { get; set; }

    public bool? ModuleDeliveryFedex { get; set; }

    public bool? ModuleDeliveryUps { get; set; }

    public bool? ModuleDeliveryUsps { get; set; }

    public bool? ModuleProductEmailTemplate { get; set; }

    public bool? ModuleSaleAmazon { get; set; }

    public bool? ModuleSaleLoyalty { get; set; }

    public bool? ModuleSaleMargin { get; set; }

    public bool? GroupSaleOrderTemplate { get; set; }

    public bool? ModuleSaleQuotationBuilder { get; set; }

    public bool? ModuleProductExpiry { get; set; }

    public bool? GroupStockProductionLot { get; set; }

    public bool? GroupStockLotPrintGs1 { get; set; }

    public bool? GroupLotOnDeliverySlip { get; set; }

    public bool? GroupStockTrackingLot { get; set; }

    public bool? GroupStockTrackingOwner { get; set; }

    public bool? GroupStockAdvLocation { get; set; }

    public bool? GroupWarningStock { get; set; }

    public bool? GroupStockSignDelivery { get; set; }

    public bool? ModuleStockPickingBatch { get; set; }

    public bool? GroupStockPickingWave { get; set; }

    public bool? ModuleStockBarcode { get; set; }

    public bool? ModuleStockSms { get; set; }

    public bool? ModuleQualityControl { get; set; }

    public bool? ModuleQualityControlWorksheet { get; set; }

    public bool? GroupStockMultiLocations { get; set; }

    public bool? GroupStockStorageCategories { get; set; }

    public bool? GroupStockReceptionReport { get; set; }

    public bool? ModuleStockLandedCosts { get; set; }

    public bool? GroupLotOnInvoice { get; set; }

    public Guid? PosConfigId { get; set; }

    public Guid? PosDefaultFiscalPositionId { get; set; }

    public long? PosIfaceStartCategId { get; set; }

    public Guid? PosPricelistId { get; set; }

    public Guid? PosTipProductId { get; set; }

    public string? PosProxyIp { get; set; }

    public string? PosReceiptFooter { get; set; }

    public string? PosReceiptHeader { get; set; }

    public bool? ModulePosMercury { get; set; }

    public bool? ModulePosAdyen { get; set; }

    public bool? ModulePosStripe { get; set; }

    public bool? ModulePosSix { get; set; }

    public bool? PosIfaceCashdrawer { get; set; }

    public bool? PosIfaceCustomerFacingDisplayViaProxy { get; set; }

    public bool? PosIfaceElectronicScale { get; set; }

    public bool? PosIfacePrintViaProxy { get; set; }

    public bool? PosIfaceScanViaProxy { get; set; }

    public string? PosEpsonPrinterIp { get; set; }

    public string? DefaultPickingPolicy { get; set; }

    public bool? GroupDisplayIncoterm { get; set; }

    public bool? UseSecurityLead { get; set; }

    public string? DefaultPurchaseMethod { get; set; }

    public bool? LockConfirmedPo { get; set; }

    public bool? PoOrderApproval { get; set; }

    public bool? GroupWarningPurchase { get; set; }

    public bool? ModuleAccount3wayMatch { get; set; }

    public bool? ModulePurchaseRequisition { get; set; }

    public bool? ModulePurchaseProductMatrix { get; set; }

    public bool? UsePoLead { get; set; }

    public bool? GroupSendReminder { get; set; }

    public bool? ModuleStockDropshipping { get; set; }

    public bool? IsInstalledSale { get; set; }

    public Guid? CrmAutoAssignmentIntervalNumber { get; set; }

    public string? CrmAutoAssignmentAction { get; set; }

    public string? CrmAutoAssignmentIntervalType { get; set; }

    public string? LeadEnrichAuto { get; set; }

    public string? PredictiveLeadScoringStartDateStr { get; set; }

    public string? PredictiveLeadScoringFieldsStr { get; set; }

    public bool? GroupUseLead { get; set; }

    public bool? GroupUseRecurringRevenues { get; set; }

    public bool? IsMembershipMulti { get; set; }

    public bool? CrmUseAutoAssignment { get; set; }

    public bool? ModuleCrmIapMine { get; set; }

    public bool? ModuleCrmIapEnrich { get; set; }

    public bool? ModuleWebsiteCrmIapReveal { get; set; }

    public bool? LeadMiningInPipeline { get; set; }

    public DateTime? CrmAutoAssignmentRunDatetime { get; set; }

    public bool? GroupFiscalYear { get; set; }

    public bool? UseManufacturingLead { get; set; }

    public bool? GroupMrpByproducts { get; set; }

    public bool? ModuleMrpMps { get; set; }

    public bool? ModuleMrpPlm { get; set; }

    public bool? ModuleMrpWorkorder { get; set; }

    public bool? ModuleMrpSubcontracting { get; set; }

    public bool? GroupMrpRoutings { get; set; }

    public bool? GroupUnlockedByDefault { get; set; }

    public bool? GroupMrpReceptionReport { get; set; }

    public bool? GroupMrpWorkorderDependencies { get; set; }

    public bool? ModuleProjectForecast { get; set; }

    public bool? ModuleHrTimesheet { get; set; }

    public bool? GroupSubtaskProject { get; set; }

    public bool? GroupProjectRating { get; set; }

    public bool? GroupProjectStages { get; set; }

    public bool? GroupProjectRecurringTasks { get; set; }

    public bool? GroupProjectTaskDependencies { get; set; }

    public bool? GroupProjectMilestone { get; set; }

    public Guid? DelayAlertContract { get; set; }

    public bool? ModuleHrPresence { get; set; }

    public bool? ModuleHrSkills { get; set; }

    public bool? ModuleHrHomeworking { get; set; }

    public bool? HrPresenceControlLogin { get; set; }

    public bool? HrPresenceControlEmail { get; set; }

    public bool? HrPresenceControlIp { get; set; }

    public bool? ModuleHrAttendance { get; set; }

    public bool? HrEmployeeSelfEdit { get; set; }

    public string? ExpenseAliasPrefix { get; set; }

    public bool? UseMailgateway { get; set; }

    public bool? ModuleHrPayrollExpense { get; set; }

    public bool? ModuleHrExpenseExtract { get; set; }

    public bool? ModuleWebsiteHrRecruitment { get; set; }

    public bool? ModuleHrRecruitmentSurvey { get; set; }

    public bool? GroupApplicantCvDisplay { get; set; }

    public bool? ModuleHrRecruitmentExtract { get; set; }

    public Guid? OvertimeCompanyThreshold { get; set; }

    public Guid? OvertimeEmployeeThreshold { get; set; }

    public DateOnly? OvertimeStartDate { get; set; }

    public bool? GroupAttendanceUsePin { get; set; }

    public bool? HrAttendanceOvertime { get; set; }

    public string? RecaptchaPublicKey { get; set; }

    public string? RecaptchaPrivateKey { get; set; }

    public double? RecaptchaMinScore { get; set; }

    public Guid? WebsiteId { get; set; }

    public bool? GroupMultiWebsite { get; set; }

    public bool? ModuleWebsiteLivechat { get; set; }

    public bool? ModuleMarketingAutomation { get; set; }

    public bool? ModulePaymentPaypal { get; set; }

    public string? SaleDeliverySettings { get; set; }

    public bool? ModuleWebsiteSaleDelivery { get; set; }

    public bool? GroupDeliveryInvoiceAddress { get; set; }

    public bool? GroupShowUomPrice { get; set; }

    public bool? GroupProductPriceComparison { get; set; }

    public bool? ModuleWebsiteSaleDigital { get; set; }

    public bool? ModuleWebsiteSaleWishlist { get; set; }

    public bool? ModuleWebsiteSaleComparison { get; set; }

    public bool? ModuleWebsiteSaleAutocomplete { get; set; }

    public bool? ModuleAccount { get; set; }

    public bool? ModuleWebsiteSalePicking { get; set; }

    public bool? ModuleDeliveryMondialrelay { get; set; }

    public bool? EnabledExtraCheckoutStep { get; set; }

    public bool? EnabledBuyNowButton { get; set; }

    public bool? AllowOutOfStockOrder { get; set; }

    public bool? ShowAvailability { get; set; }

    public double? AvailableThreshold { get; set; }

    public virtual ResUser? AuthSignupTemplateUser { get; set; }

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? DepositDefaultProduct { get; set; }

    public virtual DigestDigest? Digest { get; set; }

    public virtual MailTemplate? InvoiceMailTemplate { get; set; }

    public virtual ICollection<PosCategoryResConfigSettingsRel> PosCategoryResConfigSettingsRels { get; } = new List<PosCategoryResConfigSettingsRel>();

    public virtual PosConfig? PosConfig { get; set; }

    public virtual AccountFiscalPosition? PosDefaultFiscalPosition { get; set; }

    public virtual ProductPricelist? PosPricelist { get; set; }

    public virtual ProductProduct? PosTipProduct { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    public virtual ICollection<ProductPricelist> ProductPricelists { get; } = new List<ProductPricelist>();
}
