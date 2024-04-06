﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_company")]
[Index("Name", Name = "res_company_name_uniq", IsUnique = true)]
[Index("ParentId", Name = "res_company_parent_id_index")]
public partial class ResCompany
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("sequence")]
    public long? Sequence { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("paperformat_id")]
    public long? PaperformatId { get; set; }

    [Column("external_report_layout_id")]
    public Guid? ExternalReportLayoutId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("phone")]
    public string? Phone { get; set; }

    [Column("mobile")]
    public string? Mobile { get; set; }

    [Column("base_onboarding_company_state")]
    public string? BaseOnboardingCompanyState { get; set; }

    [Column("font")]
    public string? Font { get; set; }

    [Column("primary_color")]
    public string? PrimaryColor { get; set; }

    [Column("secondary_color")]
    public string? SecondaryColor { get; set; }

    [Column("layout_background")]
    public string? LayoutBackground { get; set; }

    [Column("report_footer", TypeName = "jsonb")]
    public string? ReportFooter { get; set; }

    [Column("report_header")]
    public string? ReportHeader { get; set; }

    [Column("company_details")]
    public string? CompanyDetails { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("logo_web")]
    public byte[]? LogoWeb { get; set; }

    [Column("resource_calendar_id")]
    public Guid? ResourceCalendarId { get; set; }

    [Column("partner_gid")]
    public Guid? PartnerGid { get; set; }

    [Column("iap_enrich_auto_done")]
    public bool? IapEnrichAutoDone { get; set; }

    [Column("snailmail_color")]
    public bool? SnailmailColor { get; set; }

    [Column("snailmail_cover")]
    public bool? SnailmailCover { get; set; }

    [Column("snailmail_duplex")]
    public bool? SnailmailDuplex { get; set; }

    [Column("payment_provider_onboarding_state")]
    public string? PaymentProviderOnboardingState { get; set; }

    [Column("payment_onboarding_payment_method")]
    public string? PaymentOnboardingPaymentMethod { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("fiscalyear_last_day")]
    public long? FiscalyearLastDay { get; set; }

    [Column("transfer_account_id")]
    public Guid? TransferAccountId { get; set; }

    [Column("chart_template_id")]
    public Guid? ChartTemplateId { get; set; }

    [Column("default_cash_difference_income_account_id")]
    public Guid? DefaultCashDifferenceIncomeAccountId { get; set; }

    [Column("default_cash_difference_expense_account_id")]
    public Guid? DefaultCashDifferenceExpenseAccountId { get; set; }

    [Column("account_journal_suspense_account_id")]
    public Guid? AccountJournalSuspenseAccountId { get; set; }

    [Column("account_journal_payment_debit_account_id")]
    public Guid? AccountJournalPaymentDebitAccountId { get; set; }

    [Column("account_journal_payment_credit_account_id")]
    public Guid? AccountJournalPaymentCreditAccountId { get; set; }

    [Column("account_journal_early_pay_discount_gain_account_id")]
    public Guid? AccountJournalEarlyPayDiscountGainAccountId { get; set; }

    [Column("account_journal_early_pay_discount_loss_account_id")]
    public Guid? AccountJournalEarlyPayDiscountLossAccountId { get; set; }

    [Column("account_sale_tax_id")]
    public Guid? AccountSaleTaxId { get; set; }

    [Column("account_purchase_tax_id")]
    public Guid? AccountPurchaseTaxId { get; set; }

    [Column("currency_exchange_journal_id")]
    public Guid? CurrencyExchangeJournalId { get; set; }

    [Column("income_currency_exchange_account_id")]
    public Guid? IncomeCurrencyExchangeAccountId { get; set; }

    [Column("expense_currency_exchange_account_id")]
    public Guid? ExpenseCurrencyExchangeAccountId { get; set; }

    [Column("property_stock_account_input_categ_id")]
    public Guid? PropertyStockAccountInputCategId { get; set; }

    [Column("property_stock_account_output_categ_id")]
    public Guid? PropertyStockAccountOutputCategId { get; set; }

    [Column("property_stock_valuation_account_id")]
    public Guid? PropertyStockValuationAccountId { get; set; }

    [Column("incoterm_id")]
    public Guid? IncotermId { get; set; }

    [Column("account_opening_move_id")]
    public Guid? AccountOpeningMoveId { get; set; }

    [Column("account_default_pos_receivable_account_id")]
    public Guid? AccountDefaultPosReceivableAccountId { get; set; }

    [Column("expense_accrual_account_id")]
    public Guid? ExpenseAccrualAccountId { get; set; }

    [Column("revenue_accrual_account_id")]
    public Guid? RevenueAccrualAccountId { get; set; }

    [Column("automatic_entry_default_journal_id")]
    public Guid? AutomaticEntryDefaultJournalId { get; set; }

    [Column("account_fiscal_country_id")]
    public long? AccountFiscalCountryId { get; set; }

    [Column("tax_cash_basis_journal_id")]
    public Guid? TaxCashBasisJournalId { get; set; }

    [Column("account_cash_basis_base_account_id")]
    public Guid? AccountCashBasisBaseAccountId { get; set; }

    [Column("fiscalyear_last_month")]
    public string? FiscalyearLastMonth { get; set; }

    [Column("bank_account_code_prefix")]
    public string? BankAccountCodePrefix { get; set; }

    [Column("cash_account_code_prefix")]
    public string? CashAccountCodePrefix { get; set; }

    [Column("early_pay_discount_computation")]
    public string? EarlyPayDiscountComputation { get; set; }

    [Column("transfer_account_code_prefix")]
    public string? TransferAccountCodePrefix { get; set; }

    [Column("tax_calculation_rounding_method")]
    public string? TaxCalculationRoundingMethod { get; set; }

    [Column("account_setup_bank_data_state")]
    public string? AccountSetupBankDataState { get; set; }

    [Column("account_setup_fy_data_state")]
    public string? AccountSetupFyDataState { get; set; }

    [Column("account_setup_coa_state")]
    public string? AccountSetupCoaState { get; set; }

    [Column("account_setup_taxes_state")]
    public string? AccountSetupTaxesState { get; set; }

    [Column("account_onboarding_invoice_layout_state")]
    public string? AccountOnboardingInvoiceLayoutState { get; set; }

    [Column("account_onboarding_sale_tax_state")]
    public string? AccountOnboardingSaleTaxState { get; set; }

    [Column("account_invoice_onboarding_state")]
    public string? AccountInvoiceOnboardingState { get; set; }

    [Column("account_dashboard_onboarding_state")]
    public string? AccountDashboardOnboardingState { get; set; }

    [Column("terms_type")]
    public string? TermsType { get; set; }

    [Column("account_setup_bill_state")]
    public string? AccountSetupBillState { get; set; }

    [Column("quick_edit_mode")]
    public string? QuickEditMode { get; set; }

    [Column("period_lock_date")]
    public DateOnly? PeriodLockDate { get; set; }

    [Column("fiscalyear_lock_date")]
    public DateOnly? FiscalyearLockDate { get; set; }

    [Column("tax_lock_date")]
    public DateOnly? TaxLockDate { get; set; }

    [Column("account_opening_date")]
    public DateOnly? AccountOpeningDate { get; set; }

    [Column("invoice_terms", TypeName = "jsonb")]
    public string? InvoiceTerms { get; set; }

    [Column("invoice_terms_html", TypeName = "jsonb")]
    public string? InvoiceTermsHtml { get; set; }

    [Column("expects_chart_of_accounts")]
    public bool? ExpectsChartOfAccounts { get; set; }

    [Column("anglo_saxon_accounting")]
    public bool? AngloSaxonAccounting { get; set; }

    [Column("qr_code")]
    public bool? QrCode { get; set; }

    [Column("invoice_is_email")]
    public bool? InvoiceIsEmail { get; set; }

    [Column("invoice_is_print")]
    public bool? InvoiceIsPrint { get; set; }

    [Column("account_use_credit_limit")]
    public bool? AccountUseCreditLimit { get; set; }

    [Column("account_onboarding_create_invoice_state_flag")]
    public bool? AccountOnboardingCreateInvoiceStateFlag { get; set; }

    [Column("tax_exigibility")]
    public bool? TaxExigibility { get; set; }

    [Column("account_storno")]
    public bool? AccountStorno { get; set; }

    [Column("invoice_is_snailmail")]
    public bool? InvoiceIsSnailmail { get; set; }

    [Column("quotation_validity_days")]
    public long? QuotationValidityDays { get; set; }

    [Column("sale_quotation_onboarding_state")]
    public string? SaleQuotationOnboardingState { get; set; }

    [Column("sale_onboarding_order_confirmation_state")]
    public string? SaleOnboardingOrderConfirmationState { get; set; }

    [Column("sale_onboarding_sample_quotation_state")]
    public string? SaleOnboardingSampleQuotationState { get; set; }

    [Column("sale_onboarding_payment_method")]
    public string? SaleOnboardingPaymentMethod { get; set; }

    [Column("portal_confirmation_sign")]
    public bool? PortalConfirmationSign { get; set; }

    [Column("portal_confirmation_pay")]
    public bool? PortalConfirmationPay { get; set; }

    [Column("sale_order_template_id")]
    public Guid? SaleOrderTemplateId { get; set; }

    [Column("vat_check_vies")]
    public bool? VatCheckVies { get; set; }

    [Column("nomenclature_id")]
    public long? NomenclatureId { get; set; }

    [Column("internal_transit_location_id")]
    public Guid? InternalTransitLocationId { get; set; }

    [Column("stock_mail_confirmation_template_id")]
    public Guid? StockMailConfirmationTemplateId { get; set; }

    [Column("annual_inventory_day")]
    public long? AnnualInventoryDay { get; set; }

    [Column("annual_inventory_month")]
    public string? AnnualInventoryMonth { get; set; }

    [Column("stock_move_email_validation")]
    public bool? StockMoveEmailValidation { get; set; }

    [Column("stock_sms_confirmation_template_id")]
    public Guid? StockSmsConfirmationTemplateId { get; set; }

    [Column("stock_move_sms_validation")]
    public bool? StockMoveSmsValidation { get; set; }

    [Column("has_received_warning_stock_sms")]
    public bool? HasReceivedWarningStockSms { get; set; }

    [Column("point_of_sale_update_stock_quantities")]
    public string? PointOfSaleUpdateStockQuantities { get; set; }

    [Column("point_of_sale_use_ticket_qr_code")]
    public bool? PointOfSaleUseTicketQrCode { get; set; }

    [Column("security_lead")]
    public double? SecurityLead { get; set; }

    [Column("po_lock")]
    public string? PoLock { get; set; }

    [Column("po_double_validation")]
    public string? PoDoubleValidation { get; set; }

    [Column("po_double_validation_amount")]
    public decimal? PoDoubleValidationAmount { get; set; }

    [Column("po_lead")]
    public double? PoLead { get; set; }

    [Column("days_to_purchase")]
    public double? DaysToPurchase { get; set; }

    [Column("manufacturing_lead")]
    public double? ManufacturingLead { get; set; }

    [Column("hr_presence_control_email_amount")]
    public Guid? HrPresenceControlEmailAmount { get; set; }

    [Column("hr_presence_control_ip_list")]
    public string? HrPresenceControlIpList { get; set; }

    [Column("expense_journal_id")]
    public Guid? ExpenseJournalId { get; set; }

    [Column("company_expense_journal_id")]
    public Guid? CompanyExpenseJournalId { get; set; }

    [Column("lunch_notify_message", TypeName = "jsonb")]
    public string? LunchNotifyMessage { get; set; }

    [Column("lunch_minimum_threshold")]
    public double? LunchMinimumThreshold { get; set; }

    [Column("overtime_company_threshold")]
    public Guid? OvertimeCompanyThreshold { get; set; }

    [Column("overtime_employee_threshold")]
    public Guid? OvertimeEmployeeThreshold { get; set; }

    [Column("attendance_kiosk_delay")]
    public Guid? AttendanceKioskDelay { get; set; }

    [Column("attendance_kiosk_mode")]
    public string? AttendanceKioskMode { get; set; }

    [Column("attendance_barcode_source")]
    public string? AttendanceBarcodeSource { get; set; }

    [Column("overtime_start_date")]
    public DateOnly? OvertimeStartDate { get; set; }

    [Column("hr_attendance_overtime")]
    public bool? HrAttendanceOvertime { get; set; }

    [Column("social_twitter")]
    public string? SocialTwitter { get; set; }

    [Column("social_facebook")]
    public string? SocialFacebook { get; set; }

    [Column("social_github")]
    public string? SocialGithub { get; set; }

    [Column("social_linkedin")]
    public string? SocialLinkedin { get; set; }

    [Column("social_youtube")]
    public string? SocialYoutube { get; set; }

    [Column("social_instagram")]
    public string? SocialInstagram { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("website_sale_onboarding_payment_provider_state")]
    public string? WebsiteSaleOnboardingPaymentProviderState { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; } = new List<AccountAccruedOrdersWizard>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalances { get; } = new List<AccountAgedTrialBalance>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; } = new List<AccountAnalyticAccount>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlans { get; } = new List<AccountAnalyticPlan>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategories { get; } = new List<AccountAssetCategory>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizards { get; } = new List<AccountAutomaticEntryWizard>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountBalanceReport> AccountBalanceReports { get; } = new List<AccountBalanceReport>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountBankStatement> AccountBankStatements { get; } = new List<AccountBankStatement>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountBudgetPost> AccountBudgetPosts { get; } = new List<AccountBudgetPost>();

    [ForeignKey("AccountCashBasisBaseAccountId")]
    [InverseProperty("ResCompanyAccountCashBasisBaseAccounts")]
    public virtual AccountAccount? AccountCashBasisBaseAccount { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountCommonJournalReport> AccountCommonJournalReports { get; } = new List<AccountCommonJournalReport>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReports { get; } = new List<AccountCommonPartnerReport>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountCommonReport> AccountCommonReports { get; } = new List<AccountCommonReport>();

    [ForeignKey("AccountDefaultPosReceivableAccountId")]
    [InverseProperty("ResCompanyAccountDefaultPosReceivableAccounts")]
    public virtual AccountAccount? AccountDefaultPosReceivableAccount { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOps { get; } = new List<AccountFinancialYearOp>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccounts { get; } = new List<AccountFiscalPositionAccount>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxes { get; } = new List<AccountFiscalPositionTax>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountFiscalYear> AccountFiscalYears { get; } = new List<AccountFiscalYear>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountGroup> AccountGroups { get; } = new List<AccountGroup>();

    [ForeignKey("AccountJournalEarlyPayDiscountGainAccountId")]
    [InverseProperty("ResCompanyAccountJournalEarlyPayDiscountGainAccounts")]
    public virtual AccountAccount? AccountJournalEarlyPayDiscountGainAccount { get; set; }

    [ForeignKey("AccountJournalEarlyPayDiscountLossAccountId")]
    [InverseProperty("ResCompanyAccountJournalEarlyPayDiscountLossAccounts")]
    public virtual AccountAccount? AccountJournalEarlyPayDiscountLossAccount { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<AccountJournalGroup> AccountJournalGroups { get; } = new List<AccountJournalGroup>();

    [ForeignKey("AccountJournalPaymentCreditAccountId")]
    [InverseProperty("ResCompanyAccountJournalPaymentCreditAccounts")]
    public virtual AccountAccount? AccountJournalPaymentCreditAccount { get; set; }

    [ForeignKey("AccountJournalPaymentDebitAccountId")]
    [InverseProperty("ResCompanyAccountJournalPaymentDebitAccounts")]
    public virtual AccountAccount? AccountJournalPaymentDebitAccount { get; set; }

    [ForeignKey("AccountJournalSuspenseAccountId")]
    [InverseProperty("ResCompanyAccountJournalSuspenseAccounts")]
    public virtual AccountAccount? AccountJournalSuspenseAccount { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountMoveReversal> AccountMoveReversals { get; } = new List<AccountMoveReversal>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [ForeignKey("AccountOpeningMoveId")]
    [InverseProperty("ResCompanies")]
    public virtual AccountMove? AccountOpeningMove { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; } = new List<AccountPartialReconcile>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountPaymentTerm> AccountPaymentTerms { get; } = new List<AccountPaymentTerm>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountPrintJournal> AccountPrintJournals { get; } = new List<AccountPrintJournal>();

    [ForeignKey("AccountPurchaseTaxId")]
    [InverseProperty("ResCompanyAccountPurchaseTaxes")]
    public virtual AccountTax? AccountPurchaseTax { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; } = new List<AccountReconcileModelLine>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountRecurringTemplate> AccountRecurringTemplates { get; } = new List<AccountRecurringTemplate>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgers { get; } = new List<AccountReportGeneralLedger>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgers { get; } = new List<AccountReportPartnerLedger>();

    [ForeignKey("AccountSaleTaxId")]
    [InverseProperty("ResCompanyAccountSaleTaxes")]
    public virtual AccountTax? AccountSaleTax { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLines { get; } = new List<AccountTaxRepartitionLine>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountTaxReportWizard> AccountTaxReportWizards { get; } = new List<AccountTaxReportWizard>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    [InverseProperty("Company")]
    public virtual ICollection<AccountingReport> AccountingReports { get; } = new List<AccountingReport>();

    [ForeignKey("AutomaticEntryDefaultJournalId")]
    [InverseProperty("ResCompanyAutomaticEntryDefaultJournals")]
    public virtual AccountJournal? AutomaticEntryDefaultJournal { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<BaseDocumentLayout> BaseDocumentLayouts { get; } = new List<BaseDocumentLayout>();

    [InverseProperty("Company")]
    public virtual ICollection<ChangeLockDate> ChangeLockDates { get; } = new List<ChangeLockDate>();

    [ForeignKey("ChartTemplateId")]
    [InverseProperty("ResCompanies")]
    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    [ForeignKey("CompanyExpenseJournalId")]
    [InverseProperty("ResCompanyCompanyExpenseJournals")]
    public virtual AccountJournal? CompanyExpenseJournal { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResCompanyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [InverseProperty("Company")]
    public virtual ICollection<CrmTeam> CrmTeams { get; } = new List<CrmTeam>();

    [InverseProperty("Company")]
    public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLines { get; } = new List<CrossoveredBudgetLine>();

    [InverseProperty("Company")]
    public virtual ICollection<CrossoveredBudget> CrossoveredBudgets { get; } = new List<CrossoveredBudget>();

    [ForeignKey("CurrencyExchangeJournalId")]
    [InverseProperty("ResCompanyCurrencyExchangeJournals")]
    public virtual AccountJournal? CurrencyExchangeJournal { get; set; }

    [ForeignKey("DefaultCashDifferenceExpenseAccountId")]
    [InverseProperty("ResCompanyDefaultCashDifferenceExpenseAccounts")]
    public virtual AccountAccount? DefaultCashDifferenceExpenseAccount { get; set; }

    [ForeignKey("DefaultCashDifferenceIncomeAccountId")]
    [InverseProperty("ResCompanyDefaultCashDifferenceIncomeAccounts")]
    public virtual AccountAccount? DefaultCashDifferenceIncomeAccount { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<DigestDigest> DigestDigests { get; } = new List<DigestDigest>();

    [ForeignKey("ExpenseAccrualAccountId")]
    [InverseProperty("ResCompanyExpenseAccrualAccounts")]
    public virtual AccountAccount? ExpenseAccrualAccount { get; set; }

    [ForeignKey("ExpenseCurrencyExchangeAccountId")]
    [InverseProperty("ResCompanyExpenseCurrencyExchangeAccounts")]
    public virtual AccountAccount? ExpenseCurrencyExchangeAccount { get; set; }

    [ForeignKey("ExpenseJournalId")]
    [InverseProperty("ResCompanyExpenseJournals")]
    public virtual AccountJournal? ExpenseJournal { get; set; }

    [ForeignKey("ExternalReportLayoutId")]
    [InverseProperty("ResCompanies")]
    public virtual IrUiView? ExternalReportLayout { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; } = new List<FleetVehicleLogContract>();

    [InverseProperty("Company")]
    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    [InverseProperty("Company")]
    public virtual ICollection<FleetVehicle> FleetVehicles { get; } = new List<FleetVehicle>();

    [InverseProperty("Company")]
    public virtual FollowupFollowup? FollowupFollowup { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    [InverseProperty("Company")]
    public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    [InverseProperty("Company")]
    public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();

    [InverseProperty("Company")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [InverseProperty("Company")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    [InverseProperty("Company")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    [InverseProperty("Company")]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    [InverseProperty("Company")]
    public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    [InverseProperty("EmployeeCompany")]
    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationEmployeeCompanies { get; } = new List<HrLeaveAllocation>();

    [InverseProperty("ModeCompany")]
    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationModeCompanies { get; } = new List<HrLeaveAllocation>();

    [InverseProperty("EmployeeCompany")]
    public virtual ICollection<HrLeave> HrLeaveEmployeeCompanies { get; } = new List<HrLeave>();

    [InverseProperty("ModeCompany")]
    public virtual ICollection<HrLeave> HrLeaveModeCompanies { get; } = new List<HrLeave>();

    [InverseProperty("Company")]
    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDays { get; } = new List<HrLeaveStressDay>();

    [InverseProperty("Company")]
    public virtual ICollection<HrLeaveType> HrLeaveTypes { get; } = new List<HrLeaveType>();

    [InverseProperty("Company")]
    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; } = new List<HrPlanActivityType>();

    [InverseProperty("Company")]
    public virtual ICollection<HrPlan> HrPlans { get; } = new List<HrPlan>();

    [InverseProperty("Company")]
    public virtual ICollection<HrWorkLocation> HrWorkLocations { get; } = new List<HrWorkLocation>();

    [ForeignKey("IncomeCurrencyExchangeAccountId")]
    [InverseProperty("ResCompanyIncomeCurrencyExchangeAccounts")]
    public virtual AccountAccount? IncomeCurrencyExchangeAccount { get; set; }

    [ForeignKey("IncotermId")]
    [InverseProperty("ResCompanies")]
    public virtual AccountIncoterm? Incoterm { get; set; }

    [ForeignKey("InternalTransitLocationId")]
    [InverseProperty("ResCompanies")]
    public virtual StockLocation? InternalTransitLocation { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<ResCompany> InverseParent { get; } = new List<ResCompany>();

    [InverseProperty("Company")]
    public virtual ICollection<IrAttachment> IrAttachments { get; } = new List<IrAttachment>();

    [InverseProperty("Company")]
    public virtual ICollection<IrDefault> IrDefaults { get; } = new List<IrDefault>();

    [InverseProperty("Company")]
    public virtual ICollection<IrProperty> IrProperties { get; } = new List<IrProperty>();

    [InverseProperty("Company")]
    public virtual ICollection<IrSequence> IrSequences { get; } = new List<IrSequence>();

    [InverseProperty("Company")]
    public virtual ICollection<LunchLocation> LunchLocations { get; } = new List<LunchLocation>();

    [InverseProperty("Company")]
    public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    [InverseProperty("Company")]
    public virtual ICollection<LunchProductCategory> LunchProductCategories { get; } = new List<LunchProductCategory>();

    [InverseProperty("Company")]
    public virtual ICollection<LunchProduct> LunchProducts { get; } = new List<LunchProduct>();

    [InverseProperty("Company")]
    public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();

    [InverseProperty("Company")]
    public virtual ICollection<LunchTopping> LunchToppings { get; } = new List<LunchTopping>();

    [InverseProperty("Company")]
    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; } = new List<MaintenanceEquipmentCategory>();

    [InverseProperty("Company")]
    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    [InverseProperty("Company")]
    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    [InverseProperty("Company")]
    public virtual ICollection<MaintenanceTeam> MaintenanceTeams { get; } = new List<MaintenanceTeam>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("ResCompanies")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    [InverseProperty("Company")]
    public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    [InverseProperty("Company")]
    public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    [InverseProperty("Company")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    [InverseProperty("Company")]
    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    [InverseProperty("Company")]
    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    [InverseProperty("Company")]
    public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; } = new List<MrpWorkcenter>();

    [InverseProperty("Company")]
    public virtual ICollection<NoteNote> NoteNotes { get; } = new List<NoteNote>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual ResCompany? Parent { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("ResCompanies")]
    public virtual ResPartner? Partner { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<PaymentProvider> PaymentProviders { get; } = new List<PaymentProvider>();

    [InverseProperty("Company")]
    public virtual ICollection<PaymentToken> PaymentTokens { get; } = new List<PaymentToken>();

    [InverseProperty("Company")]
    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    [InverseProperty("Company")]
    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    [InverseProperty("Company")]
    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    [InverseProperty("Company")]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("Company")]
    public virtual ICollection<PosPaymentMethod> PosPaymentMethods { get; } = new List<PosPaymentMethod>();

    [InverseProperty("Company")]
    public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    [InverseProperty("Company")]
    public virtual ICollection<ProductPackaging> ProductPackagings { get; } = new List<ProductPackaging>();

    [InverseProperty("Company")]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; } = new List<ProductPricelistItem>();

    [InverseProperty("Company")]
    public virtual ICollection<ProductPricelist> ProductPricelists { get; } = new List<ProductPricelist>();

    [InverseProperty("Company")]
    public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    [InverseProperty("Company")]
    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    [InverseProperty("Company")]
    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    [InverseProperty("Company")]
    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    [InverseProperty("Company")]
    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    [ForeignKey("PropertyStockAccountInputCategId")]
    [InverseProperty("ResCompanyPropertyStockAccountInputCategs")]
    public virtual AccountAccount? PropertyStockAccountInputCateg { get; set; }

    [ForeignKey("PropertyStockAccountOutputCategId")]
    [InverseProperty("ResCompanyPropertyStockAccountOutputCategs")]
    public virtual AccountAccount? PropertyStockAccountOutputCateg { get; set; }

    [ForeignKey("PropertyStockValuationAccountId")]
    [InverseProperty("ResCompanyPropertyStockValuationAccounts")]
    public virtual AccountAccount? PropertyStockValuationAccount { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("Company")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    [InverseProperty("Company")]
    public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    [InverseProperty("Company")]
    public virtual ICollection<RecurringPayment> RecurringPayments { get; } = new List<RecurringPayment>();

    [InverseProperty("Company")]
    public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    [InverseProperty("Company")]
    public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    [InverseProperty("Company")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("Company")]
    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    [InverseProperty("Company")]
    public virtual ICollection<ResCurrencyRate> ResCurrencyRates { get; } = new List<ResCurrencyRate>();

    [InverseProperty("Company")]
    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    [InverseProperty("Company")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    [InverseProperty("Company")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    [ForeignKey("ResourceCalendarId")]
    [InverseProperty("ResCompanies")]
    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; } = new List<ResourceCalendarLeaf>();

    [InverseProperty("Company")]
    public virtual ICollection<ResourceCalendar> ResourceCalendars { get; } = new List<ResourceCalendar>();

    [InverseProperty("Company")]
    public virtual ICollection<ResourceResource> ResourceResources { get; } = new List<ResourceResource>();

    [ForeignKey("RevenueAccrualAccountId")]
    [InverseProperty("ResCompanyRevenueAccrualAccounts")]
    public virtual AccountAccount? RevenueAccrualAccount { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    [InverseProperty("Company")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [ForeignKey("SaleOrderTemplateId")]
    [InverseProperty("ResCompanies")]
    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; } = new List<SaleOrderTemplateLine>();

    [InverseProperty("Company")]
    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; } = new List<SaleOrderTemplateOption>();

    [InverseProperty("Company")]
    public virtual ICollection<SaleOrderTemplate> SaleOrderTemplates { get; } = new List<SaleOrderTemplate>();

    [InverseProperty("Company")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [InverseProperty("Company")]
    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    [InverseProperty("Company")]
    public virtual ICollection<StockLocation> StockLocations { get; } = new List<StockLocation>();

    [InverseProperty("Company")]
    public virtual ICollection<StockLot> StockLots { get; } = new List<StockLot>();

    [ForeignKey("StockMailConfirmationTemplateId")]
    [InverseProperty("ResCompanies")]
    public virtual MailTemplate? StockMailConfirmationTemplate { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("Company")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("Company")]
    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    [InverseProperty("Company")]
    public virtual ICollection<StockPackageType> StockPackageTypes { get; } = new List<StockPackageType>();

    [InverseProperty("Company")]
    public virtual ICollection<StockPickingType> StockPickingTypes { get; } = new List<StockPickingType>();

    [InverseProperty("Company")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    [InverseProperty("Company")]
    public virtual ICollection<StockPutawayRule> StockPutawayRules { get; } = new List<StockPutawayRule>();

    [InverseProperty("Company")]
    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; } = new List<StockQuantPackage>();

    [InverseProperty("Company")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    [InverseProperty("Company")]
    public virtual ICollection<StockRoute> StockRoutes { get; } = new List<StockRoute>();

    [InverseProperty("Company")]
    public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    [InverseProperty("Company")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [ForeignKey("StockSmsConfirmationTemplateId")]
    [InverseProperty("ResCompanies")]
    public virtual SmsTemplate? StockSmsConfirmationTemplate { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<StockStorageCategory> StockStorageCategories { get; } = new List<StockStorageCategory>();

    [InverseProperty("Company")]
    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; } = new List<StockValuationLayerRevaluation>();

    [InverseProperty("Company")]
    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    [InverseProperty("Company")]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    [InverseProperty("Company")]
    public virtual ICollection<StockWarehouse> StockWarehouses { get; } = new List<StockWarehouse>();

    [ForeignKey("TaxCashBasisJournalId")]
    [InverseProperty("ResCompanyTaxCashBasisJournals")]
    public virtual AccountJournal? TaxCashBasisJournal { get; set; }

    [ForeignKey("TransferAccountId")]
    [InverseProperty("ResCompanyTransferAccounts")]
    public virtual AccountAccount? TransferAccount { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<UtmCampaign> UtmCampaigns { get; } = new List<UtmCampaign>();

    [ForeignKey("WebsiteId")]
    [InverseProperty("ResCompanies")]
    public virtual Website? Website { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<Website> Websites { get; } = new List<Website>();

    [ForeignKey("WriteUid")]
    [InverseProperty("ResCompanyWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ResCompanyId")]
    [InverseProperty("ResCompanies")]
    public virtual ICollection<IapAccount> IapAccounts { get; } = new List<IapAccount>();

    [ForeignKey("Cid")]
    [InverseProperty("Cids")]
    public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}