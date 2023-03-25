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

[Table("account_account")]
[Index("Code", "TenantId", Name = "account_account_code_company_uniq", IsUnique = true)]
public partial class AccountAccount: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("group_id")]
    public Guid? GroupId { get; set; }

    [Column("root_id")]
    public Guid? RootId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("account_type")]
    public string? AccountType { get; set; }

    [Column("internal_group")]
    public string? InternalGroup { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("deprecated")]
    public bool? Deprecated { get; set; }

    [Column("include_initial_balance")]
    public bool? IncludeInitialBalance { get; set; }

    [Column("reconcile")]
    public bool? Reconcile { get; set; }

    [Column("is_off_balance")]
    public bool? IsOffBalance { get; set; }

    [Column("non_trade")]
    public bool? NonTrade { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("AccountAccounts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountAccountCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("AccountAccounts")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("AccountAccounts")]
    public virtual AccountGroup? Group { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("AccountAccounts")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountAccountWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Account")]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    [InverseProperty("Account")]
    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; } = new List<AccountAccruedOrdersWizard>();

    [InverseProperty("GeneralAccount")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("AccountAsset")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategoryAccountAssets { get; } = new List<AccountAssetCategory>();

    [InverseProperty("AccountDepreciationExpense")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategoryAccountDepreciationExpenses { get; } = new List<AccountAssetCategory>();

    [InverseProperty("AccountDepreciation")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategoryAccountDepreciations { get; } = new List<AccountAssetCategory>();

    [InverseProperty("DestinationAccount")]
    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizards { get; } = new List<AccountAutomaticEntryWizard>();

    [InverseProperty("AccountDest")]
    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountAccountDests { get; } = new List<AccountFiscalPositionAccount>();

    [InverseProperty("AccountSrc")]
    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountAccountSrcs { get; } = new List<AccountFiscalPositionAccount>();

    [InverseProperty("DefaultAccount")]
    public virtual ICollection<AccountJournal> AccountJournalDefaultAccounts { get; } = new List<AccountJournal>();

    [InverseProperty("LossAccount")]
    public virtual ICollection<AccountJournal> AccountJournalLossAccounts { get; } = new List<AccountJournal>();

    [InverseProperty("ProfitAccount")]
    public virtual ICollection<AccountJournal> AccountJournalProfitAccounts { get; } = new List<AccountJournal>();

    [InverseProperty("SuspenseAccount")]
    public virtual ICollection<AccountJournal> AccountJournalSuspenseAccounts { get; } = new List<AccountJournal>();

    [InverseProperty("Account")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("DestinationAccount")]
    public virtual ICollection<AccountPayment> AccountPaymentDestinationAccounts { get; } = new List<AccountPayment>();

    [InverseProperty("ForceOutstandingAccount")]
    public virtual ICollection<AccountPayment> AccountPaymentForceOutstandingAccounts { get; } = new List<AccountPayment>();

    [InverseProperty("PaymentAccount")]
    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; } = new List<AccountPaymentMethodLine>();

    [InverseProperty("OutstandingAccount")]
    public virtual ICollection<AccountPayment> AccountPaymentOutstandingAccounts { get; } = new List<AccountPayment>();

    [InverseProperty("WriteoffAccount")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("Account")]
    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; } = new List<AccountReconcileModelLine>();

    [InverseProperty("Account")]
    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLines { get; } = new List<AccountTaxRepartitionLine>();

    [InverseProperty("CashBasisTransitionAccount")]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    [InverseProperty("Account")]
    public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizards { get; } = new List<PosCloseSessionWizard>();

    [InverseProperty("OutstandingAccount")]
    public virtual ICollection<PosPaymentMethod> PosPaymentMethodOutstandingAccounts { get; } = new List<PosPaymentMethod>();

    [InverseProperty("ReceivableAccount")]
    public virtual ICollection<PosPaymentMethod> PosPaymentMethodReceivableAccounts { get; } = new List<PosPaymentMethod>();

    [InverseProperty("AccountCashBasisBaseAccount")]
    public virtual ICollection<ResCompany> ResCompanyAccountCashBasisBaseAccounts { get; } = new List<ResCompany>();

    [InverseProperty("AccountDefaultPosReceivableAccount")]
    public virtual ICollection<ResCompany> ResCompanyAccountDefaultPosReceivableAccounts { get; } = new List<ResCompany>();

    [InverseProperty("AccountJournalEarlyPayDiscountGainAccount")]
    public virtual ICollection<ResCompany> ResCompanyAccountJournalEarlyPayDiscountGainAccounts { get; } = new List<ResCompany>();

    [InverseProperty("AccountJournalEarlyPayDiscountLossAccount")]
    public virtual ICollection<ResCompany> ResCompanyAccountJournalEarlyPayDiscountLossAccounts { get; } = new List<ResCompany>();

    [InverseProperty("AccountJournalPaymentCreditAccount")]
    public virtual ICollection<ResCompany> ResCompanyAccountJournalPaymentCreditAccounts { get; } = new List<ResCompany>();

    [InverseProperty("AccountJournalPaymentDebitAccount")]
    public virtual ICollection<ResCompany> ResCompanyAccountJournalPaymentDebitAccounts { get; } = new List<ResCompany>();

    [InverseProperty("AccountJournalSuspenseAccount")]
    public virtual ICollection<ResCompany> ResCompanyAccountJournalSuspenseAccounts { get; } = new List<ResCompany>();

    [InverseProperty("DefaultCashDifferenceExpenseAccount")]
    public virtual ICollection<ResCompany> ResCompanyDefaultCashDifferenceExpenseAccounts { get; } = new List<ResCompany>();

    [InverseProperty("DefaultCashDifferenceIncomeAccount")]
    public virtual ICollection<ResCompany> ResCompanyDefaultCashDifferenceIncomeAccounts { get; } = new List<ResCompany>();

    [InverseProperty("ExpenseAccrualAccount")]
    public virtual ICollection<ResCompany> ResCompanyExpenseAccrualAccounts { get; } = new List<ResCompany>();

    [InverseProperty("ExpenseCurrencyExchangeAccount")]
    public virtual ICollection<ResCompany> ResCompanyExpenseCurrencyExchangeAccounts { get; } = new List<ResCompany>();

    [InverseProperty("IncomeCurrencyExchangeAccount")]
    public virtual ICollection<ResCompany> ResCompanyIncomeCurrencyExchangeAccounts { get; } = new List<ResCompany>();

    [InverseProperty("PropertyStockAccountInputCateg")]
    public virtual ICollection<ResCompany> ResCompanyPropertyStockAccountInputCategs { get; } = new List<ResCompany>();

    [InverseProperty("PropertyStockAccountOutputCateg")]
    public virtual ICollection<ResCompany> ResCompanyPropertyStockAccountOutputCategs { get; } = new List<ResCompany>();

    [InverseProperty("PropertyStockValuationAccount")]
    public virtual ICollection<ResCompany> ResCompanyPropertyStockValuationAccounts { get; } = new List<ResCompany>();

    [InverseProperty("RevenueAccrualAccount")]
    public virtual ICollection<ResCompany> ResCompanyRevenueAccrualAccounts { get; } = new List<ResCompany>();

    [InverseProperty("TransferAccount")]
    public virtual ICollection<ResCompany> ResCompanyTransferAccounts { get; } = new List<ResCompany>();

    [InverseProperty("DepositAccount")]
    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    [InverseProperty("ValuationInAccount")]
    public virtual ICollection<StockLocation> StockLocationValuationInAccounts { get; } = new List<StockLocation>();

    [InverseProperty("ValuationOutAccount")]
    public virtual ICollection<StockLocation> StockLocationValuationOutAccounts { get; } = new List<StockLocation>();

    [InverseProperty("Account")]
    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; } = new List<StockValuationLayerRevaluation>();


    [ForeignKey("AccountAccountId")]
    [InverseProperty("AccountAccounts")]
    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; } = new List<AccountAccountTag>();

    [ForeignKey("AccountAccountId")]
    [InverseProperty("AccountAccounts")]
    public virtual ICollection<AccountBalanceReport> AccountBalanceReports { get; } = new List<AccountBalanceReport>();

    [ForeignKey("AccountAccountId")]
    [InverseProperty("AccountAccounts")]
    public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    [ForeignKey("AccountAccountId")]
    [InverseProperty("AccountAccounts")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [ForeignKey("AccountAccountId")]
    [InverseProperty("AccountAccounts")]
    public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgers { get; } = new List<AccountReportGeneralLedger>();

    [ForeignKey("AccountId")]
    [InverseProperty("Accounts")]
    public virtual ICollection<AccountBudgetPost> Budgets { get; } = new List<AccountBudgetPost>();

    [ForeignKey("AccountId")]
    [InverseProperty("Accounts1")]
    public virtual ICollection<AccountJournal> Journals { get; } = new List<AccountJournal>();

    [ForeignKey("AccountId")]
    [InverseProperty("Accounts")]
    public virtual ICollection<AccountBankbookReport> ReportLines { get; } = new List<AccountBankbookReport>();

    [ForeignKey("AccountId")]
    [InverseProperty("Accounts")]
    public virtual ICollection<AccountDaybookReport> ReportLines1 { get; } = new List<AccountDaybookReport>();

    [ForeignKey("AccountId")]
    [InverseProperty("Accounts")]
    public virtual ICollection<AccountFinancialReport> ReportLines2 { get; } = new List<AccountFinancialReport>();

    [ForeignKey("AccountId")]
    [InverseProperty("Accounts")]
    public virtual ICollection<AccountCashbookReport> ReportLinesNavigation { get; } = new List<AccountCashbookReport>();

    [ForeignKey("AccountId")]
    [InverseProperty("Accounts")]
    public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();
}
