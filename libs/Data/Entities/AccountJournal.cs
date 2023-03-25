using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("account_journal")]
[Index("TenantId", "Code", Name = "account_journal_code_company_uniq", IsUnique = true)]
[Index("TenantId", Name = "account_journal_company_id_index")]
public partial class AccountJournal: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("default_account_id")]
    public Guid? DefaultAccountId { get; set; }

    [Column("suspense_account_id")]
    public Guid? SuspenseAccountId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("profit_account_id")]
    public Guid? ProfitAccountId { get; set; }

    [Column("loss_account_id")]
    public Guid? LossAccountId { get; set; }

    [Column("bank_account_id")]
    public Guid? BankAccountId { get; set; }

    [Column("sale_activity_type_id")]
    public long? SaleActivityTypeId { get; set; }

    [Column("sale_activity_user_id")]
    public Guid? SaleActivityUserId { get; set; }

    [Column("alias_id")]
    public Guid? AliasId { get; set; }

    [Column("secure_sequence_id")]
    public Guid? SecureSequenceId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("invoice_reference_type")]
    public string? InvoiceReferenceType { get; set; }

    [Column("invoice_reference_model")]
    public string? InvoiceReferenceModel { get; set; }

    [Column("bank_statements_source")]
    public string? BankStatementsSource { get; set; }

    [Column("sequence_override_regex")]
    public string? SequenceOverrideRegex { get; set; }

    [Column("sale_activity_note")]
    public string? SaleActivityNote { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("restrict_mode_hash_table")]
    public bool? RestrictModeHashTable { get; set; }

    [Column("refund_sequence")]
    public bool? RefundSequence { get; set; }

    [Column("payment_sequence")]
    public bool? PaymentSequence { get; set; }

    [Column("show_on_dashboard")]
    public bool? ShowOnDashboard { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("AliasId")]
    [InverseProperty("AccountJournals")]
    public virtual MailAlias? Alias { get; set; }

    [ForeignKey("BankAccountId")]
    [InverseProperty("AccountJournals")]
    public virtual ResPartnerBank? BankAccount { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("AccountJournals")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountJournalCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("AccountJournals")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("DefaultAccountId")]
    [InverseProperty("AccountJournalDefaultAccounts")]
    public virtual AccountAccount? DefaultAccount { get; set; }

    [ForeignKey("LossAccountId")]
    [InverseProperty("AccountJournalLossAccounts")]
    public virtual AccountAccount? LossAccount { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("AccountJournals")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("ProfitAccountId")]
    [InverseProperty("AccountJournalProfitAccounts")]
    public virtual AccountAccount? ProfitAccount { get; set; }

    [ForeignKey("SaleActivityTypeId")]
    [InverseProperty("AccountJournals")]
    public virtual MailActivityType? SaleActivityType { get; set; }

    [ForeignKey("SaleActivityUserId")]
    [InverseProperty("AccountJournalSaleActivityUsers")]
    public virtual ResUser? SaleActivityUser { get; set; }

    [ForeignKey("SecureSequenceId")]
    [InverseProperty("AccountJournals")]
    public virtual IrSequence? SecureSequence { get; set; }

    [ForeignKey("SuspenseAccountId")]
    [InverseProperty("AccountJournalSuspenseAccounts")]
    public virtual AccountAccount? SuspenseAccount { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountJournalWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Journal")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategories { get; } = new List<AccountAssetCategory>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountBankStatementImportJournalCreation> AccountBankStatementImportJournalCreations { get; } = new List<AccountBankStatementImportJournalCreation>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountBankStatement> AccountBankStatements { get; } = new List<AccountBankStatement>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountMoveReversal> AccountMoveReversals { get; } = new List<AccountMoveReversal>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; } = new List<AccountPaymentMethodLine>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("DestinationJournal")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; } = new List<AccountReconcileModelLine>();

    [InverseProperty("Journal")]
    public virtual ICollection<AccountRecurringTemplate> AccountRecurringTemplates { get; } = new List<AccountRecurringTemplate>();

    [InverseProperty("BankJournal")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheetBankJournals { get; } = new List<HrExpenseSheet>();

    [InverseProperty("Journal")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheetJournals { get; } = new List<HrExpenseSheet>();

    [InverseProperty("InvoiceJournal")]
    public virtual ICollection<PosConfig> PosConfigInvoiceJournals { get; } = new List<PosConfig>();

    [InverseProperty("Journal")]
    public virtual ICollection<PosConfig> PosConfigJournals { get; } = new List<PosConfig>();

    [InverseProperty("SaleJournalNavigation")]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("Journal")]
    public virtual ICollection<PosPaymentMethod> PosPaymentMethods { get; } = new List<PosPaymentMethod>();

    [InverseProperty("CashJournal")]
    public virtual ICollection<PosSession> PosSessions { get; } = new List<PosSession>();

    [InverseProperty("Journal")]
    public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    [InverseProperty("AutomaticEntryDefaultJournal")]
    public virtual ICollection<ResCompany> ResCompanyAutomaticEntryDefaultJournals { get; } = new List<ResCompany>();

    [InverseProperty("CompanyExpenseJournal")]
    public virtual ICollection<ResCompany> ResCompanyCompanyExpenseJournals { get; } = new List<ResCompany>();

    [InverseProperty("CurrencyExchangeJournal")]
    public virtual ICollection<ResCompany> ResCompanyCurrencyExchangeJournals { get; } = new List<ResCompany>();

    [InverseProperty("ExpenseJournal")]
    public virtual ICollection<ResCompany> ResCompanyExpenseJournals { get; } = new List<ResCompany>();

    [InverseProperty("TaxCashBasisJournal")]
    public virtual ICollection<ResCompany> ResCompanyTaxCashBasisJournals { get; } = new List<ResCompany>();

    [InverseProperty("AccountJournal")]
    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; } = new List<StockValuationLayerRevaluation>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountAgedTrialBalance> AccountAgedTrialBalances { get; } = new List<AccountAgedTrialBalance>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountBankbookReport> AccountBankbookReports { get; } = new List<AccountBankbookReport>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountCashbookReport> AccountCashbookReports { get; } = new List<AccountCashbookReport>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountCommonJournalReport> AccountCommonJournalReports { get; } = new List<AccountCommonJournalReport>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountCommonPartnerReport> AccountCommonPartnerReports { get; } = new List<AccountCommonPartnerReport>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountCommonReport> AccountCommonReports { get; } = new List<AccountCommonReport>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountDaybookReport> AccountDaybookReports { get; } = new List<AccountDaybookReport>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountEdiFormat> AccountEdiFormats { get; } = new List<AccountEdiFormat>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountJournalGroup> AccountJournalGroups { get; } = new List<AccountJournalGroup>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountPrintJournal> AccountPrintJournals { get; } = new List<AccountPrintJournal>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; } = new List<AccountReconcileModelTemplate>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountReportPartnerLedger> AccountReportPartnerLedgers { get; } = new List<AccountReportPartnerLedger>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountTaxReportWizard> AccountTaxReportWizards { get; } = new List<AccountTaxReportWizard>();

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountJournals")]
    public virtual ICollection<AccountingReport> AccountingReports { get; } = new List<AccountingReport>();

    [ForeignKey("JournalId")]
    [InverseProperty("Journals")]
    public virtual ICollection<AccountBalanceReport> Accounts { get; } = new List<AccountBalanceReport>();

    [ForeignKey("JournalId")]
    [InverseProperty("Journals")]
    public virtual ICollection<AccountAccount> Accounts1 { get; } = new List<AccountAccount>();

    [ForeignKey("JournalId")]
    [InverseProperty("Journals")]
    public virtual ICollection<AccountReportGeneralLedger> AccountsNavigation { get; } = new List<AccountReportGeneralLedger>();
}
