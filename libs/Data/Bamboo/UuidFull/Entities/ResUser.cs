using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_users")]
[Index("Login", "WebsiteId", Name = "res_users_login_key", IsUnique = true)]
[Index("PartnerId", Name = "res_users_partner_id_index")]
public partial class ResUser
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("login")]
    public string? Login { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("action_id")]
    public Guid? ActionId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("signature")]
    public string? Signature { get; set; }

    [Column("share")]
    public bool? Share { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("totp_secret")]
    public string? TotpSecret { get; set; }

    [Column("notification_type")]
    public string? NotificationType { get; set; }

    [Column("odoobot_state")]
    public string? OdoobotState { get; set; }

    [Column("odoobot_failed")]
    public bool? OdoobotFailed { get; set; }

    [Column("sale_team_id")]
    public Guid? SaleTeamId { get; set; }

    [Column("target_sales_won")]
    public long? TargetSalesWon { get; set; }

    [Column("target_sales_done")]
    public long? TargetSalesDone { get; set; }

    [Column("target_sales_invoiced")]
    public long? TargetSalesInvoiced { get; set; }

    [Column("last_lunch_location_id")]
    public Guid? LastLunchLocationId { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAccount> AccountAccountCreateUs { get; } = new List<AccountAccount>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAccountTag> AccountAccountTagCreateUs { get; } = new List<AccountAccountTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAccountTag> AccountAccountTagWriteUs { get; } = new List<AccountAccountTag>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplateCreateUs { get; } = new List<AccountAccountTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplateWriteUs { get; } = new List<AccountAccountTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAccountType> AccountAccountTypeCreateUs { get; } = new List<AccountAccountType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAccountType> AccountAccountTypeWriteUs { get; } = new List<AccountAccountType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAccount> AccountAccountWriteUs { get; } = new List<AccountAccount>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizardCreateUs { get; } = new List<AccountAccruedOrdersWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizardWriteUs { get; } = new List<AccountAccruedOrdersWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalanceCreateUs { get; } = new List<AccountAgedTrialBalance>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalanceWriteUs { get; } = new List<AccountAgedTrialBalance>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountCreateUs { get; } = new List<AccountAnalyticAccount>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountWriteUs { get; } = new List<AccountAnalyticAccount>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilityCreateUs { get; } = new List<AccountAnalyticApplicability>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilityWriteUs { get; } = new List<AccountAnalyticApplicability>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModelCreateUs { get; } = new List<AccountAnalyticDistributionModel>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModelWriteUs { get; } = new List<AccountAnalyticDistributionModel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineCreateUs { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("User")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineUsers { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineWriteUs { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlanCreateUs { get; } = new List<AccountAnalyticPlan>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlanWriteUs { get; } = new List<AccountAnalyticPlan>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAssetAsset> AccountAssetAssetCreateUs { get; } = new List<AccountAssetAsset>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAssetAsset> AccountAssetAssetWriteUs { get; } = new List<AccountAssetAsset>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategoryCreateUs { get; } = new List<AccountAssetCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategoryWriteUs { get; } = new List<AccountAssetCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAssetDepreciationLine> AccountAssetDepreciationLineCreateUs { get; } = new List<AccountAssetDepreciationLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAssetDepreciationLine> AccountAssetDepreciationLineWriteUs { get; } = new List<AccountAssetDepreciationLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizardCreateUs { get; } = new List<AccountAutomaticEntryWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizardWriteUs { get; } = new List<AccountAutomaticEntryWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountBalanceReport> AccountBalanceReportCreateUs { get; } = new List<AccountBalanceReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountBalanceReport> AccountBalanceReportWriteUs { get; } = new List<AccountBalanceReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountBankStatement> AccountBankStatementCreateUs { get; } = new List<AccountBankStatement>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountBankStatementImport> AccountBankStatementImportCreateUs { get; } = new List<AccountBankStatementImport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountBankStatementImportJournalCreation> AccountBankStatementImportJournalCreationCreateUs { get; } = new List<AccountBankStatementImportJournalCreation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountBankStatementImportJournalCreation> AccountBankStatementImportJournalCreationWriteUs { get; } = new List<AccountBankStatementImportJournalCreation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountBankStatementImport> AccountBankStatementImportWriteUs { get; } = new List<AccountBankStatementImport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineCreateUs { get; } = new List<AccountBankStatementLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineWriteUs { get; } = new List<AccountBankStatementLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountBankStatement> AccountBankStatementWriteUs { get; } = new List<AccountBankStatement>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountBankbookReport> AccountBankbookReportCreateUs { get; } = new List<AccountBankbookReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountBankbookReport> AccountBankbookReportWriteUs { get; } = new List<AccountBankbookReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountBudgetPost> AccountBudgetPostCreateUs { get; } = new List<AccountBudgetPost>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountBudgetPost> AccountBudgetPostWriteUs { get; } = new List<AccountBudgetPost>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountCashRounding> AccountCashRoundingCreateUs { get; } = new List<AccountCashRounding>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountCashRounding> AccountCashRoundingWriteUs { get; } = new List<AccountCashRounding>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountCashbookReport> AccountCashbookReportCreateUs { get; } = new List<AccountCashbookReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountCashbookReport> AccountCashbookReportWriteUs { get; } = new List<AccountCashbookReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateCreateUs { get; } = new List<AccountChartTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateWriteUs { get; } = new List<AccountChartTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReportCreateUs { get; } = new List<AccountCommonAccountReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReportWriteUs { get; } = new List<AccountCommonAccountReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountCommonJournalReport> AccountCommonJournalReportCreateUs { get; } = new List<AccountCommonJournalReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountCommonJournalReport> AccountCommonJournalReportWriteUs { get; } = new List<AccountCommonJournalReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReportCreateUs { get; } = new List<AccountCommonPartnerReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReportWriteUs { get; } = new List<AccountCommonPartnerReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountCommonReport> AccountCommonReportCreateUs { get; } = new List<AccountCommonReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountCommonReport> AccountCommonReportWriteUs { get; } = new List<AccountCommonReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountDaybookReport> AccountDaybookReportCreateUs { get; } = new List<AccountDaybookReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountDaybookReport> AccountDaybookReportWriteUs { get; } = new List<AccountDaybookReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountEdiDocument> AccountEdiDocumentCreateUs { get; } = new List<AccountEdiDocument>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountEdiDocument> AccountEdiDocumentWriteUs { get; } = new List<AccountEdiDocument>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountEdiFormat> AccountEdiFormatCreateUs { get; } = new List<AccountEdiFormat>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountEdiFormat> AccountEdiFormatWriteUs { get; } = new List<AccountEdiFormat>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFinancialReport> AccountFinancialReportCreateUs { get; } = new List<AccountFinancialReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFinancialReport> AccountFinancialReportWriteUs { get; } = new List<AccountFinancialReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOpCreateUs { get; } = new List<AccountFinancialYearOp>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOpWriteUs { get; } = new List<AccountFinancialYearOp>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountCreateUs { get; } = new List<AccountFiscalPositionAccount>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateCreateUs { get; } = new List<AccountFiscalPositionAccountTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateWriteUs { get; } = new List<AccountFiscalPositionAccountTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountWriteUs { get; } = new List<AccountFiscalPositionAccount>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositionCreateUs { get; } = new List<AccountFiscalPosition>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxCreateUs { get; } = new List<AccountFiscalPositionTax>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateCreateUs { get; } = new List<AccountFiscalPositionTaxTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateWriteUs { get; } = new List<AccountFiscalPositionTaxTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxWriteUs { get; } = new List<AccountFiscalPositionTax>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplateCreateUs { get; } = new List<AccountFiscalPositionTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplateWriteUs { get; } = new List<AccountFiscalPositionTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositionWriteUs { get; } = new List<AccountFiscalPosition>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFiscalYear> AccountFiscalYearCreateUs { get; } = new List<AccountFiscalYear>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFiscalYear> AccountFiscalYearWriteUs { get; } = new List<AccountFiscalYear>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountFullReconcile> AccountFullReconcileCreateUs { get; } = new List<AccountFullReconcile>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountFullReconcile> AccountFullReconcileWriteUs { get; } = new List<AccountFullReconcile>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountGroup> AccountGroupCreateUs { get; } = new List<AccountGroup>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountGroupTemplate> AccountGroupTemplateCreateUs { get; } = new List<AccountGroupTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountGroupTemplate> AccountGroupTemplateWriteUs { get; } = new List<AccountGroupTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountGroup> AccountGroupWriteUs { get; } = new List<AccountGroup>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountIncoterm> AccountIncotermCreateUs { get; } = new List<AccountIncoterm>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountIncoterm> AccountIncotermWriteUs { get; } = new List<AccountIncoterm>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSendCreateUs { get; } = new List<AccountInvoiceSend>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSendWriteUs { get; } = new List<AccountInvoiceSend>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountJournal> AccountJournalCreateUs { get; } = new List<AccountJournal>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountJournalGroup> AccountJournalGroupCreateUs { get; } = new List<AccountJournalGroup>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountJournalGroup> AccountJournalGroupWriteUs { get; } = new List<AccountJournalGroup>();

    [InverseProperty("SaleActivityUser")]
    public virtual ICollection<AccountJournal> AccountJournalSaleActivityUsers { get; } = new List<AccountJournal>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountJournal> AccountJournalWriteUs { get; } = new List<AccountJournal>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountMove> AccountMoveCreateUs { get; } = new List<AccountMove>();

    [InverseProperty("InvoiceUser")]
    public virtual ICollection<AccountMove> AccountMoveInvoiceUsers { get; } = new List<AccountMove>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountMoveLine> AccountMoveLineCreateUs { get; } = new List<AccountMoveLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountMoveLine> AccountMoveLineWriteUs { get; } = new List<AccountMoveLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountMoveReversal> AccountMoveReversalCreateUs { get; } = new List<AccountMoveReversal>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountMoveReversal> AccountMoveReversalWriteUs { get; } = new List<AccountMoveReversal>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountMove> AccountMoveWriteUs { get; } = new List<AccountMove>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileCreateUs { get; } = new List<AccountPartialReconcile>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileWriteUs { get; } = new List<AccountPartialReconcile>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountPayment> AccountPaymentCreateUs { get; } = new List<AccountPayment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountPaymentMethod> AccountPaymentMethodCreateUs { get; } = new List<AccountPaymentMethod>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLineCreateUs { get; } = new List<AccountPaymentMethodLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLineWriteUs { get; } = new List<AccountPaymentMethodLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountPaymentMethod> AccountPaymentMethodWriteUs { get; } = new List<AccountPaymentMethod>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterCreateUs { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterWriteUs { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountPaymentTerm> AccountPaymentTermCreateUs { get; } = new List<AccountPaymentTerm>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountPaymentTermLine> AccountPaymentTermLineCreateUs { get; } = new List<AccountPaymentTermLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountPaymentTermLine> AccountPaymentTermLineWriteUs { get; } = new List<AccountPaymentTermLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountPaymentTerm> AccountPaymentTermWriteUs { get; } = new List<AccountPaymentTerm>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountPayment> AccountPaymentWriteUs { get; } = new List<AccountPayment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountPrintJournal> AccountPrintJournalCreateUs { get; } = new List<AccountPrintJournal>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountPrintJournal> AccountPrintJournalWriteUs { get; } = new List<AccountPrintJournal>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReconcileModel> AccountReconcileModelCreateUs { get; } = new List<AccountReconcileModel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLineCreateUs { get; } = new List<AccountReconcileModelLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplateCreateUs { get; } = new List<AccountReconcileModelLineTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplateWriteUs { get; } = new List<AccountReconcileModelLineTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLineWriteUs { get; } = new List<AccountReconcileModelLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappingCreateUs { get; } = new List<AccountReconcileModelPartnerMapping>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappingWriteUs { get; } = new List<AccountReconcileModelPartnerMapping>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplateCreateUs { get; } = new List<AccountReconcileModelTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplateWriteUs { get; } = new List<AccountReconcileModelTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReconcileModel> AccountReconcileModelWriteUs { get; } = new List<AccountReconcileModel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountRecurringTemplate> AccountRecurringTemplateCreateUs { get; } = new List<AccountRecurringTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountRecurringTemplate> AccountRecurringTemplateWriteUs { get; } = new List<AccountRecurringTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReportColumn> AccountReportColumnCreateUs { get; } = new List<AccountReportColumn>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReportColumn> AccountReportColumnWriteUs { get; } = new List<AccountReportColumn>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReport> AccountReportCreateUs { get; } = new List<AccountReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReportExpression> AccountReportExpressionCreateUs { get; } = new List<AccountReportExpression>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReportExpression> AccountReportExpressionWriteUs { get; } = new List<AccountReportExpression>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValueCreateUs { get; } = new List<AccountReportExternalValue>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValueWriteUs { get; } = new List<AccountReportExternalValue>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgerCreateUs { get; } = new List<AccountReportGeneralLedger>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgerWriteUs { get; } = new List<AccountReportGeneralLedger>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReportLine> AccountReportLineCreateUs { get; } = new List<AccountReportLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReportLine> AccountReportLineWriteUs { get; } = new List<AccountReportLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgerCreateUs { get; } = new List<AccountReportPartnerLedger>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgerWriteUs { get; } = new List<AccountReportPartnerLedger>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountReport> AccountReportWriteUs { get; } = new List<AccountReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountResequenceWizard> AccountResequenceWizardCreateUs { get; } = new List<AccountResequenceWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountResequenceWizard> AccountResequenceWizardWriteUs { get; } = new List<AccountResequenceWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigCreateUs { get; } = new List<AccountSetupBankManualConfig>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigWriteUs { get; } = new List<AccountSetupBankManualConfig>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountTax> AccountTaxCreateUs { get; } = new List<AccountTax>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountTaxGroup> AccountTaxGroupCreateUs { get; } = new List<AccountTaxGroup>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountTaxGroup> AccountTaxGroupWriteUs { get; } = new List<AccountTaxGroup>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineCreateUs { get; } = new List<AccountTaxRepartitionLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateCreateUs { get; } = new List<AccountTaxRepartitionLineTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateWriteUs { get; } = new List<AccountTaxRepartitionLineTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineWriteUs { get; } = new List<AccountTaxRepartitionLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountTaxReportWizard> AccountTaxReportWizardCreateUs { get; } = new List<AccountTaxReportWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountTaxReportWizard> AccountTaxReportWizardWriteUs { get; } = new List<AccountTaxReportWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplateCreateUs { get; } = new List<AccountTaxTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplateWriteUs { get; } = new List<AccountTaxTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountTax> AccountTaxWriteUs { get; } = new List<AccountTax>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountTourUploadBill> AccountTourUploadBillCreateUs { get; } = new List<AccountTourUploadBill>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountTourUploadBillEmailConfirm> AccountTourUploadBillEmailConfirmCreateUs { get; } = new List<AccountTourUploadBillEmailConfirm>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountTourUploadBillEmailConfirm> AccountTourUploadBillEmailConfirmWriteUs { get; } = new List<AccountTourUploadBillEmailConfirm>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountTourUploadBill> AccountTourUploadBillWriteUs { get; } = new List<AccountTourUploadBill>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountUnreconcile> AccountUnreconcileCreateUs { get; } = new List<AccountUnreconcile>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountUnreconcile> AccountUnreconcileWriteUs { get; } = new List<AccountUnreconcile>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AccountingReport> AccountingReportCreateUs { get; } = new List<AccountingReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AccountingReport> AccountingReportWriteUs { get; } = new List<AccountingReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasonCreateUs { get; } = new List<ApplicantGetRefuseReason>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasonWriteUs { get; } = new List<ApplicantGetRefuseReason>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ApplicantSendMail> ApplicantSendMailCreateUs { get; } = new List<ApplicantSendMail>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ApplicantSendMail> ApplicantSendMailWriteUs { get; } = new List<ApplicantSendMail>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AssetDepreciationConfirmationWizard> AssetDepreciationConfirmationWizardCreateUs { get; } = new List<AssetDepreciationConfirmationWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AssetDepreciationConfirmationWizard> AssetDepreciationConfirmationWizardWriteUs { get; } = new List<AssetDepreciationConfirmationWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AssetModify> AssetModifyCreateUs { get; } = new List<AssetModify>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AssetModify> AssetModifyWriteUs { get; } = new List<AssetModify>();

    [InverseProperty("User")]
    public virtual ICollection<AuthTotpDevice> AuthTotpDevices { get; } = new List<AuthTotpDevice>();

    [InverseProperty("CreateU")]
    public virtual ICollection<AuthTotpWizard> AuthTotpWizardCreateUs { get; } = new List<AuthTotpWizard>();

    [InverseProperty("User")]
    public virtual ICollection<AuthTotpWizard> AuthTotpWizardUsers { get; } = new List<AuthTotpWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<AuthTotpWizard> AuthTotpWizardWriteUs { get; } = new List<AuthTotpWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BarcodeNomenclature> BarcodeNomenclatureCreateUs { get; } = new List<BarcodeNomenclature>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BarcodeNomenclature> BarcodeNomenclatureWriteUs { get; } = new List<BarcodeNomenclature>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BarcodeRule> BarcodeRuleCreateUs { get; } = new List<BarcodeRule>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BarcodeRule> BarcodeRuleWriteUs { get; } = new List<BarcodeRule>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseDocumentLayout> BaseDocumentLayoutCreateUs { get; } = new List<BaseDocumentLayout>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseDocumentLayout> BaseDocumentLayoutWriteUs { get; } = new List<BaseDocumentLayout>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseEnableProfilingWizard> BaseEnableProfilingWizardCreateUs { get; } = new List<BaseEnableProfilingWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseEnableProfilingWizard> BaseEnableProfilingWizardWriteUs { get; } = new List<BaseEnableProfilingWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportImport> BaseImportImportCreateUs { get; } = new List<BaseImportImport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportImport> BaseImportImportWriteUs { get; } = new List<BaseImportImport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportMapping> BaseImportMappingCreateUs { get; } = new List<BaseImportMapping>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportMapping> BaseImportMappingWriteUs { get; } = new List<BaseImportMapping>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsChar> BaseImportTestsModelsCharCreateUs { get; } = new List<BaseImportTestsModelsChar>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlyCreateUs { get; } = new List<BaseImportTestsModelsCharNoreadonly>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlyWriteUs { get; } = new List<BaseImportTestsModelsCharNoreadonly>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlyCreateUs { get; } = new List<BaseImportTestsModelsCharReadonly>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlyWriteUs { get; } = new List<BaseImportTestsModelsCharReadonly>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequiredCreateUs { get; } = new List<BaseImportTestsModelsCharRequired>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequiredWriteUs { get; } = new List<BaseImportTestsModelsCharRequired>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStateCreateUs { get; } = new List<BaseImportTestsModelsCharState>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStateWriteUs { get; } = new List<BaseImportTestsModelsCharState>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlyCreateUs { get; } = new List<BaseImportTestsModelsCharStillreadonly>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlyWriteUs { get; } = new List<BaseImportTestsModelsCharStillreadonly>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsChar> BaseImportTestsModelsCharWriteUs { get; } = new List<BaseImportTestsModelsChar>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexCreateUs { get; } = new List<BaseImportTestsModelsComplex>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexWriteUs { get; } = new List<BaseImportTestsModelsComplex>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloatCreateUs { get; } = new List<BaseImportTestsModelsFloat>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloatWriteUs { get; } = new List<BaseImportTestsModelsFloat>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2oCreateUs { get; } = new List<BaseImportTestsModelsM2o>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelatedCreateUs { get; } = new List<BaseImportTestsModelsM2oRelated>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelatedWriteUs { get; } = new List<BaseImportTestsModelsM2oRelated>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequiredCreateUs { get; } = new List<BaseImportTestsModelsM2oRequired>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelatedCreateUs { get; } = new List<BaseImportTestsModelsM2oRequiredRelated>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelatedWriteUs { get; } = new List<BaseImportTestsModelsM2oRequiredRelated>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequiredWriteUs { get; } = new List<BaseImportTestsModelsM2oRequired>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2oWriteUs { get; } = new List<BaseImportTestsModelsM2o>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildCreateUs { get; } = new List<BaseImportTestsModelsO2mChild>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildWriteUs { get; } = new List<BaseImportTestsModelsO2mChild>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsO2m> BaseImportTestsModelsO2mCreateUs { get; } = new List<BaseImportTestsModelsO2m>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsO2m> BaseImportTestsModelsO2mWriteUs { get; } = new List<BaseImportTestsModelsO2m>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviewCreateUs { get; } = new List<BaseImportTestsModelsPreview>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviewWriteUs { get; } = new List<BaseImportTestsModelsPreview>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseLanguageExport> BaseLanguageExportCreateUs { get; } = new List<BaseLanguageExport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseLanguageExport> BaseLanguageExportWriteUs { get; } = new List<BaseLanguageExport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseLanguageImport> BaseLanguageImportCreateUs { get; } = new List<BaseLanguageImport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseLanguageImport> BaseLanguageImportWriteUs { get; } = new List<BaseLanguageImport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseLanguageInstall> BaseLanguageInstallCreateUs { get; } = new List<BaseLanguageInstall>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseLanguageInstall> BaseLanguageInstallWriteUs { get; } = new List<BaseLanguageInstall>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestCreateUs { get; } = new List<BaseModuleInstallRequest>();

    [InverseProperty("User")]
    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestUsers { get; } = new List<BaseModuleInstallRequest>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestWriteUs { get; } = new List<BaseModuleInstallRequest>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviewCreateUs { get; } = new List<BaseModuleInstallReview>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviewWriteUs { get; } = new List<BaseModuleInstallReview>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseModuleUninstall> BaseModuleUninstallCreateUs { get; } = new List<BaseModuleUninstall>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseModuleUninstall> BaseModuleUninstallWriteUs { get; } = new List<BaseModuleUninstall>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseModuleUpdate> BaseModuleUpdateCreateUs { get; } = new List<BaseModuleUpdate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseModuleUpdate> BaseModuleUpdateWriteUs { get; } = new List<BaseModuleUpdate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BaseModuleUpgrade> BaseModuleUpgradeCreateUs { get; } = new List<BaseModuleUpgrade>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BaseModuleUpgrade> BaseModuleUpgradeWriteUs { get; } = new List<BaseModuleUpgrade>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardCreateUs { get; } = new List<BasePartnerMergeAutomaticWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardWriteUs { get; } = new List<BasePartnerMergeAutomaticWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BasePartnerMergeLine> BasePartnerMergeLineCreateUs { get; } = new List<BasePartnerMergeLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BasePartnerMergeLine> BasePartnerMergeLineWriteUs { get; } = new List<BasePartnerMergeLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<BusBu> BusBuCreateUs { get; } = new List<BusBu>();

    [InverseProperty("WriteU")]
    public virtual ICollection<BusBu> BusBuWriteUs { get; } = new List<BusBu>();

    [InverseProperty("User")]
    public virtual BusPresence? BusPresence { get; set; }

    [InverseProperty("CreateU")]
    public virtual ICollection<CalendarAlarm> CalendarAlarmCreateUs { get; } = new List<CalendarAlarm>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CalendarAlarm> CalendarAlarmWriteUs { get; } = new List<CalendarAlarm>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CalendarAttendee> CalendarAttendeeCreateUs { get; } = new List<CalendarAttendee>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CalendarAttendee> CalendarAttendeeWriteUs { get; } = new List<CalendarAttendee>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CalendarEvent> CalendarEventCreateUs { get; } = new List<CalendarEvent>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CalendarEventType> CalendarEventTypeCreateUs { get; } = new List<CalendarEventType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CalendarEventType> CalendarEventTypeWriteUs { get; } = new List<CalendarEventType>();

    [InverseProperty("User")]
    public virtual ICollection<CalendarEvent> CalendarEventUsers { get; } = new List<CalendarEvent>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CalendarEvent> CalendarEventWriteUs { get; } = new List<CalendarEvent>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CalendarFilter> CalendarFilterCreateUs { get; } = new List<CalendarFilter>();

    [InverseProperty("User")]
    public virtual ICollection<CalendarFilter> CalendarFilterUsers { get; } = new List<CalendarFilter>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CalendarFilter> CalendarFilterWriteUs { get; } = new List<CalendarFilter>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CalendarProviderConfig> CalendarProviderConfigCreateUs { get; } = new List<CalendarProviderConfig>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CalendarProviderConfig> CalendarProviderConfigWriteUs { get; } = new List<CalendarProviderConfig>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CalendarRecurrence> CalendarRecurrenceCreateUs { get; } = new List<CalendarRecurrence>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CalendarRecurrence> CalendarRecurrenceWriteUs { get; } = new List<CalendarRecurrence>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ChangeLockDate> ChangeLockDateCreateUs { get; } = new List<ChangeLockDate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ChangeLockDate> ChangeLockDateWriteUs { get; } = new List<ChangeLockDate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ChangePasswordOwn> ChangePasswordOwnCreateUs { get; } = new List<ChangePasswordOwn>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ChangePasswordOwn> ChangePasswordOwnWriteUs { get; } = new List<ChangePasswordOwn>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ChangePasswordUser> ChangePasswordUserCreateUs { get; } = new List<ChangePasswordUser>();

    [InverseProperty("User")]
    public virtual ICollection<ChangePasswordUser> ChangePasswordUserUsers { get; } = new List<ChangePasswordUser>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ChangePasswordUser> ChangePasswordUserWriteUs { get; } = new List<ChangePasswordUser>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ChangePasswordWizard> ChangePasswordWizardCreateUs { get; } = new List<ChangePasswordWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ChangePasswordWizard> ChangePasswordWizardWriteUs { get; } = new List<ChangePasswordWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ChangeProductionQty> ChangeProductionQtyCreateUs { get; } = new List<ChangeProductionQty>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ChangeProductionQty> ChangeProductionQtyWriteUs { get; } = new List<ChangeProductionQty>();

    [ForeignKey("CompanyId")]
    [InverseProperty("ResUsers")]
    public virtual ResCompany? Company { get; set; }

    [InverseProperty("CreateU")]
    public virtual ICollection<ConfirmStockSm> ConfirmStockSmCreateUs { get; } = new List<ConfirmStockSm>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ConfirmStockSm> ConfirmStockSmWriteUs { get; } = new List<ConfirmStockSm>();

    [ForeignKey("CreateUid")]
    [InverseProperty("InverseCreateU")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmIapLeadHelper> CrmIapLeadHelperCreateUs { get; } = new List<CrmIapLeadHelper>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmIapLeadHelper> CrmIapLeadHelperWriteUs { get; } = new List<CrmIapLeadHelper>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustryCreateUs { get; } = new List<CrmIapLeadIndustry>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustryWriteUs { get; } = new List<CrmIapLeadIndustry>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestCreateUs { get; } = new List<CrmIapLeadMiningRequest>();

    [InverseProperty("User")]
    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestUsers { get; } = new List<CrmIapLeadMiningRequest>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestWriteUs { get; } = new List<CrmIapLeadMiningRequest>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoleCreateUs { get; } = new List<CrmIapLeadRole>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoleWriteUs { get; } = new List<CrmIapLeadRole>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmIapLeadSeniority> CrmIapLeadSeniorityCreateUs { get; } = new List<CrmIapLeadSeniority>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmIapLeadSeniority> CrmIapLeadSeniorityWriteUs { get; } = new List<CrmIapLeadSeniority>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerCreateUs { get; } = new List<CrmLead2opportunityPartner>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassCreateUs { get; } = new List<CrmLead2opportunityPartnerMass>();

    [InverseProperty("User")]
    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassUsers { get; } = new List<CrmLead2opportunityPartnerMass>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassWriteUs { get; } = new List<CrmLead2opportunityPartnerMass>();

    [InverseProperty("User")]
    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerUsers { get; } = new List<CrmLead2opportunityPartner>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerWriteUs { get; } = new List<CrmLead2opportunityPartner>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmLead> CrmLeadCreateUs { get; } = new List<CrmLead>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmLeadLost> CrmLeadLostCreateUs { get; } = new List<CrmLeadLost>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmLeadLost> CrmLeadLostWriteUs { get; } = new List<CrmLeadLost>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdateCreateUs { get; } = new List<CrmLeadPlsUpdate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdateWriteUs { get; } = new List<CrmLeadPlsUpdate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencyCreateUs { get; } = new List<CrmLeadScoringFrequency>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFieldCreateUs { get; } = new List<CrmLeadScoringFrequencyField>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFieldWriteUs { get; } = new List<CrmLeadScoringFrequencyField>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencyWriteUs { get; } = new List<CrmLeadScoringFrequency>();

    [InverseProperty("User")]
    public virtual ICollection<CrmLead> CrmLeadUsers { get; } = new List<CrmLead>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmLead> CrmLeadWriteUs { get; } = new List<CrmLead>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmLostReason> CrmLostReasonCreateUs { get; } = new List<CrmLostReason>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmLostReason> CrmLostReasonWriteUs { get; } = new List<CrmLostReason>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityCreateUs { get; } = new List<CrmMergeOpportunity>();

    [InverseProperty("User")]
    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityUsers { get; } = new List<CrmMergeOpportunity>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityWriteUs { get; } = new List<CrmMergeOpportunity>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmQuotationPartner> CrmQuotationPartnerCreateUs { get; } = new List<CrmQuotationPartner>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmQuotationPartner> CrmQuotationPartnerWriteUs { get; } = new List<CrmQuotationPartner>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmRecurringPlan> CrmRecurringPlanCreateUs { get; } = new List<CrmRecurringPlan>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmRecurringPlan> CrmRecurringPlanWriteUs { get; } = new List<CrmRecurringPlan>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmStage> CrmStageCreateUs { get; } = new List<CrmStage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmStage> CrmStageWriteUs { get; } = new List<CrmStage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmTag> CrmTagCreateUs { get; } = new List<CrmTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmTag> CrmTagWriteUs { get; } = new List<CrmTag>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmTeam> CrmTeamCreateUs { get; } = new List<CrmTeam>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrmTeamMember> CrmTeamMemberCreateUs { get; } = new List<CrmTeamMember>();

    [InverseProperty("User")]
    public virtual ICollection<CrmTeamMember> CrmTeamMemberUsers { get; } = new List<CrmTeamMember>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmTeamMember> CrmTeamMemberWriteUs { get; } = new List<CrmTeamMember>();

    [InverseProperty("User")]
    public virtual ICollection<CrmTeam> CrmTeamUsers { get; } = new List<CrmTeam>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrmTeam> CrmTeamWriteUs { get; } = new List<CrmTeam>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrossoveredBudget> CrossoveredBudgetCreateUs { get; } = new List<CrossoveredBudget>();

    [InverseProperty("CreateU")]
    public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLineCreateUs { get; } = new List<CrossoveredBudgetLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLineWriteUs { get; } = new List<CrossoveredBudgetLine>();

    [InverseProperty("User")]
    public virtual ICollection<CrossoveredBudget> CrossoveredBudgetUsers { get; } = new List<CrossoveredBudget>();

    [InverseProperty("WriteU")]
    public virtual ICollection<CrossoveredBudget> CrossoveredBudgetWriteUs { get; } = new List<CrossoveredBudget>();

    [InverseProperty("CreateU")]
    public virtual ICollection<DecimalPrecision> DecimalPrecisionCreateUs { get; } = new List<DecimalPrecision>();

    [InverseProperty("WriteU")]
    public virtual ICollection<DecimalPrecision> DecimalPrecisionWriteUs { get; } = new List<DecimalPrecision>();

    [InverseProperty("CreateU")]
    public virtual ICollection<DigestDigest> DigestDigestCreateUs { get; } = new List<DigestDigest>();

    [InverseProperty("WriteU")]
    public virtual ICollection<DigestDigest> DigestDigestWriteUs { get; } = new List<DigestDigest>();

    [InverseProperty("CreateU")]
    public virtual ICollection<DigestTip> DigestTipCreateUs { get; } = new List<DigestTip>();

    [InverseProperty("WriteU")]
    public virtual ICollection<DigestTip> DigestTipWriteUs { get; } = new List<DigestTip>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FetchmailServer> FetchmailServerCreateUs { get; } = new List<FetchmailServer>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FetchmailServer> FetchmailServerWriteUs { get; } = new List<FetchmailServer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetServiceType> FleetServiceTypeCreateUs { get; } = new List<FleetServiceType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetServiceType> FleetServiceTypeWriteUs { get; } = new List<FleetServiceType>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogCreateUs { get; } = new List<FleetVehicleAssignationLog>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogWriteUs { get; } = new List<FleetVehicleAssignationLog>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicle> FleetVehicleCreateUs { get; } = new List<FleetVehicle>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractCreateUs { get; } = new List<FleetVehicleLogContract>();

    [InverseProperty("User")]
    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractUsers { get; } = new List<FleetVehicleLogContract>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractWriteUs { get; } = new List<FleetVehicleLogContract>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceCreateUs { get; } = new List<FleetVehicleLogService>();

    [InverseProperty("Manager")]
    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceManagers { get; } = new List<FleetVehicleLogService>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceWriteUs { get; } = new List<FleetVehicleLogService>();

    [InverseProperty("Manager")]
    public virtual ICollection<FleetVehicle> FleetVehicleManagers { get; } = new List<FleetVehicle>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleModelBrand> FleetVehicleModelBrandCreateUs { get; } = new List<FleetVehicleModelBrand>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleModelBrand> FleetVehicleModelBrandWriteUs { get; } = new List<FleetVehicleModelBrand>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleModelCategory> FleetVehicleModelCategoryCreateUs { get; } = new List<FleetVehicleModelCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleModelCategory> FleetVehicleModelCategoryWriteUs { get; } = new List<FleetVehicleModelCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleModel> FleetVehicleModelCreateUs { get; } = new List<FleetVehicleModel>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleModel> FleetVehicleModelWriteUs { get; } = new List<FleetVehicleModel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleOdometer> FleetVehicleOdometerCreateUs { get; } = new List<FleetVehicleOdometer>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleOdometer> FleetVehicleOdometerWriteUs { get; } = new List<FleetVehicleOdometer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleState> FleetVehicleStateCreateUs { get; } = new List<FleetVehicleState>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleState> FleetVehicleStateWriteUs { get; } = new List<FleetVehicleState>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FleetVehicleTag> FleetVehicleTagCreateUs { get; } = new List<FleetVehicleTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicleTag> FleetVehicleTagWriteUs { get; } = new List<FleetVehicleTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FleetVehicle> FleetVehicleWriteUs { get; } = new List<FleetVehicle>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FollowupFollowup> FollowupFollowupCreateUs { get; } = new List<FollowupFollowup>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FollowupFollowup> FollowupFollowupWriteUs { get; } = new List<FollowupFollowup>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FollowupLine> FollowupLineCreateUs { get; } = new List<FollowupLine>();

    [InverseProperty("ManualActionResponsible")]
    public virtual ICollection<FollowupLine> FollowupLineManualActionResponsibles { get; } = new List<FollowupLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FollowupLine> FollowupLineWriteUs { get; } = new List<FollowupLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FollowupPrint> FollowupPrintCreateUs { get; } = new List<FollowupPrint>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FollowupPrint> FollowupPrintWriteUs { get; } = new List<FollowupPrint>();

    [InverseProperty("CreateU")]
    public virtual ICollection<FollowupSendingResult> FollowupSendingResultCreateUs { get; } = new List<FollowupSendingResult>();

    [InverseProperty("WriteU")]
    public virtual ICollection<FollowupSendingResult> FollowupSendingResultWriteUs { get; } = new List<FollowupSendingResult>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrApplicantCategory> HrApplicantCategoryCreateUs { get; } = new List<HrApplicantCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrApplicantCategory> HrApplicantCategoryWriteUs { get; } = new List<HrApplicantCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrApplicant> HrApplicantCreateUs { get; } = new List<HrApplicant>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrApplicantRefuseReason> HrApplicantRefuseReasonCreateUs { get; } = new List<HrApplicantRefuseReason>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrApplicantRefuseReason> HrApplicantRefuseReasonWriteUs { get; } = new List<HrApplicantRefuseReason>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrApplicantSkill> HrApplicantSkillCreateUs { get; } = new List<HrApplicantSkill>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrApplicantSkill> HrApplicantSkillWriteUs { get; } = new List<HrApplicantSkill>();

    [InverseProperty("User")]
    public virtual ICollection<HrApplicant> HrApplicantUsers { get; } = new List<HrApplicant>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrApplicant> HrApplicantWriteUs { get; } = new List<HrApplicant>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrAttendance> HrAttendanceCreateUs { get; } = new List<HrAttendance>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrAttendanceOvertime> HrAttendanceOvertimeCreateUs { get; } = new List<HrAttendanceOvertime>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrAttendanceOvertime> HrAttendanceOvertimeWriteUs { get; } = new List<HrAttendanceOvertime>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrAttendance> HrAttendanceWriteUs { get; } = new List<HrAttendance>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrContract> HrContractCreateUs { get; } = new List<HrContract>();

    [InverseProperty("HrResponsible")]
    public virtual ICollection<HrContract> HrContractHrResponsibles { get; } = new List<HrContract>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrContractType> HrContractTypeCreateUs { get; } = new List<HrContractType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrContractType> HrContractTypeWriteUs { get; } = new List<HrContractType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrContract> HrContractWriteUs { get; } = new List<HrContract>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrDepartment> HrDepartmentCreateUs { get; } = new List<HrDepartment>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrDepartment> HrDepartmentWriteUs { get; } = new List<HrDepartment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrDepartureReason> HrDepartureReasonCreateUs { get; } = new List<HrDepartureReason>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrDepartureReason> HrDepartureReasonWriteUs { get; } = new List<HrDepartureReason>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrDepartureWizard> HrDepartureWizardCreateUs { get; } = new List<HrDepartureWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrDepartureWizard> HrDepartureWizardWriteUs { get; } = new List<HrDepartureWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrEmployeeCategory> HrEmployeeCategoryCreateUs { get; } = new List<HrEmployeeCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrEmployeeCategory> HrEmployeeCategoryWriteUs { get; } = new List<HrEmployeeCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrEmployee> HrEmployeeCreateUs { get; } = new List<HrEmployee>();

    [InverseProperty("ExpenseManager")]
    public virtual ICollection<HrEmployee> HrEmployeeExpenseManagers { get; } = new List<HrEmployee>();

    [InverseProperty("LeaveManager")]
    public virtual ICollection<HrEmployee> HrEmployeeLeaveManagers { get; } = new List<HrEmployee>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrEmployeeSkill> HrEmployeeSkillCreateUs { get; } = new List<HrEmployeeSkill>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogCreateUs { get; } = new List<HrEmployeeSkillLog>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogWriteUs { get; } = new List<HrEmployeeSkillLog>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrEmployeeSkill> HrEmployeeSkillWriteUs { get; } = new List<HrEmployeeSkill>();

    [InverseProperty("User")]
    public virtual ICollection<HrEmployee> HrEmployeeUsers { get; } = new List<HrEmployee>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrEmployee> HrEmployeeWriteUs { get; } = new List<HrEmployee>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicateCreateUs { get; } = new List<HrExpenseApproveDuplicate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicateWriteUs { get; } = new List<HrExpenseApproveDuplicate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrExpense> HrExpenseCreateUs { get; } = new List<HrExpense>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizardCreateUs { get; } = new List<HrExpenseRefuseWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizardWriteUs { get; } = new List<HrExpenseRefuseWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheetCreateUs { get; } = new List<HrExpenseSheet>();

    [InverseProperty("User")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheetUsers { get; } = new List<HrExpenseSheet>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheetWriteUs { get; } = new List<HrExpenseSheet>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplitCreateUs { get; } = new List<HrExpenseSplit>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizardCreateUs { get; } = new List<HrExpenseSplitWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizardWriteUs { get; } = new List<HrExpenseSplitWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplitWriteUs { get; } = new List<HrExpenseSplit>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrExpense> HrExpenseWriteUs { get; } = new List<HrExpense>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrHolidaysCancelLeave> HrHolidaysCancelLeaveCreateUs { get; } = new List<HrHolidaysCancelLeave>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrHolidaysCancelLeave> HrHolidaysCancelLeaveWriteUs { get; } = new List<HrHolidaysCancelLeave>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrHolidaysSummaryEmployee> HrHolidaysSummaryEmployeeCreateUs { get; } = new List<HrHolidaysSummaryEmployee>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrHolidaysSummaryEmployee> HrHolidaysSummaryEmployeeWriteUs { get; } = new List<HrHolidaysSummaryEmployee>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrJob> HrJobCreateUs { get; } = new List<HrJob>();

    [InverseProperty("HrResponsible")]
    public virtual ICollection<HrJob> HrJobHrResponsibles { get; } = new List<HrJob>();

    [InverseProperty("User")]
    public virtual ICollection<HrJob> HrJobUsers { get; } = new List<HrJob>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrJob> HrJobWriteUs { get; } = new List<HrJob>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevelCreateUs { get; } = new List<HrLeaveAccrualLevel>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevelWriteUs { get; } = new List<HrLeaveAccrualLevel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrLeaveAccrualPlan> HrLeaveAccrualPlanCreateUs { get; } = new List<HrLeaveAccrualPlan>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrLeaveAccrualPlan> HrLeaveAccrualPlanWriteUs { get; } = new List<HrLeaveAccrualPlan>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationCreateUs { get; } = new List<HrLeaveAllocation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationWriteUs { get; } = new List<HrLeaveAllocation>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrLeave> HrLeaveCreateUs { get; } = new List<HrLeave>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDayCreateUs { get; } = new List<HrLeaveStressDay>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDayWriteUs { get; } = new List<HrLeaveStressDay>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrLeaveType> HrLeaveTypeCreateUs { get; } = new List<HrLeaveType>();

    [InverseProperty("Responsible")]
    public virtual ICollection<HrLeaveType> HrLeaveTypeResponsibles { get; } = new List<HrLeaveType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrLeaveType> HrLeaveTypeWriteUs { get; } = new List<HrLeaveType>();

    [InverseProperty("User")]
    public virtual ICollection<HrLeave> HrLeaveUsers { get; } = new List<HrLeave>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrLeave> HrLeaveWriteUs { get; } = new List<HrLeave>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypeCreateUs { get; } = new List<HrPayrollStructureType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypeWriteUs { get; } = new List<HrPayrollStructureType>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeCreateUs { get; } = new List<HrPlanActivityType>();

    [InverseProperty("ResponsibleNavigation")]
    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeResponsibleNavigations { get; } = new List<HrPlanActivityType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeWriteUs { get; } = new List<HrPlanActivityType>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrPlan> HrPlanCreateUs { get; } = new List<HrPlan>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrPlanWizard> HrPlanWizardCreateUs { get; } = new List<HrPlanWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrPlanWizard> HrPlanWizardWriteUs { get; } = new List<HrPlanWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrPlan> HrPlanWriteUs { get; } = new List<HrPlan>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrRecruitmentDegree> HrRecruitmentDegreeCreateUs { get; } = new List<HrRecruitmentDegree>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrRecruitmentDegree> HrRecruitmentDegreeWriteUs { get; } = new List<HrRecruitmentDegree>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSourceCreateUs { get; } = new List<HrRecruitmentSource>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSourceWriteUs { get; } = new List<HrRecruitmentSource>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrRecruitmentStage> HrRecruitmentStageCreateUs { get; } = new List<HrRecruitmentStage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrRecruitmentStage> HrRecruitmentStageWriteUs { get; } = new List<HrRecruitmentStage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrResumeLine> HrResumeLineCreateUs { get; } = new List<HrResumeLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrResumeLineType> HrResumeLineTypeCreateUs { get; } = new List<HrResumeLineType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrResumeLineType> HrResumeLineTypeWriteUs { get; } = new List<HrResumeLineType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrResumeLine> HrResumeLineWriteUs { get; } = new List<HrResumeLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrSkill> HrSkillCreateUs { get; } = new List<HrSkill>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrSkillLevel> HrSkillLevelCreateUs { get; } = new List<HrSkillLevel>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrSkillLevel> HrSkillLevelWriteUs { get; } = new List<HrSkillLevel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrSkillType> HrSkillTypeCreateUs { get; } = new List<HrSkillType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrSkillType> HrSkillTypeWriteUs { get; } = new List<HrSkillType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrSkill> HrSkillWriteUs { get; } = new List<HrSkill>();

    [InverseProperty("CreateU")]
    public virtual ICollection<HrWorkLocation> HrWorkLocationCreateUs { get; } = new List<HrWorkLocation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<HrWorkLocation> HrWorkLocationWriteUs { get; } = new List<HrWorkLocation>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IapAccount> IapAccountCreateUs { get; } = new List<IapAccount>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IapAccount> IapAccountWriteUs { get; } = new List<IapAccount>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResUser> InverseCreateU { get; } = new List<ResUser>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResUser> InverseWriteU { get; } = new List<ResUser>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrActClient> IrActClientCreateUs { get; } = new List<IrActClient>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrActClient> IrActClientWriteUs { get; } = new List<IrActClient>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrActReportXml> IrActReportXmlCreateUs { get; } = new List<IrActReportXml>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrActReportXml> IrActReportXmlWriteUs { get; } = new List<IrActReportXml>();

    [InverseProperty("ActivityUser")]
    public virtual ICollection<IrActServer> IrActServerActivityUsers { get; } = new List<IrActServer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrActServer> IrActServerCreateUs { get; } = new List<IrActServer>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrActServer> IrActServerWriteUs { get; } = new List<IrActServer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrActUrl> IrActUrlCreateUs { get; } = new List<IrActUrl>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrActUrl> IrActUrlWriteUs { get; } = new List<IrActUrl>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrActWindow> IrActWindowCreateUs { get; } = new List<IrActWindow>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrActWindowView> IrActWindowViewCreateUs { get; } = new List<IrActWindowView>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrActWindowView> IrActWindowViewWriteUs { get; } = new List<IrActWindowView>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrActWindow> IrActWindowWriteUs { get; } = new List<IrActWindow>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrAction> IrActionCreateUs { get; } = new List<IrAction>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrAction> IrActionWriteUs { get; } = new List<IrAction>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrActionsTodo> IrActionsTodoCreateUs { get; } = new List<IrActionsTodo>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrActionsTodo> IrActionsTodoWriteUs { get; } = new List<IrActionsTodo>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrAsset> IrAssetCreateUs { get; } = new List<IrAsset>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrAsset> IrAssetWriteUs { get; } = new List<IrAsset>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrAttachment> IrAttachmentCreateUs { get; } = new List<IrAttachment>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrAttachment> IrAttachmentWriteUs { get; } = new List<IrAttachment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrConfigParameter> IrConfigParameterCreateUs { get; } = new List<IrConfigParameter>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrConfigParameter> IrConfigParameterWriteUs { get; } = new List<IrConfigParameter>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrCron> IrCronCreateUs { get; } = new List<IrCron>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrCronTrigger> IrCronTriggerCreateUs { get; } = new List<IrCronTrigger>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrCronTrigger> IrCronTriggerWriteUs { get; } = new List<IrCronTrigger>();

    [InverseProperty("User")]
    public virtual ICollection<IrCron> IrCronUsers { get; } = new List<IrCron>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrCron> IrCronWriteUs { get; } = new List<IrCron>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrDefault> IrDefaultCreateUs { get; } = new List<IrDefault>();

    [InverseProperty("User")]
    public virtual ICollection<IrDefault> IrDefaultUsers { get; } = new List<IrDefault>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrDefault> IrDefaultWriteUs { get; } = new List<IrDefault>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrDemo> IrDemoCreateUs { get; } = new List<IrDemo>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrDemoFailure> IrDemoFailureCreateUs { get; } = new List<IrDemoFailure>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrDemoFailureWizard> IrDemoFailureWizardCreateUs { get; } = new List<IrDemoFailureWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrDemoFailureWizard> IrDemoFailureWizardWriteUs { get; } = new List<IrDemoFailureWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrDemoFailure> IrDemoFailureWriteUs { get; } = new List<IrDemoFailure>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrDemo> IrDemoWriteUs { get; } = new List<IrDemo>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrExport> IrExportCreateUs { get; } = new List<IrExport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrExport> IrExportWriteUs { get; } = new List<IrExport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrExportsLine> IrExportsLineCreateUs { get; } = new List<IrExportsLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrExportsLine> IrExportsLineWriteUs { get; } = new List<IrExportsLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrFilter> IrFilterCreateUs { get; } = new List<IrFilter>();

    [InverseProperty("User")]
    public virtual ICollection<IrFilter> IrFilterUsers { get; } = new List<IrFilter>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrFilter> IrFilterWriteUs { get; } = new List<IrFilter>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrMailServer> IrMailServerCreateUs { get; } = new List<IrMailServer>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrMailServer> IrMailServerWriteUs { get; } = new List<IrMailServer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModelAccess> IrModelAccessCreateUs { get; } = new List<IrModelAccess>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModelAccess> IrModelAccessWriteUs { get; } = new List<IrModelAccess>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModelConstraint> IrModelConstraintCreateUs { get; } = new List<IrModelConstraint>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModelConstraint> IrModelConstraintWriteUs { get; } = new List<IrModelConstraint>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModel> IrModelCreateUs { get; } = new List<IrModel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModelDatum> IrModelDatumCreateUs { get; } = new List<IrModelDatum>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModelDatum> IrModelDatumWriteUs { get; } = new List<IrModelDatum>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModelField> IrModelFieldCreateUs { get; } = new List<IrModelField>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModelField> IrModelFieldWriteUs { get; } = new List<IrModelField>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelectionCreateUs { get; } = new List<IrModelFieldsSelection>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelectionWriteUs { get; } = new List<IrModelFieldsSelection>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModelRelation> IrModelRelationCreateUs { get; } = new List<IrModelRelation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModelRelation> IrModelRelationWriteUs { get; } = new List<IrModelRelation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModel> IrModelWriteUs { get; } = new List<IrModel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModuleCategory> IrModuleCategoryCreateUs { get; } = new List<IrModuleCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModuleCategory> IrModuleCategoryWriteUs { get; } = new List<IrModuleCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModuleModule> IrModuleModuleCreateUs { get; } = new List<IrModuleModule>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusionCreateUs { get; } = new List<IrModuleModuleExclusion>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusionWriteUs { get; } = new List<IrModuleModuleExclusion>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrModuleModule> IrModuleModuleWriteUs { get; } = new List<IrModuleModule>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrProperty> IrPropertyCreateUs { get; } = new List<IrProperty>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrProperty> IrPropertyWriteUs { get; } = new List<IrProperty>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrRule> IrRuleCreateUs { get; } = new List<IrRule>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrRule> IrRuleWriteUs { get; } = new List<IrRule>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrSequence> IrSequenceCreateUs { get; } = new List<IrSequence>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrSequenceDateRange> IrSequenceDateRangeCreateUs { get; } = new List<IrSequenceDateRange>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrSequenceDateRange> IrSequenceDateRangeWriteUs { get; } = new List<IrSequenceDateRange>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrSequence> IrSequenceWriteUs { get; } = new List<IrSequence>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrServerObjectLine> IrServerObjectLineCreateUs { get; } = new List<IrServerObjectLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrServerObjectLine> IrServerObjectLineWriteUs { get; } = new List<IrServerObjectLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrUiMenu> IrUiMenuCreateUs { get; } = new List<IrUiMenu>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrUiMenu> IrUiMenuWriteUs { get; } = new List<IrUiMenu>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrUiView> IrUiViewCreateUs { get; } = new List<IrUiView>();

    [InverseProperty("CreateU")]
    public virtual ICollection<IrUiViewCustom> IrUiViewCustomCreateUs { get; } = new List<IrUiViewCustom>();

    [InverseProperty("User")]
    public virtual ICollection<IrUiViewCustom> IrUiViewCustomUsers { get; } = new List<IrUiViewCustom>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrUiViewCustom> IrUiViewCustomWriteUs { get; } = new List<IrUiViewCustom>();

    [InverseProperty("WriteU")]
    public virtual ICollection<IrUiView> IrUiViewWriteUs { get; } = new List<IrUiView>();

    [ForeignKey("LastLunchLocationId")]
    [InverseProperty("ResUsers")]
    public virtual LunchLocation? LastLunchLocation { get; set; }

    [InverseProperty("CreateU")]
    public virtual ICollection<LotLabelLayout> LotLabelLayoutCreateUs { get; } = new List<LotLabelLayout>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LotLabelLayout> LotLabelLayoutWriteUs { get; } = new List<LotLabelLayout>();

    [InverseProperty("CreateU")]
    public virtual ICollection<LunchAlert> LunchAlertCreateUs { get; } = new List<LunchAlert>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LunchAlert> LunchAlertWriteUs { get; } = new List<LunchAlert>();

    [InverseProperty("CreateU")]
    public virtual ICollection<LunchCashmove> LunchCashmoveCreateUs { get; } = new List<LunchCashmove>();

    [InverseProperty("User")]
    public virtual ICollection<LunchCashmove> LunchCashmoveUsers { get; } = new List<LunchCashmove>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LunchCashmove> LunchCashmoveWriteUs { get; } = new List<LunchCashmove>();

    [InverseProperty("CreateU")]
    public virtual ICollection<LunchLocation> LunchLocationCreateUs { get; } = new List<LunchLocation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LunchLocation> LunchLocationWriteUs { get; } = new List<LunchLocation>();

    [InverseProperty("CreateU")]
    public virtual ICollection<LunchOrder> LunchOrderCreateUs { get; } = new List<LunchOrder>();

    [InverseProperty("User")]
    public virtual ICollection<LunchOrder> LunchOrderUsers { get; } = new List<LunchOrder>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LunchOrder> LunchOrderWriteUs { get; } = new List<LunchOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<LunchProductCategory> LunchProductCategoryCreateUs { get; } = new List<LunchProductCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LunchProductCategory> LunchProductCategoryWriteUs { get; } = new List<LunchProductCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<LunchProduct> LunchProductCreateUs { get; } = new List<LunchProduct>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LunchProduct> LunchProductWriteUs { get; } = new List<LunchProduct>();

    [InverseProperty("CreateU")]
    public virtual ICollection<LunchSupplier> LunchSupplierCreateUs { get; } = new List<LunchSupplier>();

    [InverseProperty("Responsible")]
    public virtual ICollection<LunchSupplier> LunchSupplierResponsibles { get; } = new List<LunchSupplier>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LunchSupplier> LunchSupplierWriteUs { get; } = new List<LunchSupplier>();

    [InverseProperty("CreateU")]
    public virtual ICollection<LunchTopping> LunchToppingCreateUs { get; } = new List<LunchTopping>();

    [InverseProperty("WriteU")]
    public virtual ICollection<LunchTopping> LunchToppingWriteUs { get; } = new List<LunchTopping>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailActivity> MailActivityCreateUs { get; } = new List<MailActivity>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailActivityType> MailActivityTypeCreateUs { get; } = new List<MailActivityType>();

    [InverseProperty("DefaultUser")]
    public virtual ICollection<MailActivityType> MailActivityTypeDefaultUsers { get; } = new List<MailActivityType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailActivityType> MailActivityTypeWriteUs { get; } = new List<MailActivityType>();

    [InverseProperty("User")]
    public virtual ICollection<MailActivity> MailActivityUsers { get; } = new List<MailActivity>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailActivity> MailActivityWriteUs { get; } = new List<MailActivity>();

    [InverseProperty("AliasUser")]
    public virtual ICollection<MailAlias> MailAliasAliasUsers { get; } = new List<MailAlias>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailAlias> MailAliasCreateUs { get; } = new List<MailAlias>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailAlias> MailAliasWriteUs { get; } = new List<MailAlias>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailBlacklist> MailBlacklistCreateUs { get; } = new List<MailBlacklist>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailBlacklistRemove> MailBlacklistRemoveCreateUs { get; } = new List<MailBlacklistRemove>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailBlacklistRemove> MailBlacklistRemoveWriteUs { get; } = new List<MailBlacklistRemove>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailBlacklist> MailBlacklistWriteUs { get; } = new List<MailBlacklist>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailChannel> MailChannelCreateUs { get; } = new List<MailChannel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailChannelMember> MailChannelMemberCreateUs { get; } = new List<MailChannelMember>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailChannelMember> MailChannelMemberWriteUs { get; } = new List<MailChannelMember>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessionCreateUs { get; } = new List<MailChannelRtcSession>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessionWriteUs { get; } = new List<MailChannelRtcSession>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailChannel> MailChannelWriteUs { get; } = new List<MailChannel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailComposeMessage> MailComposeMessageCreateUs { get; } = new List<MailComposeMessage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailComposeMessage> MailComposeMessageWriteUs { get; } = new List<MailComposeMessage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailGatewayAllowed> MailGatewayAllowedCreateUs { get; } = new List<MailGatewayAllowed>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailGatewayAllowed> MailGatewayAllowedWriteUs { get; } = new List<MailGatewayAllowed>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailGuest> MailGuestCreateUs { get; } = new List<MailGuest>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailGuest> MailGuestWriteUs { get; } = new List<MailGuest>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailIceServer> MailIceServerCreateUs { get; } = new List<MailIceServer>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailIceServer> MailIceServerWriteUs { get; } = new List<MailIceServer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailLinkPreview> MailLinkPreviewCreateUs { get; } = new List<MailLinkPreview>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailLinkPreview> MailLinkPreviewWriteUs { get; } = new List<MailLinkPreview>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailMail> MailMailCreateUs { get; } = new List<MailMail>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailMail> MailMailWriteUs { get; } = new List<MailMail>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailMessage> MailMessageCreateUs { get; } = new List<MailMessage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailMessageSchedule> MailMessageScheduleCreateUs { get; } = new List<MailMessageSchedule>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailMessageSchedule> MailMessageScheduleWriteUs { get; } = new List<MailMessageSchedule>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailMessageSubtype> MailMessageSubtypeCreateUs { get; } = new List<MailMessageSubtype>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailMessageSubtype> MailMessageSubtypeWriteUs { get; } = new List<MailMessageSubtype>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailMessage> MailMessageWriteUs { get; } = new List<MailMessage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailResendMessage> MailResendMessageCreateUs { get; } = new List<MailResendMessage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailResendMessage> MailResendMessageWriteUs { get; } = new List<MailResendMessage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailResendPartner> MailResendPartnerCreateUs { get; } = new List<MailResendPartner>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailResendPartner> MailResendPartnerWriteUs { get; } = new List<MailResendPartner>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailShortcode> MailShortcodeCreateUs { get; } = new List<MailShortcode>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailShortcode> MailShortcodeWriteUs { get; } = new List<MailShortcode>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailTemplate> MailTemplateCreateUs { get; } = new List<MailTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailTemplatePreview> MailTemplatePreviewCreateUs { get; } = new List<MailTemplatePreview>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailTemplatePreview> MailTemplatePreviewWriteUs { get; } = new List<MailTemplatePreview>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailTemplateReset> MailTemplateResetCreateUs { get; } = new List<MailTemplateReset>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailTemplateReset> MailTemplateResetWriteUs { get; } = new List<MailTemplateReset>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailTemplate> MailTemplateWriteUs { get; } = new List<MailTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailTrackingValue> MailTrackingValueCreateUs { get; } = new List<MailTrackingValue>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailTrackingValue> MailTrackingValueWriteUs { get; } = new List<MailTrackingValue>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MailWizardInvite> MailWizardInviteCreateUs { get; } = new List<MailWizardInvite>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MailWizardInvite> MailWizardInviteWriteUs { get; } = new List<MailWizardInvite>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryCreateUs { get; } = new List<MaintenanceEquipmentCategory>();

    [InverseProperty("TechnicianUser")]
    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryTechnicianUsers { get; } = new List<MaintenanceEquipmentCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryWriteUs { get; } = new List<MaintenanceEquipmentCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentCreateUs { get; } = new List<MaintenanceEquipment>();

    [InverseProperty("OwnerUser")]
    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentOwnerUsers { get; } = new List<MaintenanceEquipment>();

    [InverseProperty("TechnicianUser")]
    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentTechnicianUsers { get; } = new List<MaintenanceEquipment>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentWriteUs { get; } = new List<MaintenanceEquipment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MaintenanceRequest> MaintenanceRequestCreateUs { get; } = new List<MaintenanceRequest>();

    [InverseProperty("OwnerUser")]
    public virtual ICollection<MaintenanceRequest> MaintenanceRequestOwnerUsers { get; } = new List<MaintenanceRequest>();

    [InverseProperty("User")]
    public virtual ICollection<MaintenanceRequest> MaintenanceRequestUsers { get; } = new List<MaintenanceRequest>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MaintenanceRequest> MaintenanceRequestWriteUs { get; } = new List<MaintenanceRequest>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MaintenanceStage> MaintenanceStageCreateUs { get; } = new List<MaintenanceStage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MaintenanceStage> MaintenanceStageWriteUs { get; } = new List<MaintenanceStage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MaintenanceTeam> MaintenanceTeamCreateUs { get; } = new List<MaintenanceTeam>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MaintenanceTeam> MaintenanceTeamWriteUs { get; } = new List<MaintenanceTeam>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpBomByproduct> MrpBomByproductCreateUs { get; } = new List<MrpBomByproduct>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpBomByproduct> MrpBomByproductWriteUs { get; } = new List<MrpBomByproduct>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpBom> MrpBomCreateUs { get; } = new List<MrpBom>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpBomLine> MrpBomLineCreateUs { get; } = new List<MrpBomLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpBomLine> MrpBomLineWriteUs { get; } = new List<MrpBomLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpBom> MrpBomWriteUs { get; } = new List<MrpBom>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpConsumptionWarning> MrpConsumptionWarningCreateUs { get; } = new List<MrpConsumptionWarning>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLineCreateUs { get; } = new List<MrpConsumptionWarningLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLineWriteUs { get; } = new List<MrpConsumptionWarningLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpConsumptionWarning> MrpConsumptionWarningWriteUs { get; } = new List<MrpConsumptionWarning>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpDocument> MrpDocumentCreateUs { get; } = new List<MrpDocument>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpDocument> MrpDocumentWriteUs { get; } = new List<MrpDocument>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpImmediateProduction> MrpImmediateProductionCreateUs { get; } = new List<MrpImmediateProduction>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLineCreateUs { get; } = new List<MrpImmediateProductionLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLineWriteUs { get; } = new List<MrpImmediateProductionLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpImmediateProduction> MrpImmediateProductionWriteUs { get; } = new List<MrpImmediateProduction>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpProductionBackorder> MrpProductionBackorderCreateUs { get; } = new List<MrpProductionBackorder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLineCreateUs { get; } = new List<MrpProductionBackorderLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLineWriteUs { get; } = new List<MrpProductionBackorderLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpProductionBackorder> MrpProductionBackorderWriteUs { get; } = new List<MrpProductionBackorder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpProduction> MrpProductionCreateUs { get; } = new List<MrpProduction>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpProductionSplit> MrpProductionSplitCreateUs { get; } = new List<MrpProductionSplit>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineCreateUs { get; } = new List<MrpProductionSplitLine>();

    [InverseProperty("User")]
    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineUsers { get; } = new List<MrpProductionSplitLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineWriteUs { get; } = new List<MrpProductionSplitLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpProductionSplitMulti> MrpProductionSplitMultiCreateUs { get; } = new List<MrpProductionSplitMulti>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpProductionSplitMulti> MrpProductionSplitMultiWriteUs { get; } = new List<MrpProductionSplitMulti>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpProductionSplit> MrpProductionSplitWriteUs { get; } = new List<MrpProductionSplit>();

    [InverseProperty("User")]
    public virtual ICollection<MrpProduction> MrpProductionUsers { get; } = new List<MrpProduction>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpProduction> MrpProductionWriteUs { get; } = new List<MrpProduction>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenterCreateUs { get; } = new List<MrpRoutingWorkcenter>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenterWriteUs { get; } = new List<MrpRoutingWorkcenter>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpUnbuild> MrpUnbuildCreateUs { get; } = new List<MrpUnbuild>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpUnbuild> MrpUnbuildWriteUs { get; } = new List<MrpUnbuild>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacityCreateUs { get; } = new List<MrpWorkcenterCapacity>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacityWriteUs { get; } = new List<MrpWorkcenterCapacity>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpWorkcenter> MrpWorkcenterCreateUs { get; } = new List<MrpWorkcenter>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityCreateUs { get; } = new List<MrpWorkcenterProductivity>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpWorkcenterProductivityLoss> MrpWorkcenterProductivityLossCreateUs { get; } = new List<MrpWorkcenterProductivityLoss>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpWorkcenterProductivityLossType> MrpWorkcenterProductivityLossTypeCreateUs { get; } = new List<MrpWorkcenterProductivityLossType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpWorkcenterProductivityLossType> MrpWorkcenterProductivityLossTypeWriteUs { get; } = new List<MrpWorkcenterProductivityLossType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpWorkcenterProductivityLoss> MrpWorkcenterProductivityLossWriteUs { get; } = new List<MrpWorkcenterProductivityLoss>();

    [InverseProperty("User")]
    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityUsers { get; } = new List<MrpWorkcenterProductivity>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityWriteUs { get; } = new List<MrpWorkcenterProductivity>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpWorkcenterTag> MrpWorkcenterTagCreateUs { get; } = new List<MrpWorkcenterTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpWorkcenterTag> MrpWorkcenterTagWriteUs { get; } = new List<MrpWorkcenterTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpWorkcenter> MrpWorkcenterWriteUs { get; } = new List<MrpWorkcenter>();

    [InverseProperty("CreateU")]
    public virtual ICollection<MrpWorkorder> MrpWorkorderCreateUs { get; } = new List<MrpWorkorder>();

    [InverseProperty("WriteU")]
    public virtual ICollection<MrpWorkorder> MrpWorkorderWriteUs { get; } = new List<MrpWorkorder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<NoteNote> NoteNoteCreateUs { get; } = new List<NoteNote>();

    [InverseProperty("User")]
    public virtual ICollection<NoteNote> NoteNoteUsers { get; } = new List<NoteNote>();

    [InverseProperty("WriteU")]
    public virtual ICollection<NoteNote> NoteNoteWriteUs { get; } = new List<NoteNote>();

    [InverseProperty("CreateU")]
    public virtual ICollection<NoteStage> NoteStageCreateUs { get; } = new List<NoteStage>();

    [InverseProperty("User")]
    public virtual ICollection<NoteStage> NoteStageUsers { get; } = new List<NoteStage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<NoteStage> NoteStageWriteUs { get; } = new List<NoteStage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<NoteTag> NoteTagCreateUs { get; } = new List<NoteTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<NoteTag> NoteTagWriteUs { get; } = new List<NoteTag>();

    [ForeignKey("PartnerId")]
    [InverseProperty("ResUsers")]
    public virtual ResPartner? Partner { get; set; }

    [InverseProperty("CreateU")]
    public virtual ICollection<PaymentIcon> PaymentIconCreateUs { get; } = new List<PaymentIcon>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PaymentIcon> PaymentIconWriteUs { get; } = new List<PaymentIcon>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PaymentLinkWizard> PaymentLinkWizardCreateUs { get; } = new List<PaymentLinkWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PaymentLinkWizard> PaymentLinkWizardWriteUs { get; } = new List<PaymentLinkWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PaymentProvider> PaymentProviderCreateUs { get; } = new List<PaymentProvider>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PaymentProviderOnboardingWizard> PaymentProviderOnboardingWizardCreateUs { get; } = new List<PaymentProviderOnboardingWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PaymentProviderOnboardingWizard> PaymentProviderOnboardingWizardWriteUs { get; } = new List<PaymentProviderOnboardingWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PaymentProvider> PaymentProviderWriteUs { get; } = new List<PaymentProvider>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PaymentRefundWizard> PaymentRefundWizardCreateUs { get; } = new List<PaymentRefundWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PaymentRefundWizard> PaymentRefundWizardWriteUs { get; } = new List<PaymentRefundWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PaymentToken> PaymentTokenCreateUs { get; } = new List<PaymentToken>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PaymentToken> PaymentTokenWriteUs { get; } = new List<PaymentToken>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PaymentTransaction> PaymentTransactionCreateUs { get; } = new List<PaymentTransaction>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PaymentTransaction> PaymentTransactionWriteUs { get; } = new List<PaymentTransaction>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PhoneBlacklist> PhoneBlacklistCreateUs { get; } = new List<PhoneBlacklist>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PhoneBlacklistRemove> PhoneBlacklistRemoveCreateUs { get; } = new List<PhoneBlacklistRemove>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PhoneBlacklistRemove> PhoneBlacklistRemoveWriteUs { get; } = new List<PhoneBlacklistRemove>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PhoneBlacklist> PhoneBlacklistWriteUs { get; } = new List<PhoneBlacklist>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PickingLabelType> PickingLabelTypeCreateUs { get; } = new List<PickingLabelType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PickingLabelType> PickingLabelTypeWriteUs { get; } = new List<PickingLabelType>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PortalShare> PortalShareCreateUs { get; } = new List<PortalShare>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PortalShare> PortalShareWriteUs { get; } = new List<PortalShare>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PortalWizard> PortalWizardCreateUs { get; } = new List<PortalWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PortalWizardUser> PortalWizardUserCreateUs { get; } = new List<PortalWizardUser>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PortalWizardUser> PortalWizardUserWriteUs { get; } = new List<PortalWizardUser>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PortalWizard> PortalWizardWriteUs { get; } = new List<PortalWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosBill> PosBillCreateUs { get; } = new List<PosBill>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosBill> PosBillWriteUs { get; } = new List<PosBill>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosCategory> PosCategoryCreateUs { get; } = new List<PosCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosCategory> PosCategoryWriteUs { get; } = new List<PosCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizardCreateUs { get; } = new List<PosCloseSessionWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizardWriteUs { get; } = new List<PosCloseSessionWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosConfig> PosConfigCreateUs { get; } = new List<PosConfig>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosConfig> PosConfigWriteUs { get; } = new List<PosConfig>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosDetailsWizard> PosDetailsWizardCreateUs { get; } = new List<PosDetailsWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosDetailsWizard> PosDetailsWizardWriteUs { get; } = new List<PosDetailsWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosMakePayment> PosMakePaymentCreateUs { get; } = new List<PosMakePayment>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosMakePayment> PosMakePaymentWriteUs { get; } = new List<PosMakePayment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosOrder> PosOrderCreateUs { get; } = new List<PosOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosOrderLine> PosOrderLineCreateUs { get; } = new List<PosOrderLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosOrderLine> PosOrderLineWriteUs { get; } = new List<PosOrderLine>();

    [InverseProperty("User")]
    public virtual ICollection<PosOrder> PosOrderUsers { get; } = new List<PosOrder>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosOrder> PosOrderWriteUs { get; } = new List<PosOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosPackOperationLot> PosPackOperationLotCreateUs { get; } = new List<PosPackOperationLot>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosPackOperationLot> PosPackOperationLotWriteUs { get; } = new List<PosPackOperationLot>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosPayment> PosPaymentCreateUs { get; } = new List<PosPayment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosPaymentMethod> PosPaymentMethodCreateUs { get; } = new List<PosPaymentMethod>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosPaymentMethod> PosPaymentMethodWriteUs { get; } = new List<PosPaymentMethod>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosPayment> PosPaymentWriteUs { get; } = new List<PosPayment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosSessionCheckProductWizard> PosSessionCheckProductWizardCreateUs { get; } = new List<PosSessionCheckProductWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosSessionCheckProductWizard> PosSessionCheckProductWizardWriteUs { get; } = new List<PosSessionCheckProductWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PosSession> PosSessionCreateUs { get; } = new List<PosSession>();

    [InverseProperty("User")]
    public virtual ICollection<PosSession> PosSessionUsers { get; } = new List<PosSession>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PosSession> PosSessionWriteUs { get; } = new List<PosSession>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PrivacyLog> PrivacyLogCreateUs { get; } = new List<PrivacyLog>();

    [InverseProperty("User")]
    public virtual ICollection<PrivacyLog> PrivacyLogUsers { get; } = new List<PrivacyLog>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PrivacyLog> PrivacyLogWriteUs { get; } = new List<PrivacyLog>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizardCreateUs { get; } = new List<PrivacyLookupWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLineCreateUs { get; } = new List<PrivacyLookupWizardLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLineWriteUs { get; } = new List<PrivacyLookupWizardLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizardWriteUs { get; } = new List<PrivacyLookupWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProcurementGroup> ProcurementGroupCreateUs { get; } = new List<ProcurementGroup>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProcurementGroup> ProcurementGroupWriteUs { get; } = new List<ProcurementGroup>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductAttribute> ProductAttributeCreateUs { get; } = new List<ProductAttribute>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValueCreateUs { get; } = new List<ProductAttributeCustomValue>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValueWriteUs { get; } = new List<ProductAttributeCustomValue>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductAttributeValue> ProductAttributeValueCreateUs { get; } = new List<ProductAttributeValue>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductAttributeValue> ProductAttributeValueWriteUs { get; } = new List<ProductAttributeValue>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductAttribute> ProductAttributeWriteUs { get; } = new List<ProductAttribute>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductCategory> ProductCategoryCreateUs { get; } = new List<ProductCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductCategory> ProductCategoryWriteUs { get; } = new List<ProductCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductImage> ProductImageCreateUs { get; } = new List<ProductImage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductImage> ProductImageWriteUs { get; } = new List<ProductImage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductLabelLayout> ProductLabelLayoutCreateUs { get; } = new List<ProductLabelLayout>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductLabelLayout> ProductLabelLayoutWriteUs { get; } = new List<ProductLabelLayout>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductPackaging> ProductPackagingCreateUs { get; } = new List<ProductPackaging>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductPackaging> ProductPackagingWriteUs { get; } = new List<ProductPackaging>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductPricelist> ProductPricelistCreateUs { get; } = new List<ProductPricelist>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItemCreateUs { get; } = new List<ProductPricelistItem>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItemWriteUs { get; } = new List<ProductPricelistItem>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductPricelist> ProductPricelistWriteUs { get; } = new List<ProductPricelist>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductProduct> ProductProductCreateUs { get; } = new List<ProductProduct>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductProduct> ProductProductWriteUs { get; } = new List<ProductProduct>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductPublicCategory> ProductPublicCategoryCreateUs { get; } = new List<ProductPublicCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductPublicCategory> ProductPublicCategoryWriteUs { get; } = new List<ProductPublicCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductRemoval> ProductRemovalCreateUs { get; } = new List<ProductRemoval>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductRemoval> ProductRemovalWriteUs { get; } = new List<ProductRemoval>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductReplenish> ProductReplenishCreateUs { get; } = new List<ProductReplenish>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductReplenish> ProductReplenishWriteUs { get; } = new List<ProductReplenish>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductRibbon> ProductRibbonCreateUs { get; } = new List<ProductRibbon>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductRibbon> ProductRibbonWriteUs { get; } = new List<ProductRibbon>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfoCreateUs { get; } = new List<ProductSupplierinfo>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfoWriteUs { get; } = new List<ProductSupplierinfo>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductTag> ProductTagCreateUs { get; } = new List<ProductTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductTag> ProductTagWriteUs { get; } = new List<ProductTag>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionCreateUs { get; } = new List<ProductTemplateAttributeExclusion>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionWriteUs { get; } = new List<ProductTemplateAttributeExclusion>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLineCreateUs { get; } = new List<ProductTemplateAttributeLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLineWriteUs { get; } = new List<ProductTemplateAttributeLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValueCreateUs { get; } = new List<ProductTemplateAttributeValue>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValueWriteUs { get; } = new List<ProductTemplateAttributeValue>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProductTemplate> ProductTemplateCreateUs { get; } = new List<ProductTemplate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProductTemplate> ProductTemplateWriteUs { get; } = new List<ProductTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectCollaborator> ProjectCollaboratorCreateUs { get; } = new List<ProjectCollaborator>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectCollaborator> ProjectCollaboratorWriteUs { get; } = new List<ProjectCollaborator>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectMilestone> ProjectMilestoneCreateUs { get; } = new List<ProjectMilestone>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectMilestone> ProjectMilestoneWriteUs { get; } = new List<ProjectMilestone>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectProject> ProjectProjectCreateUs { get; } = new List<ProjectProject>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectProjectStage> ProjectProjectStageCreateUs { get; } = new List<ProjectProjectStage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectProjectStage> ProjectProjectStageWriteUs { get; } = new List<ProjectProjectStage>();

    [InverseProperty("User")]
    public virtual ICollection<ProjectProject> ProjectProjectUsers { get; } = new List<ProjectProject>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectProject> ProjectProjectWriteUs { get; } = new List<ProjectProject>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectShareWizard> ProjectShareWizardCreateUs { get; } = new List<ProjectShareWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectShareWizard> ProjectShareWizardWriteUs { get; } = new List<ProjectShareWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectTag> ProjectTagCreateUs { get; } = new List<ProjectTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectTag> ProjectTagWriteUs { get; } = new List<ProjectTag>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectTask> ProjectTaskCreateUs { get; } = new List<ProjectTask>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectTaskRecurrence> ProjectTaskRecurrenceCreateUs { get; } = new List<ProjectTaskRecurrence>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectTaskRecurrence> ProjectTaskRecurrenceWriteUs { get; } = new List<ProjectTaskRecurrence>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectTaskType> ProjectTaskTypeCreateUs { get; } = new List<ProjectTaskType>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizardCreateUs { get; } = new List<ProjectTaskTypeDeleteWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizardWriteUs { get; } = new List<ProjectTaskTypeDeleteWizard>();

    [InverseProperty("User")]
    public virtual ICollection<ProjectTaskType> ProjectTaskTypeUsers { get; } = new List<ProjectTaskType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectTaskType> ProjectTaskTypeWriteUs { get; } = new List<ProjectTaskType>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelCreateUs { get; } = new List<ProjectTaskUserRel>();

    [InverseProperty("User")]
    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelUsers { get; } = new List<ProjectTaskUserRel>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelWriteUs { get; } = new List<ProjectTaskUserRel>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectTask> ProjectTaskWriteUs { get; } = new List<ProjectTask>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ProjectUpdate> ProjectUpdateCreateUs { get; } = new List<ProjectUpdate>();

    [InverseProperty("User")]
    public virtual ICollection<ProjectUpdate> ProjectUpdateUsers { get; } = new List<ProjectUpdate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ProjectUpdate> ProjectUpdateWriteUs { get; } = new List<ProjectUpdate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PurchaseOrder> PurchaseOrderCreateUs { get; } = new List<PurchaseOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLineCreateUs { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLineWriteUs { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("User")]
    public virtual ICollection<PurchaseOrder> PurchaseOrderUsers { get; } = new List<PurchaseOrder>();

    [InverseProperty("WriteU")]
    public virtual ICollection<PurchaseOrder> PurchaseOrderWriteUs { get; } = new List<PurchaseOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<RatingRating> RatingRatingCreateUs { get; } = new List<RatingRating>();

    [InverseProperty("WriteU")]
    public virtual ICollection<RatingRating> RatingRatingWriteUs { get; } = new List<RatingRating>();

    [InverseProperty("CreateU")]
    public virtual ICollection<RecurringPayment> RecurringPaymentCreateUs { get; } = new List<RecurringPayment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<RecurringPaymentLine> RecurringPaymentLineCreateUs { get; } = new List<RecurringPaymentLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<RecurringPaymentLine> RecurringPaymentLineWriteUs { get; } = new List<RecurringPaymentLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<RecurringPayment> RecurringPaymentWriteUs { get; } = new List<RecurringPayment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<RepairFee> RepairFeeCreateUs { get; } = new List<RepairFee>();

    [InverseProperty("WriteU")]
    public virtual ICollection<RepairFee> RepairFeeWriteUs { get; } = new List<RepairFee>();

    [InverseProperty("CreateU")]
    public virtual ICollection<RepairLine> RepairLineCreateUs { get; } = new List<RepairLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<RepairLine> RepairLineWriteUs { get; } = new List<RepairLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<RepairOrder> RepairOrderCreateUs { get; } = new List<RepairOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<RepairOrderMakeInvoice> RepairOrderMakeInvoiceCreateUs { get; } = new List<RepairOrderMakeInvoice>();

    [InverseProperty("WriteU")]
    public virtual ICollection<RepairOrderMakeInvoice> RepairOrderMakeInvoiceWriteUs { get; } = new List<RepairOrderMakeInvoice>();

    [InverseProperty("User")]
    public virtual ICollection<RepairOrder> RepairOrderUsers { get; } = new List<RepairOrder>();

    [InverseProperty("WriteU")]
    public virtual ICollection<RepairOrder> RepairOrderWriteUs { get; } = new List<RepairOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<RepairTag> RepairTagCreateUs { get; } = new List<RepairTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<RepairTag> RepairTagWriteUs { get; } = new List<RepairTag>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ReportLayout> ReportLayoutCreateUs { get; } = new List<ReportLayout>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ReportLayout> ReportLayoutWriteUs { get; } = new List<ReportLayout>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ReportPaperformat> ReportPaperformatCreateUs { get; } = new List<ReportPaperformat>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ReportPaperformat> ReportPaperformatWriteUs { get; } = new List<ReportPaperformat>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResBank> ResBankCreateUs { get; } = new List<ResBank>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResBank> ResBankWriteUs { get; } = new List<ResBank>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResCompany> ResCompanyCreateUs { get; } = new List<ResCompany>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResCompany> ResCompanyWriteUs { get; } = new List<ResCompany>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResConfig> ResConfigCreateUs { get; } = new List<ResConfig>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResConfigInstaller> ResConfigInstallerCreateUs { get; } = new List<ResConfigInstaller>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResConfigInstaller> ResConfigInstallerWriteUs { get; } = new List<ResConfigInstaller>();

    [InverseProperty("AuthSignupTemplateUser")]
    public virtual ICollection<ResConfigSetting> ResConfigSettingAuthSignupTemplateUsers { get; } = new List<ResConfigSetting>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResConfigSetting> ResConfigSettingCreateUs { get; } = new List<ResConfigSetting>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResConfigSetting> ResConfigSettingWriteUs { get; } = new List<ResConfigSetting>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResConfig> ResConfigWriteUs { get; } = new List<ResConfig>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResCountry> ResCountryCreateUs { get; } = new List<ResCountry>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResCountryGroup> ResCountryGroupCreateUs { get; } = new List<ResCountryGroup>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResCountryGroup> ResCountryGroupWriteUs { get; } = new List<ResCountryGroup>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResCountryState> ResCountryStateCreateUs { get; } = new List<ResCountryState>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResCountryState> ResCountryStateWriteUs { get; } = new List<ResCountryState>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResCountry> ResCountryWriteUs { get; } = new List<ResCountry>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResCurrency> ResCurrencyCreateUs { get; } = new List<ResCurrency>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResCurrencyRate> ResCurrencyRateCreateUs { get; } = new List<ResCurrencyRate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResCurrencyRate> ResCurrencyRateWriteUs { get; } = new List<ResCurrencyRate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResCurrency> ResCurrencyWriteUs { get; } = new List<ResCurrency>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResGroup> ResGroupCreateUs { get; } = new List<ResGroup>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResGroup> ResGroupWriteUs { get; } = new List<ResGroup>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResLang> ResLangCreateUs { get; } = new List<ResLang>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResLang> ResLangWriteUs { get; } = new List<ResLang>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncCreateUs { get; } = new List<ResPartnerAutocompleteSync>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncWriteUs { get; } = new List<ResPartnerAutocompleteSync>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResPartnerBank> ResPartnerBankCreateUs { get; } = new List<ResPartnerBank>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResPartnerBank> ResPartnerBankWriteUs { get; } = new List<ResPartnerBank>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResPartnerCategory> ResPartnerCategoryCreateUs { get; } = new List<ResPartnerCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResPartnerCategory> ResPartnerCategoryWriteUs { get; } = new List<ResPartnerCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResPartner> ResPartnerCreateUs { get; } = new List<ResPartner>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResPartnerIndustry> ResPartnerIndustryCreateUs { get; } = new List<ResPartnerIndustry>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResPartnerIndustry> ResPartnerIndustryWriteUs { get; } = new List<ResPartnerIndustry>();

    [InverseProperty("PaymentResponsible")]
    public virtual ICollection<ResPartner> ResPartnerPaymentResponsibles { get; } = new List<ResPartner>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResPartnerTitle> ResPartnerTitleCreateUs { get; } = new List<ResPartnerTitle>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResPartnerTitle> ResPartnerTitleWriteUs { get; } = new List<ResPartnerTitle>();

    [InverseProperty("User")]
    public virtual ICollection<ResPartner> ResPartnerUsers { get; } = new List<ResPartner>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResPartner> ResPartnerWriteUs { get; } = new List<ResPartner>();

    [InverseProperty("User")]
    public virtual ICollection<ResUsersApikey> ResUsersApikeys { get; } = new List<ResUsersApikey>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResUsersApikeysDescription> ResUsersApikeysDescriptionCreateUs { get; } = new List<ResUsersApikeysDescription>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResUsersApikeysDescription> ResUsersApikeysDescriptionWriteUs { get; } = new List<ResUsersApikeysDescription>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResUsersDeletion> ResUsersDeletionCreateUs { get; } = new List<ResUsersDeletion>();

    [InverseProperty("User")]
    public virtual ICollection<ResUsersDeletion> ResUsersDeletionUsers { get; } = new List<ResUsersDeletion>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResUsersDeletion> ResUsersDeletionWriteUs { get; } = new List<ResUsersDeletion>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResUsersIdentitycheck> ResUsersIdentitycheckCreateUs { get; } = new List<ResUsersIdentitycheck>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResUsersIdentitycheck> ResUsersIdentitycheckWriteUs { get; } = new List<ResUsersIdentitycheck>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResUsersLog> ResUsersLogCreateUs { get; } = new List<ResUsersLog>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResUsersLog> ResUsersLogWriteUs { get; } = new List<ResUsersLog>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResUsersSetting> ResUsersSettingCreateUs { get; } = new List<ResUsersSetting>();

    [InverseProperty("User")]
    public virtual ResUsersSetting? ResUsersSettingUser { get; set; }

    [InverseProperty("WriteU")]
    public virtual ICollection<ResUsersSetting> ResUsersSettingWriteUs { get; } = new List<ResUsersSetting>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeCreateUs { get; } = new List<ResUsersSettingsVolume>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeWriteUs { get; } = new List<ResUsersSettingsVolume>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardCreateUs { get; } = new List<ResetViewArchWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardWriteUs { get; } = new List<ResetViewArchWizard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendanceCreateUs { get; } = new List<ResourceCalendarAttendance>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendanceWriteUs { get; } = new List<ResourceCalendarAttendance>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResourceCalendar> ResourceCalendarCreateUs { get; } = new List<ResourceCalendar>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeafCreateUs { get; } = new List<ResourceCalendarLeaf>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeafWriteUs { get; } = new List<ResourceCalendarLeaf>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResourceCalendar> ResourceCalendarWriteUs { get; } = new List<ResourceCalendar>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ResourceResource> ResourceResourceCreateUs { get; } = new List<ResourceResource>();

    [InverseProperty("User")]
    public virtual ICollection<ResourceResource> ResourceResourceUsers { get; } = new List<ResourceResource>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ResourceResource> ResourceResourceWriteUs { get; } = new List<ResourceResource>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvCreateUs { get; } = new List<SaleAdvancePaymentInv>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvWriteUs { get; } = new List<SaleAdvancePaymentInv>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SaleOrderCancel> SaleOrderCancelCreateUs { get; } = new List<SaleOrderCancel>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SaleOrderCancel> SaleOrderCancelWriteUs { get; } = new List<SaleOrderCancel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SaleOrder> SaleOrderCreateUs { get; } = new List<SaleOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SaleOrderLine> SaleOrderLineCreateUs { get; } = new List<SaleOrderLine>();

    [InverseProperty("Salesman")]
    public virtual ICollection<SaleOrderLine> SaleOrderLineSalesmen { get; } = new List<SaleOrderLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SaleOrderLine> SaleOrderLineWriteUs { get; } = new List<SaleOrderLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SaleOrderOption> SaleOrderOptionCreateUs { get; } = new List<SaleOrderOption>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SaleOrderOption> SaleOrderOptionWriteUs { get; } = new List<SaleOrderOption>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SaleOrderTemplate> SaleOrderTemplateCreateUs { get; } = new List<SaleOrderTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLineCreateUs { get; } = new List<SaleOrderTemplateLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLineWriteUs { get; } = new List<SaleOrderTemplateLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptionCreateUs { get; } = new List<SaleOrderTemplateOption>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptionWriteUs { get; } = new List<SaleOrderTemplateOption>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SaleOrderTemplate> SaleOrderTemplateWriteUs { get; } = new List<SaleOrderTemplate>();

    [InverseProperty("User")]
    public virtual ICollection<SaleOrder> SaleOrderUsers { get; } = new List<SaleOrder>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SaleOrder> SaleOrderWriteUs { get; } = new List<SaleOrder>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SalePaymentProviderOnboardingWizard> SalePaymentProviderOnboardingWizardCreateUs { get; } = new List<SalePaymentProviderOnboardingWizard>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SalePaymentProviderOnboardingWizard> SalePaymentProviderOnboardingWizardWriteUs { get; } = new List<SalePaymentProviderOnboardingWizard>();

    [ForeignKey("SaleTeamId")]
    [InverseProperty("ResUsers")]
    public virtual CrmTeam? SaleTeam { get; set; }

    [InverseProperty("CreateU")]
    public virtual ICollection<SmsComposer> SmsComposerCreateUs { get; } = new List<SmsComposer>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SmsComposer> SmsComposerWriteUs { get; } = new List<SmsComposer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SmsResend> SmsResendCreateUs { get; } = new List<SmsResend>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SmsResendRecipient> SmsResendRecipientCreateUs { get; } = new List<SmsResendRecipient>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SmsResendRecipient> SmsResendRecipientWriteUs { get; } = new List<SmsResendRecipient>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SmsResend> SmsResendWriteUs { get; } = new List<SmsResend>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SmsSm> SmsSmCreateUs { get; } = new List<SmsSm>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SmsSm> SmsSmWriteUs { get; } = new List<SmsSm>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SmsTemplate> SmsTemplateCreateUs { get; } = new List<SmsTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SmsTemplatePreview> SmsTemplatePreviewCreateUs { get; } = new List<SmsTemplatePreview>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SmsTemplatePreview> SmsTemplatePreviewWriteUs { get; } = new List<SmsTemplatePreview>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SmsTemplateReset> SmsTemplateResetCreateUs { get; } = new List<SmsTemplateReset>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SmsTemplateReset> SmsTemplateResetWriteUs { get; } = new List<SmsTemplateReset>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SmsTemplate> SmsTemplateWriteUs { get; } = new List<SmsTemplate>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoiceCreateUs { get; } = new List<SnailmailConfirmInvoice>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoiceWriteUs { get; } = new List<SnailmailConfirmInvoice>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SnailmailLetter> SnailmailLetterCreateUs { get; } = new List<SnailmailLetter>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrorCreateUs { get; } = new List<SnailmailLetterFormatError>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrorWriteUs { get; } = new List<SnailmailLetterFormatError>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFieldCreateUs { get; } = new List<SnailmailLetterMissingRequiredField>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFieldWriteUs { get; } = new List<SnailmailLetterMissingRequiredField>();

    [InverseProperty("User")]
    public virtual ICollection<SnailmailLetter> SnailmailLetterUsers { get; } = new List<SnailmailLetter>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SnailmailLetter> SnailmailLetterWriteUs { get; } = new List<SnailmailLetter>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboardCreateUs { get; } = new List<SpreadsheetDashboard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<SpreadsheetDashboardGroup> SpreadsheetDashboardGroupCreateUs { get; } = new List<SpreadsheetDashboardGroup>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SpreadsheetDashboardGroup> SpreadsheetDashboardGroupWriteUs { get; } = new List<SpreadsheetDashboardGroup>();

    [InverseProperty("WriteU")]
    public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboardWriteUs { get; } = new List<SpreadsheetDashboard>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockAssignSerial> StockAssignSerialCreateUs { get; } = new List<StockAssignSerial>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockAssignSerial> StockAssignSerialWriteUs { get; } = new List<StockAssignSerial>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmationCreateUs { get; } = new List<StockBackorderConfirmation>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLineCreateUs { get; } = new List<StockBackorderConfirmationLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLineWriteUs { get; } = new List<StockBackorderConfirmationLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmationWriteUs { get; } = new List<StockBackorderConfirmation>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockChangeProductQty> StockChangeProductQtyCreateUs { get; } = new List<StockChangeProductQty>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockChangeProductQty> StockChangeProductQtyWriteUs { get; } = new List<StockChangeProductQty>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockImmediateTransfer> StockImmediateTransferCreateUs { get; } = new List<StockImmediateTransfer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLineCreateUs { get; } = new List<StockImmediateTransferLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLineWriteUs { get; } = new List<StockImmediateTransferLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockImmediateTransfer> StockImmediateTransferWriteUs { get; } = new List<StockImmediateTransfer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNameCreateUs { get; } = new List<StockInventoryAdjustmentName>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNameWriteUs { get; } = new List<StockInventoryAdjustmentName>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockInventoryConflict> StockInventoryConflictCreateUs { get; } = new List<StockInventoryConflict>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockInventoryConflict> StockInventoryConflictWriteUs { get; } = new List<StockInventoryConflict>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockInventoryWarning> StockInventoryWarningCreateUs { get; } = new List<StockInventoryWarning>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockInventoryWarning> StockInventoryWarningWriteUs { get; } = new List<StockInventoryWarning>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockLocation> StockLocationCreateUs { get; } = new List<StockLocation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockLocation> StockLocationWriteUs { get; } = new List<StockLocation>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockLot> StockLotCreateUs { get; } = new List<StockLot>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockLot> StockLotWriteUs { get; } = new List<StockLot>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockMove> StockMoveCreateUs { get; } = new List<StockMove>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockMoveLine> StockMoveLineCreateUs { get; } = new List<StockMoveLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockMoveLine> StockMoveLineWriteUs { get; } = new List<StockMoveLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockMove> StockMoveWriteUs { get; } = new List<StockMove>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozeCreateUs { get; } = new List<StockOrderpointSnooze>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozeWriteUs { get; } = new List<StockOrderpointSnooze>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockPackageDestination> StockPackageDestinationCreateUs { get; } = new List<StockPackageDestination>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockPackageDestination> StockPackageDestinationWriteUs { get; } = new List<StockPackageDestination>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockPackageLevel> StockPackageLevelCreateUs { get; } = new List<StockPackageLevel>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockPackageLevel> StockPackageLevelWriteUs { get; } = new List<StockPackageLevel>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockPackageType> StockPackageTypeCreateUs { get; } = new List<StockPackageType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockPackageType> StockPackageTypeWriteUs { get; } = new List<StockPackageType>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockPicking> StockPickingCreateUs { get; } = new List<StockPicking>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockPickingType> StockPickingTypeCreateUs { get; } = new List<StockPickingType>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockPickingType> StockPickingTypeWriteUs { get; } = new List<StockPickingType>();

    [InverseProperty("User")]
    public virtual ICollection<StockPicking> StockPickingUsers { get; } = new List<StockPicking>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockPicking> StockPickingWriteUs { get; } = new List<StockPicking>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockPutawayRule> StockPutawayRuleCreateUs { get; } = new List<StockPutawayRule>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockPutawayRule> StockPutawayRuleWriteUs { get; } = new List<StockPutawayRule>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockQuant> StockQuantCreateUs { get; } = new List<StockQuant>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockQuantPackage> StockQuantPackageCreateUs { get; } = new List<StockQuantPackage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockQuantPackage> StockQuantPackageWriteUs { get; } = new List<StockQuantPackage>();

    [InverseProperty("User")]
    public virtual ICollection<StockQuant> StockQuantUsers { get; } = new List<StockQuant>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockQuant> StockQuantWriteUs { get; } = new List<StockQuant>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockQuantityHistory> StockQuantityHistoryCreateUs { get; } = new List<StockQuantityHistory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockQuantityHistory> StockQuantityHistoryWriteUs { get; } = new List<StockQuantityHistory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfoCreateUs { get; } = new List<StockReplenishmentInfo>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfoWriteUs { get; } = new List<StockReplenishmentInfo>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptionCreateUs { get; } = new List<StockReplenishmentOption>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptionWriteUs { get; } = new List<StockReplenishmentOption>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockRequestCount> StockRequestCountCreateUs { get; } = new List<StockRequestCount>();

    [InverseProperty("User")]
    public virtual ICollection<StockRequestCount> StockRequestCountUsers { get; } = new List<StockRequestCount>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockRequestCount> StockRequestCountWriteUs { get; } = new List<StockRequestCount>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockReturnPicking> StockReturnPickingCreateUs { get; } = new List<StockReturnPicking>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLineCreateUs { get; } = new List<StockReturnPickingLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLineWriteUs { get; } = new List<StockReturnPickingLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockReturnPicking> StockReturnPickingWriteUs { get; } = new List<StockReturnPicking>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockRoute> StockRouteCreateUs { get; } = new List<StockRoute>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockRoute> StockRouteWriteUs { get; } = new List<StockRoute>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockRule> StockRuleCreateUs { get; } = new List<StockRule>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockRule> StockRuleWriteUs { get; } = new List<StockRule>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockRulesReport> StockRulesReportCreateUs { get; } = new List<StockRulesReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockRulesReport> StockRulesReportWriteUs { get; } = new List<StockRulesReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockSchedulerCompute> StockSchedulerComputeCreateUs { get; } = new List<StockSchedulerCompute>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockSchedulerCompute> StockSchedulerComputeWriteUs { get; } = new List<StockSchedulerCompute>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockScrap> StockScrapCreateUs { get; } = new List<StockScrap>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockScrap> StockScrapWriteUs { get; } = new List<StockScrap>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacityCreateUs { get; } = new List<StockStorageCategoryCapacity>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacityWriteUs { get; } = new List<StockStorageCategoryCapacity>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockStorageCategory> StockStorageCategoryCreateUs { get; } = new List<StockStorageCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockStorageCategory> StockStorageCategoryWriteUs { get; } = new List<StockStorageCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockTraceabilityReport> StockTraceabilityReportCreateUs { get; } = new List<StockTraceabilityReport>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockTraceabilityReport> StockTraceabilityReportWriteUs { get; } = new List<StockTraceabilityReport>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockTrackConfirmation> StockTrackConfirmationCreateUs { get; } = new List<StockTrackConfirmation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockTrackConfirmation> StockTrackConfirmationWriteUs { get; } = new List<StockTrackConfirmation>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockTrackLine> StockTrackLineCreateUs { get; } = new List<StockTrackLine>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockTrackLine> StockTrackLineWriteUs { get; } = new List<StockTrackLine>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockValuationLayer> StockValuationLayerCreateUs { get; } = new List<StockValuationLayer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluationCreateUs { get; } = new List<StockValuationLayerRevaluation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluationWriteUs { get; } = new List<StockValuationLayerRevaluation>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockValuationLayer> StockValuationLayerWriteUs { get; } = new List<StockValuationLayer>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockWarehouse> StockWarehouseCreateUs { get; } = new List<StockWarehouse>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpointCreateUs { get; } = new List<StockWarehouseOrderpoint>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpointWriteUs { get; } = new List<StockWarehouseOrderpoint>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockWarehouse> StockWarehouseWriteUs { get; } = new List<StockWarehouse>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairCreateUs { get; } = new List<StockWarnInsufficientQtyRepair>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairWriteUs { get; } = new List<StockWarnInsufficientQtyRepair>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScrapCreateUs { get; } = new List<StockWarnInsufficientQtyScrap>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScrapWriteUs { get; } = new List<StockWarnInsufficientQtyScrap>();

    [InverseProperty("CreateU")]
    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuildCreateUs { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    [InverseProperty("WriteU")]
    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuildWriteUs { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ThemeIrAsset> ThemeIrAssetCreateUs { get; } = new List<ThemeIrAsset>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ThemeIrAsset> ThemeIrAssetWriteUs { get; } = new List<ThemeIrAsset>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ThemeIrAttachment> ThemeIrAttachmentCreateUs { get; } = new List<ThemeIrAttachment>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ThemeIrAttachment> ThemeIrAttachmentWriteUs { get; } = new List<ThemeIrAttachment>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ThemeIrUiView> ThemeIrUiViewCreateUs { get; } = new List<ThemeIrUiView>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ThemeIrUiView> ThemeIrUiViewWriteUs { get; } = new List<ThemeIrUiView>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenuCreateUs { get; } = new List<ThemeWebsiteMenu>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenuWriteUs { get; } = new List<ThemeWebsiteMenu>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ThemeWebsitePage> ThemeWebsitePageCreateUs { get; } = new List<ThemeWebsitePage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ThemeWebsitePage> ThemeWebsitePageWriteUs { get; } = new List<ThemeWebsitePage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<UomCategory> UomCategoryCreateUs { get; } = new List<UomCategory>();

    [InverseProperty("WriteU")]
    public virtual ICollection<UomCategory> UomCategoryWriteUs { get; } = new List<UomCategory>();

    [InverseProperty("CreateU")]
    public virtual ICollection<UomUom> UomUomCreateUs { get; } = new List<UomUom>();

    [InverseProperty("WriteU")]
    public virtual ICollection<UomUom> UomUomWriteUs { get; } = new List<UomUom>();

    [InverseProperty("CreateU")]
    public virtual ICollection<UtmCampaign> UtmCampaignCreateUs { get; } = new List<UtmCampaign>();

    [InverseProperty("User")]
    public virtual ICollection<UtmCampaign> UtmCampaignUsers { get; } = new List<UtmCampaign>();

    [InverseProperty("WriteU")]
    public virtual ICollection<UtmCampaign> UtmCampaignWriteUs { get; } = new List<UtmCampaign>();

    [InverseProperty("CreateU")]
    public virtual ICollection<UtmMedium> UtmMediumCreateUs { get; } = new List<UtmMedium>();

    [InverseProperty("WriteU")]
    public virtual ICollection<UtmMedium> UtmMediumWriteUs { get; } = new List<UtmMedium>();

    [InverseProperty("CreateU")]
    public virtual ICollection<UtmSource> UtmSourceCreateUs { get; } = new List<UtmSource>();

    [InverseProperty("WriteU")]
    public virtual ICollection<UtmSource> UtmSourceWriteUs { get; } = new List<UtmSource>();

    [InverseProperty("CreateU")]
    public virtual ICollection<UtmStage> UtmStageCreateUs { get; } = new List<UtmStage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<UtmStage> UtmStageWriteUs { get; } = new List<UtmStage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<UtmTag> UtmTagCreateUs { get; } = new List<UtmTag>();

    [InverseProperty("WriteU")]
    public virtual ICollection<UtmTag> UtmTagWriteUs { get; } = new List<UtmTag>();

    [InverseProperty("CreateU")]
    public virtual ICollection<ValidateAccountMove> ValidateAccountMoveCreateUs { get; } = new List<ValidateAccountMove>();

    [InverseProperty("WriteU")]
    public virtual ICollection<ValidateAccountMove> ValidateAccountMoveWriteUs { get; } = new List<ValidateAccountMove>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebEditorConverterTest> WebEditorConverterTestCreateUs { get; } = new List<WebEditorConverterTest>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebEditorConverterTestSub> WebEditorConverterTestSubCreateUs { get; } = new List<WebEditorConverterTestSub>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebEditorConverterTestSub> WebEditorConverterTestSubWriteUs { get; } = new List<WebEditorConverterTestSub>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebEditorConverterTest> WebEditorConverterTestWriteUs { get; } = new List<WebEditorConverterTest>();

    [InverseProperty("User")]
    public virtual ICollection<WebTourTour> WebTourTours { get; } = new List<WebTourTour>();

    [ForeignKey("WebsiteId")]
    [InverseProperty("ResUsers")]
    public virtual Website? Website { get; set; }

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteBaseUnit> WebsiteBaseUnitCreateUs { get; } = new List<WebsiteBaseUnit>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteBaseUnit> WebsiteBaseUnitWriteUs { get; } = new List<WebsiteBaseUnit>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatureCreateUs { get; } = new List<WebsiteConfiguratorFeature>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatureWriteUs { get; } = new List<WebsiteConfiguratorFeature>();

    [InverseProperty("CreateU")]
    public virtual ICollection<Website> WebsiteCreateUs { get; } = new List<Website>();

    [InverseProperty("CrmDefaultUser")]
    public virtual ICollection<Website> WebsiteCrmDefaultUsers { get; } = new List<Website>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteMenu> WebsiteMenuCreateUs { get; } = new List<WebsiteMenu>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteMenu> WebsiteMenuWriteUs { get; } = new List<WebsiteMenu>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsitePage> WebsitePageCreateUs { get; } = new List<WebsitePage>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsitePage> WebsitePageWriteUs { get; } = new List<WebsitePage>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteRewrite> WebsiteRewriteCreateUs { get; } = new List<WebsiteRewrite>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteRewrite> WebsiteRewriteWriteUs { get; } = new List<WebsiteRewrite>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteRobot> WebsiteRobotCreateUs { get; } = new List<WebsiteRobot>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteRobot> WebsiteRobotWriteUs { get; } = new List<WebsiteRobot>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteRoute> WebsiteRouteCreateUs { get; } = new List<WebsiteRoute>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteRoute> WebsiteRouteWriteUs { get; } = new List<WebsiteRoute>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFieldCreateUs { get; } = new List<WebsiteSaleExtraField>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFieldWriteUs { get; } = new List<WebsiteSaleExtraField>();

    [InverseProperty("Salesperson")]
    public virtual ICollection<Website> WebsiteSalespeople { get; } = new List<Website>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilterCreateUs { get; } = new List<WebsiteSnippetFilter>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilterWriteUs { get; } = new List<WebsiteSnippetFilter>();

    [InverseProperty("User")]
    public virtual ICollection<Website> WebsiteUsers { get; } = new List<Website>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WebsiteVisitor> WebsiteVisitorCreateUs { get; } = new List<WebsiteVisitor>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WebsiteVisitor> WebsiteVisitorWriteUs { get; } = new List<WebsiteVisitor>();

    [InverseProperty("WriteU")]
    public virtual ICollection<Website> WebsiteWriteUs { get; } = new List<Website>();

    [InverseProperty("CreateU")]
    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreateCreateUs { get; } = new List<WizardIrModelMenuCreate>();

    [InverseProperty("WriteU")]
    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreateWriteUs { get; } = new List<WizardIrModelMenuCreate>();

    [ForeignKey("WriteUid")]
    [InverseProperty("InverseWriteU")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<ResCompany> Cids { get; } = new List<ResCompany>();

    [ForeignKey("ResUsersId")]
    [InverseProperty("ResUsers")]
    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; } = new List<CrmLead2opportunityPartnerMass>();

    [ForeignKey("ResUsersId")]
    [InverseProperty("ResUsers")]
    public virtual ICollection<DigestDigest> DigestDigests { get; } = new List<DigestDigest>();

    [ForeignKey("ResUsersId")]
    [InverseProperty("ResUsers")]
    public virtual ICollection<DigestTip> DigestTips { get; } = new List<DigestTip>();

    [ForeignKey("Uid")]
    [InverseProperty("UidsNavigation")]
    public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();

    [ForeignKey("ResUsersId")]
    [InverseProperty("ResUsers")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    [ForeignKey("ResUsersId")]
    [InverseProperty("ResUsers")]
    public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    [ForeignKey("ResUsersId")]
    [InverseProperty("ResUsersNavigation")]
    public virtual ICollection<HrJob> HrJobsNavigation { get; } = new List<HrJob>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<HrJob> Jobs { get; } = new List<HrJob>();

    [ForeignKey("ResUsersId")]
    [InverseProperty("ResUsers")]
    public virtual ICollection<MaintenanceTeam> MaintenanceTeams { get; } = new List<MaintenanceTeam>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<LunchProduct> Products { get; } = new List<LunchProduct>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<ProjectProject> Projects { get; } = new List<ProjectProject>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<CrmTeam> Teams { get; } = new List<CrmTeam>();
}
