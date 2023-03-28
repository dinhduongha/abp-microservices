using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountJournal
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? DefaultAccountId { get; set; }

    public Guid? SuspenseAccountId { get; set; }

    public long Sequence { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProfitAccountId { get; set; }

    public Guid? LossAccountId { get; set; }

    public Guid? BankAccountId { get; set; }

    public long? SaleActivityTypeId { get; set; }

    public Guid? SaleActivityUserId { get; set; }

    public Guid? AliasId { get; set; }

    public Guid? SecureSequenceId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public long? Color { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Type { get; set; }

    public string? InvoiceReferenceType { get; set; }

    public string? InvoiceReferenceModel { get; set; }

    public string? BankStatementsSource { get; set; }

    public string? SequenceOverrideRegex { get; set; }

    public string? SaleActivityNote { get; set; }

    public bool? Active { get; set; }

    public bool? RestrictModeHashTable { get; set; }

    public bool? RefundSequence { get; set; }

    public bool? PaymentSequence { get; set; }

    public bool? ShowOnDashboard { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountAssetCategory> AccountAssetCategories { get; } = new List<AccountAssetCategory>();

    //public virtual ICollection<AccountBankStatementImportJournalCreation> AccountBankStatementImportJournalCreations { get; } = new List<AccountBankStatementImportJournalCreation>();

    //public virtual ICollection<AccountBankStatement> AccountBankStatements { get; } = new List<AccountBankStatement>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMoveReversal> AccountMoveReversals { get; } = new List<AccountMoveReversal>();

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; } = new List<AccountPaymentMethodLine>();

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    //public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; } = new List<AccountReconcileModelLine>();

    //public virtual ICollection<AccountRecurringTemplate> AccountRecurringTemplates { get; } = new List<AccountRecurringTemplate>();

    public virtual MailAlias? Alias { get; set; }

    public virtual ResPartnerBank? BankAccount { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountAccount? DefaultAccount { get; set; }

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheetBankJournals { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheetJournals { get; } = new List<HrExpenseSheet>();

    public virtual AccountAccount? LossAccount { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    //public virtual ICollection<PosConfig> PosConfigInvoiceJournals { get; } = new List<PosConfig>();

    //public virtual ICollection<PosConfig> PosConfigJournals { get; } = new List<PosConfig>();

    //public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    //public virtual ICollection<PosPaymentMethod> PosPaymentMethods { get; } = new List<PosPaymentMethod>();

    //public virtual ICollection<PosSession> PosSessions { get; } = new List<PosSession>();

    public virtual AccountAccount? ProfitAccount { get; set; }

    //public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    //public virtual ICollection<ResCompany> ResCompanyAutomaticEntryDefaultJournals { get; } = new List<ResCompany>();

    //public virtual ICollection<ResCompany> ResCompanyCompanyExpenseJournals { get; } = new List<ResCompany>();

    //public virtual ICollection<ResCompany> ResCompanyCurrencyExchangeJournals { get; } = new List<ResCompany>();

    //public virtual ICollection<ResCompany> ResCompanyExpenseJournals { get; } = new List<ResCompany>();

    //public virtual ICollection<ResCompany> ResCompanyTaxCashBasisJournals { get; } = new List<ResCompany>();

    public virtual MailActivityType? SaleActivityType { get; set; }

    public virtual ResUser? SaleActivityUser { get; set; }

    public virtual IrSequence? SecureSequence { get; set; }

    //public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; } = new List<StockValuationLayerRevaluation>();

    public virtual AccountAccount? SuspenseAccount { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalances { get; } = new List<AccountAgedTrialBalance>();

    //public virtual ICollection<AccountBankbookReport> AccountBankbookReports { get; } = new List<AccountBankbookReport>();

    //public virtual ICollection<AccountCashbookReport> AccountCashbookReports { get; } = new List<AccountCashbookReport>();

    //public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    //public virtual ICollection<AccountCommonJournalReport> AccountCommonJournalReports { get; } = new List<AccountCommonJournalReport>();

    //public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReports { get; } = new List<AccountCommonPartnerReport>();

    //public virtual ICollection<AccountCommonReport> AccountCommonReports { get; } = new List<AccountCommonReport>();

    //public virtual ICollection<AccountDaybookReport> AccountDaybookReports { get; } = new List<AccountDaybookReport>();

    //public virtual ICollection<AccountEdiFormat> AccountEdiFormats { get; } = new List<AccountEdiFormat>();

    //public virtual ICollection<AccountJournalGroup> AccountJournalGroups { get; } = new List<AccountJournalGroup>();

    //public virtual ICollection<AccountPrintJournal> AccountPrintJournals { get; } = new List<AccountPrintJournal>();

    //public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; } = new List<AccountReconcileModelTemplate>();

    //public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    //public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgers { get; } = new List<AccountReportPartnerLedger>();

    //public virtual ICollection<AccountTaxReportWizard> AccountTaxReportWizards { get; } = new List<AccountTaxReportWizard>();

    //public virtual ICollection<AccountingReport> AccountingReports { get; } = new List<AccountingReport>();

    //public virtual ICollection<AccountBalanceReport> Accounts { get; } = new List<AccountBalanceReport>();

    //public virtual ICollection<AccountAccount> Accounts1 { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountReportGeneralLedger> AccountsNavigation { get; } = new List<AccountReportGeneralLedger>();
}
