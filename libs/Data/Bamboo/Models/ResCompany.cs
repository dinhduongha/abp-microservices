using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResCompany
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? PartnerId { get; set; }

    public long? CurrencyId { get; set; }

    public long? Sequence { get; set; }

    public DateTime? CreationTime { get; set; }

    public Guid? ParentId { get; set; }

    public long? PaperformatId { get; set; }

    public Guid? ExternalReportLayoutId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? BaseOnboardingCompanyState { get; set; }

    public string? Font { get; set; }

    public string? PrimaryColor { get; set; }

    public string? SecondaryColor { get; set; }

    public string? LayoutBackground { get; set; }

    public string? ReportFooter { get; set; }

    public string? ReportHeader { get; set; }

    public string? CompanyDetails { get; set; }

    public bool? Active { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public byte[]? LogoWeb { get; set; }

    public Guid? ResourceCalendarId { get; set; }

    public Guid? PartnerGid { get; set; }

    public bool? IapEnrichAutoDone { get; set; }

    public bool? SnailmailColor { get; set; }

    public bool? SnailmailCover { get; set; }

    public bool? SnailmailDuplex { get; set; }

    public string? PaymentProviderOnboardingState { get; set; }

    public string? PaymentOnboardingPaymentMethod { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? FiscalyearLastDay { get; set; }

    public Guid? TransferAccountId { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public Guid? DefaultCashDifferenceIncomeAccountId { get; set; }

    public Guid? DefaultCashDifferenceExpenseAccountId { get; set; }

    public Guid? AccountJournalSuspenseAccountId { get; set; }

    public Guid? AccountJournalPaymentDebitAccountId { get; set; }

    public Guid? AccountJournalPaymentCreditAccountId { get; set; }

    public Guid? AccountJournalEarlyPayDiscountGainAccountId { get; set; }

    public Guid? AccountJournalEarlyPayDiscountLossAccountId { get; set; }

    public Guid? AccountSaleTaxId { get; set; }

    public Guid? AccountPurchaseTaxId { get; set; }

    public Guid? CurrencyExchangeJournalId { get; set; }

    public Guid? IncomeCurrencyExchangeAccountId { get; set; }

    public Guid? ExpenseCurrencyExchangeAccountId { get; set; }

    public Guid? PropertyStockAccountInputCategId { get; set; }

    public Guid? PropertyStockAccountOutputCategId { get; set; }

    public Guid? PropertyStockValuationAccountId { get; set; }

    public Guid? IncotermId { get; set; }

    public Guid? AccountOpeningMoveId { get; set; }

    public Guid? AccountDefaultPosReceivableAccountId { get; set; }

    public Guid? ExpenseAccrualAccountId { get; set; }

    public Guid? RevenueAccrualAccountId { get; set; }

    public Guid? AutomaticEntryDefaultJournalId { get; set; }

    public long? AccountFiscalCountryId { get; set; }

    public Guid? TaxCashBasisJournalId { get; set; }

    public Guid? AccountCashBasisBaseAccountId { get; set; }

    public string? FiscalyearLastMonth { get; set; }

    public string? BankAccountCodePrefix { get; set; }

    public string? CashAccountCodePrefix { get; set; }

    public string? EarlyPayDiscountComputation { get; set; }

    public string? TransferAccountCodePrefix { get; set; }

    public string? TaxCalculationRoundingMethod { get; set; }

    public string? AccountSetupBankDataState { get; set; }

    public string? AccountSetupFyDataState { get; set; }

    public string? AccountSetupCoaState { get; set; }

    public string? AccountSetupTaxesState { get; set; }

    public string? AccountOnboardingInvoiceLayoutState { get; set; }

    public string? AccountOnboardingSaleTaxState { get; set; }

    public string? AccountInvoiceOnboardingState { get; set; }

    public string? AccountDashboardOnboardingState { get; set; }

    public string? TermsType { get; set; }

    public string? AccountSetupBillState { get; set; }

    public string? QuickEditMode { get; set; }

    public DateOnly? PeriodLockDate { get; set; }

    public DateOnly? FiscalyearLockDate { get; set; }

    public DateOnly? TaxLockDate { get; set; }

    public DateOnly? AccountOpeningDate { get; set; }

    public string? InvoiceTerms { get; set; }

    public string? InvoiceTermsHtml { get; set; }

    public bool? ExpectsChartOfAccounts { get; set; }

    public bool? AngloSaxonAccounting { get; set; }

    public bool? QrCode { get; set; }

    public bool? InvoiceIsEmail { get; set; }

    public bool? InvoiceIsPrint { get; set; }

    public bool? AccountUseCreditLimit { get; set; }

    public bool? AccountOnboardingCreateInvoiceStateFlag { get; set; }

    public bool? TaxExigibility { get; set; }

    public bool? AccountStorno { get; set; }

    public bool? InvoiceIsSnailmail { get; set; }

    public long? QuotationValidityDays { get; set; }

    public string? SaleQuotationOnboardingState { get; set; }

    public string? SaleOnboardingOrderConfirmationState { get; set; }

    public string? SaleOnboardingSampleQuotationState { get; set; }

    public string? SaleOnboardingPaymentMethod { get; set; }

    public bool? PortalConfirmationSign { get; set; }

    public bool? PortalConfirmationPay { get; set; }

    public Guid? SaleOrderTemplateId { get; set; }

    public bool? VatCheckVies { get; set; }

    public long? NomenclatureId { get; set; }

    public Guid? InternalTransitLocationId { get; set; }

    public Guid? StockMailConfirmationTemplateId { get; set; }

    public long? AnnualInventoryDay { get; set; }

    public string? AnnualInventoryMonth { get; set; }

    public bool? StockMoveEmailValidation { get; set; }

    public Guid? StockSmsConfirmationTemplateId { get; set; }

    public bool? StockMoveSmsValidation { get; set; }

    public bool? HasReceivedWarningStockSms { get; set; }

    public string? PointOfSaleUpdateStockQuantities { get; set; }

    public bool? PointOfSaleUseTicketQrCode { get; set; }

    public double? SecurityLead { get; set; }

    public string? PoLock { get; set; }

    public string? PoDoubleValidation { get; set; }

    public decimal? PoDoubleValidationAmount { get; set; }

    public double? PoLead { get; set; }

    public double? DaysToPurchase { get; set; }

    public double? ManufacturingLead { get; set; }

    public Guid? HrPresenceControlEmailAmount { get; set; }

    public string? HrPresenceControlIpList { get; set; }

    public Guid? ExpenseJournalId { get; set; }

    public Guid? CompanyExpenseJournalId { get; set; }

    public Guid? OvertimeCompanyThreshold { get; set; }

    public Guid? OvertimeEmployeeThreshold { get; set; }

    public Guid? AttendanceKioskDelay { get; set; }

    public string? AttendanceKioskMode { get; set; }

    public string? AttendanceBarcodeSource { get; set; }

    public DateOnly? OvertimeStartDate { get; set; }

    public bool? HrAttendanceOvertime { get; set; }

    public string? SocialTwitter { get; set; }

    public string? SocialFacebook { get; set; }

    public string? SocialGithub { get; set; }

    public string? SocialLinkedin { get; set; }

    public string? SocialYoutube { get; set; }

    public string? SocialInstagram { get; set; }

    public Guid? WebsiteId { get; set; }

    public string? WebsiteSaleOnboardingPaymentProviderState { get; set; }

    public string? LunchNotifyMessage { get; set; }

    public double? LunchMinimumThreshold { get; set; }

    //public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; } = new List<AccountAccruedOrdersWizard>();

    //public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalances { get; } = new List<AccountAgedTrialBalance>();

    //public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; } = new List<AccountAnalyticAccount>();

    //public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlans { get; } = new List<AccountAnalyticPlan>();

    //public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    //public virtual ICollection<AccountAssetCategory> AccountAssetCategories { get; } = new List<AccountAssetCategory>();

    //public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizards { get; } = new List<AccountAutomaticEntryWizard>();

    //public virtual ICollection<AccountBalanceReport> AccountBalanceReports { get; } = new List<AccountBalanceReport>();

    //public virtual ICollection<AccountBankStatement> AccountBankStatements { get; } = new List<AccountBankStatement>();

    //public virtual ICollection<AccountBudgetPost> AccountBudgetPosts { get; } = new List<AccountBudgetPost>();

    public virtual AccountAccount? AccountCashBasisBaseAccount { get; set; }

    //public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    //public virtual ICollection<AccountCommonJournalReport> AccountCommonJournalReports { get; } = new List<AccountCommonJournalReport>();

    //public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReports { get; } = new List<AccountCommonPartnerReport>();

    //public virtual ICollection<AccountCommonReport> AccountCommonReports { get; } = new List<AccountCommonReport>();

    public virtual AccountAccount? AccountDefaultPosReceivableAccount { get; set; }

    //public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOps { get; } = new List<AccountFinancialYearOp>();

    public virtual ResCountry? AccountFiscalCountry { get; set; }

    //public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccounts { get; } = new List<AccountFiscalPositionAccount>();

    //public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxes { get; } = new List<AccountFiscalPositionTax>();

    //public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    //public virtual ICollection<AccountFiscalYear> AccountFiscalYears { get; } = new List<AccountFiscalYear>();

    //public virtual ICollection<AccountGroup> AccountGroups { get; } = new List<AccountGroup>();

    public virtual AccountAccount? AccountJournalEarlyPayDiscountGainAccount { get; set; }

    public virtual AccountAccount? AccountJournalEarlyPayDiscountLossAccount { get; set; }

    //public virtual ICollection<AccountJournalGroup> AccountJournalGroups { get; } = new List<AccountJournalGroup>();

    public virtual AccountAccount? AccountJournalPaymentCreditAccount { get; set; }

    public virtual AccountAccount? AccountJournalPaymentDebitAccount { get; set; }

    public virtual AccountAccount? AccountJournalSuspenseAccount { get; set; }

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMoveReversal> AccountMoveReversals { get; } = new List<AccountMoveReversal>();

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual AccountMove? AccountOpeningMove { get; set; }

    //public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; } = new List<AccountPartialReconcile>();

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPaymentTerm> AccountPaymentTerms { get; } = new List<AccountPaymentTerm>();

    //public virtual ICollection<AccountPrintJournal> AccountPrintJournals { get; } = new List<AccountPrintJournal>();

    public virtual AccountTax? AccountPurchaseTax { get; set; }

    //public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; } = new List<AccountReconcileModelLine>();

    //public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    //public virtual ICollection<AccountRecurringTemplate> AccountRecurringTemplates { get; } = new List<AccountRecurringTemplate>();

    //public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    //public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgers { get; } = new List<AccountReportGeneralLedger>();

    //public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgers { get; } = new List<AccountReportPartnerLedger>();

    public virtual AccountTax? AccountSaleTax { get; set; }

    //public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLines { get; } = new List<AccountTaxRepartitionLine>();

    //public virtual ICollection<AccountTaxReportWizard> AccountTaxReportWizards { get; } = new List<AccountTaxReportWizard>();

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    //public virtual ICollection<AccountingReport> AccountingReports { get; } = new List<AccountingReport>();

    public virtual AccountJournal? AutomaticEntryDefaultJournal { get; set; }

    //public virtual ICollection<BaseDocumentLayout> BaseDocumentLayouts { get; } = new List<BaseDocumentLayout>();

    //public virtual ICollection<ChangeLockDate> ChangeLockDates { get; } = new List<ChangeLockDate>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual AccountJournal? CompanyExpenseJournal { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    //public virtual ICollection<CrmTeam> CrmTeams { get; } = new List<CrmTeam>();

    //public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLines { get; } = new List<CrossoveredBudgetLine>();

    //public virtual ICollection<CrossoveredBudget> CrossoveredBudgets { get; } = new List<CrossoveredBudget>();

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountJournal? CurrencyExchangeJournal { get; set; }

    public virtual AccountAccount? DefaultCashDifferenceExpenseAccount { get; set; }

    public virtual AccountAccount? DefaultCashDifferenceIncomeAccount { get; set; }

    //public virtual ICollection<DigestDigest> DigestDigests { get; } = new List<DigestDigest>();

    public virtual AccountAccount? ExpenseAccrualAccount { get; set; }

    public virtual AccountAccount? ExpenseCurrencyExchangeAccount { get; set; }

    public virtual AccountJournal? ExpenseJournal { get; set; }

    public virtual IrUiView? ExternalReportLayout { get; set; }

    //public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; } = new List<FleetVehicleLogContract>();

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    //public virtual ICollection<FleetVehicle> FleetVehicles { get; } = new List<FleetVehicle>();

    public virtual FollowupFollowup? FollowupFollowup { get; set; }

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    //public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();

    //public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    //public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    //public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    //public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationEmployeeCompanies { get; } = new List<HrLeaveAllocation>();

    //public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationModeCompanies { get; } = new List<HrLeaveAllocation>();

    //public virtual ICollection<HrLeave> HrLeaveEmployeeCompanies { get; } = new List<HrLeave>();

    //public virtual ICollection<HrLeave> HrLeaveModeCompanies { get; } = new List<HrLeave>();

    //public virtual ICollection<HrLeaveStressDay> HrLeaveStressDays { get; } = new List<HrLeaveStressDay>();

    //public virtual ICollection<HrLeaveType> HrLeaveTypes { get; } = new List<HrLeaveType>();

    //public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; } = new List<HrPlanActivityType>();

    //public virtual ICollection<HrPlan> HrPlans { get; } = new List<HrPlan>();

    //public virtual ICollection<HrWorkLocation> HrWorkLocations { get; } = new List<HrWorkLocation>();

    public virtual AccountAccount? IncomeCurrencyExchangeAccount { get; set; }

    public virtual AccountIncoterm? Incoterm { get; set; }

    public virtual StockLocation? InternalTransitLocation { get; set; }

    //public virtual ICollection<ResCompany> InverseParent { get; } = new List<ResCompany>();

    //public virtual ICollection<IrAttachment> IrAttachments { get; } = new List<IrAttachment>();

    //public virtual ICollection<IrDefault> IrDefaults { get; } = new List<IrDefault>();

    //public virtual ICollection<IrProperty> IrProperties { get; } = new List<IrProperty>();

    //public virtual ICollection<IrSequence> IrSequences { get; } = new List<IrSequence>();

    //public virtual ICollection<LunchLocation> LunchLocations { get; } = new List<LunchLocation>();

    //public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    //public virtual ICollection<LunchProductCategory> LunchProductCategories { get; } = new List<LunchProductCategory>();

    //public virtual ICollection<LunchProduct> LunchProducts { get; } = new List<LunchProduct>();

    //public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();

    //public virtual ICollection<LunchTopping> LunchToppings { get; } = new List<LunchTopping>();

    //public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; } = new List<MaintenanceEquipmentCategory>();

    //public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    //public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    //public virtual ICollection<MaintenanceTeam> MaintenanceTeams { get; } = new List<MaintenanceTeam>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    //public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    //public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    //public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    //public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    //public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    //public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    //public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; } = new List<MrpWorkcenter>();

    public virtual BarcodeNomenclature? Nomenclature { get; set; }

    //public virtual ICollection<NoteNote> NoteNotes { get; } = new List<NoteNote>();

    public virtual ReportPaperformat? Paperformat { get; set; }

    public virtual ResCompany? Parent { get; set; }

    public virtual ResPartner? Partner { get; set; }

    //public virtual ICollection<PaymentProvider> PaymentProviders { get; } = new List<PaymentProvider>();

    //public virtual ICollection<PaymentToken> PaymentTokens { get; } = new List<PaymentToken>();

    //public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    //public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    //public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    //public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    //public virtual ICollection<PosPaymentMethod> PosPaymentMethods { get; } = new List<PosPaymentMethod>();

    //public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    //public virtual ICollection<ProductPackaging> ProductPackagings { get; } = new List<ProductPackaging>();

    //public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; } = new List<ProductPricelistItem>();

    //public virtual ICollection<ProductPricelist> ProductPricelists { get; } = new List<ProductPricelist>();

    //public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    //public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    //public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    public virtual AccountAccount? PropertyStockAccountInputCateg { get; set; }

    public virtual AccountAccount? PropertyStockAccountOutputCateg { get; set; }

    public virtual AccountAccount? PropertyStockValuationAccount { get; set; }

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    //public virtual ICollection<RecurringPayment> RecurringPayments { get; } = new List<RecurringPayment>();

    //public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    //public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    //public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<ResCurrencyRate> ResCurrencyRates { get; } = new List<ResCurrencyRate>();

    //public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    //public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    //public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; } = new List<ResourceCalendarLeaf>();

    //public virtual ICollection<ResourceCalendar> ResourceCalendars { get; } = new List<ResourceCalendar>();

    //public virtual ICollection<ResourceResource> ResourceResources { get; } = new List<ResourceResource>();

    public virtual AccountAccount? RevenueAccrualAccount { get; set; }

    //public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    //public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; } = new List<SaleOrderTemplateLine>();

    //public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; } = new List<SaleOrderTemplateOption>();

    //public virtual ICollection<SaleOrderTemplate> SaleOrderTemplates { get; } = new List<SaleOrderTemplate>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    //public virtual ICollection<StockLocation> StockLocations { get; } = new List<StockLocation>();

    //public virtual ICollection<StockLot> StockLots { get; } = new List<StockLot>();

    public virtual MailTemplate? StockMailConfirmationTemplate { get; set; }

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    //public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    //public virtual ICollection<StockPackageType> StockPackageTypes { get; } = new List<StockPackageType>();

    //public virtual ICollection<StockPickingType> StockPickingTypes { get; } = new List<StockPickingType>();

    //public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    //public virtual ICollection<StockPutawayRule> StockPutawayRules { get; } = new List<StockPutawayRule>();

    //public virtual ICollection<StockQuantPackage> StockQuantPackages { get; } = new List<StockQuantPackage>();

    //public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    //public virtual ICollection<StockRoute> StockRoutes { get; } = new List<StockRoute>();

    //public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    //public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    public virtual SmsTemplate? StockSmsConfirmationTemplate { get; set; }

    //public virtual ICollection<StockStorageCategory> StockStorageCategories { get; } = new List<StockStorageCategory>();

    //public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; } = new List<StockValuationLayerRevaluation>();

    //public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    //public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    //public virtual ICollection<StockWarehouse> StockWarehouses { get; } = new List<StockWarehouse>();

    public virtual AccountJournal? TaxCashBasisJournal { get; set; }

    public virtual AccountAccount? TransferAccount { get; set; }

    //public virtual ICollection<UtmCampaign> UtmCampaigns { get; } = new List<UtmCampaign>();

    public virtual Website? Website { get; set; }

    //public virtual ICollection<Website> Websites { get; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<IapAccount> IapAccounts { get; } = new List<IapAccount>();

    //public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
