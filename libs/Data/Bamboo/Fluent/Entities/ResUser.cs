using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResUser
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? PartnerId { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public Guid? ActionId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Signature { get; set; }

    public bool? Share { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? TotpSecret { get; set; }

    public string? NotificationType { get; set; }

    public string? OdoobotState { get; set; }

    public bool? OdoobotFailed { get; set; }

    public Guid? SaleTeamId { get; set; }

    public long? TargetSalesWon { get; set; }

    public long? TargetSalesDone { get; set; }

    public long? TargetSalesInvoiced { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? LastLunchLocationId { get; set; }

    //public virtual ICollection<AccountAccount> AccountAccountCreateUs { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountAccountTag> AccountAccountTagCreateUs { get; } = new List<AccountAccountTag>();

    //public virtual ICollection<AccountAccountTag> AccountAccountTagWriteUs { get; } = new List<AccountAccountTag>();

    //public virtual ICollection<AccountAccountTemplate> AccountAccountTemplateCreateUs { get; } = new List<AccountAccountTemplate>();

    //public virtual ICollection<AccountAccountTemplate> AccountAccountTemplateWriteUs { get; } = new List<AccountAccountTemplate>();

    //public virtual ICollection<AccountAccountType> AccountAccountTypeCreateUs { get; } = new List<AccountAccountType>();

    //public virtual ICollection<AccountAccountType> AccountAccountTypeWriteUs { get; } = new List<AccountAccountType>();

    //public virtual ICollection<AccountAccount> AccountAccountWriteUs { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizardCreateUs { get; } = new List<AccountAccruedOrdersWizard>();

    //public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizardWriteUs { get; } = new List<AccountAccruedOrdersWizard>();

    //public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalanceCreateUs { get; } = new List<AccountAgedTrialBalance>();

    //public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalanceWriteUs { get; } = new List<AccountAgedTrialBalance>();

    //public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountCreateUs { get; } = new List<AccountAnalyticAccount>();

    //public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountWriteUs { get; } = new List<AccountAnalyticAccount>();

    //public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilityCreateUs { get; } = new List<AccountAnalyticApplicability>();

    //public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilityWriteUs { get; } = new List<AccountAnalyticApplicability>();

    //public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModelCreateUs { get; } = new List<AccountAnalyticDistributionModel>();

    //public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModelWriteUs { get; } = new List<AccountAnalyticDistributionModel>();

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineCreateUs { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineUsers { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineWriteUs { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlanCreateUs { get; } = new List<AccountAnalyticPlan>();

    //public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlanWriteUs { get; } = new List<AccountAnalyticPlan>();

    //public virtual ICollection<AccountAssetAsset> AccountAssetAssetCreateUs { get; } = new List<AccountAssetAsset>();

    //public virtual ICollection<AccountAssetAsset> AccountAssetAssetWriteUs { get; } = new List<AccountAssetAsset>();

    //public virtual ICollection<AccountAssetCategory> AccountAssetCategoryCreateUs { get; } = new List<AccountAssetCategory>();

    //public virtual ICollection<AccountAssetCategory> AccountAssetCategoryWriteUs { get; } = new List<AccountAssetCategory>();

    //public virtual ICollection<AccountAssetDepreciationLine> AccountAssetDepreciationLineCreateUs { get; } = new List<AccountAssetDepreciationLine>();

    //public virtual ICollection<AccountAssetDepreciationLine> AccountAssetDepreciationLineWriteUs { get; } = new List<AccountAssetDepreciationLine>();

    //public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizardCreateUs { get; } = new List<AccountAutomaticEntryWizard>();

    //public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizardWriteUs { get; } = new List<AccountAutomaticEntryWizard>();

    //public virtual ICollection<AccountBalanceReport> AccountBalanceReportCreateUs { get; } = new List<AccountBalanceReport>();

    //public virtual ICollection<AccountBalanceReport> AccountBalanceReportWriteUs { get; } = new List<AccountBalanceReport>();

    //public virtual ICollection<AccountBankStatement> AccountBankStatementCreateUs { get; } = new List<AccountBankStatement>();

    //public virtual ICollection<AccountBankStatementImport> AccountBankStatementImportCreateUs { get; } = new List<AccountBankStatementImport>();

    //public virtual ICollection<AccountBankStatementImportJournalCreation> AccountBankStatementImportJournalCreationCreateUs { get; } = new List<AccountBankStatementImportJournalCreation>();

    //public virtual ICollection<AccountBankStatementImportJournalCreation> AccountBankStatementImportJournalCreationWriteUs { get; } = new List<AccountBankStatementImportJournalCreation>();

    //public virtual ICollection<AccountBankStatementImport> AccountBankStatementImportWriteUs { get; } = new List<AccountBankStatementImport>();

    //public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineCreateUs { get; } = new List<AccountBankStatementLine>();

    //public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineWriteUs { get; } = new List<AccountBankStatementLine>();

    //public virtual ICollection<AccountBankStatement> AccountBankStatementWriteUs { get; } = new List<AccountBankStatement>();

    //public virtual ICollection<AccountBankbookReport> AccountBankbookReportCreateUs { get; } = new List<AccountBankbookReport>();

    //public virtual ICollection<AccountBankbookReport> AccountBankbookReportWriteUs { get; } = new List<AccountBankbookReport>();

    //public virtual ICollection<AccountBudgetPost> AccountBudgetPostCreateUs { get; } = new List<AccountBudgetPost>();

    //public virtual ICollection<AccountBudgetPost> AccountBudgetPostWriteUs { get; } = new List<AccountBudgetPost>();

    //public virtual ICollection<AccountCashRounding> AccountCashRoundingCreateUs { get; } = new List<AccountCashRounding>();

    //public virtual ICollection<AccountCashRounding> AccountCashRoundingWriteUs { get; } = new List<AccountCashRounding>();

    //public virtual ICollection<AccountCashbookReport> AccountCashbookReportCreateUs { get; } = new List<AccountCashbookReport>();

    //public virtual ICollection<AccountCashbookReport> AccountCashbookReportWriteUs { get; } = new List<AccountCashbookReport>();

    //public virtual ICollection<AccountChartTemplate> AccountChartTemplateCreateUs { get; } = new List<AccountChartTemplate>();

    //public virtual ICollection<AccountChartTemplate> AccountChartTemplateWriteUs { get; } = new List<AccountChartTemplate>();

    //public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReportCreateUs { get; } = new List<AccountCommonAccountReport>();

    //public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReportWriteUs { get; } = new List<AccountCommonAccountReport>();

    //public virtual ICollection<AccountCommonJournalReport> AccountCommonJournalReportCreateUs { get; } = new List<AccountCommonJournalReport>();

    //public virtual ICollection<AccountCommonJournalReport> AccountCommonJournalReportWriteUs { get; } = new List<AccountCommonJournalReport>();

    //public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReportCreateUs { get; } = new List<AccountCommonPartnerReport>();

    //public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReportWriteUs { get; } = new List<AccountCommonPartnerReport>();

    //public virtual ICollection<AccountCommonReport> AccountCommonReportCreateUs { get; } = new List<AccountCommonReport>();

    //public virtual ICollection<AccountCommonReport> AccountCommonReportWriteUs { get; } = new List<AccountCommonReport>();

    //public virtual ICollection<AccountDaybookReport> AccountDaybookReportCreateUs { get; } = new List<AccountDaybookReport>();

    //public virtual ICollection<AccountDaybookReport> AccountDaybookReportWriteUs { get; } = new List<AccountDaybookReport>();

    //public virtual ICollection<AccountEdiDocument> AccountEdiDocumentCreateUs { get; } = new List<AccountEdiDocument>();

    //public virtual ICollection<AccountEdiDocument> AccountEdiDocumentWriteUs { get; } = new List<AccountEdiDocument>();

    //public virtual ICollection<AccountEdiFormat> AccountEdiFormatCreateUs { get; } = new List<AccountEdiFormat>();

    //public virtual ICollection<AccountEdiFormat> AccountEdiFormatWriteUs { get; } = new List<AccountEdiFormat>();

    //public virtual ICollection<AccountFinancialReport> AccountFinancialReportCreateUs { get; } = new List<AccountFinancialReport>();

    //public virtual ICollection<AccountFinancialReport> AccountFinancialReportWriteUs { get; } = new List<AccountFinancialReport>();

    //public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOpCreateUs { get; } = new List<AccountFinancialYearOp>();

    //public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOpWriteUs { get; } = new List<AccountFinancialYearOp>();

    //public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountCreateUs { get; } = new List<AccountFiscalPositionAccount>();

    //public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateCreateUs { get; } = new List<AccountFiscalPositionAccountTemplate>();

    //public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateWriteUs { get; } = new List<AccountFiscalPositionAccountTemplate>();

    //public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountWriteUs { get; } = new List<AccountFiscalPositionAccount>();

    //public virtual ICollection<AccountFiscalPosition> AccountFiscalPositionCreateUs { get; } = new List<AccountFiscalPosition>();

    //public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxCreateUs { get; } = new List<AccountFiscalPositionTax>();

    //public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateCreateUs { get; } = new List<AccountFiscalPositionTaxTemplate>();

    //public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateWriteUs { get; } = new List<AccountFiscalPositionTaxTemplate>();

    //public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxWriteUs { get; } = new List<AccountFiscalPositionTax>();

    //public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplateCreateUs { get; } = new List<AccountFiscalPositionTemplate>();

    //public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplateWriteUs { get; } = new List<AccountFiscalPositionTemplate>();

    //public virtual ICollection<AccountFiscalPosition> AccountFiscalPositionWriteUs { get; } = new List<AccountFiscalPosition>();

    //public virtual ICollection<AccountFiscalYear> AccountFiscalYearCreateUs { get; } = new List<AccountFiscalYear>();

    //public virtual ICollection<AccountFiscalYear> AccountFiscalYearWriteUs { get; } = new List<AccountFiscalYear>();

    //public virtual ICollection<AccountFullReconcile> AccountFullReconcileCreateUs { get; } = new List<AccountFullReconcile>();

    //public virtual ICollection<AccountFullReconcile> AccountFullReconcileWriteUs { get; } = new List<AccountFullReconcile>();

    //public virtual ICollection<AccountGroup> AccountGroupCreateUs { get; } = new List<AccountGroup>();

    //public virtual ICollection<AccountGroupTemplate> AccountGroupTemplateCreateUs { get; } = new List<AccountGroupTemplate>();

    //public virtual ICollection<AccountGroupTemplate> AccountGroupTemplateWriteUs { get; } = new List<AccountGroupTemplate>();

    //public virtual ICollection<AccountGroup> AccountGroupWriteUs { get; } = new List<AccountGroup>();

    //public virtual ICollection<AccountIncoterm> AccountIncotermCreateUs { get; } = new List<AccountIncoterm>();

    //public virtual ICollection<AccountIncoterm> AccountIncotermWriteUs { get; } = new List<AccountIncoterm>();

    //public virtual ICollection<AccountInvoiceSend> AccountInvoiceSendCreateUs { get; } = new List<AccountInvoiceSend>();

    //public virtual ICollection<AccountInvoiceSend> AccountInvoiceSendWriteUs { get; } = new List<AccountInvoiceSend>();

    //public virtual ICollection<AccountJournal> AccountJournalCreateUs { get; } = new List<AccountJournal>();

    //public virtual ICollection<AccountJournalGroup> AccountJournalGroupCreateUs { get; } = new List<AccountJournalGroup>();

    //public virtual ICollection<AccountJournalGroup> AccountJournalGroupWriteUs { get; } = new List<AccountJournalGroup>();

    //public virtual ICollection<AccountJournal> AccountJournalSaleActivityUsers { get; } = new List<AccountJournal>();

    //public virtual ICollection<AccountJournal> AccountJournalWriteUs { get; } = new List<AccountJournal>();

    //public virtual ICollection<AccountMove> AccountMoveCreateUs { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountMove> AccountMoveInvoiceUsers { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLineCreateUs { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLineWriteUs { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMoveReversal> AccountMoveReversalCreateUs { get; } = new List<AccountMoveReversal>();

    //public virtual ICollection<AccountMoveReversal> AccountMoveReversalWriteUs { get; } = new List<AccountMoveReversal>();

    //public virtual ICollection<AccountMove> AccountMoveWriteUs { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileCreateUs { get; } = new List<AccountPartialReconcile>();

    //public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileWriteUs { get; } = new List<AccountPartialReconcile>();

    //public virtual ICollection<AccountPayment> AccountPaymentCreateUs { get; } = new List<AccountPayment>();

    //public virtual ICollection<AccountPaymentMethod> AccountPaymentMethodCreateUs { get; } = new List<AccountPaymentMethod>();

    //public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLineCreateUs { get; } = new List<AccountPaymentMethodLine>();

    //public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLineWriteUs { get; } = new List<AccountPaymentMethodLine>();

    //public virtual ICollection<AccountPaymentMethod> AccountPaymentMethodWriteUs { get; } = new List<AccountPaymentMethod>();

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterCreateUs { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterWriteUs { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPaymentTerm> AccountPaymentTermCreateUs { get; } = new List<AccountPaymentTerm>();

    //public virtual ICollection<AccountPaymentTermLine> AccountPaymentTermLineCreateUs { get; } = new List<AccountPaymentTermLine>();

    //public virtual ICollection<AccountPaymentTermLine> AccountPaymentTermLineWriteUs { get; } = new List<AccountPaymentTermLine>();

    //public virtual ICollection<AccountPaymentTerm> AccountPaymentTermWriteUs { get; } = new List<AccountPaymentTerm>();

    //public virtual ICollection<AccountPayment> AccountPaymentWriteUs { get; } = new List<AccountPayment>();

    //public virtual ICollection<AccountPrintJournal> AccountPrintJournalCreateUs { get; } = new List<AccountPrintJournal>();

    //public virtual ICollection<AccountPrintJournal> AccountPrintJournalWriteUs { get; } = new List<AccountPrintJournal>();

    //public virtual ICollection<AccountReconcileModel> AccountReconcileModelCreateUs { get; } = new List<AccountReconcileModel>();

    //public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLineCreateUs { get; } = new List<AccountReconcileModelLine>();

    //public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplateCreateUs { get; } = new List<AccountReconcileModelLineTemplate>();

    //public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplateWriteUs { get; } = new List<AccountReconcileModelLineTemplate>();

    //public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLineWriteUs { get; } = new List<AccountReconcileModelLine>();

    //public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappingCreateUs { get; } = new List<AccountReconcileModelPartnerMapping>();

    //public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappingWriteUs { get; } = new List<AccountReconcileModelPartnerMapping>();

    //public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplateCreateUs { get; } = new List<AccountReconcileModelTemplate>();

    //public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplateWriteUs { get; } = new List<AccountReconcileModelTemplate>();

    //public virtual ICollection<AccountReconcileModel> AccountReconcileModelWriteUs { get; } = new List<AccountReconcileModel>();

    //public virtual ICollection<AccountRecurringTemplate> AccountRecurringTemplateCreateUs { get; } = new List<AccountRecurringTemplate>();

    //public virtual ICollection<AccountRecurringTemplate> AccountRecurringTemplateWriteUs { get; } = new List<AccountRecurringTemplate>();

    //public virtual ICollection<AccountReportColumn> AccountReportColumnCreateUs { get; } = new List<AccountReportColumn>();

    //public virtual ICollection<AccountReportColumn> AccountReportColumnWriteUs { get; } = new List<AccountReportColumn>();

    //public virtual ICollection<AccountReport> AccountReportCreateUs { get; } = new List<AccountReport>();

    //public virtual ICollection<AccountReportExpression> AccountReportExpressionCreateUs { get; } = new List<AccountReportExpression>();

    //public virtual ICollection<AccountReportExpression> AccountReportExpressionWriteUs { get; } = new List<AccountReportExpression>();

    //public virtual ICollection<AccountReportExternalValue> AccountReportExternalValueCreateUs { get; } = new List<AccountReportExternalValue>();

    //public virtual ICollection<AccountReportExternalValue> AccountReportExternalValueWriteUs { get; } = new List<AccountReportExternalValue>();

    //public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgerCreateUs { get; } = new List<AccountReportGeneralLedger>();

    //public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgerWriteUs { get; } = new List<AccountReportGeneralLedger>();

    //public virtual ICollection<AccountReportLine> AccountReportLineCreateUs { get; } = new List<AccountReportLine>();

    //public virtual ICollection<AccountReportLine> AccountReportLineWriteUs { get; } = new List<AccountReportLine>();

    //public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgerCreateUs { get; } = new List<AccountReportPartnerLedger>();

    //public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgerWriteUs { get; } = new List<AccountReportPartnerLedger>();

    //public virtual ICollection<AccountReport> AccountReportWriteUs { get; } = new List<AccountReport>();

    //public virtual ICollection<AccountResequenceWizard> AccountResequenceWizardCreateUs { get; } = new List<AccountResequenceWizard>();

    //public virtual ICollection<AccountResequenceWizard> AccountResequenceWizardWriteUs { get; } = new List<AccountResequenceWizard>();

    //public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigCreateUs { get; } = new List<AccountSetupBankManualConfig>();

    //public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigWriteUs { get; } = new List<AccountSetupBankManualConfig>();

    //public virtual ICollection<AccountTax> AccountTaxCreateUs { get; } = new List<AccountTax>();

    //public virtual ICollection<AccountTaxGroup> AccountTaxGroupCreateUs { get; } = new List<AccountTaxGroup>();

    //public virtual ICollection<AccountTaxGroup> AccountTaxGroupWriteUs { get; } = new List<AccountTaxGroup>();

    //public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineCreateUs { get; } = new List<AccountTaxRepartitionLine>();

    //public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateCreateUs { get; } = new List<AccountTaxRepartitionLineTemplate>();

    //public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateWriteUs { get; } = new List<AccountTaxRepartitionLineTemplate>();

    //public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineWriteUs { get; } = new List<AccountTaxRepartitionLine>();

    //public virtual ICollection<AccountTaxReportWizard> AccountTaxReportWizardCreateUs { get; } = new List<AccountTaxReportWizard>();

    //public virtual ICollection<AccountTaxReportWizard> AccountTaxReportWizardWriteUs { get; } = new List<AccountTaxReportWizard>();

    //public virtual ICollection<AccountTaxTemplate> AccountTaxTemplateCreateUs { get; } = new List<AccountTaxTemplate>();

    //public virtual ICollection<AccountTaxTemplate> AccountTaxTemplateWriteUs { get; } = new List<AccountTaxTemplate>();

    //public virtual ICollection<AccountTax> AccountTaxWriteUs { get; } = new List<AccountTax>();

    //public virtual ICollection<AccountTourUploadBill> AccountTourUploadBillCreateUs { get; } = new List<AccountTourUploadBill>();

    //public virtual ICollection<AccountTourUploadBillEmailConfirm> AccountTourUploadBillEmailConfirmCreateUs { get; } = new List<AccountTourUploadBillEmailConfirm>();

    //public virtual ICollection<AccountTourUploadBillEmailConfirm> AccountTourUploadBillEmailConfirmWriteUs { get; } = new List<AccountTourUploadBillEmailConfirm>();

    //public virtual ICollection<AccountTourUploadBill> AccountTourUploadBillWriteUs { get; } = new List<AccountTourUploadBill>();

    //public virtual ICollection<AccountUnreconcile> AccountUnreconcileCreateUs { get; } = new List<AccountUnreconcile>();

    //public virtual ICollection<AccountUnreconcile> AccountUnreconcileWriteUs { get; } = new List<AccountUnreconcile>();

    //public virtual ICollection<AccountingReport> AccountingReportCreateUs { get; } = new List<AccountingReport>();

    //public virtual ICollection<AccountingReport> AccountingReportWriteUs { get; } = new List<AccountingReport>();

    //public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasonCreateUs { get; } = new List<ApplicantGetRefuseReason>();

    //public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasonWriteUs { get; } = new List<ApplicantGetRefuseReason>();

    //public virtual ICollection<ApplicantSendMail> ApplicantSendMailCreateUs { get; } = new List<ApplicantSendMail>();

    //public virtual ICollection<ApplicantSendMail> ApplicantSendMailWriteUs { get; } = new List<ApplicantSendMail>();

    //public virtual ICollection<AssetDepreciationConfirmationWizard> AssetDepreciationConfirmationWizardCreateUs { get; } = new List<AssetDepreciationConfirmationWizard>();

    //public virtual ICollection<AssetDepreciationConfirmationWizard> AssetDepreciationConfirmationWizardWriteUs { get; } = new List<AssetDepreciationConfirmationWizard>();

    //public virtual ICollection<AssetModify> AssetModifyCreateUs { get; } = new List<AssetModify>();

    //public virtual ICollection<AssetModify> AssetModifyWriteUs { get; } = new List<AssetModify>();

    //public virtual ICollection<AuthTotpDevice> AuthTotpDevices { get; } = new List<AuthTotpDevice>();

    //public virtual ICollection<AuthTotpWizard> AuthTotpWizardCreateUs { get; } = new List<AuthTotpWizard>();

    //public virtual ICollection<AuthTotpWizard> AuthTotpWizardUsers { get; } = new List<AuthTotpWizard>();

    //public virtual ICollection<AuthTotpWizard> AuthTotpWizardWriteUs { get; } = new List<AuthTotpWizard>();

    //public virtual ICollection<BarcodeNomenclature> BarcodeNomenclatureCreateUs { get; } = new List<BarcodeNomenclature>();

    //public virtual ICollection<BarcodeNomenclature> BarcodeNomenclatureWriteUs { get; } = new List<BarcodeNomenclature>();

    //public virtual ICollection<BarcodeRule> BarcodeRuleCreateUs { get; } = new List<BarcodeRule>();

    //public virtual ICollection<BarcodeRule> BarcodeRuleWriteUs { get; } = new List<BarcodeRule>();

    //public virtual ICollection<BaseDocumentLayout> BaseDocumentLayoutCreateUs { get; } = new List<BaseDocumentLayout>();

    //public virtual ICollection<BaseDocumentLayout> BaseDocumentLayoutWriteUs { get; } = new List<BaseDocumentLayout>();

    //public virtual ICollection<BaseEnableProfilingWizard> BaseEnableProfilingWizardCreateUs { get; } = new List<BaseEnableProfilingWizard>();

    //public virtual ICollection<BaseEnableProfilingWizard> BaseEnableProfilingWizardWriteUs { get; } = new List<BaseEnableProfilingWizard>();

    //public virtual ICollection<BaseImportImport> BaseImportImportCreateUs { get; } = new List<BaseImportImport>();

    //public virtual ICollection<BaseImportImport> BaseImportImportWriteUs { get; } = new List<BaseImportImport>();

    //public virtual ICollection<BaseImportMapping> BaseImportMappingCreateUs { get; } = new List<BaseImportMapping>();

    //public virtual ICollection<BaseImportMapping> BaseImportMappingWriteUs { get; } = new List<BaseImportMapping>();

    //public virtual ICollection<BaseImportTestsModelsChar> BaseImportTestsModelsCharCreateUs { get; } = new List<BaseImportTestsModelsChar>();

    //public virtual ICollection<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlyCreateUs { get; } = new List<BaseImportTestsModelsCharNoreadonly>();

    //public virtual ICollection<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlyWriteUs { get; } = new List<BaseImportTestsModelsCharNoreadonly>();

    //public virtual ICollection<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlyCreateUs { get; } = new List<BaseImportTestsModelsCharReadonly>();

    //public virtual ICollection<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlyWriteUs { get; } = new List<BaseImportTestsModelsCharReadonly>();

    //public virtual ICollection<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequiredCreateUs { get; } = new List<BaseImportTestsModelsCharRequired>();

    //public virtual ICollection<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequiredWriteUs { get; } = new List<BaseImportTestsModelsCharRequired>();

    //public virtual ICollection<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStateCreateUs { get; } = new List<BaseImportTestsModelsCharState>();

    //public virtual ICollection<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStateWriteUs { get; } = new List<BaseImportTestsModelsCharState>();

    //public virtual ICollection<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlyCreateUs { get; } = new List<BaseImportTestsModelsCharStillreadonly>();

    //public virtual ICollection<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlyWriteUs { get; } = new List<BaseImportTestsModelsCharStillreadonly>();

    //public virtual ICollection<BaseImportTestsModelsChar> BaseImportTestsModelsCharWriteUs { get; } = new List<BaseImportTestsModelsChar>();

    //public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexCreateUs { get; } = new List<BaseImportTestsModelsComplex>();

    //public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexWriteUs { get; } = new List<BaseImportTestsModelsComplex>();

    //public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloatCreateUs { get; } = new List<BaseImportTestsModelsFloat>();

    //public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloatWriteUs { get; } = new List<BaseImportTestsModelsFloat>();

    //public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2oCreateUs { get; } = new List<BaseImportTestsModelsM2o>();

    //public virtual ICollection<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelatedCreateUs { get; } = new List<BaseImportTestsModelsM2oRelated>();

    //public virtual ICollection<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelatedWriteUs { get; } = new List<BaseImportTestsModelsM2oRelated>();

    //public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequiredCreateUs { get; } = new List<BaseImportTestsModelsM2oRequired>();

    //public virtual ICollection<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelatedCreateUs { get; } = new List<BaseImportTestsModelsM2oRequiredRelated>();

    //public virtual ICollection<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelatedWriteUs { get; } = new List<BaseImportTestsModelsM2oRequiredRelated>();

    //public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequiredWriteUs { get; } = new List<BaseImportTestsModelsM2oRequired>();

    //public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2oWriteUs { get; } = new List<BaseImportTestsModelsM2o>();

    //public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildCreateUs { get; } = new List<BaseImportTestsModelsO2mChild>();

    //public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildWriteUs { get; } = new List<BaseImportTestsModelsO2mChild>();

    //public virtual ICollection<BaseImportTestsModelsO2m> BaseImportTestsModelsO2mCreateUs { get; } = new List<BaseImportTestsModelsO2m>();

    //public virtual ICollection<BaseImportTestsModelsO2m> BaseImportTestsModelsO2mWriteUs { get; } = new List<BaseImportTestsModelsO2m>();

    //public virtual ICollection<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviewCreateUs { get; } = new List<BaseImportTestsModelsPreview>();

    //public virtual ICollection<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviewWriteUs { get; } = new List<BaseImportTestsModelsPreview>();

    //public virtual ICollection<BaseLanguageExport> BaseLanguageExportCreateUs { get; } = new List<BaseLanguageExport>();

    //public virtual ICollection<BaseLanguageExport> BaseLanguageExportWriteUs { get; } = new List<BaseLanguageExport>();

    //public virtual ICollection<BaseLanguageImport> BaseLanguageImportCreateUs { get; } = new List<BaseLanguageImport>();

    //public virtual ICollection<BaseLanguageImport> BaseLanguageImportWriteUs { get; } = new List<BaseLanguageImport>();

    //public virtual ICollection<BaseLanguageInstall> BaseLanguageInstallCreateUs { get; } = new List<BaseLanguageInstall>();

    //public virtual ICollection<BaseLanguageInstall> BaseLanguageInstallWriteUs { get; } = new List<BaseLanguageInstall>();

    //public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestCreateUs { get; } = new List<BaseModuleInstallRequest>();

    //public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestUsers { get; } = new List<BaseModuleInstallRequest>();

    //public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestWriteUs { get; } = new List<BaseModuleInstallRequest>();

    //public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviewCreateUs { get; } = new List<BaseModuleInstallReview>();

    //public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviewWriteUs { get; } = new List<BaseModuleInstallReview>();

    //public virtual ICollection<BaseModuleUninstall> BaseModuleUninstallCreateUs { get; } = new List<BaseModuleUninstall>();

    //public virtual ICollection<BaseModuleUninstall> BaseModuleUninstallWriteUs { get; } = new List<BaseModuleUninstall>();

    //public virtual ICollection<BaseModuleUpdate> BaseModuleUpdateCreateUs { get; } = new List<BaseModuleUpdate>();

    //public virtual ICollection<BaseModuleUpdate> BaseModuleUpdateWriteUs { get; } = new List<BaseModuleUpdate>();

    //public virtual ICollection<BaseModuleUpgrade> BaseModuleUpgradeCreateUs { get; } = new List<BaseModuleUpgrade>();

    //public virtual ICollection<BaseModuleUpgrade> BaseModuleUpgradeWriteUs { get; } = new List<BaseModuleUpgrade>();

    //public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardCreateUs { get; } = new List<BasePartnerMergeAutomaticWizard>();

    //public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardWriteUs { get; } = new List<BasePartnerMergeAutomaticWizard>();

    //public virtual ICollection<BasePartnerMergeLine> BasePartnerMergeLineCreateUs { get; } = new List<BasePartnerMergeLine>();

    //public virtual ICollection<BasePartnerMergeLine> BasePartnerMergeLineWriteUs { get; } = new List<BasePartnerMergeLine>();

    //public virtual ICollection<BusBu> BusBuCreateUs { get; } = new List<BusBu>();

    //public virtual ICollection<BusBu> BusBuWriteUs { get; } = new List<BusBu>();

    public virtual BusPresence? BusPresence { get; set; }

    //public virtual ICollection<CalendarAlarm> CalendarAlarmCreateUs { get; } = new List<CalendarAlarm>();

    //public virtual ICollection<CalendarAlarm> CalendarAlarmWriteUs { get; } = new List<CalendarAlarm>();

    //public virtual ICollection<CalendarAttendee> CalendarAttendeeCreateUs { get; } = new List<CalendarAttendee>();

    //public virtual ICollection<CalendarAttendee> CalendarAttendeeWriteUs { get; } = new List<CalendarAttendee>();

    //public virtual ICollection<CalendarEvent> CalendarEventCreateUs { get; } = new List<CalendarEvent>();

    //public virtual ICollection<CalendarEventType> CalendarEventTypeCreateUs { get; } = new List<CalendarEventType>();

    //public virtual ICollection<CalendarEventType> CalendarEventTypeWriteUs { get; } = new List<CalendarEventType>();

    //public virtual ICollection<CalendarEvent> CalendarEventUsers { get; } = new List<CalendarEvent>();

    //public virtual ICollection<CalendarEvent> CalendarEventWriteUs { get; } = new List<CalendarEvent>();

    //public virtual ICollection<CalendarFilter> CalendarFilterCreateUs { get; } = new List<CalendarFilter>();

    //public virtual ICollection<CalendarFilter> CalendarFilterUsers { get; } = new List<CalendarFilter>();

    //public virtual ICollection<CalendarFilter> CalendarFilterWriteUs { get; } = new List<CalendarFilter>();

    //public virtual ICollection<CalendarProviderConfig> CalendarProviderConfigCreateUs { get; } = new List<CalendarProviderConfig>();

    //public virtual ICollection<CalendarProviderConfig> CalendarProviderConfigWriteUs { get; } = new List<CalendarProviderConfig>();

    //public virtual ICollection<CalendarRecurrence> CalendarRecurrenceCreateUs { get; } = new List<CalendarRecurrence>();

    //public virtual ICollection<CalendarRecurrence> CalendarRecurrenceWriteUs { get; } = new List<CalendarRecurrence>();

    //public virtual ICollection<ChangeLockDate> ChangeLockDateCreateUs { get; } = new List<ChangeLockDate>();

    //public virtual ICollection<ChangeLockDate> ChangeLockDateWriteUs { get; } = new List<ChangeLockDate>();

    //public virtual ICollection<ChangePasswordOwn> ChangePasswordOwnCreateUs { get; } = new List<ChangePasswordOwn>();

    //public virtual ICollection<ChangePasswordOwn> ChangePasswordOwnWriteUs { get; } = new List<ChangePasswordOwn>();

    //public virtual ICollection<ChangePasswordUser> ChangePasswordUserCreateUs { get; } = new List<ChangePasswordUser>();

    //public virtual ICollection<ChangePasswordUser> ChangePasswordUserUsers { get; } = new List<ChangePasswordUser>();

    //public virtual ICollection<ChangePasswordUser> ChangePasswordUserWriteUs { get; } = new List<ChangePasswordUser>();

    //public virtual ICollection<ChangePasswordWizard> ChangePasswordWizardCreateUs { get; } = new List<ChangePasswordWizard>();

    //public virtual ICollection<ChangePasswordWizard> ChangePasswordWizardWriteUs { get; } = new List<ChangePasswordWizard>();

    //public virtual ICollection<ChangeProductionQty> ChangeProductionQtyCreateUs { get; } = new List<ChangeProductionQty>();

    //public virtual ICollection<ChangeProductionQty> ChangeProductionQtyWriteUs { get; } = new List<ChangeProductionQty>();

    public virtual ResCompany? Company { get; set; }

    //public virtual ICollection<ConfirmStockSm> ConfirmStockSmCreateUs { get; } = new List<ConfirmStockSm>();

    //public virtual ICollection<ConfirmStockSm> ConfirmStockSmWriteUs { get; } = new List<ConfirmStockSm>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmIapLeadHelper> CrmIapLeadHelperCreateUs { get; } = new List<CrmIapLeadHelper>();

    //public virtual ICollection<CrmIapLeadHelper> CrmIapLeadHelperWriteUs { get; } = new List<CrmIapLeadHelper>();

    //public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustryCreateUs { get; } = new List<CrmIapLeadIndustry>();

    //public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustryWriteUs { get; } = new List<CrmIapLeadIndustry>();

    //public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestCreateUs { get; } = new List<CrmIapLeadMiningRequest>();

    //public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestUsers { get; } = new List<CrmIapLeadMiningRequest>();

    //public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestWriteUs { get; } = new List<CrmIapLeadMiningRequest>();

    //public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoleCreateUs { get; } = new List<CrmIapLeadRole>();

    //public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoleWriteUs { get; } = new List<CrmIapLeadRole>();

    //public virtual ICollection<CrmIapLeadSeniority> CrmIapLeadSeniorityCreateUs { get; } = new List<CrmIapLeadSeniority>();

    //public virtual ICollection<CrmIapLeadSeniority> CrmIapLeadSeniorityWriteUs { get; } = new List<CrmIapLeadSeniority>();

    //public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerCreateUs { get; } = new List<CrmLead2opportunityPartner>();

    //public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassCreateUs { get; } = new List<CrmLead2opportunityPartnerMass>();

    //public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassUsers { get; } = new List<CrmLead2opportunityPartnerMass>();

    //public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassWriteUs { get; } = new List<CrmLead2opportunityPartnerMass>();

    //public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerUsers { get; } = new List<CrmLead2opportunityPartner>();

    //public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerWriteUs { get; } = new List<CrmLead2opportunityPartner>();

    //public virtual ICollection<CrmLead> CrmLeadCreateUs { get; } = new List<CrmLead>();

    //public virtual ICollection<CrmLeadLost> CrmLeadLostCreateUs { get; } = new List<CrmLeadLost>();

    //public virtual ICollection<CrmLeadLost> CrmLeadLostWriteUs { get; } = new List<CrmLeadLost>();

    //public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdateCreateUs { get; } = new List<CrmLeadPlsUpdate>();

    //public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdateWriteUs { get; } = new List<CrmLeadPlsUpdate>();

    //public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencyCreateUs { get; } = new List<CrmLeadScoringFrequency>();

    //public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFieldCreateUs { get; } = new List<CrmLeadScoringFrequencyField>();

    //public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFieldWriteUs { get; } = new List<CrmLeadScoringFrequencyField>();

    //public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencyWriteUs { get; } = new List<CrmLeadScoringFrequency>();

    //public virtual ICollection<CrmLead> CrmLeadUsers { get; } = new List<CrmLead>();

    //public virtual ICollection<CrmLead> CrmLeadWriteUs { get; } = new List<CrmLead>();

    //public virtual ICollection<CrmLostReason> CrmLostReasonCreateUs { get; } = new List<CrmLostReason>();

    //public virtual ICollection<CrmLostReason> CrmLostReasonWriteUs { get; } = new List<CrmLostReason>();

    //public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityCreateUs { get; } = new List<CrmMergeOpportunity>();

    //public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityUsers { get; } = new List<CrmMergeOpportunity>();

    //public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityWriteUs { get; } = new List<CrmMergeOpportunity>();

    //public virtual ICollection<CrmQuotationPartner> CrmQuotationPartnerCreateUs { get; } = new List<CrmQuotationPartner>();

    //public virtual ICollection<CrmQuotationPartner> CrmQuotationPartnerWriteUs { get; } = new List<CrmQuotationPartner>();

    //public virtual ICollection<CrmRecurringPlan> CrmRecurringPlanCreateUs { get; } = new List<CrmRecurringPlan>();

    //public virtual ICollection<CrmRecurringPlan> CrmRecurringPlanWriteUs { get; } = new List<CrmRecurringPlan>();

    //public virtual ICollection<CrmStage> CrmStageCreateUs { get; } = new List<CrmStage>();

    //public virtual ICollection<CrmStage> CrmStageWriteUs { get; } = new List<CrmStage>();

    //public virtual ICollection<CrmTag> CrmTagCreateUs { get; } = new List<CrmTag>();

    //public virtual ICollection<CrmTag> CrmTagWriteUs { get; } = new List<CrmTag>();

    //public virtual ICollection<CrmTeam> CrmTeamCreateUs { get; } = new List<CrmTeam>();

    //public virtual ICollection<CrmTeamMember> CrmTeamMemberCreateUs { get; } = new List<CrmTeamMember>();

    //public virtual ICollection<CrmTeamMember> CrmTeamMemberUsers { get; } = new List<CrmTeamMember>();

    //public virtual ICollection<CrmTeamMember> CrmTeamMemberWriteUs { get; } = new List<CrmTeamMember>();

    //public virtual ICollection<CrmTeam> CrmTeamUsers { get; } = new List<CrmTeam>();

    //public virtual ICollection<CrmTeam> CrmTeamWriteUs { get; } = new List<CrmTeam>();

    //public virtual ICollection<CrossoveredBudget> CrossoveredBudgetCreateUs { get; } = new List<CrossoveredBudget>();

    //public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLineCreateUs { get; } = new List<CrossoveredBudgetLine>();

    //public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLineWriteUs { get; } = new List<CrossoveredBudgetLine>();

    //public virtual ICollection<CrossoveredBudget> CrossoveredBudgetUsers { get; } = new List<CrossoveredBudget>();

    //public virtual ICollection<CrossoveredBudget> CrossoveredBudgetWriteUs { get; } = new List<CrossoveredBudget>();

    //public virtual ICollection<DecimalPrecision> DecimalPrecisionCreateUs { get; } = new List<DecimalPrecision>();

    //public virtual ICollection<DecimalPrecision> DecimalPrecisionWriteUs { get; } = new List<DecimalPrecision>();

    //public virtual ICollection<DigestDigest> DigestDigestCreateUs { get; } = new List<DigestDigest>();

    //public virtual ICollection<DigestDigest> DigestDigestWriteUs { get; } = new List<DigestDigest>();

    //public virtual ICollection<DigestTip> DigestTipCreateUs { get; } = new List<DigestTip>();

    //public virtual ICollection<DigestTip> DigestTipWriteUs { get; } = new List<DigestTip>();

    //public virtual ICollection<FetchmailServer> FetchmailServerCreateUs { get; } = new List<FetchmailServer>();

    //public virtual ICollection<FetchmailServer> FetchmailServerWriteUs { get; } = new List<FetchmailServer>();

    //public virtual ICollection<FleetServiceType> FleetServiceTypeCreateUs { get; } = new List<FleetServiceType>();

    //public virtual ICollection<FleetServiceType> FleetServiceTypeWriteUs { get; } = new List<FleetServiceType>();

    //public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogCreateUs { get; } = new List<FleetVehicleAssignationLog>();

    //public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogWriteUs { get; } = new List<FleetVehicleAssignationLog>();

    //public virtual ICollection<FleetVehicle> FleetVehicleCreateUs { get; } = new List<FleetVehicle>();

    //public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractCreateUs { get; } = new List<FleetVehicleLogContract>();

    //public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractUsers { get; } = new List<FleetVehicleLogContract>();

    //public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractWriteUs { get; } = new List<FleetVehicleLogContract>();

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceCreateUs { get; } = new List<FleetVehicleLogService>();

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceManagers { get; } = new List<FleetVehicleLogService>();

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceWriteUs { get; } = new List<FleetVehicleLogService>();

    //public virtual ICollection<FleetVehicle> FleetVehicleManagers { get; } = new List<FleetVehicle>();

    //public virtual ICollection<FleetVehicleModelBrand> FleetVehicleModelBrandCreateUs { get; } = new List<FleetVehicleModelBrand>();

    //public virtual ICollection<FleetVehicleModelBrand> FleetVehicleModelBrandWriteUs { get; } = new List<FleetVehicleModelBrand>();

    //public virtual ICollection<FleetVehicleModelCategory> FleetVehicleModelCategoryCreateUs { get; } = new List<FleetVehicleModelCategory>();

    //public virtual ICollection<FleetVehicleModelCategory> FleetVehicleModelCategoryWriteUs { get; } = new List<FleetVehicleModelCategory>();

    //public virtual ICollection<FleetVehicleModel> FleetVehicleModelCreateUs { get; } = new List<FleetVehicleModel>();

    //public virtual ICollection<FleetVehicleModel> FleetVehicleModelWriteUs { get; } = new List<FleetVehicleModel>();

    //public virtual ICollection<FleetVehicleOdometer> FleetVehicleOdometerCreateUs { get; } = new List<FleetVehicleOdometer>();

    //public virtual ICollection<FleetVehicleOdometer> FleetVehicleOdometerWriteUs { get; } = new List<FleetVehicleOdometer>();

    //public virtual ICollection<FleetVehicleState> FleetVehicleStateCreateUs { get; } = new List<FleetVehicleState>();

    //public virtual ICollection<FleetVehicleState> FleetVehicleStateWriteUs { get; } = new List<FleetVehicleState>();

    //public virtual ICollection<FleetVehicleTag> FleetVehicleTagCreateUs { get; } = new List<FleetVehicleTag>();

    //public virtual ICollection<FleetVehicleTag> FleetVehicleTagWriteUs { get; } = new List<FleetVehicleTag>();

    //public virtual ICollection<FleetVehicle> FleetVehicleWriteUs { get; } = new List<FleetVehicle>();

    //public virtual ICollection<FollowupFollowup> FollowupFollowupCreateUs { get; } = new List<FollowupFollowup>();

    //public virtual ICollection<FollowupFollowup> FollowupFollowupWriteUs { get; } = new List<FollowupFollowup>();

    //public virtual ICollection<FollowupLine> FollowupLineCreateUs { get; } = new List<FollowupLine>();

    //public virtual ICollection<FollowupLine> FollowupLineManualActionResponsibles { get; } = new List<FollowupLine>();

    //public virtual ICollection<FollowupLine> FollowupLineWriteUs { get; } = new List<FollowupLine>();

    //public virtual ICollection<FollowupPrint> FollowupPrintCreateUs { get; } = new List<FollowupPrint>();

    //public virtual ICollection<FollowupPrint> FollowupPrintWriteUs { get; } = new List<FollowupPrint>();

    //public virtual ICollection<FollowupSendingResult> FollowupSendingResultCreateUs { get; } = new List<FollowupSendingResult>();

    //public virtual ICollection<FollowupSendingResult> FollowupSendingResultWriteUs { get; } = new List<FollowupSendingResult>();

    //public virtual ICollection<HrApplicantCategory> HrApplicantCategoryCreateUs { get; } = new List<HrApplicantCategory>();

    //public virtual ICollection<HrApplicantCategory> HrApplicantCategoryWriteUs { get; } = new List<HrApplicantCategory>();

    //public virtual ICollection<HrApplicant> HrApplicantCreateUs { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrApplicantRefuseReason> HrApplicantRefuseReasonCreateUs { get; } = new List<HrApplicantRefuseReason>();

    //public virtual ICollection<HrApplicantRefuseReason> HrApplicantRefuseReasonWriteUs { get; } = new List<HrApplicantRefuseReason>();

    //public virtual ICollection<HrApplicantSkill> HrApplicantSkillCreateUs { get; } = new List<HrApplicantSkill>();

    //public virtual ICollection<HrApplicantSkill> HrApplicantSkillWriteUs { get; } = new List<HrApplicantSkill>();

    //public virtual ICollection<HrApplicant> HrApplicantUsers { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrApplicant> HrApplicantWriteUs { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrAttendance> HrAttendanceCreateUs { get; } = new List<HrAttendance>();

    //public virtual ICollection<HrAttendanceOvertime> HrAttendanceOvertimeCreateUs { get; } = new List<HrAttendanceOvertime>();

    //public virtual ICollection<HrAttendanceOvertime> HrAttendanceOvertimeWriteUs { get; } = new List<HrAttendanceOvertime>();

    //public virtual ICollection<HrAttendance> HrAttendanceWriteUs { get; } = new List<HrAttendance>();

    //public virtual ICollection<HrContract> HrContractCreateUs { get; } = new List<HrContract>();

    //public virtual ICollection<HrContract> HrContractHrResponsibles { get; } = new List<HrContract>();

    //public virtual ICollection<HrContractType> HrContractTypeCreateUs { get; } = new List<HrContractType>();

    //public virtual ICollection<HrContractType> HrContractTypeWriteUs { get; } = new List<HrContractType>();

    //public virtual ICollection<HrContract> HrContractWriteUs { get; } = new List<HrContract>();

    //public virtual ICollection<HrDepartment> HrDepartmentCreateUs { get; } = new List<HrDepartment>();

    //public virtual ICollection<HrDepartment> HrDepartmentWriteUs { get; } = new List<HrDepartment>();

    //public virtual ICollection<HrDepartureReason> HrDepartureReasonCreateUs { get; } = new List<HrDepartureReason>();

    //public virtual ICollection<HrDepartureReason> HrDepartureReasonWriteUs { get; } = new List<HrDepartureReason>();

    //public virtual ICollection<HrDepartureWizard> HrDepartureWizardCreateUs { get; } = new List<HrDepartureWizard>();

    //public virtual ICollection<HrDepartureWizard> HrDepartureWizardWriteUs { get; } = new List<HrDepartureWizard>();

    //public virtual ICollection<HrEmployeeCategory> HrEmployeeCategoryCreateUs { get; } = new List<HrEmployeeCategory>();

    //public virtual ICollection<HrEmployeeCategory> HrEmployeeCategoryWriteUs { get; } = new List<HrEmployeeCategory>();

    //public virtual ICollection<HrEmployee> HrEmployeeCreateUs { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrEmployee> HrEmployeeExpenseManagers { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrEmployee> HrEmployeeLeaveManagers { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrEmployeeSkill> HrEmployeeSkillCreateUs { get; } = new List<HrEmployeeSkill>();

    //public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogCreateUs { get; } = new List<HrEmployeeSkillLog>();

    //public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogWriteUs { get; } = new List<HrEmployeeSkillLog>();

    //public virtual ICollection<HrEmployeeSkill> HrEmployeeSkillWriteUs { get; } = new List<HrEmployeeSkill>();

    //public virtual ICollection<HrEmployee> HrEmployeeUsers { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrEmployee> HrEmployeeWriteUs { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicateCreateUs { get; } = new List<HrExpenseApproveDuplicate>();

    //public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicateWriteUs { get; } = new List<HrExpenseApproveDuplicate>();

    //public virtual ICollection<HrExpense> HrExpenseCreateUs { get; } = new List<HrExpense>();

    //public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizardCreateUs { get; } = new List<HrExpenseRefuseWizard>();

    //public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizardWriteUs { get; } = new List<HrExpenseRefuseWizard>();

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheetCreateUs { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheetUsers { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheetWriteUs { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrExpenseSplit> HrExpenseSplitCreateUs { get; } = new List<HrExpenseSplit>();

    //public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizardCreateUs { get; } = new List<HrExpenseSplitWizard>();

    //public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizardWriteUs { get; } = new List<HrExpenseSplitWizard>();

    //public virtual ICollection<HrExpenseSplit> HrExpenseSplitWriteUs { get; } = new List<HrExpenseSplit>();

    //public virtual ICollection<HrExpense> HrExpenseWriteUs { get; } = new List<HrExpense>();

    //public virtual ICollection<HrHolidaysCancelLeave> HrHolidaysCancelLeaveCreateUs { get; } = new List<HrHolidaysCancelLeave>();

    //public virtual ICollection<HrHolidaysCancelLeave> HrHolidaysCancelLeaveWriteUs { get; } = new List<HrHolidaysCancelLeave>();

    //public virtual ICollection<HrHolidaysSummaryEmployee> HrHolidaysSummaryEmployeeCreateUs { get; } = new List<HrHolidaysSummaryEmployee>();

    //public virtual ICollection<HrHolidaysSummaryEmployee> HrHolidaysSummaryEmployeeWriteUs { get; } = new List<HrHolidaysSummaryEmployee>();

    //public virtual ICollection<HrJob> HrJobCreateUs { get; } = new List<HrJob>();

    //public virtual ICollection<HrJob> HrJobHrResponsibles { get; } = new List<HrJob>();

    //public virtual ICollection<HrJob> HrJobUsers { get; } = new List<HrJob>();

    //public virtual ICollection<HrJob> HrJobWriteUs { get; } = new List<HrJob>();

    //public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevelCreateUs { get; } = new List<HrLeaveAccrualLevel>();

    //public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevelWriteUs { get; } = new List<HrLeaveAccrualLevel>();

    //public virtual ICollection<HrLeaveAccrualPlan> HrLeaveAccrualPlanCreateUs { get; } = new List<HrLeaveAccrualPlan>();

    //public virtual ICollection<HrLeaveAccrualPlan> HrLeaveAccrualPlanWriteUs { get; } = new List<HrLeaveAccrualPlan>();

    //public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationCreateUs { get; } = new List<HrLeaveAllocation>();

    //public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationWriteUs { get; } = new List<HrLeaveAllocation>();

    //public virtual ICollection<HrLeave> HrLeaveCreateUs { get; } = new List<HrLeave>();

    //public virtual ICollection<HrLeaveStressDay> HrLeaveStressDayCreateUs { get; } = new List<HrLeaveStressDay>();

    //public virtual ICollection<HrLeaveStressDay> HrLeaveStressDayWriteUs { get; } = new List<HrLeaveStressDay>();

    //public virtual ICollection<HrLeaveType> HrLeaveTypeCreateUs { get; } = new List<HrLeaveType>();

    //public virtual ICollection<HrLeaveType> HrLeaveTypeResponsibles { get; } = new List<HrLeaveType>();

    //public virtual ICollection<HrLeaveType> HrLeaveTypeWriteUs { get; } = new List<HrLeaveType>();

    //public virtual ICollection<HrLeave> HrLeaveUsers { get; } = new List<HrLeave>();

    //public virtual ICollection<HrLeave> HrLeaveWriteUs { get; } = new List<HrLeave>();

    //public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypeCreateUs { get; } = new List<HrPayrollStructureType>();

    //public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypeWriteUs { get; } = new List<HrPayrollStructureType>();

    //public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeCreateUs { get; } = new List<HrPlanActivityType>();

    //public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeResponsibleNavigations { get; } = new List<HrPlanActivityType>();

    //public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeWriteUs { get; } = new List<HrPlanActivityType>();

    //public virtual ICollection<HrPlan> HrPlanCreateUs { get; } = new List<HrPlan>();

    //public virtual ICollection<HrPlanWizard> HrPlanWizardCreateUs { get; } = new List<HrPlanWizard>();

    //public virtual ICollection<HrPlanWizard> HrPlanWizardWriteUs { get; } = new List<HrPlanWizard>();

    //public virtual ICollection<HrPlan> HrPlanWriteUs { get; } = new List<HrPlan>();

    //public virtual ICollection<HrRecruitmentDegree> HrRecruitmentDegreeCreateUs { get; } = new List<HrRecruitmentDegree>();

    //public virtual ICollection<HrRecruitmentDegree> HrRecruitmentDegreeWriteUs { get; } = new List<HrRecruitmentDegree>();

    //public virtual ICollection<HrRecruitmentSource> HrRecruitmentSourceCreateUs { get; } = new List<HrRecruitmentSource>();

    //public virtual ICollection<HrRecruitmentSource> HrRecruitmentSourceWriteUs { get; } = new List<HrRecruitmentSource>();

    //public virtual ICollection<HrRecruitmentStage> HrRecruitmentStageCreateUs { get; } = new List<HrRecruitmentStage>();

    //public virtual ICollection<HrRecruitmentStage> HrRecruitmentStageWriteUs { get; } = new List<HrRecruitmentStage>();

    //public virtual ICollection<HrResumeLine> HrResumeLineCreateUs { get; } = new List<HrResumeLine>();

    //public virtual ICollection<HrResumeLineType> HrResumeLineTypeCreateUs { get; } = new List<HrResumeLineType>();

    //public virtual ICollection<HrResumeLineType> HrResumeLineTypeWriteUs { get; } = new List<HrResumeLineType>();

    //public virtual ICollection<HrResumeLine> HrResumeLineWriteUs { get; } = new List<HrResumeLine>();

    //public virtual ICollection<HrSkill> HrSkillCreateUs { get; } = new List<HrSkill>();

    //public virtual ICollection<HrSkillLevel> HrSkillLevelCreateUs { get; } = new List<HrSkillLevel>();

    //public virtual ICollection<HrSkillLevel> HrSkillLevelWriteUs { get; } = new List<HrSkillLevel>();

    //public virtual ICollection<HrSkillType> HrSkillTypeCreateUs { get; } = new List<HrSkillType>();

    //public virtual ICollection<HrSkillType> HrSkillTypeWriteUs { get; } = new List<HrSkillType>();

    //public virtual ICollection<HrSkill> HrSkillWriteUs { get; } = new List<HrSkill>();

    //public virtual ICollection<HrWorkLocation> HrWorkLocationCreateUs { get; } = new List<HrWorkLocation>();

    //public virtual ICollection<HrWorkLocation> HrWorkLocationWriteUs { get; } = new List<HrWorkLocation>();

    //public virtual ICollection<IapAccount> IapAccountCreateUs { get; } = new List<IapAccount>();

    //public virtual ICollection<IapAccount> IapAccountWriteUs { get; } = new List<IapAccount>();

    //public virtual ICollection<ResUser> InverseCreateU { get; } = new List<ResUser>();

    //public virtual ICollection<ResUser> InverseWriteU { get; } = new List<ResUser>();

    //public virtual ICollection<IrActClient> IrActClientCreateUs { get; } = new List<IrActClient>();

    //public virtual ICollection<IrActClient> IrActClientWriteUs { get; } = new List<IrActClient>();

    //public virtual ICollection<IrActReportXml> IrActReportXmlCreateUs { get; } = new List<IrActReportXml>();

    //public virtual ICollection<IrActReportXml> IrActReportXmlWriteUs { get; } = new List<IrActReportXml>();

    //public virtual ICollection<IrActServer> IrActServerActivityUsers { get; } = new List<IrActServer>();

    //public virtual ICollection<IrActServer> IrActServerCreateUs { get; } = new List<IrActServer>();

    //public virtual ICollection<IrActServer> IrActServerWriteUs { get; } = new List<IrActServer>();

    //public virtual ICollection<IrActUrl> IrActUrlCreateUs { get; } = new List<IrActUrl>();

    //public virtual ICollection<IrActUrl> IrActUrlWriteUs { get; } = new List<IrActUrl>();

    //public virtual ICollection<IrActWindow> IrActWindowCreateUs { get; } = new List<IrActWindow>();

    //public virtual ICollection<IrActWindowView> IrActWindowViewCreateUs { get; } = new List<IrActWindowView>();

    //public virtual ICollection<IrActWindowView> IrActWindowViewWriteUs { get; } = new List<IrActWindowView>();

    //public virtual ICollection<IrActWindow> IrActWindowWriteUs { get; } = new List<IrActWindow>();

    //public virtual ICollection<IrAction> IrActionCreateUs { get; } = new List<IrAction>();

    //public virtual ICollection<IrAction> IrActionWriteUs { get; } = new List<IrAction>();

    //public virtual ICollection<IrActionsTodo> IrActionsTodoCreateUs { get; } = new List<IrActionsTodo>();

    //public virtual ICollection<IrActionsTodo> IrActionsTodoWriteUs { get; } = new List<IrActionsTodo>();

    //public virtual ICollection<IrAsset> IrAssetCreateUs { get; } = new List<IrAsset>();

    //public virtual ICollection<IrAsset> IrAssetWriteUs { get; } = new List<IrAsset>();

    //public virtual ICollection<IrAttachment> IrAttachmentCreateUs { get; } = new List<IrAttachment>();

    //public virtual ICollection<IrAttachment> IrAttachmentWriteUs { get; } = new List<IrAttachment>();

    //public virtual ICollection<IrConfigParameter> IrConfigParameterCreateUs { get; } = new List<IrConfigParameter>();

    //public virtual ICollection<IrConfigParameter> IrConfigParameterWriteUs { get; } = new List<IrConfigParameter>();

    //public virtual ICollection<IrCron> IrCronCreateUs { get; } = new List<IrCron>();

    //public virtual ICollection<IrCronTrigger> IrCronTriggerCreateUs { get; } = new List<IrCronTrigger>();

    //public virtual ICollection<IrCronTrigger> IrCronTriggerWriteUs { get; } = new List<IrCronTrigger>();

    //public virtual ICollection<IrCron> IrCronUsers { get; } = new List<IrCron>();

    //public virtual ICollection<IrCron> IrCronWriteUs { get; } = new List<IrCron>();

    //public virtual ICollection<IrDefault> IrDefaultCreateUs { get; } = new List<IrDefault>();

    //public virtual ICollection<IrDefault> IrDefaultUsers { get; } = new List<IrDefault>();

    //public virtual ICollection<IrDefault> IrDefaultWriteUs { get; } = new List<IrDefault>();

    //public virtual ICollection<IrDemo> IrDemoCreateUs { get; } = new List<IrDemo>();

    //public virtual ICollection<IrDemoFailure> IrDemoFailureCreateUs { get; } = new List<IrDemoFailure>();

    //public virtual ICollection<IrDemoFailureWizard> IrDemoFailureWizardCreateUs { get; } = new List<IrDemoFailureWizard>();

    //public virtual ICollection<IrDemoFailureWizard> IrDemoFailureWizardWriteUs { get; } = new List<IrDemoFailureWizard>();

    //public virtual ICollection<IrDemoFailure> IrDemoFailureWriteUs { get; } = new List<IrDemoFailure>();

    //public virtual ICollection<IrDemo> IrDemoWriteUs { get; } = new List<IrDemo>();

    //public virtual ICollection<IrExport> IrExportCreateUs { get; } = new List<IrExport>();

    //public virtual ICollection<IrExport> IrExportWriteUs { get; } = new List<IrExport>();

    //public virtual ICollection<IrExportsLine> IrExportsLineCreateUs { get; } = new List<IrExportsLine>();

    //public virtual ICollection<IrExportsLine> IrExportsLineWriteUs { get; } = new List<IrExportsLine>();

    //public virtual ICollection<IrFilter> IrFilterCreateUs { get; } = new List<IrFilter>();

    //public virtual ICollection<IrFilter> IrFilterUsers { get; } = new List<IrFilter>();

    //public virtual ICollection<IrFilter> IrFilterWriteUs { get; } = new List<IrFilter>();

    //public virtual ICollection<IrMailServer> IrMailServerCreateUs { get; } = new List<IrMailServer>();

    //public virtual ICollection<IrMailServer> IrMailServerWriteUs { get; } = new List<IrMailServer>();

    //public virtual ICollection<IrModelAccess> IrModelAccessCreateUs { get; } = new List<IrModelAccess>();

    //public virtual ICollection<IrModelAccess> IrModelAccessWriteUs { get; } = new List<IrModelAccess>();

    //public virtual ICollection<IrModelConstraint> IrModelConstraintCreateUs { get; } = new List<IrModelConstraint>();

    //public virtual ICollection<IrModelConstraint> IrModelConstraintWriteUs { get; } = new List<IrModelConstraint>();

    //public virtual ICollection<IrModel> IrModelCreateUs { get; } = new List<IrModel>();

    //public virtual ICollection<IrModelDatum> IrModelDatumCreateUs { get; } = new List<IrModelDatum>();

    //public virtual ICollection<IrModelDatum> IrModelDatumWriteUs { get; } = new List<IrModelDatum>();

    //public virtual ICollection<IrModelField> IrModelFieldCreateUs { get; } = new List<IrModelField>();

    //public virtual ICollection<IrModelField> IrModelFieldWriteUs { get; } = new List<IrModelField>();

    //public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelectionCreateUs { get; } = new List<IrModelFieldsSelection>();

    //public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelectionWriteUs { get; } = new List<IrModelFieldsSelection>();

    //public virtual ICollection<IrModelRelation> IrModelRelationCreateUs { get; } = new List<IrModelRelation>();

    //public virtual ICollection<IrModelRelation> IrModelRelationWriteUs { get; } = new List<IrModelRelation>();

    //public virtual ICollection<IrModel> IrModelWriteUs { get; } = new List<IrModel>();

    //public virtual ICollection<IrModuleCategory> IrModuleCategoryCreateUs { get; } = new List<IrModuleCategory>();

    //public virtual ICollection<IrModuleCategory> IrModuleCategoryWriteUs { get; } = new List<IrModuleCategory>();

    //public virtual ICollection<IrModuleModule> IrModuleModuleCreateUs { get; } = new List<IrModuleModule>();

    //public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusionCreateUs { get; } = new List<IrModuleModuleExclusion>();

    //public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusionWriteUs { get; } = new List<IrModuleModuleExclusion>();

    //public virtual ICollection<IrModuleModule> IrModuleModuleWriteUs { get; } = new List<IrModuleModule>();

    //public virtual ICollection<IrProperty> IrPropertyCreateUs { get; } = new List<IrProperty>();

    //public virtual ICollection<IrProperty> IrPropertyWriteUs { get; } = new List<IrProperty>();

    //public virtual ICollection<IrRule> IrRuleCreateUs { get; } = new List<IrRule>();

    //public virtual ICollection<IrRule> IrRuleWriteUs { get; } = new List<IrRule>();

    //public virtual ICollection<IrSequence> IrSequenceCreateUs { get; } = new List<IrSequence>();

    //public virtual ICollection<IrSequenceDateRange> IrSequenceDateRangeCreateUs { get; } = new List<IrSequenceDateRange>();

    //public virtual ICollection<IrSequenceDateRange> IrSequenceDateRangeWriteUs { get; } = new List<IrSequenceDateRange>();

    //public virtual ICollection<IrSequence> IrSequenceWriteUs { get; } = new List<IrSequence>();

    //public virtual ICollection<IrServerObjectLine> IrServerObjectLineCreateUs { get; } = new List<IrServerObjectLine>();

    //public virtual ICollection<IrServerObjectLine> IrServerObjectLineWriteUs { get; } = new List<IrServerObjectLine>();

    //public virtual ICollection<IrUiMenu> IrUiMenuCreateUs { get; } = new List<IrUiMenu>();

    //public virtual ICollection<IrUiMenu> IrUiMenuWriteUs { get; } = new List<IrUiMenu>();

    //public virtual ICollection<IrUiView> IrUiViewCreateUs { get; } = new List<IrUiView>();

    //public virtual ICollection<IrUiViewCustom> IrUiViewCustomCreateUs { get; } = new List<IrUiViewCustom>();

    //public virtual ICollection<IrUiViewCustom> IrUiViewCustomUsers { get; } = new List<IrUiViewCustom>();

    //public virtual ICollection<IrUiViewCustom> IrUiViewCustomWriteUs { get; } = new List<IrUiViewCustom>();

    //public virtual ICollection<IrUiView> IrUiViewWriteUs { get; } = new List<IrUiView>();

    public virtual LunchLocation? LastLunchLocation { get; set; }

    //public virtual ICollection<LotLabelLayout> LotLabelLayoutCreateUs { get; } = new List<LotLabelLayout>();

    //public virtual ICollection<LotLabelLayout> LotLabelLayoutWriteUs { get; } = new List<LotLabelLayout>();

    //public virtual ICollection<LunchAlert> LunchAlertCreateUs { get; } = new List<LunchAlert>();

    //public virtual ICollection<LunchAlert> LunchAlertWriteUs { get; } = new List<LunchAlert>();

    //public virtual ICollection<LunchCashmove> LunchCashmoveCreateUs { get; } = new List<LunchCashmove>();

    //public virtual ICollection<LunchCashmove> LunchCashmoveUsers { get; } = new List<LunchCashmove>();

    //public virtual ICollection<LunchCashmove> LunchCashmoveWriteUs { get; } = new List<LunchCashmove>();

    //public virtual ICollection<LunchLocation> LunchLocationCreateUs { get; } = new List<LunchLocation>();

    //public virtual ICollection<LunchLocation> LunchLocationWriteUs { get; } = new List<LunchLocation>();

    //public virtual ICollection<LunchOrder> LunchOrderCreateUs { get; } = new List<LunchOrder>();

    //public virtual ICollection<LunchOrder> LunchOrderUsers { get; } = new List<LunchOrder>();

    //public virtual ICollection<LunchOrder> LunchOrderWriteUs { get; } = new List<LunchOrder>();

    //public virtual ICollection<LunchProductCategory> LunchProductCategoryCreateUs { get; } = new List<LunchProductCategory>();

    //public virtual ICollection<LunchProductCategory> LunchProductCategoryWriteUs { get; } = new List<LunchProductCategory>();

    //public virtual ICollection<LunchProduct> LunchProductCreateUs { get; } = new List<LunchProduct>();

    //public virtual ICollection<LunchProduct> LunchProductWriteUs { get; } = new List<LunchProduct>();

    //public virtual ICollection<LunchSupplier> LunchSupplierCreateUs { get; } = new List<LunchSupplier>();

    //public virtual ICollection<LunchSupplier> LunchSupplierResponsibles { get; } = new List<LunchSupplier>();

    //public virtual ICollection<LunchSupplier> LunchSupplierWriteUs { get; } = new List<LunchSupplier>();

    //public virtual ICollection<LunchTopping> LunchToppingCreateUs { get; } = new List<LunchTopping>();

    //public virtual ICollection<LunchTopping> LunchToppingWriteUs { get; } = new List<LunchTopping>();

    //public virtual ICollection<MailActivity> MailActivityCreateUs { get; } = new List<MailActivity>();

    //public virtual ICollection<MailActivityType> MailActivityTypeCreateUs { get; } = new List<MailActivityType>();

    //public virtual ICollection<MailActivityType> MailActivityTypeDefaultUsers { get; } = new List<MailActivityType>();

    //public virtual ICollection<MailActivityType> MailActivityTypeWriteUs { get; } = new List<MailActivityType>();

    //public virtual ICollection<MailActivity> MailActivityUsers { get; } = new List<MailActivity>();

    //public virtual ICollection<MailActivity> MailActivityWriteUs { get; } = new List<MailActivity>();

    //public virtual ICollection<MailAlias> MailAliasAliasUsers { get; } = new List<MailAlias>();

    //public virtual ICollection<MailAlias> MailAliasCreateUs { get; } = new List<MailAlias>();

    //public virtual ICollection<MailAlias> MailAliasWriteUs { get; } = new List<MailAlias>();

    //public virtual ICollection<MailBlacklist> MailBlacklistCreateUs { get; } = new List<MailBlacklist>();

    //public virtual ICollection<MailBlacklistRemove> MailBlacklistRemoveCreateUs { get; } = new List<MailBlacklistRemove>();

    //public virtual ICollection<MailBlacklistRemove> MailBlacklistRemoveWriteUs { get; } = new List<MailBlacklistRemove>();

    //public virtual ICollection<MailBlacklist> MailBlacklistWriteUs { get; } = new List<MailBlacklist>();

    //public virtual ICollection<MailChannel> MailChannelCreateUs { get; } = new List<MailChannel>();

    //public virtual ICollection<MailChannelMember> MailChannelMemberCreateUs { get; } = new List<MailChannelMember>();

    //public virtual ICollection<MailChannelMember> MailChannelMemberWriteUs { get; } = new List<MailChannelMember>();

    //public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessionCreateUs { get; } = new List<MailChannelRtcSession>();

    //public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessionWriteUs { get; } = new List<MailChannelRtcSession>();

    //public virtual ICollection<MailChannel> MailChannelWriteUs { get; } = new List<MailChannel>();

    //public virtual ICollection<MailComposeMessage> MailComposeMessageCreateUs { get; } = new List<MailComposeMessage>();

    //public virtual ICollection<MailComposeMessage> MailComposeMessageWriteUs { get; } = new List<MailComposeMessage>();

    //public virtual ICollection<MailGatewayAllowed> MailGatewayAllowedCreateUs { get; } = new List<MailGatewayAllowed>();

    //public virtual ICollection<MailGatewayAllowed> MailGatewayAllowedWriteUs { get; } = new List<MailGatewayAllowed>();

    //public virtual ICollection<MailGuest> MailGuestCreateUs { get; } = new List<MailGuest>();

    //public virtual ICollection<MailGuest> MailGuestWriteUs { get; } = new List<MailGuest>();

    //public virtual ICollection<MailIceServer> MailIceServerCreateUs { get; } = new List<MailIceServer>();

    //public virtual ICollection<MailIceServer> MailIceServerWriteUs { get; } = new List<MailIceServer>();

    //public virtual ICollection<MailLinkPreview> MailLinkPreviewCreateUs { get; } = new List<MailLinkPreview>();

    //public virtual ICollection<MailLinkPreview> MailLinkPreviewWriteUs { get; } = new List<MailLinkPreview>();

    //public virtual ICollection<MailMail> MailMailCreateUs { get; } = new List<MailMail>();

    //public virtual ICollection<MailMail> MailMailWriteUs { get; } = new List<MailMail>();

    //public virtual ICollection<MailMessage> MailMessageCreateUs { get; } = new List<MailMessage>();

    //public virtual ICollection<MailMessageSchedule> MailMessageScheduleCreateUs { get; } = new List<MailMessageSchedule>();

    //public virtual ICollection<MailMessageSchedule> MailMessageScheduleWriteUs { get; } = new List<MailMessageSchedule>();

    //public virtual ICollection<MailMessageSubtype> MailMessageSubtypeCreateUs { get; } = new List<MailMessageSubtype>();

    //public virtual ICollection<MailMessageSubtype> MailMessageSubtypeWriteUs { get; } = new List<MailMessageSubtype>();

    //public virtual ICollection<MailMessage> MailMessageWriteUs { get; } = new List<MailMessage>();

    //public virtual ICollection<MailResendMessage> MailResendMessageCreateUs { get; } = new List<MailResendMessage>();

    //public virtual ICollection<MailResendMessage> MailResendMessageWriteUs { get; } = new List<MailResendMessage>();

    //public virtual ICollection<MailResendPartner> MailResendPartnerCreateUs { get; } = new List<MailResendPartner>();

    //public virtual ICollection<MailResendPartner> MailResendPartnerWriteUs { get; } = new List<MailResendPartner>();

    //public virtual ICollection<MailShortcode> MailShortcodeCreateUs { get; } = new List<MailShortcode>();

    //public virtual ICollection<MailShortcode> MailShortcodeWriteUs { get; } = new List<MailShortcode>();

    //public virtual ICollection<MailTemplate> MailTemplateCreateUs { get; } = new List<MailTemplate>();

    //public virtual ICollection<MailTemplatePreview> MailTemplatePreviewCreateUs { get; } = new List<MailTemplatePreview>();

    //public virtual ICollection<MailTemplatePreview> MailTemplatePreviewWriteUs { get; } = new List<MailTemplatePreview>();

    //public virtual ICollection<MailTemplateReset> MailTemplateResetCreateUs { get; } = new List<MailTemplateReset>();

    //public virtual ICollection<MailTemplateReset> MailTemplateResetWriteUs { get; } = new List<MailTemplateReset>();

    //public virtual ICollection<MailTemplate> MailTemplateWriteUs { get; } = new List<MailTemplate>();

    //public virtual ICollection<MailTrackingValue> MailTrackingValueCreateUs { get; } = new List<MailTrackingValue>();

    //public virtual ICollection<MailTrackingValue> MailTrackingValueWriteUs { get; } = new List<MailTrackingValue>();

    //public virtual ICollection<MailWizardInvite> MailWizardInviteCreateUs { get; } = new List<MailWizardInvite>();

    //public virtual ICollection<MailWizardInvite> MailWizardInviteWriteUs { get; } = new List<MailWizardInvite>();

    //public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryCreateUs { get; } = new List<MaintenanceEquipmentCategory>();

    //public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryTechnicianUsers { get; } = new List<MaintenanceEquipmentCategory>();

    //public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryWriteUs { get; } = new List<MaintenanceEquipmentCategory>();

    //public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentCreateUs { get; } = new List<MaintenanceEquipment>();

    //public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentOwnerUsers { get; } = new List<MaintenanceEquipment>();

    //public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentTechnicianUsers { get; } = new List<MaintenanceEquipment>();

    //public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentWriteUs { get; } = new List<MaintenanceEquipment>();

    //public virtual ICollection<MaintenanceRequest> MaintenanceRequestCreateUs { get; } = new List<MaintenanceRequest>();

    //public virtual ICollection<MaintenanceRequest> MaintenanceRequestOwnerUsers { get; } = new List<MaintenanceRequest>();

    //public virtual ICollection<MaintenanceRequest> MaintenanceRequestUsers { get; } = new List<MaintenanceRequest>();

    //public virtual ICollection<MaintenanceRequest> MaintenanceRequestWriteUs { get; } = new List<MaintenanceRequest>();

    //public virtual ICollection<MaintenanceStage> MaintenanceStageCreateUs { get; } = new List<MaintenanceStage>();

    //public virtual ICollection<MaintenanceStage> MaintenanceStageWriteUs { get; } = new List<MaintenanceStage>();

    //public virtual ICollection<MaintenanceTeam> MaintenanceTeamCreateUs { get; } = new List<MaintenanceTeam>();

    //public virtual ICollection<MaintenanceTeam> MaintenanceTeamWriteUs { get; } = new List<MaintenanceTeam>();

    //public virtual ICollection<MrpBomByproduct> MrpBomByproductCreateUs { get; } = new List<MrpBomByproduct>();

    //public virtual ICollection<MrpBomByproduct> MrpBomByproductWriteUs { get; } = new List<MrpBomByproduct>();

    //public virtual ICollection<MrpBom> MrpBomCreateUs { get; } = new List<MrpBom>();

    //public virtual ICollection<MrpBomLine> MrpBomLineCreateUs { get; } = new List<MrpBomLine>();

    //public virtual ICollection<MrpBomLine> MrpBomLineWriteUs { get; } = new List<MrpBomLine>();

    //public virtual ICollection<MrpBom> MrpBomWriteUs { get; } = new List<MrpBom>();

    //public virtual ICollection<MrpConsumptionWarning> MrpConsumptionWarningCreateUs { get; } = new List<MrpConsumptionWarning>();

    //public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLineCreateUs { get; } = new List<MrpConsumptionWarningLine>();

    //public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLineWriteUs { get; } = new List<MrpConsumptionWarningLine>();

    //public virtual ICollection<MrpConsumptionWarning> MrpConsumptionWarningWriteUs { get; } = new List<MrpConsumptionWarning>();

    //public virtual ICollection<MrpDocument> MrpDocumentCreateUs { get; } = new List<MrpDocument>();

    //public virtual ICollection<MrpDocument> MrpDocumentWriteUs { get; } = new List<MrpDocument>();

    //public virtual ICollection<MrpImmediateProduction> MrpImmediateProductionCreateUs { get; } = new List<MrpImmediateProduction>();

    //public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLineCreateUs { get; } = new List<MrpImmediateProductionLine>();

    //public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLineWriteUs { get; } = new List<MrpImmediateProductionLine>();

    //public virtual ICollection<MrpImmediateProduction> MrpImmediateProductionWriteUs { get; } = new List<MrpImmediateProduction>();

    //public virtual ICollection<MrpProductionBackorder> MrpProductionBackorderCreateUs { get; } = new List<MrpProductionBackorder>();

    //public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLineCreateUs { get; } = new List<MrpProductionBackorderLine>();

    //public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLineWriteUs { get; } = new List<MrpProductionBackorderLine>();

    //public virtual ICollection<MrpProductionBackorder> MrpProductionBackorderWriteUs { get; } = new List<MrpProductionBackorder>();

    //public virtual ICollection<MrpProduction> MrpProductionCreateUs { get; } = new List<MrpProduction>();

    //public virtual ICollection<MrpProductionSplit> MrpProductionSplitCreateUs { get; } = new List<MrpProductionSplit>();

    //public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineCreateUs { get; } = new List<MrpProductionSplitLine>();

    //public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineUsers { get; } = new List<MrpProductionSplitLine>();

    //public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineWriteUs { get; } = new List<MrpProductionSplitLine>();

    //public virtual ICollection<MrpProductionSplitMulti> MrpProductionSplitMultiCreateUs { get; } = new List<MrpProductionSplitMulti>();

    //public virtual ICollection<MrpProductionSplitMulti> MrpProductionSplitMultiWriteUs { get; } = new List<MrpProductionSplitMulti>();

    //public virtual ICollection<MrpProductionSplit> MrpProductionSplitWriteUs { get; } = new List<MrpProductionSplit>();

    //public virtual ICollection<MrpProduction> MrpProductionUsers { get; } = new List<MrpProduction>();

    //public virtual ICollection<MrpProduction> MrpProductionWriteUs { get; } = new List<MrpProduction>();

    //public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenterCreateUs { get; } = new List<MrpRoutingWorkcenter>();

    //public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenterWriteUs { get; } = new List<MrpRoutingWorkcenter>();

    //public virtual ICollection<MrpUnbuild> MrpUnbuildCreateUs { get; } = new List<MrpUnbuild>();

    //public virtual ICollection<MrpUnbuild> MrpUnbuildWriteUs { get; } = new List<MrpUnbuild>();

    //public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacityCreateUs { get; } = new List<MrpWorkcenterCapacity>();

    //public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacityWriteUs { get; } = new List<MrpWorkcenterCapacity>();

    //public virtual ICollection<MrpWorkcenter> MrpWorkcenterCreateUs { get; } = new List<MrpWorkcenter>();

    //public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityCreateUs { get; } = new List<MrpWorkcenterProductivity>();

    //public virtual ICollection<MrpWorkcenterProductivityLoss> MrpWorkcenterProductivityLossCreateUs { get; } = new List<MrpWorkcenterProductivityLoss>();

    //public virtual ICollection<MrpWorkcenterProductivityLossType> MrpWorkcenterProductivityLossTypeCreateUs { get; } = new List<MrpWorkcenterProductivityLossType>();

    //public virtual ICollection<MrpWorkcenterProductivityLossType> MrpWorkcenterProductivityLossTypeWriteUs { get; } = new List<MrpWorkcenterProductivityLossType>();

    //public virtual ICollection<MrpWorkcenterProductivityLoss> MrpWorkcenterProductivityLossWriteUs { get; } = new List<MrpWorkcenterProductivityLoss>();

    //public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityUsers { get; } = new List<MrpWorkcenterProductivity>();

    //public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityWriteUs { get; } = new List<MrpWorkcenterProductivity>();

    //public virtual ICollection<MrpWorkcenterTag> MrpWorkcenterTagCreateUs { get; } = new List<MrpWorkcenterTag>();

    //public virtual ICollection<MrpWorkcenterTag> MrpWorkcenterTagWriteUs { get; } = new List<MrpWorkcenterTag>();

    //public virtual ICollection<MrpWorkcenter> MrpWorkcenterWriteUs { get; } = new List<MrpWorkcenter>();

    //public virtual ICollection<MrpWorkorder> MrpWorkorderCreateUs { get; } = new List<MrpWorkorder>();

    //public virtual ICollection<MrpWorkorder> MrpWorkorderWriteUs { get; } = new List<MrpWorkorder>();

    //public virtual ICollection<NoteNote> NoteNoteCreateUs { get; } = new List<NoteNote>();

    //public virtual ICollection<NoteNote> NoteNoteUsers { get; } = new List<NoteNote>();

    //public virtual ICollection<NoteNote> NoteNoteWriteUs { get; } = new List<NoteNote>();

    //public virtual ICollection<NoteStage> NoteStageCreateUs { get; } = new List<NoteStage>();

    //public virtual ICollection<NoteStage> NoteStageUsers { get; } = new List<NoteStage>();

    //public virtual ICollection<NoteStage> NoteStageWriteUs { get; } = new List<NoteStage>();

    //public virtual ICollection<NoteTag> NoteTagCreateUs { get; } = new List<NoteTag>();

    //public virtual ICollection<NoteTag> NoteTagWriteUs { get; } = new List<NoteTag>();

    public virtual ResPartner? Partner { get; set; }

    //public virtual ICollection<PaymentIcon> PaymentIconCreateUs { get; } = new List<PaymentIcon>();

    //public virtual ICollection<PaymentIcon> PaymentIconWriteUs { get; } = new List<PaymentIcon>();

    //public virtual ICollection<PaymentLinkWizard> PaymentLinkWizardCreateUs { get; } = new List<PaymentLinkWizard>();

    //public virtual ICollection<PaymentLinkWizard> PaymentLinkWizardWriteUs { get; } = new List<PaymentLinkWizard>();

    //public virtual ICollection<PaymentProvider> PaymentProviderCreateUs { get; } = new List<PaymentProvider>();

    //public virtual ICollection<PaymentProviderOnboardingWizard> PaymentProviderOnboardingWizardCreateUs { get; } = new List<PaymentProviderOnboardingWizard>();

    //public virtual ICollection<PaymentProviderOnboardingWizard> PaymentProviderOnboardingWizardWriteUs { get; } = new List<PaymentProviderOnboardingWizard>();

    //public virtual ICollection<PaymentProvider> PaymentProviderWriteUs { get; } = new List<PaymentProvider>();

    //public virtual ICollection<PaymentRefundWizard> PaymentRefundWizardCreateUs { get; } = new List<PaymentRefundWizard>();

    //public virtual ICollection<PaymentRefundWizard> PaymentRefundWizardWriteUs { get; } = new List<PaymentRefundWizard>();

    //public virtual ICollection<PaymentToken> PaymentTokenCreateUs { get; } = new List<PaymentToken>();

    //public virtual ICollection<PaymentToken> PaymentTokenWriteUs { get; } = new List<PaymentToken>();

    //public virtual ICollection<PaymentTransaction> PaymentTransactionCreateUs { get; } = new List<PaymentTransaction>();

    //public virtual ICollection<PaymentTransaction> PaymentTransactionWriteUs { get; } = new List<PaymentTransaction>();

    //public virtual ICollection<PhoneBlacklist> PhoneBlacklistCreateUs { get; } = new List<PhoneBlacklist>();

    //public virtual ICollection<PhoneBlacklistRemove> PhoneBlacklistRemoveCreateUs { get; } = new List<PhoneBlacklistRemove>();

    //public virtual ICollection<PhoneBlacklistRemove> PhoneBlacklistRemoveWriteUs { get; } = new List<PhoneBlacklistRemove>();

    //public virtual ICollection<PhoneBlacklist> PhoneBlacklistWriteUs { get; } = new List<PhoneBlacklist>();

    //public virtual ICollection<PickingLabelType> PickingLabelTypeCreateUs { get; } = new List<PickingLabelType>();

    //public virtual ICollection<PickingLabelType> PickingLabelTypeWriteUs { get; } = new List<PickingLabelType>();

    //public virtual ICollection<PortalShare> PortalShareCreateUs { get; } = new List<PortalShare>();

    //public virtual ICollection<PortalShare> PortalShareWriteUs { get; } = new List<PortalShare>();

    //public virtual ICollection<PortalWizard> PortalWizardCreateUs { get; } = new List<PortalWizard>();

    //public virtual ICollection<PortalWizardUser> PortalWizardUserCreateUs { get; } = new List<PortalWizardUser>();

    //public virtual ICollection<PortalWizardUser> PortalWizardUserWriteUs { get; } = new List<PortalWizardUser>();

    //public virtual ICollection<PortalWizard> PortalWizardWriteUs { get; } = new List<PortalWizard>();

    //public virtual ICollection<PosBill> PosBillCreateUs { get; } = new List<PosBill>();

    //public virtual ICollection<PosBill> PosBillWriteUs { get; } = new List<PosBill>();

    //public virtual ICollection<PosCategory> PosCategoryCreateUs { get; } = new List<PosCategory>();

    //public virtual ICollection<PosCategory> PosCategoryWriteUs { get; } = new List<PosCategory>();

    //public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizardCreateUs { get; } = new List<PosCloseSessionWizard>();

    //public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizardWriteUs { get; } = new List<PosCloseSessionWizard>();

    //public virtual ICollection<PosConfig> PosConfigCreateUs { get; } = new List<PosConfig>();

    //public virtual ICollection<PosConfig> PosConfigWriteUs { get; } = new List<PosConfig>();

    //public virtual ICollection<PosDetailsWizard> PosDetailsWizardCreateUs { get; } = new List<PosDetailsWizard>();

    //public virtual ICollection<PosDetailsWizard> PosDetailsWizardWriteUs { get; } = new List<PosDetailsWizard>();

    //public virtual ICollection<PosMakePayment> PosMakePaymentCreateUs { get; } = new List<PosMakePayment>();

    //public virtual ICollection<PosMakePayment> PosMakePaymentWriteUs { get; } = new List<PosMakePayment>();

    //public virtual ICollection<PosOrder> PosOrderCreateUs { get; } = new List<PosOrder>();

    //public virtual ICollection<PosOrderLine> PosOrderLineCreateUs { get; } = new List<PosOrderLine>();

    //public virtual ICollection<PosOrderLine> PosOrderLineWriteUs { get; } = new List<PosOrderLine>();

    //public virtual ICollection<PosOrder> PosOrderUsers { get; } = new List<PosOrder>();

    //public virtual ICollection<PosOrder> PosOrderWriteUs { get; } = new List<PosOrder>();

    //public virtual ICollection<PosPackOperationLot> PosPackOperationLotCreateUs { get; } = new List<PosPackOperationLot>();

    //public virtual ICollection<PosPackOperationLot> PosPackOperationLotWriteUs { get; } = new List<PosPackOperationLot>();

    //public virtual ICollection<PosPayment> PosPaymentCreateUs { get; } = new List<PosPayment>();

    //public virtual ICollection<PosPaymentMethod> PosPaymentMethodCreateUs { get; } = new List<PosPaymentMethod>();

    //public virtual ICollection<PosPaymentMethod> PosPaymentMethodWriteUs { get; } = new List<PosPaymentMethod>();

    //public virtual ICollection<PosPayment> PosPaymentWriteUs { get; } = new List<PosPayment>();

    //public virtual ICollection<PosSessionCheckProductWizard> PosSessionCheckProductWizardCreateUs { get; } = new List<PosSessionCheckProductWizard>();

    //public virtual ICollection<PosSessionCheckProductWizard> PosSessionCheckProductWizardWriteUs { get; } = new List<PosSessionCheckProductWizard>();

    //public virtual ICollection<PosSession> PosSessionCreateUs { get; } = new List<PosSession>();

    //public virtual ICollection<PosSession> PosSessionUsers { get; } = new List<PosSession>();

    //public virtual ICollection<PosSession> PosSessionWriteUs { get; } = new List<PosSession>();

    //public virtual ICollection<PrivacyLog> PrivacyLogCreateUs { get; } = new List<PrivacyLog>();

    //public virtual ICollection<PrivacyLog> PrivacyLogUsers { get; } = new List<PrivacyLog>();

    //public virtual ICollection<PrivacyLog> PrivacyLogWriteUs { get; } = new List<PrivacyLog>();

    //public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizardCreateUs { get; } = new List<PrivacyLookupWizard>();

    //public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLineCreateUs { get; } = new List<PrivacyLookupWizardLine>();

    //public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLineWriteUs { get; } = new List<PrivacyLookupWizardLine>();

    //public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizardWriteUs { get; } = new List<PrivacyLookupWizard>();

    //public virtual ICollection<ProcurementGroup> ProcurementGroupCreateUs { get; } = new List<ProcurementGroup>();

    //public virtual ICollection<ProcurementGroup> ProcurementGroupWriteUs { get; } = new List<ProcurementGroup>();

    //public virtual ICollection<ProductAttribute> ProductAttributeCreateUs { get; } = new List<ProductAttribute>();

    //public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValueCreateUs { get; } = new List<ProductAttributeCustomValue>();

    //public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValueWriteUs { get; } = new List<ProductAttributeCustomValue>();

    //public virtual ICollection<ProductAttributeValue> ProductAttributeValueCreateUs { get; } = new List<ProductAttributeValue>();

    //public virtual ICollection<ProductAttributeValue> ProductAttributeValueWriteUs { get; } = new List<ProductAttributeValue>();

    //public virtual ICollection<ProductAttribute> ProductAttributeWriteUs { get; } = new List<ProductAttribute>();

    //public virtual ICollection<ProductCategory> ProductCategoryCreateUs { get; } = new List<ProductCategory>();

    //public virtual ICollection<ProductCategory> ProductCategoryWriteUs { get; } = new List<ProductCategory>();

    //public virtual ICollection<ProductImage> ProductImageCreateUs { get; } = new List<ProductImage>();

    //public virtual ICollection<ProductImage> ProductImageWriteUs { get; } = new List<ProductImage>();

    //public virtual ICollection<ProductLabelLayout> ProductLabelLayoutCreateUs { get; } = new List<ProductLabelLayout>();

    //public virtual ICollection<ProductLabelLayout> ProductLabelLayoutWriteUs { get; } = new List<ProductLabelLayout>();

    //public virtual ICollection<ProductPackaging> ProductPackagingCreateUs { get; } = new List<ProductPackaging>();

    //public virtual ICollection<ProductPackaging> ProductPackagingWriteUs { get; } = new List<ProductPackaging>();

    //public virtual ICollection<ProductPricelist> ProductPricelistCreateUs { get; } = new List<ProductPricelist>();

    //public virtual ICollection<ProductPricelistItem> ProductPricelistItemCreateUs { get; } = new List<ProductPricelistItem>();

    //public virtual ICollection<ProductPricelistItem> ProductPricelistItemWriteUs { get; } = new List<ProductPricelistItem>();

    //public virtual ICollection<ProductPricelist> ProductPricelistWriteUs { get; } = new List<ProductPricelist>();

    //public virtual ICollection<ProductProduct> ProductProductCreateUs { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProductProduct> ProductProductWriteUs { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProductPublicCategory> ProductPublicCategoryCreateUs { get; } = new List<ProductPublicCategory>();

    //public virtual ICollection<ProductPublicCategory> ProductPublicCategoryWriteUs { get; } = new List<ProductPublicCategory>();

    //public virtual ICollection<ProductRemoval> ProductRemovalCreateUs { get; } = new List<ProductRemoval>();

    //public virtual ICollection<ProductRemoval> ProductRemovalWriteUs { get; } = new List<ProductRemoval>();

    //public virtual ICollection<ProductReplenish> ProductReplenishCreateUs { get; } = new List<ProductReplenish>();

    //public virtual ICollection<ProductReplenish> ProductReplenishWriteUs { get; } = new List<ProductReplenish>();

    //public virtual ICollection<ProductRibbon> ProductRibbonCreateUs { get; } = new List<ProductRibbon>();

    //public virtual ICollection<ProductRibbon> ProductRibbonWriteUs { get; } = new List<ProductRibbon>();

    //public virtual ICollection<ProductSupplierinfo> ProductSupplierinfoCreateUs { get; } = new List<ProductSupplierinfo>();

    //public virtual ICollection<ProductSupplierinfo> ProductSupplierinfoWriteUs { get; } = new List<ProductSupplierinfo>();

    //public virtual ICollection<ProductTag> ProductTagCreateUs { get; } = new List<ProductTag>();

    //public virtual ICollection<ProductTag> ProductTagWriteUs { get; } = new List<ProductTag>();

    //public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionCreateUs { get; } = new List<ProductTemplateAttributeExclusion>();

    //public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionWriteUs { get; } = new List<ProductTemplateAttributeExclusion>();

    //public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLineCreateUs { get; } = new List<ProductTemplateAttributeLine>();

    //public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLineWriteUs { get; } = new List<ProductTemplateAttributeLine>();

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValueCreateUs { get; } = new List<ProductTemplateAttributeValue>();

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValueWriteUs { get; } = new List<ProductTemplateAttributeValue>();

    //public virtual ICollection<ProductTemplate> ProductTemplateCreateUs { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ProductTemplate> ProductTemplateWriteUs { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ProjectCollaborator> ProjectCollaboratorCreateUs { get; } = new List<ProjectCollaborator>();

    //public virtual ICollection<ProjectCollaborator> ProjectCollaboratorWriteUs { get; } = new List<ProjectCollaborator>();

    //public virtual ICollection<ProjectMilestone> ProjectMilestoneCreateUs { get; } = new List<ProjectMilestone>();

    //public virtual ICollection<ProjectMilestone> ProjectMilestoneWriteUs { get; } = new List<ProjectMilestone>();

    //public virtual ICollection<ProjectProject> ProjectProjectCreateUs { get; } = new List<ProjectProject>();

    //public virtual ICollection<ProjectProjectStage> ProjectProjectStageCreateUs { get; } = new List<ProjectProjectStage>();

    //public virtual ICollection<ProjectProjectStage> ProjectProjectStageWriteUs { get; } = new List<ProjectProjectStage>();

    //public virtual ICollection<ProjectProject> ProjectProjectUsers { get; } = new List<ProjectProject>();

    //public virtual ICollection<ProjectProject> ProjectProjectWriteUs { get; } = new List<ProjectProject>();

    //public virtual ICollection<ProjectShareWizard> ProjectShareWizardCreateUs { get; } = new List<ProjectShareWizard>();

    //public virtual ICollection<ProjectShareWizard> ProjectShareWizardWriteUs { get; } = new List<ProjectShareWizard>();

    //public virtual ICollection<ProjectTag> ProjectTagCreateUs { get; } = new List<ProjectTag>();

    //public virtual ICollection<ProjectTag> ProjectTagWriteUs { get; } = new List<ProjectTag>();

    //public virtual ICollection<ProjectTask> ProjectTaskCreateUs { get; } = new List<ProjectTask>();

    //public virtual ICollection<ProjectTaskRecurrence> ProjectTaskRecurrenceCreateUs { get; } = new List<ProjectTaskRecurrence>();

    //public virtual ICollection<ProjectTaskRecurrence> ProjectTaskRecurrenceWriteUs { get; } = new List<ProjectTaskRecurrence>();

    //public virtual ICollection<ProjectTaskType> ProjectTaskTypeCreateUs { get; } = new List<ProjectTaskType>();

    //public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizardCreateUs { get; } = new List<ProjectTaskTypeDeleteWizard>();

    //public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizardWriteUs { get; } = new List<ProjectTaskTypeDeleteWizard>();

    //public virtual ICollection<ProjectTaskType> ProjectTaskTypeUsers { get; } = new List<ProjectTaskType>();

    //public virtual ICollection<ProjectTaskType> ProjectTaskTypeWriteUs { get; } = new List<ProjectTaskType>();

    //public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelCreateUs { get; } = new List<ProjectTaskUserRel>();

    //public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelUsers { get; } = new List<ProjectTaskUserRel>();

    //public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelWriteUs { get; } = new List<ProjectTaskUserRel>();

    //public virtual ICollection<ProjectTask> ProjectTaskWriteUs { get; } = new List<ProjectTask>();

    //public virtual ICollection<ProjectUpdate> ProjectUpdateCreateUs { get; } = new List<ProjectUpdate>();

    //public virtual ICollection<ProjectUpdate> ProjectUpdateUsers { get; } = new List<ProjectUpdate>();

    //public virtual ICollection<ProjectUpdate> ProjectUpdateWriteUs { get; } = new List<ProjectUpdate>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrderCreateUs { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLineCreateUs { get; } = new List<PurchaseOrderLine>();

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLineWriteUs { get; } = new List<PurchaseOrderLine>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrderUsers { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrderWriteUs { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<RatingRating> RatingRatingCreateUs { get; } = new List<RatingRating>();

    //public virtual ICollection<RatingRating> RatingRatingWriteUs { get; } = new List<RatingRating>();

    //public virtual ICollection<RecurringPayment> RecurringPaymentCreateUs { get; } = new List<RecurringPayment>();

    //public virtual ICollection<RecurringPaymentLine> RecurringPaymentLineCreateUs { get; } = new List<RecurringPaymentLine>();

    //public virtual ICollection<RecurringPaymentLine> RecurringPaymentLineWriteUs { get; } = new List<RecurringPaymentLine>();

    //public virtual ICollection<RecurringPayment> RecurringPaymentWriteUs { get; } = new List<RecurringPayment>();

    //public virtual ICollection<RepairFee> RepairFeeCreateUs { get; } = new List<RepairFee>();

    //public virtual ICollection<RepairFee> RepairFeeWriteUs { get; } = new List<RepairFee>();

    //public virtual ICollection<RepairLine> RepairLineCreateUs { get; } = new List<RepairLine>();

    //public virtual ICollection<RepairLine> RepairLineWriteUs { get; } = new List<RepairLine>();

    //public virtual ICollection<RepairOrder> RepairOrderCreateUs { get; } = new List<RepairOrder>();

    //public virtual ICollection<RepairOrderMakeInvoice> RepairOrderMakeInvoiceCreateUs { get; } = new List<RepairOrderMakeInvoice>();

    //public virtual ICollection<RepairOrderMakeInvoice> RepairOrderMakeInvoiceWriteUs { get; } = new List<RepairOrderMakeInvoice>();

    //public virtual ICollection<RepairOrder> RepairOrderUsers { get; } = new List<RepairOrder>();

    //public virtual ICollection<RepairOrder> RepairOrderWriteUs { get; } = new List<RepairOrder>();

    //public virtual ICollection<RepairTag> RepairTagCreateUs { get; } = new List<RepairTag>();

    //public virtual ICollection<RepairTag> RepairTagWriteUs { get; } = new List<RepairTag>();

    //public virtual ICollection<ReportLayout> ReportLayoutCreateUs { get; } = new List<ReportLayout>();

    //public virtual ICollection<ReportLayout> ReportLayoutWriteUs { get; } = new List<ReportLayout>();

    //public virtual ICollection<ReportPaperformat> ReportPaperformatCreateUs { get; } = new List<ReportPaperformat>();

    //public virtual ICollection<ReportPaperformat> ReportPaperformatWriteUs { get; } = new List<ReportPaperformat>();

    //public virtual ICollection<ResBank> ResBankCreateUs { get; } = new List<ResBank>();

    //public virtual ICollection<ResBank> ResBankWriteUs { get; } = new List<ResBank>();

    //public virtual ICollection<ResCompany> ResCompanyCreateUs { get; } = new List<ResCompany>();

    //public virtual ICollection<ResCompany> ResCompanyWriteUs { get; } = new List<ResCompany>();

    //public virtual ICollection<ResConfig> ResConfigCreateUs { get; } = new List<ResConfig>();

    //public virtual ICollection<ResConfigInstaller> ResConfigInstallerCreateUs { get; } = new List<ResConfigInstaller>();

    //public virtual ICollection<ResConfigInstaller> ResConfigInstallerWriteUs { get; } = new List<ResConfigInstaller>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettingAuthSignupTemplateUsers { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettingCreateUs { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettingWriteUs { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<ResConfig> ResConfigWriteUs { get; } = new List<ResConfig>();

    //public virtual ICollection<ResCountry> ResCountryCreateUs { get; } = new List<ResCountry>();

    //public virtual ICollection<ResCountryGroup> ResCountryGroupCreateUs { get; } = new List<ResCountryGroup>();

    //public virtual ICollection<ResCountryGroup> ResCountryGroupWriteUs { get; } = new List<ResCountryGroup>();

    //public virtual ICollection<ResCountryState> ResCountryStateCreateUs { get; } = new List<ResCountryState>();

    //public virtual ICollection<ResCountryState> ResCountryStateWriteUs { get; } = new List<ResCountryState>();

    //public virtual ICollection<ResCountry> ResCountryWriteUs { get; } = new List<ResCountry>();

    //public virtual ICollection<ResCurrency> ResCurrencyCreateUs { get; } = new List<ResCurrency>();

    //public virtual ICollection<ResCurrencyRate> ResCurrencyRateCreateUs { get; } = new List<ResCurrencyRate>();

    //public virtual ICollection<ResCurrencyRate> ResCurrencyRateWriteUs { get; } = new List<ResCurrencyRate>();

    //public virtual ICollection<ResCurrency> ResCurrencyWriteUs { get; } = new List<ResCurrency>();

    //public virtual ICollection<ResGroup> ResGroupCreateUs { get; } = new List<ResGroup>();

    //public virtual ICollection<ResGroup> ResGroupWriteUs { get; } = new List<ResGroup>();

    //public virtual ICollection<ResLang> ResLangCreateUs { get; } = new List<ResLang>();

    //public virtual ICollection<ResLang> ResLangWriteUs { get; } = new List<ResLang>();

    //public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncCreateUs { get; } = new List<ResPartnerAutocompleteSync>();

    //public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncWriteUs { get; } = new List<ResPartnerAutocompleteSync>();

    //public virtual ICollection<ResPartnerBank> ResPartnerBankCreateUs { get; } = new List<ResPartnerBank>();

    //public virtual ICollection<ResPartnerBank> ResPartnerBankWriteUs { get; } = new List<ResPartnerBank>();

    //public virtual ICollection<ResPartnerCategory> ResPartnerCategoryCreateUs { get; } = new List<ResPartnerCategory>();

    //public virtual ICollection<ResPartnerCategory> ResPartnerCategoryWriteUs { get; } = new List<ResPartnerCategory>();

    //public virtual ICollection<ResPartner> ResPartnerCreateUs { get; } = new List<ResPartner>();

    //public virtual ICollection<ResPartnerIndustry> ResPartnerIndustryCreateUs { get; } = new List<ResPartnerIndustry>();

    //public virtual ICollection<ResPartnerIndustry> ResPartnerIndustryWriteUs { get; } = new List<ResPartnerIndustry>();

    //public virtual ICollection<ResPartner> ResPartnerPaymentResponsibles { get; } = new List<ResPartner>();

    //public virtual ICollection<ResPartnerTitle> ResPartnerTitleCreateUs { get; } = new List<ResPartnerTitle>();

    //public virtual ICollection<ResPartnerTitle> ResPartnerTitleWriteUs { get; } = new List<ResPartnerTitle>();

    //public virtual ICollection<ResPartner> ResPartnerUsers { get; } = new List<ResPartner>();

    //public virtual ICollection<ResPartner> ResPartnerWriteUs { get; } = new List<ResPartner>();

    //public virtual ICollection<ResUsersApikey> ResUsersApikeys { get; } = new List<ResUsersApikey>();

    //public virtual ICollection<ResUsersApikeysDescription> ResUsersApikeysDescriptionCreateUs { get; } = new List<ResUsersApikeysDescription>();

    //public virtual ICollection<ResUsersApikeysDescription> ResUsersApikeysDescriptionWriteUs { get; } = new List<ResUsersApikeysDescription>();

    //public virtual ICollection<ResUsersDeletion> ResUsersDeletionCreateUs { get; } = new List<ResUsersDeletion>();

    //public virtual ICollection<ResUsersDeletion> ResUsersDeletionUsers { get; } = new List<ResUsersDeletion>();

    //public virtual ICollection<ResUsersDeletion> ResUsersDeletionWriteUs { get; } = new List<ResUsersDeletion>();

    //public virtual ICollection<ResUsersIdentitycheck> ResUsersIdentitycheckCreateUs { get; } = new List<ResUsersIdentitycheck>();

    //public virtual ICollection<ResUsersIdentitycheck> ResUsersIdentitycheckWriteUs { get; } = new List<ResUsersIdentitycheck>();

    //public virtual ICollection<ResUsersLog> ResUsersLogCreateUs { get; } = new List<ResUsersLog>();

    //public virtual ICollection<ResUsersLog> ResUsersLogWriteUs { get; } = new List<ResUsersLog>();

    //public virtual ICollection<ResUsersSetting> ResUsersSettingCreateUs { get; } = new List<ResUsersSetting>();

    public virtual ResUsersSetting? ResUsersSettingUser { get; set; }

    //public virtual ICollection<ResUsersSetting> ResUsersSettingWriteUs { get; } = new List<ResUsersSetting>();

    //public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeCreateUs { get; } = new List<ResUsersSettingsVolume>();

    //public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeWriteUs { get; } = new List<ResUsersSettingsVolume>();

    //public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardCreateUs { get; } = new List<ResetViewArchWizard>();

    //public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardWriteUs { get; } = new List<ResetViewArchWizard>();

    //public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendanceCreateUs { get; } = new List<ResourceCalendarAttendance>();

    //public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendanceWriteUs { get; } = new List<ResourceCalendarAttendance>();

    //public virtual ICollection<ResourceCalendar> ResourceCalendarCreateUs { get; } = new List<ResourceCalendar>();

    //public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeafCreateUs { get; } = new List<ResourceCalendarLeaf>();

    //public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeafWriteUs { get; } = new List<ResourceCalendarLeaf>();

    //public virtual ICollection<ResourceCalendar> ResourceCalendarWriteUs { get; } = new List<ResourceCalendar>();

    //public virtual ICollection<ResourceResource> ResourceResourceCreateUs { get; } = new List<ResourceResource>();

    //public virtual ICollection<ResourceResource> ResourceResourceUsers { get; } = new List<ResourceResource>();

    //public virtual ICollection<ResourceResource> ResourceResourceWriteUs { get; } = new List<ResourceResource>();

    //public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvCreateUs { get; } = new List<SaleAdvancePaymentInv>();

    //public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvWriteUs { get; } = new List<SaleAdvancePaymentInv>();

    //public virtual ICollection<SaleOrderCancel> SaleOrderCancelCreateUs { get; } = new List<SaleOrderCancel>();

    //public virtual ICollection<SaleOrderCancel> SaleOrderCancelWriteUs { get; } = new List<SaleOrderCancel>();

    //public virtual ICollection<SaleOrder> SaleOrderCreateUs { get; } = new List<SaleOrder>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLineCreateUs { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLineSalesmen { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLineWriteUs { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<SaleOrderOption> SaleOrderOptionCreateUs { get; } = new List<SaleOrderOption>();

    //public virtual ICollection<SaleOrderOption> SaleOrderOptionWriteUs { get; } = new List<SaleOrderOption>();

    //public virtual ICollection<SaleOrderTemplate> SaleOrderTemplateCreateUs { get; } = new List<SaleOrderTemplate>();

    //public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLineCreateUs { get; } = new List<SaleOrderTemplateLine>();

    //public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLineWriteUs { get; } = new List<SaleOrderTemplateLine>();

    //public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptionCreateUs { get; } = new List<SaleOrderTemplateOption>();

    //public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptionWriteUs { get; } = new List<SaleOrderTemplateOption>();

    //public virtual ICollection<SaleOrderTemplate> SaleOrderTemplateWriteUs { get; } = new List<SaleOrderTemplate>();

    //public virtual ICollection<SaleOrder> SaleOrderUsers { get; } = new List<SaleOrder>();

    //public virtual ICollection<SaleOrder> SaleOrderWriteUs { get; } = new List<SaleOrder>();

    //public virtual ICollection<SalePaymentProviderOnboardingWizard> SalePaymentProviderOnboardingWizardCreateUs { get; } = new List<SalePaymentProviderOnboardingWizard>();

    //public virtual ICollection<SalePaymentProviderOnboardingWizard> SalePaymentProviderOnboardingWizardWriteUs { get; } = new List<SalePaymentProviderOnboardingWizard>();

    public virtual CrmTeam? SaleTeam { get; set; }

    //public virtual ICollection<SmsComposer> SmsComposerCreateUs { get; } = new List<SmsComposer>();

    //public virtual ICollection<SmsComposer> SmsComposerWriteUs { get; } = new List<SmsComposer>();

    //public virtual ICollection<SmsResend> SmsResendCreateUs { get; } = new List<SmsResend>();

    //public virtual ICollection<SmsResendRecipient> SmsResendRecipientCreateUs { get; } = new List<SmsResendRecipient>();

    //public virtual ICollection<SmsResendRecipient> SmsResendRecipientWriteUs { get; } = new List<SmsResendRecipient>();

    //public virtual ICollection<SmsResend> SmsResendWriteUs { get; } = new List<SmsResend>();

    //public virtual ICollection<SmsSm> SmsSmCreateUs { get; } = new List<SmsSm>();

    //public virtual ICollection<SmsSm> SmsSmWriteUs { get; } = new List<SmsSm>();

    //public virtual ICollection<SmsTemplate> SmsTemplateCreateUs { get; } = new List<SmsTemplate>();

    //public virtual ICollection<SmsTemplatePreview> SmsTemplatePreviewCreateUs { get; } = new List<SmsTemplatePreview>();

    //public virtual ICollection<SmsTemplatePreview> SmsTemplatePreviewWriteUs { get; } = new List<SmsTemplatePreview>();

    //public virtual ICollection<SmsTemplateReset> SmsTemplateResetCreateUs { get; } = new List<SmsTemplateReset>();

    //public virtual ICollection<SmsTemplateReset> SmsTemplateResetWriteUs { get; } = new List<SmsTemplateReset>();

    //public virtual ICollection<SmsTemplate> SmsTemplateWriteUs { get; } = new List<SmsTemplate>();

    //public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoiceCreateUs { get; } = new List<SnailmailConfirmInvoice>();

    //public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoiceWriteUs { get; } = new List<SnailmailConfirmInvoice>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetterCreateUs { get; } = new List<SnailmailLetter>();

    //public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrorCreateUs { get; } = new List<SnailmailLetterFormatError>();

    //public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrorWriteUs { get; } = new List<SnailmailLetterFormatError>();

    //public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFieldCreateUs { get; } = new List<SnailmailLetterMissingRequiredField>();

    //public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFieldWriteUs { get; } = new List<SnailmailLetterMissingRequiredField>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetterUsers { get; } = new List<SnailmailLetter>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetterWriteUs { get; } = new List<SnailmailLetter>();

    //public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboardCreateUs { get; } = new List<SpreadsheetDashboard>();

    //public virtual ICollection<SpreadsheetDashboardGroup> SpreadsheetDashboardGroupCreateUs { get; } = new List<SpreadsheetDashboardGroup>();

    //public virtual ICollection<SpreadsheetDashboardGroup> SpreadsheetDashboardGroupWriteUs { get; } = new List<SpreadsheetDashboardGroup>();

    //public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboardWriteUs { get; } = new List<SpreadsheetDashboard>();

    //public virtual ICollection<StockAssignSerial> StockAssignSerialCreateUs { get; } = new List<StockAssignSerial>();

    //public virtual ICollection<StockAssignSerial> StockAssignSerialWriteUs { get; } = new List<StockAssignSerial>();

    //public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmationCreateUs { get; } = new List<StockBackorderConfirmation>();

    //public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLineCreateUs { get; } = new List<StockBackorderConfirmationLine>();

    //public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLineWriteUs { get; } = new List<StockBackorderConfirmationLine>();

    //public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmationWriteUs { get; } = new List<StockBackorderConfirmation>();

    //public virtual ICollection<StockChangeProductQty> StockChangeProductQtyCreateUs { get; } = new List<StockChangeProductQty>();

    //public virtual ICollection<StockChangeProductQty> StockChangeProductQtyWriteUs { get; } = new List<StockChangeProductQty>();

    //public virtual ICollection<StockImmediateTransfer> StockImmediateTransferCreateUs { get; } = new List<StockImmediateTransfer>();

    //public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLineCreateUs { get; } = new List<StockImmediateTransferLine>();

    //public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLineWriteUs { get; } = new List<StockImmediateTransferLine>();

    //public virtual ICollection<StockImmediateTransfer> StockImmediateTransferWriteUs { get; } = new List<StockImmediateTransfer>();

    //public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNameCreateUs { get; } = new List<StockInventoryAdjustmentName>();

    //public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNameWriteUs { get; } = new List<StockInventoryAdjustmentName>();

    //public virtual ICollection<StockInventoryConflict> StockInventoryConflictCreateUs { get; } = new List<StockInventoryConflict>();

    //public virtual ICollection<StockInventoryConflict> StockInventoryConflictWriteUs { get; } = new List<StockInventoryConflict>();

    //public virtual ICollection<StockInventoryWarning> StockInventoryWarningCreateUs { get; } = new List<StockInventoryWarning>();

    //public virtual ICollection<StockInventoryWarning> StockInventoryWarningWriteUs { get; } = new List<StockInventoryWarning>();

    //public virtual ICollection<StockLocation> StockLocationCreateUs { get; } = new List<StockLocation>();

    //public virtual ICollection<StockLocation> StockLocationWriteUs { get; } = new List<StockLocation>();

    //public virtual ICollection<StockLot> StockLotCreateUs { get; } = new List<StockLot>();

    //public virtual ICollection<StockLot> StockLotWriteUs { get; } = new List<StockLot>();

    //public virtual ICollection<StockMove> StockMoveCreateUs { get; } = new List<StockMove>();

    //public virtual ICollection<StockMoveLine> StockMoveLineCreateUs { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMoveLine> StockMoveLineWriteUs { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMove> StockMoveWriteUs { get; } = new List<StockMove>();

    //public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozeCreateUs { get; } = new List<StockOrderpointSnooze>();

    //public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozeWriteUs { get; } = new List<StockOrderpointSnooze>();

    //public virtual ICollection<StockPackageDestination> StockPackageDestinationCreateUs { get; } = new List<StockPackageDestination>();

    //public virtual ICollection<StockPackageDestination> StockPackageDestinationWriteUs { get; } = new List<StockPackageDestination>();

    //public virtual ICollection<StockPackageLevel> StockPackageLevelCreateUs { get; } = new List<StockPackageLevel>();

    //public virtual ICollection<StockPackageLevel> StockPackageLevelWriteUs { get; } = new List<StockPackageLevel>();

    //public virtual ICollection<StockPackageType> StockPackageTypeCreateUs { get; } = new List<StockPackageType>();

    //public virtual ICollection<StockPackageType> StockPackageTypeWriteUs { get; } = new List<StockPackageType>();

    //public virtual ICollection<StockPicking> StockPickingCreateUs { get; } = new List<StockPicking>();

    //public virtual ICollection<StockPickingType> StockPickingTypeCreateUs { get; } = new List<StockPickingType>();

    //public virtual ICollection<StockPickingType> StockPickingTypeWriteUs { get; } = new List<StockPickingType>();

    //public virtual ICollection<StockPicking> StockPickingUsers { get; } = new List<StockPicking>();

    //public virtual ICollection<StockPicking> StockPickingWriteUs { get; } = new List<StockPicking>();

    //public virtual ICollection<StockPutawayRule> StockPutawayRuleCreateUs { get; } = new List<StockPutawayRule>();

    //public virtual ICollection<StockPutawayRule> StockPutawayRuleWriteUs { get; } = new List<StockPutawayRule>();

    //public virtual ICollection<StockQuant> StockQuantCreateUs { get; } = new List<StockQuant>();

    //public virtual ICollection<StockQuantPackage> StockQuantPackageCreateUs { get; } = new List<StockQuantPackage>();

    //public virtual ICollection<StockQuantPackage> StockQuantPackageWriteUs { get; } = new List<StockQuantPackage>();

    //public virtual ICollection<StockQuant> StockQuantUsers { get; } = new List<StockQuant>();

    //public virtual ICollection<StockQuant> StockQuantWriteUs { get; } = new List<StockQuant>();

    //public virtual ICollection<StockQuantityHistory> StockQuantityHistoryCreateUs { get; } = new List<StockQuantityHistory>();

    //public virtual ICollection<StockQuantityHistory> StockQuantityHistoryWriteUs { get; } = new List<StockQuantityHistory>();

    //public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfoCreateUs { get; } = new List<StockReplenishmentInfo>();

    //public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfoWriteUs { get; } = new List<StockReplenishmentInfo>();

    //public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptionCreateUs { get; } = new List<StockReplenishmentOption>();

    //public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptionWriteUs { get; } = new List<StockReplenishmentOption>();

    //public virtual ICollection<StockRequestCount> StockRequestCountCreateUs { get; } = new List<StockRequestCount>();

    //public virtual ICollection<StockRequestCount> StockRequestCountUsers { get; } = new List<StockRequestCount>();

    //public virtual ICollection<StockRequestCount> StockRequestCountWriteUs { get; } = new List<StockRequestCount>();

    //public virtual ICollection<StockReturnPicking> StockReturnPickingCreateUs { get; } = new List<StockReturnPicking>();

    //public virtual ICollection<StockReturnPickingLine> StockReturnPickingLineCreateUs { get; } = new List<StockReturnPickingLine>();

    //public virtual ICollection<StockReturnPickingLine> StockReturnPickingLineWriteUs { get; } = new List<StockReturnPickingLine>();

    //public virtual ICollection<StockReturnPicking> StockReturnPickingWriteUs { get; } = new List<StockReturnPicking>();

    //public virtual ICollection<StockRoute> StockRouteCreateUs { get; } = new List<StockRoute>();

    //public virtual ICollection<StockRoute> StockRouteWriteUs { get; } = new List<StockRoute>();

    //public virtual ICollection<StockRule> StockRuleCreateUs { get; } = new List<StockRule>();

    //public virtual ICollection<StockRule> StockRuleWriteUs { get; } = new List<StockRule>();

    //public virtual ICollection<StockRulesReport> StockRulesReportCreateUs { get; } = new List<StockRulesReport>();

    //public virtual ICollection<StockRulesReport> StockRulesReportWriteUs { get; } = new List<StockRulesReport>();

    //public virtual ICollection<StockSchedulerCompute> StockSchedulerComputeCreateUs { get; } = new List<StockSchedulerCompute>();

    //public virtual ICollection<StockSchedulerCompute> StockSchedulerComputeWriteUs { get; } = new List<StockSchedulerCompute>();

    //public virtual ICollection<StockScrap> StockScrapCreateUs { get; } = new List<StockScrap>();

    //public virtual ICollection<StockScrap> StockScrapWriteUs { get; } = new List<StockScrap>();

    //public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacityCreateUs { get; } = new List<StockStorageCategoryCapacity>();

    //public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacityWriteUs { get; } = new List<StockStorageCategoryCapacity>();

    //public virtual ICollection<StockStorageCategory> StockStorageCategoryCreateUs { get; } = new List<StockStorageCategory>();

    //public virtual ICollection<StockStorageCategory> StockStorageCategoryWriteUs { get; } = new List<StockStorageCategory>();

    //public virtual ICollection<StockTraceabilityReport> StockTraceabilityReportCreateUs { get; } = new List<StockTraceabilityReport>();

    //public virtual ICollection<StockTraceabilityReport> StockTraceabilityReportWriteUs { get; } = new List<StockTraceabilityReport>();

    //public virtual ICollection<StockTrackConfirmation> StockTrackConfirmationCreateUs { get; } = new List<StockTrackConfirmation>();

    //public virtual ICollection<StockTrackConfirmation> StockTrackConfirmationWriteUs { get; } = new List<StockTrackConfirmation>();

    //public virtual ICollection<StockTrackLine> StockTrackLineCreateUs { get; } = new List<StockTrackLine>();

    //public virtual ICollection<StockTrackLine> StockTrackLineWriteUs { get; } = new List<StockTrackLine>();

    //public virtual ICollection<StockValuationLayer> StockValuationLayerCreateUs { get; } = new List<StockValuationLayer>();

    //public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluationCreateUs { get; } = new List<StockValuationLayerRevaluation>();

    //public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluationWriteUs { get; } = new List<StockValuationLayerRevaluation>();

    //public virtual ICollection<StockValuationLayer> StockValuationLayerWriteUs { get; } = new List<StockValuationLayer>();

    //public virtual ICollection<StockWarehouse> StockWarehouseCreateUs { get; } = new List<StockWarehouse>();

    //public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpointCreateUs { get; } = new List<StockWarehouseOrderpoint>();

    //public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpointWriteUs { get; } = new List<StockWarehouseOrderpoint>();

    //public virtual ICollection<StockWarehouse> StockWarehouseWriteUs { get; } = new List<StockWarehouse>();

    //public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairCreateUs { get; } = new List<StockWarnInsufficientQtyRepair>();

    //public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairWriteUs { get; } = new List<StockWarnInsufficientQtyRepair>();

    //public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScrapCreateUs { get; } = new List<StockWarnInsufficientQtyScrap>();

    //public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScrapWriteUs { get; } = new List<StockWarnInsufficientQtyScrap>();

    //public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuildCreateUs { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    //public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuildWriteUs { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    //public virtual ICollection<ThemeIrAsset> ThemeIrAssetCreateUs { get; } = new List<ThemeIrAsset>();

    //public virtual ICollection<ThemeIrAsset> ThemeIrAssetWriteUs { get; } = new List<ThemeIrAsset>();

    //public virtual ICollection<ThemeIrAttachment> ThemeIrAttachmentCreateUs { get; } = new List<ThemeIrAttachment>();

    //public virtual ICollection<ThemeIrAttachment> ThemeIrAttachmentWriteUs { get; } = new List<ThemeIrAttachment>();

    //public virtual ICollection<ThemeIrUiView> ThemeIrUiViewCreateUs { get; } = new List<ThemeIrUiView>();

    //public virtual ICollection<ThemeIrUiView> ThemeIrUiViewWriteUs { get; } = new List<ThemeIrUiView>();

    //public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenuCreateUs { get; } = new List<ThemeWebsiteMenu>();

    //public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenuWriteUs { get; } = new List<ThemeWebsiteMenu>();

    //public virtual ICollection<ThemeWebsitePage> ThemeWebsitePageCreateUs { get; } = new List<ThemeWebsitePage>();

    //public virtual ICollection<ThemeWebsitePage> ThemeWebsitePageWriteUs { get; } = new List<ThemeWebsitePage>();

    //public virtual ICollection<UomCategory> UomCategoryCreateUs { get; } = new List<UomCategory>();

    //public virtual ICollection<UomCategory> UomCategoryWriteUs { get; } = new List<UomCategory>();

    //public virtual ICollection<UomUom> UomUomCreateUs { get; } = new List<UomUom>();

    //public virtual ICollection<UomUom> UomUomWriteUs { get; } = new List<UomUom>();

    //public virtual ICollection<UtmCampaign> UtmCampaignCreateUs { get; } = new List<UtmCampaign>();

    //public virtual ICollection<UtmCampaign> UtmCampaignUsers { get; } = new List<UtmCampaign>();

    //public virtual ICollection<UtmCampaign> UtmCampaignWriteUs { get; } = new List<UtmCampaign>();

    //public virtual ICollection<UtmMedium> UtmMediumCreateUs { get; } = new List<UtmMedium>();

    //public virtual ICollection<UtmMedium> UtmMediumWriteUs { get; } = new List<UtmMedium>();

    //public virtual ICollection<UtmSource> UtmSourceCreateUs { get; } = new List<UtmSource>();

    //public virtual ICollection<UtmSource> UtmSourceWriteUs { get; } = new List<UtmSource>();

    //public virtual ICollection<UtmStage> UtmStageCreateUs { get; } = new List<UtmStage>();

    //public virtual ICollection<UtmStage> UtmStageWriteUs { get; } = new List<UtmStage>();

    //public virtual ICollection<UtmTag> UtmTagCreateUs { get; } = new List<UtmTag>();

    //public virtual ICollection<UtmTag> UtmTagWriteUs { get; } = new List<UtmTag>();

    //public virtual ICollection<ValidateAccountMove> ValidateAccountMoveCreateUs { get; } = new List<ValidateAccountMove>();

    //public virtual ICollection<ValidateAccountMove> ValidateAccountMoveWriteUs { get; } = new List<ValidateAccountMove>();

    //public virtual ICollection<WebEditorConverterTest> WebEditorConverterTestCreateUs { get; } = new List<WebEditorConverterTest>();

    //public virtual ICollection<WebEditorConverterTestSub> WebEditorConverterTestSubCreateUs { get; } = new List<WebEditorConverterTestSub>();

    //public virtual ICollection<WebEditorConverterTestSub> WebEditorConverterTestSubWriteUs { get; } = new List<WebEditorConverterTestSub>();

    //public virtual ICollection<WebEditorConverterTest> WebEditorConverterTestWriteUs { get; } = new List<WebEditorConverterTest>();

    //public virtual ICollection<WebTourTour> WebTourTours { get; } = new List<WebTourTour>();

    public virtual Website? Website { get; set; }

    //public virtual ICollection<WebsiteBaseUnit> WebsiteBaseUnitCreateUs { get; } = new List<WebsiteBaseUnit>();

    //public virtual ICollection<WebsiteBaseUnit> WebsiteBaseUnitWriteUs { get; } = new List<WebsiteBaseUnit>();

    //public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatureCreateUs { get; } = new List<WebsiteConfiguratorFeature>();

    //public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatureWriteUs { get; } = new List<WebsiteConfiguratorFeature>();

    //public virtual ICollection<Website> WebsiteCreateUs { get; } = new List<Website>();

    //public virtual ICollection<Website> WebsiteCrmDefaultUsers { get; } = new List<Website>();

    //public virtual ICollection<WebsiteMenu> WebsiteMenuCreateUs { get; } = new List<WebsiteMenu>();

    //public virtual ICollection<WebsiteMenu> WebsiteMenuWriteUs { get; } = new List<WebsiteMenu>();

    //public virtual ICollection<WebsitePage> WebsitePageCreateUs { get; } = new List<WebsitePage>();

    //public virtual ICollection<WebsitePage> WebsitePageWriteUs { get; } = new List<WebsitePage>();

    //public virtual ICollection<WebsiteRewrite> WebsiteRewriteCreateUs { get; } = new List<WebsiteRewrite>();

    //public virtual ICollection<WebsiteRewrite> WebsiteRewriteWriteUs { get; } = new List<WebsiteRewrite>();

    //public virtual ICollection<WebsiteRobot> WebsiteRobotCreateUs { get; } = new List<WebsiteRobot>();

    //public virtual ICollection<WebsiteRobot> WebsiteRobotWriteUs { get; } = new List<WebsiteRobot>();

    //public virtual ICollection<WebsiteRoute> WebsiteRouteCreateUs { get; } = new List<WebsiteRoute>();

    //public virtual ICollection<WebsiteRoute> WebsiteRouteWriteUs { get; } = new List<WebsiteRoute>();

    //public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFieldCreateUs { get; } = new List<WebsiteSaleExtraField>();

    //public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFieldWriteUs { get; } = new List<WebsiteSaleExtraField>();

    //public virtual ICollection<Website> WebsiteSalespeople { get; } = new List<Website>();

    //public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilterCreateUs { get; } = new List<WebsiteSnippetFilter>();

    //public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilterWriteUs { get; } = new List<WebsiteSnippetFilter>();

    //public virtual ICollection<Website> WebsiteUsers { get; } = new List<Website>();

    //public virtual ICollection<WebsiteVisitor> WebsiteVisitorCreateUs { get; } = new List<WebsiteVisitor>();

    //public virtual ICollection<WebsiteVisitor> WebsiteVisitorWriteUs { get; } = new List<WebsiteVisitor>();

    //public virtual ICollection<Website> WebsiteWriteUs { get; } = new List<Website>();

    //public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreateCreateUs { get; } = new List<WizardIrModelMenuCreate>();

    //public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreateWriteUs { get; } = new List<WizardIrModelMenuCreate>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResCompany> Cids { get; } = new List<ResCompany>();

    //public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; } = new List<CrmLead2opportunityPartnerMass>();

    //public virtual ICollection<DigestDigest> DigestDigests { get; } = new List<DigestDigest>();

    //public virtual ICollection<DigestTip> DigestTips { get; } = new List<DigestTip>();

    //public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    //public virtual ICollection<HrJob> HrJobsNavigation { get; } = new List<HrJob>();

    //public virtual ICollection<HrJob> Jobs { get; } = new List<HrJob>();

    //public virtual ICollection<MaintenanceTeam> MaintenanceTeams { get; } = new List<MaintenanceTeam>();

    //public virtual ICollection<LunchProduct> Products { get; } = new List<LunchProduct>();

    //public virtual ICollection<ProjectProject> Projects { get; } = new List<ProjectProject>();

    //public virtual ICollection<CrmTeam> Teams { get; } = new List<CrmTeam>();
}
